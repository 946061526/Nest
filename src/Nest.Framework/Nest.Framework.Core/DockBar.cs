using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Nest.Framework.Core
{
    public class DockBar : XtraForm, IApplicationProvider
    {
        protected delegate void DataOperation();

        private delegate void CloseOperation();

        protected delegate void SetDataSource(string MeansName);

        protected delegate void StopMeans(string MeansName);

        protected string WindowText = string.Empty;

        private Thread newThread = null;

        public BarStaticItem BarItemTime;

        private DockBar.DataOperation ExecuteMeans = null;

        private System.Windows.Forms.Timer TheardTimer = null;

        private double Cost_Time = 0.0;

        private DateTime mRunTime = DateTime.Now;

        //private GridHitInfo downHitInfo = null;

        private ProgressBarControl ProgressBar;

        private BarManager MainBar;

        //private IContainer components;

        private Bar BottomBar;

        private BarDockControl barDockControlTop;

        private BarDockControl barDockControlBottom;

        private BarDockControl barDockControlLeft;

        private BarDockControl barDockControlRight;

        public BarStaticItem BarSpring;

        private BarStaticItem BarStateText;

        private BarEditItem BarProgress;

        private RepositoryItemProgressBar repositoryItemProgressBar1;

        private BarButtonItem BarStop;

        private RepositoryItemMarqueeProgressBar repositoryItemMarqueeProgressBar1;

        private bool _StopLoad = false;

        private ISystemApplication _SystemApplication;

        private bool _IsNowRun = false;

        private bool _IsClickStopPostDataEvent = false;

        protected bool IsVisibleBar
        {
            set
            {
                this.BottomBar.Visible = value;
            }
        }

        public bool StopLoad
        {
            get
            {
                return this._StopLoad;
            }
            set
            {
                this._StopLoad = value;
            }
        }

        public ISystemApplication SystemApplication
        {
            get
            {
                return this._SystemApplication;
            }
            set
            {
                this._SystemApplication = value;
            }
        }

        public bool IsNowRun
        {
            get
            {
                return this._IsNowRun;
            }
            set
            {
                this._IsNowRun = value;
            }
        }

        public bool IsClickStopPostDataEvent
        {
            get
            {
                return this._IsClickStopPostDataEvent;
            }
            set
            {
                this._IsClickStopPostDataEvent = value;
            }
        }

        public string StatusState
        {
            get
            {
                return this.BarStateText.Caption;
            }
            set
            {
                if (this.BarStateText != null)
                {
                    this.BarStateText.Caption = "状态：" + value.Replace("状态：", "").Replace(":", "");
                }
            }
        }

        protected virtual void Stop(string MeansName)
        {
            this.AbortThread();
        }

        protected virtual void SetControl(string MeansName)
        {
            this.StatusState = "就绪";
            this.SystemApplication.StatusState = "就绪";
        }

        protected void GetDataSource(DockBar.DataOperation pExecuteMeans)
        {
            try
            {
                this.BarItemTime.Caption = "耗时:0s";
                this.SystemApplication.BarItem_Time.Caption = "耗时:0s";
                this.mRunTime = DateTime.Now;
                this.SystemApplication.BarButtonStop.Enabled = true;
                this.BarStop.Enabled = true;
                this.TheardTimer = new System.Windows.Forms.Timer
                {
                    Enabled = true,
                    Interval = 1000
                };
                this.TheardTimer.Tick += new EventHandler(this.TheardTimer_Tick);
                this.StatusState = "正在读取数据...";
                this.SystemApplication.StatusState = "正在读取数据...";
                this.ProgressBarInit();
                this.SystemApplication.ProgressBarInit();
                this.ProgressBarSetMax(100);
                this.SystemApplication.ProgressBarSetMax(100);
                this.IsNowRun = true;
                this.ExecuteMeans = pExecuteMeans;
                this.newThread = this.ThreadCreate(new ThreadStart(this.RunGetData), true, "NewThread");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void TheardTimer_Tick(object sender, EventArgs e)
        {
            if (this.IsNowRun)
            {
                int num = Convert.ToInt32(this.BarProgress.EditValue);
                if (num == this.repositoryItemProgressBar1.Maximum)
                {
                    this.ProgressBarInit();
                    this.SystemApplication.ProgressBarInit();
                    num = 0;
                }
                this.ProgressBarSetPostion(num + 1);
                this.SystemApplication.ProgressBarSetPostion(num + 1);
                DateTime now = DateTime.Now;
                this.Cost_Time = (now - this.mRunTime).TotalMilliseconds / 1000.0;
                this.BarItemTime.Caption = "耗时:" + this.Cost_Time.ToString("f0") + ".00s";
                this.SystemApplication.BarItem_Time.Caption = "耗时:" + this.Cost_Time.ToString("f0") + ".00s";
            }
            else
            {
                this.TheardTimer.Enabled = false;
                this.ProgressBarInit();
                this.SystemApplication.ProgressBarInit();
                this.StatusState = "就绪";
                this.SystemApplication.StatusState = "就绪";
                this.BarItemTime.Caption = "耗时:" + this.Cost_Time.ToString("f2") + "s";
                this.SystemApplication.BarItem_Time.Caption = "耗时:" + this.Cost_Time.ToString("f2") + "s";
            }
        }

        private void RunGetData()
        {
            try
            {
                this.ExecuteMeans();
                DateTime now = DateTime.Now;
                this.Cost_Time = (now - this.mRunTime).TotalMilliseconds / 1000.0;
                if (base.InvokeRequired)
                {
                    DockBar.CloseOperation method = new DockBar.CloseOperation(this.AbortThread);
                    base.Invoke(method);
                }
                else
                {
                    this.AbortThread();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void AbortThread()
        {
            try
            {
                DockBar.SetDataSource method = new DockBar.SetDataSource(this.SetControl);
                base.Invoke(method, new object[]
                {
                    this.ExecuteMeans.Method.Name.ToString()
                });
                this.newThread.Abort();
                this.ProgressBar.Visible = false;
                this.SystemApplication.BarButtonStop.Enabled = false;
                this.BarStop.Enabled = false;
                this.BarItemTime.Caption = "耗时:" + this.Cost_Time.ToString("f2") + "s";
                this.SystemApplication.BarItem_Time.Caption = "耗时:" + this.Cost_Time.ToString("f2") + "s";
            }
            catch (Exception ex)
            {
                throw new Exception("DockBar.AbortThread：" + ex.Message);
            }
            finally
            {
                this.ProgressBarEnd();
                this.SystemApplication.ProgressBarEnd();
                this.IsNowRun = false;
            }
        }

        private Thread ThreadCreate(ThreadStart Function, bool IsStart, string Name)
        {
            this.ProgressBarSetPostion(10);
            this.SystemApplication.ProgressBarSetPostion(10);
            this.newThread = new Thread(new ThreadStart(Function.Invoke));
            if (Name != "")
            {
                this.newThread.Name = Name;
            }
            if (IsStart)
            {
                this.newThread.Start();
            }
            return this.newThread;
        }

        /* GridView事件
        protected void RegisterTZGridView(GridView GridView)
        {
            //if (GridView != null)
            //{
            //    GridView.add_MouseDown(new MouseEventHandler(this.GridView_MouseDown));
            //    GridView.add_MouseMove(new MouseEventHandler(this.GridView_MouseMove));
            //}
        }

        protected void RegisterDWGridView(GridView GridView)
        {
            //if (GridView != null)
            //{
            //    GridView.add_Click(new EventHandler(this.GridView_Click));
            //    if (DockBar._frmProperties != null)
            //    {
            //        DockBar._frmProperties.Target = null;
            //    }
            //    GridView.add_FocusedRowChanged(new FocusedRowChangedEventHandler(this.GridView_FocusedRowChanged));
            //}
        }

        private void GridView_Click(object sender, EventArgs e)
        {
            //if (sender != null)
            //{
            //    GridView gridView = sender as GridView;
            //    if (gridView != null)
            //    {
            //        if (gridView.get_RowCount() == 1)
            //        {
            //            DataTable dataTable = (DataTable)gridView.get_GridControl().get_DataSource();
            //            ClickEntity clickEntity = new ClickEntity();
            //            if (dataTable.Columns.Contains("USER_LABEL") && gridView.GetFocusedRowCellValue("USER_LABEL") != null)
            //            {
            //                clickEntity.USER_LABEL = gridView.GetFocusedRowCellValue("USER_LABEL").ToString();
            //            }
            //            if (dataTable.Columns.Contains("BTS_ID") && gridView.GetFocusedRowCellValue("BTS_ID") != null)
            //            {
            //                clickEntity.BTS_ID = gridView.GetFocusedRowCellValue("BTS_ID").ToString();
            //            }
            //            if (dataTable.Columns.Contains("RNC_ID") && gridView.GetFocusedRowCellValue("RNC_ID") != null)
            //            {
            //                clickEntity.RNC_ID = gridView.GetFocusedRowCellValue("RNC_ID").ToString();
            //            }
            //            if (dataTable.Columns.Contains("MSC_ID") && gridView.GetFocusedRowCellValue("MSC_ID") != null)
            //            {
            //                clickEntity.MSC_ID = gridView.GetFocusedRowCellValue("MSC_ID").ToString();
            //            }
            //            if (dataTable.Columns.Contains("STARTTIME") && gridView.GetFocusedRowCellValue("STARTTIME") != null)
            //            {
            //                clickEntity.STARTTIME = gridView.GetFocusedRowCellValue("STARTTIME").ToString();
            //            }
            //            if (dataTable.Columns.Contains("CITY_ID") && gridView.GetFocusedRowCellValue("CITY_ID") != null)
            //            {
            //                clickEntity.CITY_ID = gridView.GetFocusedRowCellValue("CITY_ID").ToString();
            //            }
            //            if (dataTable.Columns.Contains("PRODUCT_ID") && gridView.GetFocusedRowCellValue("PRODUCT_ID") != null)
            //            {
            //                clickEntity.PRODUCT_ID = gridView.GetFocusedRowCellValue("PRODUCT_ID").ToString();
            //            }
            //            clickEntity.ClickIndex = ((GridView)sender).get_FocusedRowHandle();
            //            clickEntity.mDataRow = gridView.GetDataRow(gridView.get_FocusedRowHandle());
            //            this.MoveData.DataRow = clickEntity.mDataRow;
            //            if (DockBar._frmProperties != null)
            //            {
            //                DockBar._frmProperties.Target = clickEntity.mDataRow;
            //                DockBar._frmProperties.DataStruct = gridView.get_Columns();
            //                DockBar._frmProperties.DataBind();
            //            }
            //            this.MoveData.PostTable = dataTable;
            //            this.OutPost_Click(clickEntity);
            //        }
            //    }
            //}
        }

        private void GridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            //if (sender != null)
            //{
            //    GridView gridView = sender as GridView;
            //    if (gridView != null)
            //    {
            //        if (gridView.get_RowCount() != 0)
            //        {
            //            DataTable dataTable = (DataTable)gridView.get_GridControl().get_DataSource();
            //            ClickEntity clickEntity = new ClickEntity();
            //            if (dataTable.Columns.Contains("USER_LABEL") && gridView.GetFocusedRowCellValue("USER_LABEL") != null)
            //            {
            //                clickEntity.USER_LABEL = gridView.GetFocusedRowCellValue("USER_LABEL").ToString();
            //            }
            //            if (dataTable.Columns.Contains("BTS_ID") && gridView.GetFocusedRowCellValue("BTS_ID") != null)
            //            {
            //                clickEntity.BTS_ID = gridView.GetFocusedRowCellValue("BTS_ID").ToString();
            //            }
            //            if (dataTable.Columns.Contains("RNC_ID") && gridView.GetFocusedRowCellValue("RNC_ID") != null)
            //            {
            //                clickEntity.RNC_ID = gridView.GetFocusedRowCellValue("RNC_ID").ToString();
            //            }
            //            if (dataTable.Columns.Contains("MSC_ID") && gridView.GetFocusedRowCellValue("MSC_ID") != null)
            //            {
            //                clickEntity.MSC_ID = gridView.GetFocusedRowCellValue("MSC_ID").ToString();
            //            }
            //            if (dataTable.Columns.Contains("STARTTIME") && gridView.GetFocusedRowCellValue("STARTTIME") != null)
            //            {
            //                clickEntity.STARTTIME = gridView.GetFocusedRowCellValue("STARTTIME").ToString();
            //            }
            //            if (dataTable.Columns.Contains("CITY_ID") && gridView.GetFocusedRowCellValue("CITY_ID") != null)
            //            {
            //                clickEntity.CITY_ID = gridView.GetFocusedRowCellValue("CITY_ID").ToString();
            //            }
            //            if (dataTable.Columns.Contains("PRODUCT_ID") && gridView.GetFocusedRowCellValue("PRODUCT_ID") != null)
            //            {
            //                clickEntity.PRODUCT_ID = gridView.GetFocusedRowCellValue("PRODUCT_ID").ToString();
            //            }
            //            clickEntity.ClickIndex = ((GridView)sender).get_FocusedRowHandle();
            //            clickEntity.mDataRow = gridView.GetDataRow(gridView.get_FocusedRowHandle());
            //            this.MoveData.DataRow = clickEntity.mDataRow;
            //            if (DockBar._frmProperties != null)
            //            {
            //                DockBar._frmProperties.Target = clickEntity.mDataRow;
            //                DockBar._frmProperties.DataStruct = gridView.get_Columns();
            //                DockBar._frmProperties.DataBind();
            //            }
            //            this.MoveData.PostTable = dataTable;
            //            this.OutPost_Click(clickEntity);
            //        }
            //    }
            //}
        }

        private void GridView_MouseMove(object sender, MouseEventArgs e)
        {
            //if (sender != null)
            //{
            //    GridView gridView = sender as GridView;
            //    if (gridView != null)
            //    {
            //        if (e.Button == MouseButtons.Left && this.downHitInfo != null)
            //        {
            //            Size dragSize = SystemInformation.DragSize;
            //            Rectangle rectangle = new Rectangle(new Point(this.downHitInfo.get_HitPoint().X - dragSize.Width / 2, this.downHitInfo.get_HitPoint().Y - dragSize.Height / 2), dragSize);
            //            if (!rectangle.Contains(new Point(e.X, e.Y)))
            //            {
            //                if (((DataTable)gridView.get_GridControl().get_DataSource()).Columns.Contains("USER_LABEL"))
            //                {
            //                    this.MoveData.USER_LABEL = gridView.GetFocusedRowCellValue("USER_LABEL").ToString();
            //                }
            //                this.MoveData.PostTable = (DataTable)gridView.get_GridControl().get_DataSource();
            //                this.MoveData.WinFormName = this.WindowText;
            //                this.MoveData.StartTime = this.BarSpring.get_Caption().Replace("分析时段:", "").Split(new char[]
            //                {
            //                    '―'
            //                })[0].ToString();
            //                this.MoveData.EndTime = this.BarSpring.get_Caption().Replace("分析时段:", "").Split(new char[]
            //                {
            //                    '―'
            //                })[1].ToString();
            //                this.MoveData.DataRow = gridView.GetDataRow(this.downHitInfo.RowHandle);
            //                gridView.get_GridControl().DoDragDrop(this.MoveData, DragDropEffects.Move);
            //                this.downHitInfo = null;
            //                DXMouseEventArgs.GetMouseArgs(e).set_Handled(true);
            //            }
            //        }
            //    }
            //}
        }

        private void GridView_MouseDown(object sender, MouseEventArgs e)
        {
            //if (sender != null)
            //{
            //    GridView gridView = sender as GridView;
            //    if (gridView != null)
            //    {
            //        this.downHitInfo = null;
            //        GridHitInfo gridHitInfo = gridView.CalcHitInfo(new Point(e.X, e.Y));
            //        if (Control.ModifierKeys == Keys.None)
            //        {
            //            if (e.Button == MouseButtons.Left && gridHitInfo.RowHandle >= 0)
            //            {
            //                this.downHitInfo = gridHitInfo;
            //            }
            //        }
            //    }
            //}
        }
        */

        protected override void OnLoad(EventArgs e)
        {
            this.InitializeComponent();
            //this.AllowDrop = true;
            base.OnLoad(e);
            if (string.IsNullOrEmpty(this.WindowText))
            {
                this.WindowText = this.Text;
            }
            //DoubleLanguage.loadDoubleLanguageXml(base.Name, base.Controls);
        }

        protected void InitializeComponent()
        {
            this.MainBar = new DevExpress.XtraBars.BarManager();
            this.BottomBar = new DevExpress.XtraBars.Bar();
            this.BarSpring = new DevExpress.XtraBars.BarStaticItem();
            this.BarStateText = new DevExpress.XtraBars.BarStaticItem();
            this.BarProgress = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.BarStop = new DevExpress.XtraBars.BarButtonItem();
            this.BarItemTime = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.repositoryItemMarqueeProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar();
            this.ProgressBar = new DevExpress.XtraEditors.ProgressBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.MainBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // MainBar
            // 
            this.MainBar.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.BottomBar});
            this.MainBar.DockControls.Add(this.barDockControlTop);
            this.MainBar.DockControls.Add(this.barDockControlBottom);
            this.MainBar.DockControls.Add(this.barDockControlLeft);
            this.MainBar.DockControls.Add(this.barDockControlRight);
            this.MainBar.Form = this;
            this.MainBar.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.BarSpring,
            this.BarStateText,
            this.BarProgress,
            this.BarStop,
            this.BarItemTime});
            this.MainBar.MaxItemId = 9;
            this.MainBar.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMarqueeProgressBar1,
            this.repositoryItemProgressBar1});
            this.MainBar.StatusBar = this.BottomBar;
            // 
            // BottomBar
            // 
            this.BottomBar.BarName = "Status bar";
            this.BottomBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.BottomBar.DockCol = 0;
            this.BottomBar.DockRow = 0;
            this.BottomBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.BottomBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.BarSpring, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.BarStateText, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.BarProgress, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.BarStop, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.BarItemTime, true)});
            this.BottomBar.OptionsBar.AllowQuickCustomization = false;
            this.BottomBar.OptionsBar.DrawDragBorder = false;
            this.BottomBar.OptionsBar.DrawSizeGrip = true;
            this.BottomBar.OptionsBar.UseWholeRow = true;
            this.BottomBar.Text = "Status bar";
            this.BottomBar.Visible = false;
            // 
            // BarSpring
            // 
            this.BarSpring.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring;
            this.BarSpring.Id = 2;
            this.BarSpring.Name = "BarSpring";
            this.BarSpring.Size = new System.Drawing.Size(32, 0);
            this.BarSpring.TextAlignment = System.Drawing.StringAlignment.Near;
            this.BarSpring.Width = 32;
            // 
            // BarStateText
            // 
            this.BarStateText.Caption = "状态:就绪";
            this.BarStateText.Id = 3;
            this.BarStateText.Name = "BarStateText";
            this.BarStateText.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // BarProgress
            // 
            this.BarProgress.Caption = "barEditItem1";
            this.BarProgress.Edit = this.repositoryItemProgressBar1;
            this.BarProgress.EditWidth = 90;
            this.BarProgress.Id = 5;
            this.BarProgress.Name = "BarProgress";
            // 
            // repositoryItemProgressBar1
            // 
            this.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1";
            // 
            // BarStop
            // 
            this.BarStop.Caption = "暂停";
            this.BarStop.Enabled = false;
            this.BarStop.Id = 6;
            this.BarStop.Name = "BarStop";
            this.BarStop.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.BarStop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarStop_ItemClick);
            // 
            // BarItemTime
            // 
            this.BarItemTime.Caption = "耗时:0s";
            this.BarItemTime.Id = 8;
            this.BarItemTime.Name = "BarItemTime";
            this.BarItemTime.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.MainBar;
            this.barDockControlTop.Size = new System.Drawing.Size(506, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 247);
            this.barDockControlBottom.Manager = this.MainBar;
            this.barDockControlBottom.Size = new System.Drawing.Size(506, 32);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.MainBar;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 247);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(506, 0);
            this.barDockControlRight.Manager = this.MainBar;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 247);
            // 
            // repositoryItemMarqueeProgressBar1
            // 
            this.repositoryItemMarqueeProgressBar1.Name = "repositoryItemMarqueeProgressBar1";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(113, 130);
            this.ProgressBar.MenuManager = this.MainBar;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(280, 18);
            this.ProgressBar.TabIndex = 4;
            this.ProgressBar.Visible = false;
            // 
            // DockBar
            // 
            this.ClientSize = new System.Drawing.Size(506, 279);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "DockBar";
            ((System.ComponentModel.ISupportInitialize)(this.MainBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBar.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void BarStop_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.StopClick();
        }

        public void StopClick()
        {
            if (this.IsNowRun)
            {
                DockBar.StopMeans method = new DockBar.StopMeans(this.Stop);
                base.Invoke(method, new object[]
                {
                    this.ExecuteMeans.Method.Name.ToString()
                });
            }
        }

        public void ProgressBarInit()
        {
            this.BarProgress.EditValue = 0; ;
            this.ProgressBar.EditValue = 0;
            Application.DoEvents();
        }

        public void ProgressBarSetMax(int Max)
        {
            this.ProgressBar.Properties.Maximum = Max;
            this.repositoryItemProgressBar1.Maximum = Max;
            Application.DoEvents();
        }

        public void ProgressBarSetPostion(int Pos)
        {
            this.BarProgress.EditValue = Pos;
            this.ProgressBar.EditValue = Pos;
            Application.DoEvents();
        }

        public void ProgressBarEnd()
        {
            this.BarProgress.EditValue = this.repositoryItemProgressBar1.Maximum;
            this.BarProgress.EditValue = 0;
            this.ProgressBar.EditValue = this.ProgressBar.Properties.Maximum;
            this.ProgressBar.EditValue = 0;
            Application.DoEvents();
        }

        public void DoEvent()
        {
            Application.DoEvents();
        }

        protected override void OnResize(EventArgs e)
        {
            if (this.ProgressBar != null)
            {
                this.ProgressBar.Width = base.Width - 100;
                this.ProgressBar.Left = (base.Width - this.ProgressBar.Width) / 2;
                this.ProgressBar.Top = (base.Height - this.ProgressBar.Height - 25) / 2;
            }
            base.OnResize(e);
        }
    }
}
