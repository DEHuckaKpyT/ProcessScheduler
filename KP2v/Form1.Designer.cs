
namespace KP2v
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxLogs = new System.Windows.Forms.ListBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.listBoxFirstLine = new System.Windows.Forms.ListBox();
            this.listBoxSecondLine = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonBlockProcess = new System.Windows.Forms.Button();
            this.listBoxAllProcesses = new System.Windows.Forms.ListBox();
            this.listBoxDoneProcesses = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listBoxBlockedProcesses = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonAddRandomProcess = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelTrack = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxLogs
            // 
            this.listBoxLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxLogs.FormattingEnabled = true;
            this.listBoxLogs.ItemHeight = 20;
            this.listBoxLogs.Location = new System.Drawing.Point(864, 108);
            this.listBoxLogs.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxLogs.Name = "listBoxLogs";
            this.listBoxLogs.Size = new System.Drawing.Size(610, 564);
            this.listBoxLogs.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.IndianRed;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(1345, 1);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(129, 36);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // listBoxFirstLine
            // 
            this.listBoxFirstLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxFirstLine.FormattingEnabled = true;
            this.listBoxFirstLine.ItemHeight = 20;
            this.listBoxFirstLine.Location = new System.Drawing.Point(444, 32);
            this.listBoxFirstLine.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxFirstLine.Name = "listBoxFirstLine";
            this.listBoxFirstLine.Size = new System.Drawing.Size(416, 204);
            this.listBoxFirstLine.TabIndex = 2;
            this.listBoxFirstLine.SelectedIndexChanged += new System.EventHandler(this.listBoxCantSelect_SelectedIndexChanged);
            // 
            // listBoxSecondLine
            // 
            this.listBoxSecondLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxSecondLine.FormattingEnabled = true;
            this.listBoxSecondLine.ItemHeight = 20;
            this.listBoxSecondLine.Location = new System.Drawing.Point(444, 259);
            this.listBoxSecondLine.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxSecondLine.Name = "listBoxSecondLine";
            this.listBoxSecondLine.Size = new System.Drawing.Size(416, 204);
            this.listBoxSecondLine.TabIndex = 7;
            this.listBoxSecondLine.SelectedIndexChanged += new System.EventHandler(this.listBoxCantSelect_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(439, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Первая очередь";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(439, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Вторая очередь";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(859, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Журнал событий";
            // 
            // buttonBlockProcess
            // 
            this.buttonBlockProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBlockProcess.Location = new System.Drawing.Point(157, 14);
            this.buttonBlockProcess.Name = "buttonBlockProcess";
            this.buttonBlockProcess.Size = new System.Drawing.Size(265, 31);
            this.buttonBlockProcess.TabIndex = 11;
            this.buttonBlockProcess.Text = "Заблокировать/разблокировать";
            this.buttonBlockProcess.UseVisualStyleBackColor = true;
            this.buttonBlockProcess.Click += new System.EventHandler(this.buttonBlockProcess_Click);
            // 
            // listBoxAllProcesses
            // 
            this.listBoxAllProcesses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxAllProcesses.FormattingEnabled = true;
            this.listBoxAllProcesses.ItemHeight = 20;
            this.listBoxAllProcesses.Location = new System.Drawing.Point(6, 49);
            this.listBoxAllProcesses.Name = "listBoxAllProcesses";
            this.listBoxAllProcesses.Size = new System.Drawing.Size(416, 184);
            this.listBoxAllProcesses.TabIndex = 12;
            this.listBoxAllProcesses.SelectedIndexChanged += new System.EventHandler(this.listBoxAllProcesses_SelectedIndexChanged);
            // 
            // listBoxDoneProcesses
            // 
            this.listBoxDoneProcesses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxDoneProcesses.FormattingEnabled = true;
            this.listBoxDoneProcesses.ItemHeight = 20;
            this.listBoxDoneProcesses.Location = new System.Drawing.Point(18, 490);
            this.listBoxDoneProcesses.Name = "listBoxDoneProcesses";
            this.listBoxDoneProcesses.Size = new System.Drawing.Size(416, 184);
            this.listBoxDoneProcesses.TabIndex = 13;
            this.listBoxDoneProcesses.SelectedIndexChanged += new System.EventHandler(this.listBoxCantSelect_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(1394, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(62, 26);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "10";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1193, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Длительность кванта = ";
            // 
            // listBoxResult
            // 
            this.listBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.ItemHeight = 20;
            this.listBoxResult.Location = new System.Drawing.Point(444, 490);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(415, 184);
            this.listBoxResult.TabIndex = 16;
            this.listBoxResult.SelectedIndexChanged += new System.EventHandler(this.listBoxCantSelect_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(1, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 26);
            this.label5.TabIndex = 17;
            this.label5.Text = "Все процессы";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(13, 461);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(261, 26);
            this.label6.TabIndex = 18;
            this.label6.Text = "Выполненные процессы";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.listBoxBlockedProcesses);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.buttonBlockProcess);
            this.groupBox1.Controls.Add(this.listBoxAllProcesses);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 452);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Блокирование процессов";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(304, 26);
            this.label7.TabIndex = 19;
            this.label7.Text = "Заблокированные процессы";
            // 
            // listBoxBlockedProcesses
            // 
            this.listBoxBlockedProcesses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxBlockedProcesses.FormattingEnabled = true;
            this.listBoxBlockedProcesses.ItemHeight = 20;
            this.listBoxBlockedProcesses.Location = new System.Drawing.Point(6, 260);
            this.listBoxBlockedProcesses.Name = "listBoxBlockedProcesses";
            this.listBoxBlockedProcesses.Size = new System.Drawing.Size(416, 184);
            this.listBoxBlockedProcesses.TabIndex = 18;
            this.listBoxBlockedProcesses.SelectedIndexChanged += new System.EventHandler(this.listBoxBlockedProcesses_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(439, 463);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 26);
            this.label8.TabIndex = 20;
            this.label8.Text = "Результат";
            // 
            // buttonAddRandomProcess
            // 
            this.buttonAddRandomProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddRandomProcess.Location = new System.Drawing.Point(618, 0);
            this.buttonAddRandomProcess.Name = "buttonAddRandomProcess";
            this.buttonAddRandomProcess.Size = new System.Drawing.Size(242, 31);
            this.buttonAddRandomProcess.TabIndex = 21;
            this.buttonAddRandomProcess.Text = "Добавить случайный процесс";
            this.buttonAddRandomProcess.UseVisualStyleBackColor = true;
            this.buttonAddRandomProcess.Click += new System.EventHandler(this.buttonAddRandomProcess_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(875, 33);
            this.trackBar1.Maximum = 1000;
            this.trackBar1.Minimum = 10;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(401, 45);
            this.trackBar1.SmallChange = 10;
            this.trackBar1.TabIndex = 22;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(872, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "x10";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1240, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "x1000";
            // 
            // labelTrack
            // 
            this.labelTrack.AutoSize = true;
            this.labelTrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTrack.Location = new System.Drawing.Point(1056, 63);
            this.labelTrack.Name = "labelTrack";
            this.labelTrack.Size = new System.Drawing.Size(59, 26);
            this.labelTrack.TabIndex = 25;
            this.labelTrack.Text = "x100";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(866, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(239, 26);
            this.label11.TabIndex = 26;
            this.label11.Text = "Скорость выполнения";
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.IndianRed;
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStop.Location = new System.Drawing.Point(1345, 36);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(63, 36);
            this.buttonStop.TabIndex = 27;
            this.buttonStop.Text = "Стоп";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.BackColor = System.Drawing.Color.IndianRed;
            this.buttonPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPause.Location = new System.Drawing.Point(1412, 36);
            this.buttonPause.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(62, 36);
            this.buttonPause.TabIndex = 28;
            this.buttonPause.Text = "Пауза";
            this.buttonPause.UseVisualStyleBackColor = false;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 683);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.labelTrack);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.buttonAddRandomProcess);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxFirstLine);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBoxDoneProcesses);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxSecondLine);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.listBoxLogs);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Планировщик процессов";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxLogs;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ListBox listBoxFirstLine;
        private System.Windows.Forms.ListBox listBoxSecondLine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonBlockProcess;
        private System.Windows.Forms.ListBox listBoxAllProcesses;
        private System.Windows.Forms.ListBox listBoxDoneProcesses;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxBlockedProcesses;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonAddRandomProcess;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelTrack;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonPause;
    }
}

