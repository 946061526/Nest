using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraTabbedMdi;
using Nest.Framework.SysManage;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Windows.Forms;

namespace Nest.Framework.Core
{
    public interface ISystemApplication : IServiceContainer, IServiceProvider
    {
        //object[] ObjectInfo { get; set; }

        Dictionary<string, object> Objects { get; set; }

        string Status { get; set; }

        UserObject UserObject { get; set; }

        MenuInfo MenuInfo { get; set; }

        BarButtonItem BarButtonAdd { get; }

        BarButtonItem BarButtonDel { get; }

        BarButtonItem BarButtonExport { get; }

        BarButtonItem BarButtonImport { get; }

        BarButtonItem BarButtonQuery { get; }

        BarButtonItem BarButtonUpdate { get; }

        BarButtonItem BarButtonStop { get; }

        BarButtonItem BarButtonReport { get; }

        BarButtonItem BarButtonSave { get; }

        BarButtonItem BarButtonClear { get; }

        BarStaticItem BarItem_Time { get; }

        BarStaticItem BarItem_Spring { get; }

        XtraTabbedMdiManager MainTabManager { get; }

        string StatusState { get; set; }

        DockManager MainDockManager { get; }

        Form MainFrom { get; }

        Form ActiveForm { get; set; }

        ConnectionType ConnectionType { get; set; }

        string ConnnectKey { get; set; }

        void ProgressBarInit();

        void ProgressBarSetMax(int Max);

        void ProgressBarSetPostion(int Pos);

        void ProgressBarEnd();

        void DoEvent();

        void Wait();

        void BreackWait();
    }
}
