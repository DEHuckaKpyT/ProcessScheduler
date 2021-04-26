
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
            this.listBoxProcessesList = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxAllProcessesList = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxProcessesList
            // 
            this.listBoxProcessesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxProcessesList.FormattingEnabled = true;
            this.listBoxProcessesList.ItemHeight = 25;
            this.listBoxProcessesList.Location = new System.Drawing.Point(563, 47);
            this.listBoxProcessesList.Name = "listBoxProcessesList";
            this.listBoxProcessesList.Size = new System.Drawing.Size(422, 654);
            this.listBoxProcessesList.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(991, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Запустить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxAllProcessesList
            // 
            this.listBoxAllProcessesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxAllProcessesList.FormattingEnabled = true;
            this.listBoxAllProcessesList.ItemHeight = 25;
            this.listBoxAllProcessesList.Location = new System.Drawing.Point(12, 65);
            this.listBoxAllProcessesList.Name = "listBoxAllProcessesList";
            this.listBoxAllProcessesList.Size = new System.Drawing.Size(344, 579);
            this.listBoxAllProcessesList.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(82, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Название";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(115, 22);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(99, 22);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Общее время";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(233, 22);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(101, 22);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "время кванта";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(355, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Добавить процесс";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 736);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBoxAllProcessesList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxProcessesList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProcessesList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxAllProcessesList;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
    }
}

