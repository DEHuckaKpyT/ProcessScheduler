using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP2v
{
    class Process
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int TotalTime { get; set; }
        public int StepTime { get; private set; }
        ProcessStatus status;
        public ProcessStatus Status { 
            get { return status; } 
            set 
            {
                status = value;
                UpdateString();
            } 
        }
        public string String { get; private set; }

        public Process(int id, string name, int totalTime, int stepTime)
        {
            Id = id;
            Name = name;
            TotalTime = totalTime;
            StepTime = stepTime;
            Status = ProcessStatus.InLine;
        }
        void UpdateString()
        {
            String = $"{Name} {StepTime} {TotalTime} {Status}";
        }
    }
}
