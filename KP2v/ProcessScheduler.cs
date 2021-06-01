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
        ListBox listBoxAllProcesses, listBoxDoneProcesses, listBoxLogs, listBoxFirstLine, listBoxSecondLine, listBoxBlockedProcesses;
        BindingList<Process> doneProcesses;
        BindingList<Process> blockedProcesses;
        public BindingList<Process> AllProcesses { get; set; }
        public ProcessScheduler(ListBox listBoxAllProcesses, ListBox listBoxFirstLine, 
            ListBox listBoxSecondLine, ListBox listBoxLogs, ListBox listBoxDoneProcesses,
            ListBox listBoxBlockedProcesses,
            int firstListProcessingTime, BindingList<Process> doneProcesses)
        {
            Processor = new Processor();
            FirstLine = new BindingList<Process>();
            SecondLine = new BindingList<Process>();
            blockedProcesses = new BindingList<Process>();
            AllProcesses = new BindingList<Process>();
            this.listBoxLogs = listBoxLogs;
            this.listBoxFirstLine = listBoxFirstLine;
            this.listBoxSecondLine = listBoxSecondLine;
            this.listBoxAllProcesses = listBoxAllProcesses;
            this.listBoxDoneProcesses = listBoxDoneProcesses;
            this.doneProcesses = doneProcesses;
            this.listBoxBlockedProcesses = listBoxBlockedProcesses;
            FirstListProcessingTime = firstListProcessingTime;
            lastId = -1;
            UpdateListBoxes();
        }
        public Process AddNewProcess(string name, int totalTime, int stepTime, Action action)
        {
            lastId++;
            Process process = new Process(lastId, name, totalTime, stepTime, action);
            FirstLine.Add(process);
            AllProcesses.Add(process);
            return process;
        }
        public void BlockOrUnblockProcess(Process process)
        {
            if (process.Status == ProcessStatus.InLine || process.Status == ProcessStatus.Running)
            {
                if (FirstLine.Contains(process))
                {
                    FirstLine.Remove(process);
                    blockedProcesses.Add(process);
                    process.Status = ProcessStatus.Blocked;
                }
                if (SecondLine.Contains(process))
                {
                    SecondLine.Remove(process);
                    blockedProcesses.Add(process);
                    process.Status = ProcessStatus.Blocked;
                }
            }
            else if (process.Status == ProcessStatus.Blocked)
            {
                blockedProcesses.Remove(process);
                FirstLine.Add(process);
                process.Status = ProcessStatus.InLine;
            }
            UpdateListBoxes();
            UpdateListBoxBlokedProcesses();
        }
        public void StartProcessor()
        {
            while (true) 
            {
                while (FirstLine.Count > 0)
                {

                    Process process = FirstLine[0];
                    WriteLog($"Выполняется \"{process.Name}\"");
                    process.Status = ProcessStatus.Running;
                    UpdateListBoxes();
                    int timeRunning = Processor.SetProcess(process);
                    process.TotalTime -= timeRunning;
                    WriteLog($"\"{process.Name}\" вытеснился через {timeRunning} mc");
                    if (process.TotalTime == 0)
                    {
                        process.Status = ProcessStatus.Done;
                        FirstLine.Remove(process);
                        process.Result();
                        doneProcesses.Add(process);
                        UpdateListBoxDonelProcesses();
                    }
                    else
                    {
                        FirstLine.Remove(process);
                        if (process.Status != ProcessStatus.Blocked)
                            FirstLine.Add(process);
                    }
                    if (process.StepTime > FirstListProcessingTime)
                    {
                        SecondLine.Add(process);
                        FirstLine.Remove(process);
                        WriteLog($"\"{process.Name}\" перемещён во вторую очередь");
                    }
                    if (process.Status != ProcessStatus.Blocked && process.Status != ProcessStatus.Done)
                        process.Status = ProcessStatus.InLine;
                    UpdateListBoxes();
                }
                while (SecondLine.Count>0 && FirstLine.Count == 0)
                {
                    if (FirstLine.Count > 0) break;
                    if (SecondLine[0].Status != ProcessStatus.Blocked)
                    {
                        Process process = SecondLine[0];
                        WriteLog($"Выполняется \"{process.Name}\"");
                        process.Status = ProcessStatus.Running;
                        UpdateListBoxes();
                        int timeRunning = Processor.SetProcess(process);
                        process.TotalTime -= timeRunning;
                        WriteLog($"\"{process.Name}\" вытеснился через {timeRunning} mc");
                        if (process.TotalTime == 0)
                        {
                            SecondLine.Remove(process);
                            process.Status = ProcessStatus.Done;
                            process.Result();
                            doneProcesses.Add(process);
                            UpdateListBoxDonelProcesses();
                        }
                        else
                        {
                            SecondLine.Remove(process);
                            SecondLine.Add(process);
                        }
                        if (process.Status != ProcessStatus.Blocked && process.Status != ProcessStatus.Done)
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
            UpdateListBoxAllProcesses();
        }
        void UpdateListBoxAllProcesses()
        {
            listBoxAllProcesses.Invoke(new Action(() => listBoxAllProcesses.DataSource = null));
            listBoxAllProcesses.Invoke(new Action(() => listBoxAllProcesses.DataSource = AllProcesses));
            listBoxAllProcesses.Invoke(new Action(() => listBoxAllProcesses.DisplayMember = "String"));
            listBoxAllProcesses.Invoke(new Action(() => listBoxAllProcesses.ValueMember = "Id"));
            listBoxAllProcesses.Invoke(new Action(() => listBoxAllProcesses.SelectedItem = null));
        }
        void UpdateListBoxDonelProcesses()
        {
            listBoxDoneProcesses.Invoke(new Action(() => listBoxDoneProcesses.DataSource = null));
            listBoxDoneProcesses.Invoke(new Action(() => listBoxDoneProcesses.DataSource = doneProcesses));
            listBoxDoneProcesses.Invoke(new Action(() => listBoxDoneProcesses.DisplayMember = "Name"));
            listBoxDoneProcesses.Invoke(new Action(() => listBoxDoneProcesses.ValueMember = "Id"));
            listBoxDoneProcesses.Invoke(new Action(() => listBoxDoneProcesses.SelectedItem = null));
        }
        void UpdateListBoxBlokedProcesses()
        {
            listBoxBlockedProcesses.Invoke(new Action(() => listBoxBlockedProcesses.DataSource = null));
            listBoxBlockedProcesses.Invoke(new Action(() => listBoxBlockedProcesses.DataSource = blockedProcesses));
            listBoxBlockedProcesses.Invoke(new Action(() => listBoxBlockedProcesses.DisplayMember = "String"));
            listBoxBlockedProcesses.Invoke(new Action(() => listBoxBlockedProcesses.ValueMember = "Id"));
            listBoxBlockedProcesses.Invoke(new Action(() => listBoxBlockedProcesses.SelectedItem = null));
        }
        void WriteLog(string str)
        {
            listBoxLogs.Invoke(new Action(() => listBoxLogs.Items.Add(str)));
            listBoxLogs.Invoke(new Action(() => listBoxLogs.SelectedIndex = listBoxLogs.Items.Count - 1));
        }
    }
}
