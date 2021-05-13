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
        ListBox listBoxLogs, listBoxFirstLine, listBoxSecondLine;
        public ProcessScheduler(ListBox listBoxFirstLine, ListBox listBoxSecondLine, ListBox listBoxLogs, int firstListProcessingTime)
        {
            Processor = new Processor();
            FirstLine = new BindingList<Process>();
            SecondLine = new BindingList<Process>();
            this.listBoxLogs = listBoxLogs;
            this.listBoxFirstLine = listBoxFirstLine;
            this.listBoxSecondLine = listBoxSecondLine;
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
            while (SecondLine.Count > 0 || FirstLine.Count > 0)
            {
                while (FirstLine.Count > 0)
                {
                    for (int i = 0; i < FirstLine.Count; i++)
                    {
                        Process process = FirstLine[i];
                        listBoxLogs.Invoke(new Action(() => listBoxLogs.Items.Add($"Выполняется {process.Name}")));
                        process.TotalTime -= Processor.SetProcess(process);
                        listBoxLogs.Invoke(new Action(() => listBoxLogs.Items.Add($"{process.Name} вытеснился через {process.StepTime} mc")));
                        if (process.TotalTime == 0) FirstLine.Remove(process);
                        if (process.StepTime > FirstListProcessingTime)
                        {
                            SecondLine.Add(process);
                            FirstLine.Remove(process);
                            listBoxLogs.Invoke(new Action(() => listBoxLogs.Items.Add($"Процесс {process.Name} перемещён во вторую очередь")));
                            i--;
                        }
                        listBoxFirstLine.Invoke(new Action(() => listBoxFirstLine.DataSource = null));
                        listBoxFirstLine.Invoke(new Action(() => listBoxFirstLine.DataSource = FirstLine));
                        listBoxFirstLine.Invoke(new Action(() => listBoxFirstLine.DisplayMember = "String"));
                        listBoxFirstLine.Invoke(new Action(() => listBoxFirstLine.ValueMember = "Id"));
                    }
                }
                for (int i = 0; i < SecondLine.Count; i++)
                {
                    Process process = SecondLine[i];
                    listBoxLogs.Invoke(new Action(() => listBoxLogs.Items.Add($"Выполняется {process.Name}")));
                    process.TotalTime -= Processor.SetProcess(process);
                    listBoxLogs.Invoke(new Action(() => listBoxLogs.Items.Add($"{process.Name} вытеснился через {process.StepTime} mc")));
                    if (process.TotalTime == 0) SecondLine.Remove(process);
                }
                listBoxSecondLine.Invoke(new Action(() => listBoxSecondLine.DataSource = null));
                listBoxSecondLine.Invoke(new Action(() => listBoxSecondLine.DataSource = SecondLine));
                listBoxSecondLine.Invoke(new Action(() => listBoxSecondLine.DisplayMember = "String"));
                listBoxSecondLine.Invoke(new Action(() => listBoxSecondLine.ValueMember = "Id"));
            }
        }
    }
}
