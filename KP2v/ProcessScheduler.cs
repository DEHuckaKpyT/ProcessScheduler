using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KP2v
{
    class ProcessScheduler
    {
        public Dictionary<int, List<Process>> QueuingGrid { get; private set; }
        public Processor Processor { get; private set; }
        int[] listsTime;
        ListBox listBox;
        public ProcessScheduler(ListBox listBox, params int[] listsTime)
        {
            Processor = new Processor();
            this.listBox = listBox;
            this.listsTime = listsTime;
            QueuingGrid = new Dictionary<int, List<Process>>(listsTime.Length);
            for (int i = 0; i < listsTime.Length; i++)
                QueuingGrid[listsTime[i]] = new List<Process>();
        }
        public void AddNewProcess(Process process)
        {
            QueuingGrid[QueuingGrid.Keys.First()].Add(process);
        }

        public void StartProcessor()
        {
            int j = 0;
            while (j<10)
            {
                foreach (var i in QueuingGrid[listsTime[0]])
                {
                    i.TotalTime -= Processor.SetProcess(i);
                    listBox.Items.Add($"{i.Name} {i.StepTime} {i.TotalTime}");
                }
                j++;

            }



        }




    }
}
