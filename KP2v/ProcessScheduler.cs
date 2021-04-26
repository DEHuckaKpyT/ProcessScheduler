using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KP2v
{
    class ProcessScheduler
    {
        public Dictionary<int, List<Process>> QueuingGrid { get; private set; }
        public Processor Processor { get; private set; }
        int[] listsTime;
        ListBox listBoxProcessesList, listBoxAllProcessesList;
        public ProcessScheduler(ListBox listBoxProcessesList, ListBox listBoxAllProcessesList, params int[] listsTime)
        {
            Processor = new Processor();
            this.listBoxProcessesList = listBoxProcessesList;
            this.listBoxAllProcessesList = listBoxAllProcessesList;
            this.listsTime = listsTime;
            QueuingGrid = new Dictionary<int, List<Process>>(listsTime.Length);
            for (int i = 0; i < listsTime.Length; i++)
                QueuingGrid[listsTime[i]] = new List<Process>();
        }
        public void AddNewProcess(Process process)
        {
            QueuingGrid[QueuingGrid.Keys.First()].Add(process);
            listBoxAllProcessesList.Items.Add($"{process.Name} {process.StepTime} {process.TotalTime}");
        }
        public void StartProcessor()
        {
            while (QueuingGrid[listsTime[0]].Count>0)
            {
                List<Process> tempProcessList = new List<Process>(QueuingGrid[listsTime[0]]);
                foreach (var process in tempProcessList)
                {
                    process.TotalTime -= Processor.SetProcess(process);
                    listBoxProcessesList.Invoke(new Action(() => listBoxProcessesList.Items.Add($"{process.Name} {process.StepTime} {process.TotalTime}")));
                    if (process.TotalTime <= 0) QueuingGrid[listsTime[0]].Remove(process);
                }
                RefreshAllProcessesView();
            }
        }

        void RefreshAllProcessesView()
        {
            listBoxAllProcessesList.Invoke(new Action(() => listBoxAllProcessesList.Items.Clear()));
            foreach (Process process in QueuingGrid[listsTime[0]])
            {
                listBoxAllProcessesList.Invoke(new Action(() => listBoxAllProcessesList.Items.Add($"{process.Name} {process.StepTime} {process.TotalTime}")));
            }
        }
    }
}
