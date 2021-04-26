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
        ManualResetEvent manEvent;

        public int SetProcess(Process process)
        {
            Process = process;
            Thread.Sleep(process.StepTime);

            return process.StepTime;
        }
    }
}
