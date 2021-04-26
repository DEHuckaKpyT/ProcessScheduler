using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP2v
{
    class Process
    {
        public string Name { get; private set; }
        public int TotalTime { get; set; }
        public int StepTime { get; private set; }

        public Process(string name, int totalTime, int stepTime)
        {
            Name = name;
            TotalTime = totalTime;
            StepTime = stepTime;
        }
    }
}
