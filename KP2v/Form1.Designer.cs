
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
            this.SuspendLayout();
            // 
            // listBoxLogs
            // 
            this.listBoxLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxLogs.FormattingEnabled = true;
            this.listBoxLogs.ItemHeight = 20;
            this.listBoxLogs.Location = new System.Drawing.Point(848, 47);
            this.listBoxLogs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxLogs.Name = "listBoxLogs";
            this.listBoxLogs.Size = new System.Drawing.Size(610, 624);
            this.listBoxLogs.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.IndianRed;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(1345, 3);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(113, 36);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Запустить";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // listBoxFirstLine
            // 
            this.listBoxFirstLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxFirstLine.FormattingEnabled = true;
            this.listBoxFirstLine.ItemHeight = 20;
            this.listBoxFirstLine.Location = new System.Drawing.Point(7, 258);
            this.listBoxFirstLine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxFirstLine.Name = "listBoxFirstLine";
            this.listBoxFirstLine.Size = new System.Drawing.Size(416, 204);
            this.listBoxFirstLine.TabIndex = 2;
            // 
            // listBoxSecondLine
            // 
            this.listBoxSecondLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxSecondLine.FormattingEnabled = true;
            this.listBoxSecondLine.ItemHeight = 20;
            this.listBoxSecondLine.Location = new System.Drawing.Point(427, 258);
            this.listBoxSecondLine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxSecondLine.Name = "listBoxSecondLine";
            this.listBoxSecondLine.Size = new System.Drawing.Size(416, 204);
            this.listBoxSecondLine.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(2, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Первая очередь";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(422, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Вторая очередь";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(843, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Журнал событий";
            // 
            // buttonBlockProcess
            // 
            this.buttonBlockProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBlockProcess.Location = new System.Drawing.Point(158, 5);
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
            this.listBoxAllProcesses.Location = new System.Drawing.Point(7, 40);
            this.listBoxAllProcesses.Name = "listBoxAllProcesses";
            this.listBoxAllProcesses.Size = new System.Drawing.Size(416, 184);
            this.listBoxAllProcesses.TabIndex = 12;
            // 
            // listBoxDoneProcesses
            // 
            this.listBoxDoneProcesses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxDoneProcesses.FormattingEnabled = true;
            this.listBoxDoneProcesses.ItemHeight = 20;
            this.listBoxDoneProcesses.Location = new System.Drawing.Point(427, 40);
            this.listBoxDoneProcesses.Name = "listBoxDoneProcesses";
            this.listBoxDoneProcesses.Size = new System.Drawing.Size(416, 184);
            this.listBoxDoneProcesses.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(1278, 8);
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
            this.label4.Location = new System.Drawing.Point(1077, 11);
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
            this.listBoxResult.Location = new System.Drawing.Point(12, 467);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(831, 204);
            this.listBoxResult.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(2, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 26);
            this.label5.TabIndex = 17;
            this.label5.Text = "Все процессы";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(422, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(261, 26);
            this.label6.TabIndex = 18;
            this.label6.Text = "Выполненные процессы";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 683);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBoxDoneProcesses);
            this.Controls.Add(this.listBoxAllProcesses);
            this.Controls.Add(this.buttonBlockProcess);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxSecondLine);
            this.Controls.Add(this.listBoxFirstLine);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.listBoxLogs);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Планировщик процессов";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

