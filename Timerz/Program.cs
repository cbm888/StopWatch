using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace Timerz {
    class Program {
        static void Main(string[] args) {
            Watch watch = new Watch();
            watch.StartTime();
            watch.StopTime();
        }
    }
}
