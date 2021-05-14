
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
            this.SuspendLayout();
            // 
            // listBoxLogs
            // 
            this.listBoxLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxLogs.FormattingEnabled = true;
            this.listBoxLogs.ItemHeight = 20;
            this.listBoxLogs.Location = new System.Drawing.Point(306, 45);
            this.listBoxLogs.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxLogs.Name = "listBoxLogs";
            this.listBoxLogs.Size = new System.Drawing.Size(520, 464);
            this.listBoxLogs.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(713, 9);
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
            this.listBoxFirstLine.Location = new System.Drawing.Point(15, 45);
            this.listBoxFirstLine.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxFirstLine.Name = "listBoxFirstLine";
            this.listBoxFirstLine.Size = new System.Drawing.Size(259, 204);
            this.listBoxFirstLine.TabIndex = 2;
            // 
            // listBoxSecondLine
            // 
            this.listBoxSecondLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxSecondLine.FormattingEnabled = true;
            this.listBoxSecondLine.ItemHeight = 20;
            this.listBoxSecondLine.Location = new System.Drawing.Point(15, 295);
            this.listBoxSecondLine.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxSecondLine.Name = "listBoxSecondLine";
            this.listBoxSecondLine.Size = new System.Drawing.Size(259, 204);
            this.listBoxSecondLine.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Первая очередь";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Вторая очередь";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(301, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Журнал событий";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 516);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxSecondLine);
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
        private System.Windows.Forms.ListBox listBoxSecondLine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

