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
            processScheduler = new ProcessScheduler(listBox1, 5, 6, 8);
            processScheduler.AddNewProcess(new Process("1 процесс", 3000, 300));
            processScheduler.AddNewProcess(new Process("2 процесс", 5000, 500));
            processScheduler.AddNewProcess(new Process("3 процесс", 4000, 200));
            processScheduler.AddNewProcess(new Process("4 процесс", 2000, 400));
            new Thread(new ThreadStart(processScheduler.StartProcessor)).Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            new Thread(new ThreadStart(processScheduler.StartProcessor)).Start();
        }
    }
}
