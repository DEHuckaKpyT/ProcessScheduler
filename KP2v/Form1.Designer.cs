
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
            this.textBoxNameProcess = new System.Windows.Forms.TextBox();
            this.textBoxTotalTime = new System.Windows.Forms.TextBox();
            this.textBoxStepTime = new System.Windows.Forms.TextBox();
            this.buttonAddNesProcess = new System.Windows.Forms.Button();
            this.listBoxSecondLine = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxLogs
            // 
            this.listBoxLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxLogs.FormattingEnabled = true;
            this.listBoxLogs.ItemHeight = 20;
            this.listBoxLogs.Location = new System.Drawing.Point(676, 125);
            this.listBoxLogs.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxLogs.Name = "listBoxLogs";
            this.listBoxLogs.Size = new System.Drawing.Size(318, 524);
            this.listBoxLogs.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(999, 73);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(113, 34);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Запустить";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // listBoxFirstLine
            // 
            this.listBoxFirstLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxFirstLine.FormattingEnabled = true;
            this.listBoxFirstLine.ItemHeight = 20;
            this.listBoxFirstLine.Location = new System.Drawing.Point(23, 73);
            this.listBoxFirstLine.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxFirstLine.Name = "listBoxFirstLine";
            this.listBoxFirstLine.Size = new System.Drawing.Size(259, 464);
            this.listBoxFirstLine.TabIndex = 2;
            // 
            // textBoxNameProcess
            // 
            this.textBoxNameProcess.Location = new System.Drawing.Point(9, 18);
            this.textBoxNameProcess.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNameProcess.Name = "textBoxNameProcess";
            this.textBoxNameProcess.Size = new System.Drawing.Size(62, 20);
            this.textBoxNameProcess.TabIndex = 3;
            this.textBoxNameProcess.Text = "Название";
            // 
            // textBoxTotalTime
            // 
            this.textBoxTotalTime.Location = new System.Drawing.Point(86, 18);
            this.textBoxTotalTime.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTotalTime.Name = "textBoxTotalTime";
            this.textBoxTotalTime.Size = new System.Drawing.Size(75, 20);
            this.textBoxTotalTime.TabIndex = 4;
            this.textBoxTotalTime.Text = "Общее время";
            // 
            // textBoxStepTime
            // 
            this.textBoxStepTime.Location = new System.Drawing.Point(175, 18);
            this.textBoxStepTime.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStepTime.Name = "textBoxStepTime";
            this.textBoxStepTime.Size = new System.Drawing.Size(77, 20);
            this.textBoxStepTime.TabIndex = 5;
            this.textBoxStepTime.Text = "время кванта";
            // 
            // buttonAddNesProcess
            // 
            this.buttonAddNesProcess.Location = new System.Drawing.Point(266, 18);
            this.buttonAddNesProcess.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddNesProcess.Name = "buttonAddNesProcess";
            this.buttonAddNesProcess.Size = new System.Drawing.Size(152, 19);
            this.buttonAddNesProcess.TabIndex = 6;
            this.buttonAddNesProcess.Text = "Добавить процесс";
            this.buttonAddNesProcess.UseVisualStyleBackColor = true;
            this.buttonAddNesProcess.Click += new System.EventHandler(this.buttonAddNewProcess_Click);
            // 
            // listBoxSecondLine
            // 
            this.listBoxSecondLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxSecondLine.FormattingEnabled = true;
            this.listBoxSecondLine.ItemHeight = 20;
            this.listBoxSecondLine.Location = new System.Drawing.Point(286, 73);
            this.listBoxSecondLine.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxSecondLine.Name = "listBoxSecondLine";
            this.listBoxSecondLine.Size = new System.Drawing.Size(259, 464);
            this.listBoxSecondLine.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 698);
            this.Controls.Add(this.listBoxSecondLine);
            this.Controls.Add(this.buttonAddNesProcess);
            this.Controls.Add(this.textBoxStepTime);
            this.Controls.Add(this.textBoxTotalTime);
            this.Controls.Add(this.textBoxNameProcess);
            this.Controls.Add(this.listBoxFirstLine);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.listBoxLogs);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxLogs;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ListBox listBoxFirstLine;
        private System.Windows.Forms.TextBox textBoxNameProcess;
        private System.Windows.Forms.TextBox textBoxTotalTime;
        private System.Windows.Forms.TextBox textBoxStepTime;
        private System.Windows.Forms.Button buttonAddNesProcess;
        private System.Windows.Forms.ListBox listBoxSecondLine;
    }
}

