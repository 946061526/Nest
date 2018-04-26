using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Nest.Main
{
    static class Program
    {
        public static MainApp MainApp = null;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Process instance = RunningIntance();

            if (instance == null)
            {
                try
                {
                    DevExpress.Skins.SkinManager.EnableFormSkins();
                    DevExpress.Skins.SkinManager.EnableMdiFormSkins();
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    DevExpress.XtraGrid.Localization.GridLocalizer.Active = new Framework.DevLocalizationCHS.DxperienceXtraGridLocalizationCHS();
                    DevExpress.XtraEditors.Controls.Localizer.Active = new Framework.DevLocalizationCHS.DxperienceXtraEditorsLocalizationCHS();
                    //Application.Run(new frmLogin());
                    Application.Run(new MainApp());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                HandleRunningInstance(instance);
            }
        }
        /// <summary>
        /// 关闭整个系统
        /// </summary>
        public static void KillProcess()
        {
            Program.MainApp.Dispose();
            Process currentProcess = Process.GetCurrentProcess();
            currentProcess.Kill();
        }

        #region 检测是否有本系统在运行
        private static Process RunningIntance()
        {
            Process currentProcess = Process.GetCurrentProcess();
            Process[] processCollection = Process.GetProcessesByName(currentProcess.ProcessName);
            foreach (Process p in processCollection)
            {
                if (p.Id != currentProcess.Id)
                {  //检查ID是否相同
                    return currentProcess;
                }
            }
            return null;
        }

        private static void HandleRunningInstance(Process instance)
        {
            MessageBox.Show("对不起，本系统已经打开，不允许重复打开！！！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}
