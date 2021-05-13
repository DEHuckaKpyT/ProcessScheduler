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
            processScheduler = new ProcessScheduler(listBoxFirstLine, listBoxSecondLine, listBoxLogs, 4);
            processScheduler.AddNewProcess("1 процесс", 10, 3);
            processScheduler.AddNewProcess("2 процесс", 20, 5);
            //processScheduler.AddNewProcess("3 процесс", 40, 2);
            //processScheduler.AddNewProcess("4 процесс", 20, 4);
            //new Thread(new ThreadStart(processScheduler.StartProcessor)).Start();
        }

        private void buttonStart_Click(object sender, EventArgs e)
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
