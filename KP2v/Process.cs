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
        int totalTime;
        public int TotalTime
        {
            get { return totalTime; }
            set
            {
                totalTime = value < 0 ? 0 : value;
                UpdateString();
            }
        }
        public int StepTime { get; private set; }
        ProcessStatus status;
        public ProcessStatus Status
        {
            get { return status; }
            set
            {
                status = value;
                UpdateString();
            }
        }
        public string String { get; private set; }
        public Action Result { get; private set; }

        public Process(int id, string name, int totalTime, int stepTime, Action action)
        {
            Id = id;
            Name = name;
            TotalTime = totalTime;
            StepTime = stepTime;
            Status = ProcessStatus.InLine;
            Result = action;
        }
        void UpdateString()
        {
            String = $"{Name} {StepTime} {TotalTime} {Status}";
        }
    }
}
