namespace TimeManagementAssistant
{
    partial class MainForm
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
            this.textBox_process = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_time = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_audio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_process
            // 
            this.textBox_process.Location = new System.Drawing.Point(158, 58);
            this.textBox_process.Multiline = true;
            this.textBox_process.Name = "textBox_process";
            this.textBox_process.Size = new System.Drawing.Size(236, 16);
            this.textBox_process.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Link of process ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Time delay(min)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 484);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_time
            // 
            this.textBox_time.Location = new System.Drawing.Point(158, 133);
            this.textBox_time.Name = "textBox_time";
            this.textBox_time.Size = new System.Drawing.Size(236, 20);
            this.textBox_time.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "link at audioFile";
            // 
            // textBox_audio
            // 
            this.textBox_audio.Location = new System.Drawing.Point(158, 218);
            this.textBox_audio.Name = "textBox_audio";
            this.textBox_audio.Size = new System.Drawing.Size(236, 20);
            this.textBox_audio.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(588, 621);
            this.Controls.Add(this.textBox_audio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_time);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_process);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "TimeManagementAssistant";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_process;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_time;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_audio;
    }
}

