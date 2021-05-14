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
            processScheduler = new ProcessScheduler(listBoxFirstLine, listBoxSecondLine, listBoxLogs, 10);
            processScheduler.AddNewProcess("1 процесс", 40, 9);
            processScheduler.AddNewProcess("2 процесс", 63, 15);
            processScheduler.AddNewProcess("3 процесс", 66, 10);
            processScheduler.AddNewProcess("4 процесс", 50, 11);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            listBoxLogs.Items.Clear();
            new Thread(new ThreadStart(processScheduler.StartProcessor)).Start();
        }
    }
}
