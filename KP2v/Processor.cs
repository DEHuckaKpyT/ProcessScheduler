using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KP2v
{
    class Processor
    {
        public Process Process { get; private set; }
        public int SpeedRunning { get; set; }

        public int SetProcess(Process process)
        {
            Process = process;
            int timeToSleep = process.StepTime < process.TotalTime ? process.StepTime : process.TotalTime;
            Thread.Sleep(timeToSleep * SpeedRunning);

            return timeToSleep;
        }
    }
}
