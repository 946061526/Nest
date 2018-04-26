namespace Nest.Main
{
    partial class MainApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainApp));
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.BarItemSysTime = new DevExpress.XtraBars.BarStaticItem();
            this.BarItemUserName = new DevExpress.XtraBars.BarStaticItem();
            this.BarSpring = new DevExpress.XtraBars.BarStaticItem();
            this.BarStateText = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.BarProgress = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.BarItemTime = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonQuery = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonStop = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonDel = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonSave = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonClear = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonImport = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonExport = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonReport = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonExit = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.BarProgress1 = new DevExpress.XtraBars.BarStaticItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemHyperLinkEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.MenuManager = this.barManager1;
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // barManager1
            // 
            this.barManager1.AllowCustomization = false;
            this.barManager1.AllowShowToolbarsPopup = false;
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3,
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockManager = this.dockManager1;
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItem2,
            this.BarProgress1,
            this.barEditItem1,
            this.BarSpring,
            this.BarStateText,
            this.barButtonItem6,
            this.BarProgress,
            this.BarItemTime,
            this.barButtonQuery,
            this.barButtonStop,
            this.barButtonAdd,
            this.barButtonUpdate,
            this.barButtonDel,
            this.barButtonImport,
            this.barButtonExport,
            this.barButtonReport,
            this.barButtonExit,
            this.barButtonClear,
            this.barButtonSave,
            this.barStaticItem1,
            this.BarItemUserName,
            this.BarItemSysTime,
            this.barSubItem3,
            this.barButtonItem7,
            this.barButtonItem8});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 72;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHyperLinkEdit1,
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2,
            this.repositoryItemProgressBar1});
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, false, this.barSubItem2, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem3)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.RotateWhenVertical = false;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "系统样式(&T)";
            this.barSubItem2.Id = 1;
            this.barSubItem2.ItemShortcut = new DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
                | System.Windows.Forms.Keys.S));
            this.barSubItem2.Name = "barSubItem2";
            // 
            // barSubItem3
            // 
            this.barSubItem3.Caption = "测试";
            this.barSubItem3.Id = 69;
            this.barSubItem3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem7),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem8)});
            this.barSubItem3.Name = "barSubItem3";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "测试1";
            this.barButtonItem7.Id = 70;
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem7_ItemClick);
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "测试2";
            this.barButtonItem8.Id = 71;
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.BarItemSysTime, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.BarItemUserName, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.BarSpring, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.BarStateText, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem6),
            new DevExpress.XtraBars.LinkPersistInfo(this.BarProgress, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.BarItemTime, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1, true)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.RotateWhenVertical = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // BarItemSysTime
            // 
            this.BarItemSysTime.Caption = "当前时间:";
            this.BarItemSysTime.Id = 67;
            this.BarItemSysTime.Name = "BarItemSysTime";
            this.BarItemSysTime.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // BarItemUserName
            // 
            this.BarItemUserName.Caption = "用户名:";
            this.BarItemUserName.Id = 66;
            this.BarItemUserName.Name = "BarItemUserName";
            this.BarItemUserName.Size = new System.Drawing.Size(50, 0);
            this.BarItemUserName.TextAlignment = System.Drawing.StringAlignment.Near;
            this.BarItemUserName.Width = 50;
            // 
            // BarSpring
            // 
            this.BarSpring.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.BarSpring.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring;
            this.BarSpring.Id = 48;
            this.BarSpring.Name = "BarSpring";
            this.BarSpring.Size = new System.Drawing.Size(32, 0);
            this.BarSpring.TextAlignment = System.Drawing.StringAlignment.Near;
            this.BarSpring.Width = 32;
            // 
            // BarStateText
            // 
            this.BarStateText.Caption = "状态:就绪";
            this.BarStateText.Id = 49;
            this.BarStateText.Name = "BarStateText";
            this.BarStateText.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Id = 50;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // BarProgress
            // 
            this.BarProgress.Caption = "barEditItem2";
            this.BarProgress.Edit = this.repositoryItemProgressBar1;
            this.BarProgress.EditWidth = 100;
            this.BarProgress.Id = 52;
            this.BarProgress.Name = "BarProgress";
            // 
            // repositoryItemProgressBar1
            // 
            this.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1";
            // 
            // BarItemTime
            // 
            this.BarItemTime.Caption = "耗时:0s";
            this.BarItemTime.Id = 53;
            this.BarItemTime.Name = "BarItemTime";
            this.BarItemTime.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "xxxxx科技有限公司";
            this.barStaticItem1.Id = 65;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tool bar";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonQuery),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonStop),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonAdd, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonUpdate),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonDel),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonClear),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonImport, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonExport),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonReport, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonExit, true)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tool bar";
            // 
            // barButtonQuery
            // 
            this.barButtonQuery.Caption = "查询";
            this.barButtonQuery.Enabled = false;
            this.barButtonQuery.Id = 54;
            this.barButtonQuery.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonQuery.ImageOptions.Image")));
            this.barButtonQuery.Name = "barButtonQuery";
            this.barButtonQuery.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonQuery_ItemClick);
            // 
            // barButtonStop
            // 
            this.barButtonStop.Caption = "停止";
            this.barButtonStop.Enabled = false;
            this.barButtonStop.Id = 55;
            this.barButtonStop.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonStop.ImageOptions.Image")));
            this.barButtonStop.Name = "barButtonStop";
            this.barButtonStop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonStop_ItemClick);
            // 
            // barButtonAdd
            // 
            this.barButtonAdd.Caption = "新增";
            this.barButtonAdd.Enabled = false;
            this.barButtonAdd.Id = 56;
            this.barButtonAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonAdd.ImageOptions.Image")));
            this.barButtonAdd.Name = "barButtonAdd";
            this.barButtonAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonAdd_ItemClick);
            // 
            // barButtonUpdate
            // 
            this.barButtonUpdate.Caption = "修改";
            this.barButtonUpdate.Enabled = false;
            this.barButtonUpdate.Id = 57;
            this.barButtonUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonUpdate.ImageOptions.Image")));
            this.barButtonUpdate.Name = "barButtonUpdate";
            this.barButtonUpdate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonUpdate_ItemClick);
            // 
            // barButtonDel
            // 
            this.barButtonDel.Caption = "删除";
            this.barButtonDel.Enabled = false;
            this.barButtonDel.Id = 58;
            this.barButtonDel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonDel.ImageOptions.Image")));
            this.barButtonDel.Name = "barButtonDel";
            this.barButtonDel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonDel_ItemClick);
            // 
            // barButtonSave
            // 
            this.barButtonSave.Caption = "保存";
            this.barButtonSave.Enabled = false;
            this.barButtonSave.Id = 64;
            this.barButtonSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonSave.ImageOptions.Image")));
            this.barButtonSave.Name = "barButtonSave";
            this.barButtonSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonSave_ItemClick);
            // 
            // barButtonClear
            // 
            this.barButtonClear.Caption = "清空";
            this.barButtonClear.Enabled = false;
            this.barButtonClear.Id = 63;
            this.barButtonClear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonClear.ImageOptions.Image")));
            this.barButtonClear.Name = "barButtonClear";
            this.barButtonClear.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonClear_ItemClick);
            // 
            // barButtonImport
            // 
            this.barButtonImport.Caption = "导入";
            this.barButtonImport.Enabled = false;
            this.barButtonImport.Id = 59;
            this.barButtonImport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonImport.ImageOptions.Image")));
            this.barButtonImport.Name = "barButtonImport";
            this.barButtonImport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonImport_ItemClick);
            // 
            // barButtonExport
            // 
            this.barButtonExport.Caption = "导出";
            this.barButtonExport.Enabled = false;
            this.barButtonExport.Id = 60;
            this.barButtonExport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonExport.ImageOptions.Image")));
            this.barButtonExport.Name = "barButtonExport";
            this.barButtonExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonExport_ItemClick);
            // 
            // barButtonReport
            // 
            this.barButtonReport.Caption = "报表";
            this.barButtonReport.Enabled = false;
            this.barButtonReport.Id = 61;
            this.barButtonReport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonReport.ImageOptions.Image")));
            this.barButtonReport.Name = "barButtonReport";
            this.barButtonReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonReport_ItemClick);
            // 
            // barButtonExit
            // 
            this.barButtonExit.Caption = "退出";
            this.barButtonExit.Id = 62;
            this.barButtonExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonExit.ImageOptions.Image")));
            this.barButtonExit.Name = "barButtonExit";
            this.barButtonExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonExit_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(767, 83);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 416);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(767, 28);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 83);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 333);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(767, 83);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 333);
            // 
            // BarProgress1
            // 
            this.BarProgress1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.BarProgress1.Caption = "耗时:0s";
            this.BarProgress1.Id = 46;
            this.BarProgress1.Name = "BarProgress1";
            this.BarProgress1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.repositoryItemTextEdit1;
            this.barEditItem1.Id = 47;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemHyperLinkEdit1
            // 
            this.repositoryItemHyperLinkEdit1.AutoHeight = false;
            this.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1";
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Glass Oceans";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTabbedMdiManager1.MdiParent = this;
            this.xtraTabbedMdiManager1.SelectedPageChanged += new System.EventHandler(this.xtraTabbedMdiManager1_SelectedPageChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainApp
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 444);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IsMdiContainer = true;
            this.Name = "MainApp";
            this.Text = "xxxxxxx管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainApp_FormClosing);
            this.Load += new System.EventHandler(this.MainApp_Load);
            this.MdiChildActivate += new System.EventHandler(this.MainApp_MdiChildActivate);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarStaticItem BarProgress1;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.BarStaticItem BarSpring;
        private DevExpress.XtraBars.BarStaticItem BarStateText;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarEditItem BarProgress;
        private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repositoryItemProgressBar1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        public DevExpress.XtraBars.BarStaticItem BarItemTime;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonQuery;
        private DevExpress.XtraBars.BarButtonItem barButtonStop;
        private DevExpress.XtraBars.BarButtonItem barButtonAdd;
        private DevExpress.XtraBars.BarButtonItem barButtonUpdate;
        private DevExpress.XtraBars.BarButtonItem barButtonDel;
        private DevExpress.XtraBars.BarButtonItem barButtonImport;
        private DevExpress.XtraBars.BarButtonItem barButtonExport;
        private DevExpress.XtraBars.BarButtonItem barButtonReport;
        private DevExpress.XtraBars.BarButtonItem barButtonExit;
        private DevExpress.XtraBars.BarButtonItem barButtonSave;
        private DevExpress.XtraBars.BarButtonItem barButtonClear;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem BarItemSysTime;
        private DevExpress.XtraBars.BarStaticItem BarItemUserName;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraBars.BarSubItem barSubItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
    }
}