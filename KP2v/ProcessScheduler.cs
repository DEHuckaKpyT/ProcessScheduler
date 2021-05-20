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
        ListBox listBoxAllProcesses, listBoxDoneProcesses, listBoxLogs, listBoxFirstLine, listBoxSecondLine;
        BindingList<Process> doneProcesses;
        public ProcessScheduler(ListBox listBoxAllProcesses, ListBox listBoxFirstLine, ListBox listBoxSecondLine, ListBox listBoxLogs, ListBox listBoxDoneProcesses,
            int firstListProcessingTime, BindingList<Process> doneProcesses)
        {
            Processor = new Processor();
            FirstLine = new BindingList<Process>();
            SecondLine = new BindingList<Process>();
            this.listBoxLogs = listBoxLogs;
            this.listBoxFirstLine = listBoxFirstLine;
            this.listBoxSecondLine = listBoxSecondLine;
            this.listBoxAllProcesses = listBoxAllProcesses;
            this.listBoxDoneProcesses = listBoxDoneProcesses;
            this.doneProcesses = doneProcesses;
            FirstListProcessingTime = firstListProcessingTime;
            lastId = -1;
            UpdateListBoxes();
        }
        public Process AddNewProcess(string name, int totalTime, int stepTime, Action action)
        {
            lastId++;
            Process process = new Process(lastId, name, totalTime, stepTime, action);
            FirstLine.Add(process);
            return process;
        }
        public void StartProcessor()
        {
            while (SecondLine.Count > 0 || FirstLine.Count > 0)
            {
                while (FirstLine.Count(x => x.Status != ProcessStatus.Blocked) > 0)
                {
                    for (int i = 0; i < FirstLine.Count; i++)
                    {
                        if (FirstLine[i].Status != ProcessStatus.Blocked)
                        {
                            Process process = FirstLine[i];
                            WriteLog($"Выполняется \"{process.Name}\"");
                            process.Status = ProcessStatus.Running;
                            UpdateListBoxes();
                            int timeRunning = Processor.SetProcess(process);
                            process.TotalTime -= timeRunning;
                            WriteLog($"\"{process.Name}\" вытеснился через {timeRunning} mc");
                            if (process.TotalTime == 0)
                            {
                                FirstLine.Remove(process);
                                process.Result();
                                doneProcesses.Add(process);
                                UpdateListBoxDonelProcesses();
                            }
                            if (process.StepTime > FirstListProcessingTime)
                            {
                                SecondLine.Add(process);
                                FirstLine.Remove(process);
                                WriteLog($"Процесс \"{process.Name}\" перемещён во вторую очередь");
                                i--;
                            }
                            if (process.Status != ProcessStatus.Blocked)
                                process.Status = ProcessStatus.InLine;
                            UpdateListBoxes();
                        }
                    }
                }
                for (int i = 0; i < SecondLine.Count; i++)
                {
                    if (SecondLine[i].Status != ProcessStatus.Blocked)
                    {
                        Process process = SecondLine[i];
                        WriteLog($"Выполняется \"{process.Name}\"");
                        process.Status = ProcessStatus.Running;
                        UpdateListBoxes();
                        int timeRunning = Processor.SetProcess(process);
                        process.TotalTime -= timeRunning;
                        WriteLog($"\"{process.Name}\" вытеснился через {timeRunning} mc");
                        if (process.TotalTime == 0)
                        {
                            SecondLine.Remove(process);
                            process.Result();
                            doneProcesses.Add(process);
                            UpdateListBoxDonelProcesses();
                        }
                        if (process.Status != ProcessStatus.Blocked)
                            process.Status = ProcessStatus.InLine;
                        UpdateListBoxes();
                    }
                }
            }
        }
        public void UpdateListBoxes()
        {
            listBoxFirstLine.Invoke(new Action(() => listBoxFirstLine.DataSource = null));
            listBoxFirstLine.Invoke(new Action(() => listBoxFirstLine.DataSource = FirstLine));
            listBoxFirstLine.Invoke(new Action(() => listBoxFirstLine.DisplayMember = "String"));
            listBoxFirstLine.Invoke(new Action(() => listBoxFirstLine.ValueMember = "Id"));
            listBoxFirstLine.Invoke(new Action(() => listBoxFirstLine.SelectedItem = null));
            listBoxSecondLine.Invoke(new Action(() => listBoxSecondLine.DataSource = null));
            listBoxSecondLine.Invoke(new Action(() => listBoxSecondLine.DataSource = SecondLine));
            listBoxSecondLine.Invoke(new Action(() => listBoxSecondLine.DisplayMember = "String"));
            listBoxSecondLine.Invoke(new Action(() => listBoxSecondLine.ValueMember = "Id"));
            listBoxSecondLine.Invoke(new Action(() => listBoxSecondLine.SelectedItem = null));
        }
        void UpdateListBoxDonelProcesses()
        {
            listBoxDoneProcesses.Invoke(new Action(() => listBoxDoneProcesses.DataSource = null));
            listBoxDoneProcesses.Invoke(new Action(() => listBoxDoneProcesses.DataSource = doneProcesses));
            listBoxDoneProcesses.Invoke(new Action(() => listBoxDoneProcesses.DisplayMember = "Name"));
            listBoxDoneProcesses.Invoke(new Action(() => listBoxDoneProcesses.ValueMember = "Id"));
            listBoxDoneProcesses.Invoke(new Action(() => listBoxDoneProcesses.SelectedItem = null));
        }
        void WriteLog(string str)
        {
            listBoxLogs.Invoke(new Action(() => listBoxLogs.Items.Add(str)));
            listBoxLogs.Invoke(new Action(() => listBoxLogs.SelectedIndex = listBoxLogs.Items.Count - 1));
        }
    }
}
