using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KP2v
{
    class ProcessScheduler
    {
        public BindingList<Process> FirstLine { get; private set; }
        public BindingList<Process> SecondLine { get; private set; }
        public Processor Processor { get; private set; }
        int FirstListProcessingTime;
        int lastId;
        public ProcessScheduler(ListBox listBoxFirstLine, ListBox listBoxSecondLine, ListBox listBoxLogs, int firstListProcessingTime)
        {
            Processor = new Processor();
            FirstLine = new BindingList<Process>();
            SecondLine = new BindingList<Process>();
            FirstListProcessingTime = firstListProcessingTime;
            lastId = -1;

            listBoxFirstLine.DataSource = FirstLine;
            listBoxFirstLine.DisplayMember = "String";
            listBoxFirstLine.ValueMember = "Id";
            listBoxSecondLine.DataSource = SecondLine;
            listBoxSecondLine.DisplayMember = "String";
            listBoxSecondLine.ValueMember = "Id";
        }
        public void AddNewProcess(string name, int totalTime, int stepTime)
        {
            lastId++;
            FirstLine.Add(new Process(lastId, name, totalTime, stepTime));
        }
        public void StartProcessor()
        {

        }

        void RefreshAllProcessesView()
        {
            //listBoxAllProcessesList.Invoke(new Action(() => listBoxAllProcessesList.Items.Clear()));
            //foreach (Process process in QueuingGrid[listsTime[0]])
            //{
            //    listBoxAllProcessesList.Invoke(new Action(() => listBoxAllProcessesList.Items.Add($"{process.Name} {process.StepTime} {process.TotalTime}")));
            //}
        }
    }
}
