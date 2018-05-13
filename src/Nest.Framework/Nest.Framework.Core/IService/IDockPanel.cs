using DevExpress.XtraBars.Docking;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Nest.Framework.Core
{
    public abstract class IDockPanel
    {
        private ISystemApplication _SystemApplication = null;

        protected Dictionary<string, NewForm> dockBars = new Dictionary<string, NewForm>();

        public IDockPanel(ISystemApplication pSystemApplication)
        {
            this._SystemApplication = pSystemApplication;
        }

        protected void AddDocuments(string dockBarName, NewForm dockBar)
        {
            dockBar.SystemApplication = this._SystemApplication;
            this.dockBars.Add(dockBarName, dockBar);
            dockBar.MdiParent = this._SystemApplication.MainFrom;
            dockBar.FormClosing += new FormClosingEventHandler(this.dockBar_FormClosing);
            dockBar.Show();
        }

        private void dockBar_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.dockBars.Remove(((DockBar)sender).Name);
        }

        protected DockPanel AddDockPanel(string dockBarName, NewForm dockBar, DockingStyle dockingStyle)
        {
            DockPanel dockPanel = this.QueryDockPanel(dockingStyle);
            DockPanel dockPanel2 = this._SystemApplication.MainDockManager.AddPanel(dockingStyle);
            //dockPanel2.ClosedPanel += new DockPanelEventHandler(this.ClosingPanel);
            dockPanel2.ClosingPanel += this.ClosingPanel;
            dockBar.TopLevel = false;
            dockBar.SystemApplication = this._SystemApplication;
            dockBar.Dock = DockStyle.Fill;
            dockPanel2.Text = dockBar.Text;
            dockPanel2.Width = 180;
            dockPanel2.Name = dockBar.Name;
            dockPanel2.ControlContainer.Controls.Add(dockBar);
            dockBar.Show();
            if (dockPanel != null)
            {
                dockPanel2.DockAsTab(dockPanel, 0);
            }
            return dockPanel2;
        }

        protected DockPanel AddDockPanel(string dockBarName, NewForm dockBar)
        {
            DockPanel dockPanel = this._SystemApplication.MainDockManager.AddPanel(0);
            //dockPanel.add_ClosingPanel(new DockPanelCancelEventHandler(this.ClosingPanel));
            dockPanel.ClosingPanel += ClosingPanel;
            dockBar.TopLevel = false;
            dockBar.SystemApplication = this._SystemApplication;
            dockBar.Dock = DockStyle.Fill;
            dockPanel.Text = dockBar.Text;
            dockBar.Show();
            dockPanel.ControlContainer.Controls.Add(dockBar);
            dockPanel.Focus();
            return dockPanel;
        }

        protected void ClosingPanel(object sender, DockPanelCancelEventArgs e)
        {
            DockPanel dockPanel = (DockPanel)sender;
            foreach (Control control in dockPanel.ControlContainer.Controls)
            {
                if (control is NewForm)
                {
                    NewForm newForm = control as NewForm;
                    if (!newForm.CloseButton)
                    {
                        e.Cancel = true;
                        return;
                    }
                    this.dockBars.Remove(newForm.Name);
                }
            }
            dockPanel.Dispose();
        }

        protected DockPanel QueryDockPanel(DockingStyle dockState)
        {
            DockPanel result;
            for (int i = 0; i < this._SystemApplication.MainDockManager.Panels.Count; i++)
            {
                if (this._SystemApplication.MainDockManager.Panels[i].Dock == dockState)
                {
                    result = this._SystemApplication.MainDockManager.Panels[i];
                    return result;
                }
            }
            return null;
        }
    }
}

