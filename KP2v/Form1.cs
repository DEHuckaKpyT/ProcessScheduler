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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            processScheduler = new ProcessScheduler(listBoxFirstLine, listBoxSecondLine, listBoxLogs, 5);
            processScheduler.AddNewProcess("1 процесс", 3000, 300);
            processScheduler.AddNewProcess("2 процесс", 5000, 500);
            processScheduler.AddNewProcess("3 процесс", 4000, 200);
            processScheduler.AddNewProcess("4 процесс", 2000, 400);
            listBoxFirstLine.Refresh();
            listBoxFirstLine.Update();
            //new Thread(new ThreadStart(processScheduler.StartProcessor)).Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxLogs.Items.Clear();
            new Thread(new ThreadStart(processScheduler.StartProcessor)).Start();
        }

        private void buttonAddNewProcess_Click(object sender, EventArgs e)
        {
            processScheduler.AddNewProcess(textBoxNameProcess.Text, int.Parse(textBoxTotalTime.Text), int.Parse(textBoxStepTime.Text));
        }
    }
}
