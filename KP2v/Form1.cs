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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            doneProcesses = new BindingList<Process>();
            processScheduler = new ProcessScheduler(listBoxAllProcesses, listBoxFirstLine, listBoxSecondLine, listBoxLogs, listBoxDoneProcesses,
                int.Parse(textBox1.Text), doneProcesses);
            allProcesses = new List<Process>();
            allProcesses.Add(processScheduler.AddNewProcess("Случ число", 40, 9, ResultRandomNumber));
            allProcesses.Add(processScheduler.AddNewProcess("Эл-т последовательности", 63, 15, ResultElements));
            allProcesses.Add(processScheduler.AddNewProcess("Текущая дата", 66, 10, ResultDate));
            allProcesses.Add(processScheduler.AddNewProcess("Случ число", 50, 11, ResultRandomNumber));
            UpdateListBoxAllProcesses();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            listBoxLogs.Items.Clear();
            new Thread(new ThreadStart(processScheduler.StartProcessor)).Start();
        }

        private void buttonBlockProcess_Click(object sender, EventArgs e)
        {
            if (listBoxAllProcesses.SelectedItem == null) return;
            Process process = (Process)listBoxAllProcesses.SelectedItem;
            process.Status = process.Status == ProcessStatus.Blocked ? ProcessStatus.InLine : ProcessStatus.Blocked;
            processScheduler.UpdateListBoxes();
        }

        void UpdateListBoxAllProcesses()
        {
            listBoxAllProcesses.Invoke(new Action(() => listBoxAllProcesses.DataSource = null));
            listBoxAllProcesses.Invoke(new Action(() => listBoxAllProcesses.DataSource = allProcesses));
            listBoxAllProcesses.Invoke(new Action(() => listBoxAllProcesses.DisplayMember = "Name"));
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
    }
}
