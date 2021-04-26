using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            processScheduler.AddNewProcess(new Process("1 процесс", 300, 30));
            processScheduler.AddNewProcess(new Process("2 процесс", 600, 50));
            processScheduler.AddNewProcess(new Process("3 процесс", 500, 20));
            processScheduler.AddNewProcess(new Process("4 процесс", 200, 40));
            processScheduler.StartProcessor();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            processScheduler.StartProcessor();
        }
    }
}
