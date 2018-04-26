using System;
using System.Windows.Forms;
using Nest.Framework.Core;

namespace Nest.Framework.Test.UI
{
    public partial class Test1 : DockBar, IPlugin
    {
        public Test1()
        {
            InitializeComponent();
        }

        private bool addIsEnable = true;
        private bool delIsEnable = true;
        private bool updIsEnable = true;
        public bool IsAddButtonEnabeld
        {
            get { return addIsEnable; }
        }

        public bool IsUpdateButtonEnabeld
        {
            get { return updIsEnable; }
        }
        public bool IsQueryButtonEnabeld
        {
            get { return false; }
        }
        public bool IsDelButtonEnabeld
        {
            get { return delIsEnable; }
        }
        public bool IsImportButtonEnabeld
        {
            get { return false; }
        }
        public bool IsExportButtonEnabeld
        {
            get { return false; }
        }
        public bool IsReportButtonEnabeld
        {
            get { return false; }
        }
        public bool IsSaveButtonEnabeld
        {
            get { return false; }
        }
        public bool IsClearButtonEnabeld
        {
            get { return false; }
        }
        public void Close_Form()
        {
            throw new NotImplementedException();
        }

        public void IsAddButton_Click()
        {
            Test1_1 t = new Test1_1();
            t.ShowDialog(this);
        }

        public void IsClearButton_Click()
        {
            //throw new NotImplementedException();
        }

        public void IsDelButton_Click()
        {
            //throw new NotImplementedException();
            MessageBox.Show("del");
        }

        public void IsExportButton_Click()
        {
            //throw new NotImplementedException();
        }

        public void IsImportButton_Click()
        {
            //throw new NotImplementedException();
        }

        public void IsQueryButton_Click()
        {
            //throw new NotImplementedException();
        }

        public void IsReportButton_Click()
        {
            //throw new NotImplementedException();
        }

        public void IsSaveButton_Click()
        {
            //throw new NotImplementedException();
        }

        public void IsUpdateButton_Click()
        {
            // throw new NotImplementedException();
            MessageBox.Show("edit");
        }

        IDockBarService dockService;
        public void Load_Form()
        {
            dockService = (IDockBarService)this.SystemApplication.GetService(typeof(IDockBarService));
            dockService.AddDockBar(this);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
