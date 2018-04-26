using DevExpress.XtraEditors;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Nest.Framework.Core
{
    public class NewForm : XtraForm
    {
        protected delegate void DataOperation();

        private delegate void CloseOperation();

        protected delegate void SetDataSource(string MeansName);

        protected delegate void StopMeans(string MeansName);

        protected string WindowText = string.Empty;

        private Thread newThread = null;

        private DataOperation ExecuteMeans = null;

        protected bool IsNowRun = false;

        private string _TabText = string.Empty;

        private bool _CloseButton = true;

        public string TabText
        {
            get
            {
                return this._TabText;
            }
            set
            {
                this._TabText = value;
                this.Text = value;
            }
        }

        public bool CloseButton
        {
            get
            {
                return this._CloseButton;
            }
            set
            {
                this._CloseButton = value;
            }
        }

        public ISystemApplication SystemApplication
        {
            get;
            set;
        }

        protected virtual void Stop(string MeansName)
        {
            this.AbortThread();
        }

        protected virtual void SetControl(string MeansName)
        {
        }

        protected void GetDataSource(DataOperation pExecuteMeans)
        {
            this.IsNowRun = true;
            this.ExecuteMeans = pExecuteMeans;
            this.newThread = this.ThreadCreate(new ThreadStart(this.RunGetData), true, "NewThread");
        }

        private void RunGetData()
        {
            this.ExecuteMeans();
            if (base.InvokeRequired)
            {
                NewForm.CloseOperation method = new NewForm.CloseOperation(this.AbortThread);
                base.Invoke(method);
            }
            else
            {
                this.AbortThread();
            }
        }

        private void AbortThread()
        {
            try
            {
                NewForm.SetDataSource method = new NewForm.SetDataSource(this.SetControl);
                base.Invoke(method, new object[]
                {
                    this.ExecuteMeans.Method.Name.ToString()
                });
                this.newThread.Abort();
            }
            catch (Exception ex)
            {
                throw new Exception("NewForm.AbortThread：" + ex.Message);
            }
            finally
            {
                this.IsNowRun = false;
            }
        }

        private Thread ThreadCreate(ThreadStart Function, bool IsStart, string Name)
        {
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

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!this.CloseButton)
            {
                e.Cancel = true;
            }
            base.OnFormClosing(e);
        }

        protected override void Dispose(bool disposing)
        {
            if (base.Parent != null && base.Parent.Parent != null && base.Parent.Parent is DevExpress.XtraBars.Docking.DockPanel)
            {
                ((DevExpress.XtraBars.Docking.DockPanel)base.Parent.Parent).Close();
            }
            base.Dispose(disposing);
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
        }

        private void InitializeComponent()
        {
            base.SuspendLayout();
            base.ClientSize = new Size(292, 266);
            base.FormBorderStyle = FormBorderStyle.None;
            base.Name = "NewForm";
            base.ResumeLayout(false);
        }
    }
}
