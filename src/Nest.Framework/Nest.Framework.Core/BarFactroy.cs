using DevExpress.XtraBars;
using DevExpress.XtraTabbedMdi;
using System;
using System.Linq;
using Nest.Framework.SysManage;

namespace Nest.Framework.Core
{
    public class BarFactroy
    {
        public ISystemApplication SystemApplicaiton
        {
            get;
            set;
        }

        public BarFactroy()
        {

        }

        public BarFactroy(ISystemApplication pSystemApplication)
        {
            this.SystemApplicaiton = pSystemApplication;
            this.SystemApplicaiton.MainTabManager.PageRemoved += new MdiTabPageEventHandler(this.MainTabManager_PageRemoved);
            this.SystemApplicaiton.MainTabManager.SelectedPageChanged += new EventHandler(this.MainTabManager_SelectedPageChanged);

            this.SystemApplicaiton.BarButtonAdd.ItemClick += new ItemClickEventHandler(this.BarButton_ItemClick);
            this.SystemApplicaiton.BarButtonDel.ItemClick += new ItemClickEventHandler(this.BarButton_ItemClick);
            this.SystemApplicaiton.BarButtonExport.ItemClick += new ItemClickEventHandler(this.BarButton_ItemClick);
            this.SystemApplicaiton.BarButtonImport.ItemClick += new ItemClickEventHandler(this.BarButton_ItemClick);
            this.SystemApplicaiton.BarButtonQuery.ItemClick += new ItemClickEventHandler(this.BarButton_ItemClick);
            this.SystemApplicaiton.BarButtonUpdate.ItemClick += new ItemClickEventHandler(this.BarButton_ItemClick);
            this.SystemApplicaiton.BarButtonReport.ItemClick += new ItemClickEventHandler(this.BarButton_ItemClick);
            this.SystemApplicaiton.BarButtonClear.ItemClick += new ItemClickEventHandler(this.BarButton_ItemClick);
            this.SystemApplicaiton.BarButtonSave.ItemClick += new ItemClickEventHandler(this.BarButton_ItemClick);
            this.SystemApplicaiton.BarButtonStop.ItemClick += new ItemClickEventHandler(this.BarButtonStop_ItemClick);
        }

        private void MainTabManager_PageRemoved(object sender, EventArgs e)
        {
            if (this.SystemApplicaiton.MainTabManager.Pages.Count == 0)
            {
                this.SystemApplicaiton.BarButtonAdd.Enabled = false;
                this.SystemApplicaiton.BarButtonDel.Enabled = false;
                this.SystemApplicaiton.BarButtonQuery.Enabled = false;
                this.SystemApplicaiton.BarButtonUpdate.Enabled = false;
                this.SystemApplicaiton.BarButtonExport.Enabled = false;
                this.SystemApplicaiton.BarButtonImport.Enabled = false;
                this.SystemApplicaiton.BarButtonReport.Enabled = false;
                this.SystemApplicaiton.BarButtonStop.Enabled = false;
                this.SystemApplicaiton.BarButtonSave.Enabled = false;
                this.SystemApplicaiton.BarButtonClear.Enabled = false;
            }
            else
            {
                this.InitControl();
            }
        }

        private void MainTabManager_SelectedPageChanged(object sender, EventArgs e)
        {
            this.InitControl();
        }

        private void BarButtonStop_ItemClick(object sender, ItemClickEventArgs e)
        {
            DockBar dockBar = (DockBar)this.SystemApplicaiton.ActiveForm;
            dockBar.StopClick();
        }

        private void BarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            DockBar dockBar = (DockBar)this.SystemApplicaiton.ActiveForm;
            if (dockBar != null)
            {
                if (dockBar is IPlugin)
                {
                    IPlugin plugin = (IPlugin)dockBar;
                    string name = e.Item.Name;
                    switch (name)
                    {
                        case "barButtonAdd":
                            plugin.IsAddButton_Click();
                            break;
                        case "barButtonDel":
                            plugin.IsDelButton_Click();
                            break;
                        case "barButtonExport":
                            plugin.IsExportButton_Click();
                            break;
                        case "barButtonImport":
                            plugin.IsImportButton_Click();
                            break;
                        case "barButtonQuery":
                            plugin.IsQueryButton_Click();
                            break;
                        case "barButtonUpdate":
                            plugin.IsUpdateButton_Click();
                            break;
                        case "barButtonReport":
                            plugin.IsQueryButton_Click();
                            break;
                        case "barButtonSave":
                            plugin.IsSaveButton_Click();
                            break;
                        case "barButtonClear":
                            plugin.IsClearButton_Click();
                            break;
                    }
                }
            }
        }

        public void InitControl()
        {
            try
            {
                DockBar dockBar = (DockBar)this.SystemApplicaiton.ActiveForm;
                if (dockBar != null)
                {
                    this.SystemApplicaiton.BarItem_Spring.Caption = dockBar.BarSpring.Caption;
                    this.SystemApplicaiton.BarItem_Time.Caption = dockBar.BarItemTime.Caption;
                    MenuInfo menuInfo = null;
                    if (this.SystemApplicaiton.UserObject != null)
                    {
                        foreach (MenuInfo current in this.SystemApplicaiton.UserObject.MenuList)
                        {
                            if (current.ReflectType.Equals(dockBar.GetType().ToString()) &&
                                current.CnName.Equals(this.SystemApplicaiton.MainTabManager.SelectedPage.Text))
                            {
                                menuInfo = current;
                                break;
                            }
                        }
                    }
                    if (dockBar is IPlugin)
                    {
                        IPlugin plugin = (IPlugin)dockBar;
                        this.SystemApplicaiton.BarButtonAdd.Enabled = true;
                        this.SystemApplicaiton.BarButtonDel.Enabled = true;
                        this.SystemApplicaiton.BarButtonQuery.Enabled = false;
                        this.SystemApplicaiton.BarButtonUpdate.Enabled = true;
                        this.SystemApplicaiton.BarButtonExport.Enabled = false;
                        this.SystemApplicaiton.BarButtonImport.Enabled = false;
                        this.SystemApplicaiton.BarButtonReport.Enabled = false;
                        this.SystemApplicaiton.BarButtonSave.Enabled = false;
                        this.SystemApplicaiton.BarButtonClear.Enabled = false;
                        this.SystemApplicaiton.BarButtonStop.Enabled = false;
                        if (menuInfo != null && this.SystemApplicaiton.UserObject != null)
                        {
                            //找出用户组权限中 此菜单的操作权限   todo:此处需做进一步优化！！！！
                            var oList = from obj in this.SystemApplicaiton.UserObject.GroupPermissionList
                                        where obj.MenuID == menuInfo.Id
                                        select new
                                        {
                                            obj.MenuID,
                                            obj.OperationCode
                                        };
                            foreach (var obj in oList)
                            {
                                if (obj.OperationCode.Trim().Equals(MenuOperationEnum.Add.ToString()))
                                {
                                    this.SystemApplicaiton.BarButtonAdd.Enabled = plugin.IsAddButtonEnabeld;
                                    continue;
                                }
                                if (obj.OperationCode.Trim().Equals(MenuOperationEnum.Delete.ToString()))
                                {
                                    this.SystemApplicaiton.BarButtonDel.Enabled = plugin.IsDelButtonEnabeld;
                                    continue;
                                }
                                if (obj.OperationCode.Trim().Equals(MenuOperationEnum.Export.ToString()))
                                {
                                    this.SystemApplicaiton.BarButtonExport.Enabled = plugin.IsExportButtonEnabeld;
                                    continue;
                                }
                                if (obj.OperationCode.Trim().Equals(MenuOperationEnum.Import.ToString()))
                                {
                                    this.SystemApplicaiton.BarButtonImport.Enabled = plugin.IsImportButtonEnabeld;
                                    continue;
                                }
                                if (obj.OperationCode.Trim().Equals(MenuOperationEnum.Query.ToString()))
                                {
                                    this.SystemApplicaiton.BarButtonQuery.Enabled = plugin.IsQueryButtonEnabeld;
                                    continue;
                                }
                                if (obj.OperationCode.Trim().Equals(MenuOperationEnum.Update.ToString()))
                                {
                                    this.SystemApplicaiton.BarButtonUpdate.Enabled = plugin.IsUpdateButtonEnabeld;
                                    continue;
                                }
                                if (obj.OperationCode.Trim().Equals(MenuOperationEnum.Report.ToString()))
                                {
                                    this.SystemApplicaiton.BarButtonReport.Enabled = plugin.IsReportButtonEnabeld;
                                    continue;
                                }
                                if (obj.OperationCode.Trim().Equals(MenuOperationEnum.Save.ToString()))
                                {
                                    this.SystemApplicaiton.BarButtonSave.Enabled = plugin.IsSaveButtonEnabeld;
                                    continue;
                                }
                                if (obj.OperationCode.Trim().Equals(MenuOperationEnum.Clear.ToString()))
                                {
                                    this.SystemApplicaiton.BarButtonClear.Enabled = plugin.IsClearButtonEnabeld;
                                    continue;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
