using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Net;
using System.Windows.Forms;
using Nest.Framework.Core;
using Nest.Framework.SysManage;
using Nest.Framework.Utility;

namespace Nest.Main
{
    public partial class MainApp : DevExpress.XtraEditors.XtraForm, ISystemApplication
    {
        private DockBarServiceImp _DockService;
        private PluginServiceImp _PluginService;
        private ServiceContainer _ServiceContainer = new ServiceContainer();

        public MainApp()
        {
            InitializeComponent();

            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            //系统界面风格：
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2007 Blue");

            _DockService = new DockBarServiceImp(this);
            _PluginService = new PluginServiceImp(this);
            _ServiceContainer.AddService(typeof(IDockBarService), _DockService);
            _ServiceContainer.AddService(typeof(IPluginService), _PluginService);

            //初始化Bar
            new BarFactroy(this);
        }

        private void LoadLeft()
        {
            frmLeft left = new frmLeft();
            left.SystemApplication = this;

            this._DockService.AddDockBar(left.Name, left, DockState.DockLeft);
            ///系统级对象添加,顺序不能随便调整
            //ObjectInfo = new object[] { null, left };

        }

        /// <summary>
        /// 菜单映射
        /// </summary>
        /// <param name="ModelCaption"></param>
        /// <param name="ModelDllName"></param>
        /// <param name="ModelClassName"></param>
        public void MenuInit(string ModelCaption, string ModelDllName, string ModelClassName)
        {
            if (string.IsNullOrEmpty(ModelClassName) || string.IsNullOrEmpty(ModelDllName))
            {
                MessageBoxTool.Message("界面加载失败,请检查相关配置！");
                return;
            }
            RemovePage(ModelCaption, ModelClassName);
            _PluginService.LoadPlugin(ModelCaption, ModelDllName, ModelClassName);
            _PluginService.UsePlugin(ModelCaption);
        }

        public void RemovePage(string ModelCaption, string ModelClassName)
        {
            foreach (DevExpress.XtraTabbedMdi.XtraMdiTabPage page in xtraTabbedMdiManager1.Pages)
            {
                if (page.MdiChild.GetType().ToString().ToLower().Equals(ModelClassName.ToLower()) && page.Text.Equals(ModelCaption))
                {
                    xtraTabbedMdiManager1.Pages.Remove(page);
                    break;
                }
            }
        }

        #region ISystemApplication 成员

        //public object[] ObjectInfo
        //{
        //    get;
        //    set;
        //}

        public Dictionary<string, object> Objects { get; set; }

        public string Status
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public BarButtonItem BarButtonAdd
        {
            get { return this.barButtonAdd; }
        }

        public BarButtonItem BarButtonDel
        {
            get { return this.barButtonDel; }
        }

        public BarButtonItem BarButtonExport
        {
            get { return this.barButtonExport; }
        }

        public BarButtonItem BarButtonImport
        {
            get { return this.barButtonImport; }
        }

        public BarButtonItem BarButtonQuery
        {
            get { return this.barButtonQuery; }
        }

        public BarButtonItem BarButtonReport
        {
            get { return this.barButtonReport; }
        }

        public BarButtonItem BarButtonStop
        {
            get { return this.barButtonStop; }
        }

        public BarButtonItem BarButtonUpdate
        {
            get { return this.barButtonUpdate; }
        }

        public BarButtonItem BarButtonClear
        {
            get { return this.barButtonClear; }
        }

        public BarButtonItem BarButtonSave
        {
            get { return this.barButtonSave; }
        }


        public BarStaticItem BarItem_Time
        {
            get { return this.BarItemTime; }
        }

        public BarStaticItem BarItem_Spring
        {
            get { return this.BarSpring; }
        }

        public DevExpress.XtraTabbedMdi.XtraTabbedMdiManager MainTabManager
        {
            get { return this.xtraTabbedMdiManager1; }
        }

        public UserObject UserObject
        {
            get;
            set;
        }

        public MenuInfo MenuInfo
        {
            get;
            set;
        }

        /// <summary>
        /// 系统状态
        /// </summary>
        public string StatusState
        {
            get
            {
                return this.BarStateText.Caption;
            }
            set
            {
                if (BarStateText != null)
                    this.BarStateText.Caption = "状态：" + value.Replace("状态：", "").Replace(":", "");
            }
        }

        public DevExpress.XtraBars.Docking.DockManager MainDockManager
        {
            get { return this.dockManager1; }
        }

        public Form MainFrom
        {
            get { return this; }
        }

        Form _ActiveForm = new Form();
        public new Form ActiveForm
        {
            get
            {
                return this.ActiveMdiChild;
            }
            set
            {
                this._ActiveForm = value;
            }
        }

        /// <summary>
        /// 初始化进度条
        /// </summary>
        public void ProgressBarInit()
        {
            BarProgress.EditValue = 0;
            Application.DoEvents();
        }

        /// <summary>
        /// 初始化进度条最大进度
        /// </summary>
        /// <param name="Max"></param>
        public void ProgressBarSetMax(int Max)
        {
            this.repositoryItemProgressBar1.Maximum = Max;
            Application.DoEvents();
        }

        /// <summary>
        /// 进度条现在的位置
        /// </summary>
        /// <param name="Pos"></param>
        public void ProgressBarSetPostion(int Pos)
        {
            this.BarProgress.EditValue = Pos;
            Application.DoEvents();
        }

        /// <summary>
        /// 进度条恢复初始状态
        /// </summary>
        public void ProgressBarEnd()
        {
            BarProgress.EditValue = this.repositoryItemProgressBar1.Maximum;
            BarProgress.EditValue = 0;
            Application.DoEvents();
        }

        public void DoEvent()
        {
            throw new NotImplementedException();
        }

        public void Wait()
        {
            throw new NotImplementedException();
        }

        public void BreackWait()
        {
            throw new NotImplementedException();
        }

        public ConnectionType ConnectionType
        {
            get;
            set;
        }

        public string ConnnectKey
        {
            get;
            set;
        }

        #endregion

        #region IServiceContainer 成员

        public void AddService(Type serviceType, System.ComponentModel.Design.ServiceCreatorCallback callback, bool promote)
        {
            throw new NotImplementedException();
        }

        public void AddService(Type serviceType, System.ComponentModel.Design.ServiceCreatorCallback callback)
        {
            throw new NotImplementedException();
        }

        public void AddService(Type serviceType, object serviceInstance, bool promote)
        {
            throw new NotImplementedException();
        }

        public void AddService(Type serviceType, object serviceInstance)
        {
            throw new NotImplementedException();
        }

        public void RemoveService(Type serviceType, bool promote)
        {
            throw new NotImplementedException();
        }

        public void RemoveService(Type serviceType)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IServiceProvider 成员

        public new object GetService(Type serviceType)
        {
            return _ServiceContainer.GetService(serviceType);
        }

        #endregion

        #region 皮肤
        //public void TopMenu()
        //{
        //    foreach (SkinContainer cnt in SkinManager.Default.Skins)
        //    {
        //        DevExpress.XtraBars.BarButtonItem BarItems = new DevExpress.XtraBars.BarButtonItem();
        //        BarItems.Caption = getSkinName(cnt.SkinName);
        //        //BarItems.Caption = cnt.SkinName;
        //        BarItems.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(BarItems_ItemClick);
        //        barSubItem2.ItemLinks.Add(BarItems);
        //    }
        //}

        //public string getSkinName(string SkinName)
        //{
        //    if (SkinName.Equals("Caramel"))
        //    {
        //        return "怀旧色";
        //    }
        //    else if (SkinName.Equals("Money Twins"))
        //    {
        //        return "经典蓝色";
        //    }
        //    else if (SkinName.Equals("Lilian"))
        //    {
        //        return "天蓝色";
        //    }
        //    else if (SkinName.Equals("The Asphalt World"))
        //    {
        //        return "洁净世界";
        //    }
        //    else if (SkinName.Equals("iMaginary"))
        //    {
        //        return "虚拟世界";
        //    }
        //    else if (SkinName.Equals("Black"))
        //    {
        //        return "黑色经典";
        //    }
        //    else if (SkinName.Equals("Blue"))
        //    {
        //        return "蓝色海洋";
        //    }
        //    else if (SkinName.Equals("Office 2007 Blue"))
        //    {
        //        return "Office2007蓝色";
        //    }
        //    else if (SkinName.Equals("Office 2007 Black"))
        //    {
        //        return "Office2007黑色";
        //    }
        //    else if (SkinName.Equals("Office 2007 Silver"))
        //    {
        //        return "Office2007银色";
        //    }
        //    else if (SkinName.Equals("Office 2007 Green"))
        //    {
        //        return "Office2007绿色";
        //    }
        //    else if (SkinName.Equals("Office 2007 Pink"))
        //    {
        //        return "Office2007粉红色";
        //    }
        //    else if (SkinName.Equals("Coffee"))
        //    {
        //        return "咖啡色";
        //    }
        //    else if (SkinName.Equals("Liquid Sky"))
        //    {
        //        return "洁净天空";
        //    }
        //    else if (SkinName.Equals("London Liquid Sky"))
        //    {
        //        return "伦敦的天空";
        //    }
        //    else if (SkinName.Equals("Glass Oceans"))
        //    {
        //        return "玻璃色";
        //    }
        //    else if (SkinName.Equals("Stardust"))
        //    {
        //        return "金属银白";
        //    }
        //    else if (SkinName.Equals("Xmas 2008 Blue"))
        //    {
        //        return "圣诞节2008蓝调";
        //    }
        //    else if (SkinName.Equals("Valentine"))
        //    {
        //        return "情人节礼物";
        //    }
        //    else if (SkinName.Equals("McSkin"))
        //    {
        //        return "灰色";
        //    }
        //    else if (SkinName.Equals("Summer 2008"))
        //    {
        //        return "2008年的夏天";
        //    }
        //    else if (SkinName.Equals("Pumpkin"))
        //    {
        //        return "地狱之火";
        //    }
        //    else if (SkinName.Equals("Dark Side"))
        //    {
        //        return "黑色的诱惑";
        //    }
        //    else if (SkinName.Equals("Springtime"))
        //    {
        //        return "春季";
        //    }
        //    else if (SkinName.Equals("Darkroom"))
        //    {
        //        return "暗室";
        //    }
        //    else if (SkinName.Equals("Foggy"))
        //    {
        //        return "朦胧的美";
        //    }
        //    else if (SkinName.Equals("High Contrast"))
        //    {
        //        return "反差的感觉";
        //    }
        //    else if (SkinName.Equals("Seven"))
        //    {
        //        return "Win7";
        //    }
        //    else if (SkinName.Equals("Seven Classic"))
        //    {
        //        return "Win7 Classic";
        //    }
        //    else if (SkinName.Equals("Sharp"))
        //    {
        //        return "Sharp";
        //    }
        //    else if (SkinName.Equals("Sharp Plus"))
        //    {
        //        return "Sharp Plus";
        //    }
        //    return "";
        //}

        //public string turnSkinName(string SkinName)
        //{
        //    if (SkinName.Equals("怀旧色"))
        //    {
        //        return "Caramel";
        //    }
        //    else if (SkinName.Equals("经典蓝色"))
        //    {
        //        return "Money Twins";
        //    }
        //    else if (SkinName.Equals("天蓝色"))
        //    {
        //        return "Lilian";
        //    }
        //    else if (SkinName.Equals("洁净世界"))
        //    {
        //        return "The Asphalt World";
        //    }
        //    else if (SkinName.Equals("虚拟世界"))
        //    {
        //        return "iMaginary";
        //    }
        //    else if (SkinName.Equals("黑色经典"))
        //    {
        //        return "Black";
        //    }
        //    else if (SkinName.Equals("蓝色海洋"))
        //    {
        //        return "Blue";
        //    }
        //    else if (SkinName.Equals("Office2007蓝色"))
        //    {
        //        return "Office 2007 Blue";
        //    }
        //    else if (SkinName.Equals("Office2007黑色"))
        //    {
        //        return "Office 2007 Black";
        //    }
        //    else if (SkinName.Equals("Office2007银色"))
        //    {
        //        return "Office 2007 Silver";
        //    }
        //    else if (SkinName.Equals("Office2007绿色"))
        //    {
        //        return "Office 2007 Green";
        //    }
        //    else if (SkinName.Equals("Office2007粉红色"))
        //    {
        //        return "Office 2007 Pink";
        //    }
        //    else if (SkinName.Equals("咖啡色"))
        //    {
        //        return "Coffee";
        //    }
        //    else if (SkinName.Equals("洁净天空"))
        //    {
        //        return "Liquid Sky";
        //    }
        //    else if (SkinName.Equals("伦敦的天空"))
        //    {
        //        return "London Liquid Sky";
        //    }
        //    else if (SkinName.Equals("玻璃色"))
        //    {
        //        return "Glass Oceans";
        //    }
        //    else if (SkinName.Equals("金属银白"))
        //    {
        //        return "Stardust";
        //    }
        //    else if (SkinName.Equals("圣诞节2008蓝调"))
        //    {
        //        return "Xmas 2008 Blue";
        //    }
        //    else if (SkinName.Equals("情人节礼物"))
        //    {
        //        return "Valentine";
        //    }
        //    else if (SkinName.Equals("灰色"))
        //    {
        //        return "McSkin";
        //    }
        //    else if (SkinName.Equals("2008年的夏天"))
        //    {
        //        return "Summer 2008";
        //    }
        //    else if (SkinName.Equals("地狱之火"))
        //    {
        //        return "Pumpkin";
        //    }
        //    else if (SkinName.Equals("黑色的诱惑"))
        //    {
        //        return "Dark Side";
        //    }
        //    else if (SkinName.Equals("春季"))
        //    {
        //        return "Springtime";
        //    }
        //    else if (SkinName.Equals("暗室"))
        //    {
        //        return "Darkroom";
        //    }
        //    else if (SkinName.Equals("朦胧的美"))
        //    {
        //        return "Foggy";
        //    }
        //    else if (SkinName.Equals("反差的感觉"))
        //    {
        //        return "High Contrast";
        //    }
        //    else if (SkinName.Equals("Win7"))
        //    {
        //        return "Seven";
        //    }
        //    else if (SkinName.Equals("Win7 Classic"))
        //    {
        //        return "Seven Classic";
        //    }
        //    else if (SkinName.Equals("Sharp"))
        //    {
        //        return "Sharp";
        //    }
        //    else if (SkinName.Equals("Sharp Plus"))
        //    {
        //        return "Sharp Plus";
        //    }
        //    return "";
        //}


        //void BarItems_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(turnSkinName(e.Item.Caption));
        //    //DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(e.Item.Caption);
        //}
        #endregion

        public void MainApp_Load(object sender, EventArgs e)
        {
            LoadLeft();
        }

        private void Exit()
        {
            Program.MainApp.Close();
        }

        private void MainApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (MessageBoxTool.Confirm("您确定退出系统吗？") == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
                string uName = Program.MainApp.UserObject.UserInfo.EnName;
                this.timer1.Stop();
                Program.KillProcess();
            }
            catch
            {
            }
        }

        //private void BarItemClose_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    this.Exit();
        //}

        //private void BarItemUPass_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    if (System.IO.File.Exists(Application.StartupPath + "\\NetConfig.exe"))
        //        System.Diagnostics.Process.Start(Application.StartupPath + "\\NetConfig.exe");
        //}

        //private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    MessageBox.Show(barMdiChildrenListItem1.ItemLinks.Count.ToString());
        //}

        //private void BarItemAbout_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    //Login.frmAbout LFA = new IUB.Main.Login.frmAbout();
        //    //LFA.ShowDialog();
        //}

        private void MainApp_MdiChildActivate(object sender, EventArgs e)
        {
            DockBar dockBar = (DockBar)this.ActiveMdiChild;
            if (dockBar == null)
                return;
        }

        private void barButtonExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Exit();
        }

        private void xtraTabbedMdiManager1_SelectedPageChanged(object sender, EventArgs e)
        {
            if (xtraTabbedMdiManager1.Pages.Count == 0 || this.ActiveMdiChild == null)
                return;
            Form page = this.ActiveMdiChild;
            if (this.UserObject != null)
            {
                foreach (MenuInfo menu in this.UserObject.MenuList)
                {
                    if (menu.ReflectType.Equals(page.GetType().ToString()) && menu.CnName.Equals(page.Text))
                    {
                        this.MenuInfo = menu;
                        break;
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.UserObject != null)
            {
                BarItemUserName.Caption = "用户名:" + this.UserObject.UserInfo.CnName;
            }
            BarItemSysTime.Caption = "当前时间:" + System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void barButtonQuery_ItemClick(object sender, ItemClickEventArgs e)
        {
            //string typeName = "";
            //try
            //{
            //    foreach (DevExpress.XtraTabbedMdi.XtraMdiTabPage page in xtraTabbedMdiManager1.Pages)
            //    {
            //        typeName = page.Text;
            //    }
            //}
            //catch (Exception ex)
            //{
            //}
        }

        private void barButtonStop_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            //string typeName = "";
            //try
            //{
            //    foreach (DevExpress.XtraTabbedMdi.XtraMdiTabPage page in xtraTabbedMdiManager1.Pages)
            //    {
            //        typeName = page.Text;
            //    }
            //    //if (this.UserPrivilegeInfo != null && this.menuInfo != null)
            //    //{
            //    //}
            //}
            //catch (Exception ex)
            //{
            //}
        }

        private void barButtonUpdate_ItemClick(object sender, ItemClickEventArgs e)
        {
            //string typeName = "";
            //try
            //{
            //    foreach (DevExpress.XtraTabbedMdi.XtraMdiTabPage page in xtraTabbedMdiManager1.Pages)
            //    {
            //        typeName = page.Text;
            //    }
            //    //if (this.UserPrivilegeInfo != null && this.menuInfo != null)
            //    //{
            //    //}
            //}
            //catch (Exception ex)
            //{
            //}
        }

        private void barButtonDel_ItemClick(object sender, ItemClickEventArgs e)
        {
            //string typeName = "";
            //try
            //{
            //    foreach (DevExpress.XtraTabbedMdi.XtraMdiTabPage page in xtraTabbedMdiManager1.Pages)
            //    {
            //        typeName = page.Text;
            //    }
            //    //if (this.UserPrivilegeInfo != null && this.menuInfo != null)
            //    //{
            //    //}
            //}
            //catch (Exception ex)
            //{
            //}
        }

        private void barButtonSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            //string typeName = "";
            //try
            //{
            //    foreach (DevExpress.XtraTabbedMdi.XtraMdiTabPage page in xtraTabbedMdiManager1.Pages)
            //    {
            //        typeName = page.Text;
            //    }

            //    //if (this.menuInfo != null && this.UserPrivilegeInfo != null)
            //    //{
            //    //}
            //}
            //catch (Exception ex)
            //{
            //}
        }

        private void barButtonClear_ItemClick(object sender, ItemClickEventArgs e)
        {
            //string typeName = "";
            //try
            //{
            //    foreach (DevExpress.XtraTabbedMdi.XtraMdiTabPage page in xtraTabbedMdiManager1.Pages)
            //    {
            //        typeName = page.Text;
            //    }
            //    //if (this.menuInfo != null && this.UserPrivilegeInfo != null)
            //    //{
            //    //}
            //}
            //catch (Exception ex)
            //{
            //}
        }

        private void barButtonImport_ItemClick(object sender, ItemClickEventArgs e)
        {
            //string typeName = "";
            //try
            //{
            //    foreach (DevExpress.XtraTabbedMdi.XtraMdiTabPage page in xtraTabbedMdiManager1.Pages)
            //    {
            //        typeName = page.Text;
            //    }
            //    //if (this.menuInfo != null && this.UserPrivilegeInfo != null)
            //    //{
            //    //}
            //}
            //catch (Exception ex)
            //{
            //}
        }

        private void barButtonExport_ItemClick(object sender, ItemClickEventArgs e)
        {
            //string typeName = "";
            //try
            //{
            //    foreach (DevExpress.XtraTabbedMdi.XtraMdiTabPage page in xtraTabbedMdiManager1.Pages)
            //    {
            //        typeName = page.Text;
            //    }
            //    //if (this.menuInfo != null && this.UserPrivilegeInfo != null)
            //    //{
            //    //}
            //}
            //catch (Exception ex)
            //{
            //}
        }

        private void barButtonReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            //string typeName = "";
            //try
            //{
            //    foreach (DevExpress.XtraTabbedMdi.XtraMdiTabPage page in xtraTabbedMdiManager1.Pages)
            //    {
            //        typeName = page.Text;
            //    }
            //    //if (this.menuInfo != null && this.UserPrivilegeInfo != null)
            //    //{
            //    //}
            //}
            //catch (Exception ex)
            //{
            //}
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            MenuInit("Test.UI.Test1", "Nest.Framework.Test.UI.dll", "Nest.Framework.Test.UI.Test1");
        }
    }
}
