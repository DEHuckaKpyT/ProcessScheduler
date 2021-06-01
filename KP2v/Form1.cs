using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KP2v
{
    public partial class Form1 : Form
    {
        ProcessScheduler processScheduler;
        List<Process> allProcesses;
        BindingList<Process> doneProcesses;
        Random random = new Random();
        int processNumber = 0;
        Thread threadRunning;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            doneProcesses = new BindingList<Process>();
            processScheduler = new ProcessScheduler(listBoxAllProcesses, listBoxFirstLine, 
                listBoxSecondLine, listBoxLogs, listBoxDoneProcesses, listBoxBlockedProcesses,
                int.Parse(textBox1.Text), doneProcesses);
            processScheduler.Processor.SpeedRunning = 100;
            allProcesses = new List<Process>();

            StopRunning();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            //listBoxLogs.Items.Clear();
            if (threadRunning == null || threadRunning.ThreadState == ThreadState.Aborted)
            {
                threadRunning = new Thread(new ThreadStart(processScheduler.StartProcessor));
                threadRunning.Start();
            }
            if (threadRunning.ThreadState == ThreadState.Suspended)
                threadRunning.Resume();
            //StopRunning();
        }

        private void buttonBlockProcess_Click(object sender, EventArgs e)
        {
            if (listBoxAllProcesses.SelectedItem != null)
            {
                Process process = (Process)listBoxAllProcesses.SelectedItem;
                processScheduler.BlockOrUnblockProcess(process);
            }
            if (listBoxBlockedProcesses.SelectedItem != null)
            {
                Process process = (Process)listBoxBlockedProcesses.SelectedItem;
                processScheduler.BlockOrUnblockProcess(process);
            }
            processScheduler.UpdateListBoxes();
        }

        void UpdateListBoxAllProcesses()
        {
            listBoxAllProcesses.Invoke(new Action(() => listBoxAllProcesses.DataSource = null));
            listBoxAllProcesses.Invoke(new Action(() => listBoxAllProcesses.DataSource = allProcesses));
            listBoxAllProcesses.Invoke(new Action(() => listBoxAllProcesses.DisplayMember = "String"));
            listBoxAllProcesses.Invoke(new Action(() => listBoxAllProcesses.ValueMember = "Id"));
            processScheduler.UpdateListBoxes();
        }
        void ResultRandomNumber()
        {
            listBoxResult.Invoke(new Action(() => listBoxResult.Items.Add("Случайное число = " + new Random().Next(100))));
        }
        void ResultElements()
        {
            double xPrev = new Random().Next(100) / 100.0;
            double xCur = Math.Sin(xPrev);
            int n = new Random().Next(5);
            for (int i = 0; i< n; i++)
            {
                xCur = Math.Sin(xPrev);
                xPrev = xCur;
            }
            listBoxResult.Invoke(new Action(() => listBoxResult.Items.Add(n +"-й элемент последовательности = " + xCur)));
        }
        void ResultDate()
        {
            listBoxResult.Invoke(new Action(() => listBoxResult.Items.Add("Дата = " + DateTime.Now)));
        }
        private void listBoxCantSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            ((ListBox)sender).SelectedItem = null;
        }

        private void listBoxAllProcesses_SelectedIndexChanged(object sender, EventArgs e)
        {
            Process process = (Process)listBoxAllProcesses.SelectedItem;
            listBoxBlockedProcesses.SelectedItem = null;
            listBoxAllProcesses.SelectedItem = process;
        }

        private void listBoxBlockedProcesses_SelectedIndexChanged(object sender, EventArgs e)
        {
            Process process = (Process)listBoxBlockedProcesses.SelectedItem;
            listBoxAllProcesses.SelectedItem = null;
            listBoxBlockedProcesses.SelectedItem = process;
        }

        private void buttonAddRandomProcess_Click(object sender, EventArgs e)
        {
            AddRandProcess();
        }
        Action GetRandAction()
        {
            switch (random.Next(3))
            {
                case 0:
                    return ResultRandomNumber;
                case 1:
                    return ResultElements;
                case 2:
                    return ResultDate;
            }
            return null;
        }
        void AddRandProcess()
        {
            processNumber++;
            allProcesses.Add(processScheduler.AddNewProcess(processNumber.ToString() + ".Случайный", 
                random.Next(10, 100), random.Next(5, 16), GetRandAction()));
            //UpdateListBoxAllProcesses();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            labelTrack.Text = "x" + trackBar1.Value.ToString();
            processScheduler.Processor.SpeedRunning = 10000 / trackBar1.Value;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            StopRunning();
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            if (threadRunning != null && (threadRunning.ThreadState == ThreadState.Running || threadRunning.ThreadState == ThreadState.WaitSleepJoin))
                threadRunning.Suspend();
        }
        void StopRunning()
        {
            listBoxLogs.Items.Clear();
            allProcesses.Clear();
            processScheduler.AllProcesses.Clear();
            processNumber = 0;
            processScheduler.FirstLine.Clear();
            processScheduler.SecondLine.Clear();
            if (threadRunning != null)
            {
                if (threadRunning.ThreadState == ThreadState.Suspended) threadRunning.Resume();
                threadRunning.Abort();
            }
            int r = random.Next(1, 9);
            for (int i = 0; i < r; i++)
                AddRandProcess();
        }
    }
}
