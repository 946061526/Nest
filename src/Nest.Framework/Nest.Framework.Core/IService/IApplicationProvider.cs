using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nest.Framework.Core
{
    public interface IApplicationProvider
    {
        ISystemApplication SystemApplication { get; set; }

        bool StopLoad { get; set; }

        bool IsNowRun { get; set; }

        bool IsClickStopPostDataEvent { get; set; }

        string StatusState { get; set; }

        void ProgressBarInit();

        void ProgressBarSetMax(int Max);

        void ProgressBarSetPostion(int Pos);

        void ProgressBarEnd();

        void DoEvent();
    }
}
