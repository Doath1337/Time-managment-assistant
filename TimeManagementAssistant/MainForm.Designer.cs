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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textBox_process = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_time = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_audio = new System.Windows.Forms.TextBox();
            this.contextMenuStrip7 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fAQToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.developerRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.fAQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.developerRelationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telegramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip7.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_process
            // 
            this.textBox_process.Location = new System.Drawing.Point(100, 88);
            this.textBox_process.Multiline = true;
            this.textBox_process.Name = "textBox_process";
            this.textBox_process.Size = new System.Drawing.Size(236, 16);
            this.textBox_process.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Link of process ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Time delay(min)";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(100, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "enter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_time
            // 
            this.textBox_time.Location = new System.Drawing.Point(100, 155);
            this.textBox_time.Name = "textBox_time";
            this.textBox_time.Size = new System.Drawing.Size(236, 20);
            this.textBox_time.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "link at audioFile";
            // 
            // textBox_audio
            // 
            this.textBox_audio.Location = new System.Drawing.Point(100, 219);
            this.textBox_audio.Name = "textBox_audio";
            this.textBox_audio.Size = new System.Drawing.Size(236, 20);
            this.textBox_audio.TabIndex = 7;
            // 
            // contextMenuStrip7
            // 
            this.contextMenuStrip7.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fAQToolStripMenuItem2,
            this.developerRToolStripMenuItem});
            this.contextMenuStrip7.Name = "contextMenuStrip7";
            this.contextMenuStrip7.Size = new System.Drawing.Size(176, 48);
            // 
            // fAQToolStripMenuItem2
            // 
            this.fAQToolStripMenuItem2.Name = "fAQToolStripMenuItem2";
            this.fAQToolStripMenuItem2.Size = new System.Drawing.Size(175, 22);
            this.fAQToolStripMenuItem2.Text = "FAQ";
            // 
            // developerRToolStripMenuItem
            // 
            this.developerRToolStripMenuItem.Name = "developerRToolStripMenuItem";
            this.developerRToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.developerRToolStripMenuItem.Text = "Developer relations";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(431, 25);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fAQToolStripMenuItem,
            this.developerRelationToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // fAQToolStripMenuItem
            // 
            this.fAQToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fAQToolStripMenuItem.Image")));
            this.fAQToolStripMenuItem.Name = "fAQToolStripMenuItem";
            this.fAQToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fAQToolStripMenuItem.Text = "FAQ";
            this.fAQToolStripMenuItem.Click += new System.EventHandler(this.fAQToolStripMenuItem_Click_1);
            // 
            // developerRelationToolStripMenuItem
            // 
            this.developerRelationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.telegramToolStripMenuItem,
            this.vKToolStripMenuItem,
            this.mailToolStripMenuItem});
            this.developerRelationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("developerRelationToolStripMenuItem.Image")));
            this.developerRelationToolStripMenuItem.Name = "developerRelationToolStripMenuItem";
            this.developerRelationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.developerRelationToolStripMenuItem.Text = "Developer relation";
            // 
            // telegramToolStripMenuItem
            // 
            this.telegramToolStripMenuItem.Name = "telegramToolStripMenuItem";
            this.telegramToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.telegramToolStripMenuItem.Text = "Telegram";
            this.telegramToolStripMenuItem.Click += new System.EventHandler(this.telegramToolStripMenuItem_Click);
            // 
            // vKToolStripMenuItem
            // 
            this.vKToolStripMenuItem.Name = "vKToolStripMenuItem";
            this.vKToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vKToolStripMenuItem.Text = "VK";
            this.vKToolStripMenuItem.Click += new System.EventHandler(this.vKToolStripMenuItem_Click);
            // 
            // mailToolStripMenuItem
            // 
            this.mailToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.mailToolStripMenuItem.Name = "mailToolStripMenuItem";
            this.mailToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mailToolStripMenuItem.Text = "Mail";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(431, 589);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.textBox_audio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_time);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_process);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimeManagementAssistant";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.contextMenuStrip7.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip7;
        private System.Windows.Forms.ToolStripMenuItem fAQToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem developerRToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem fAQToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem developerRelationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telegramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
    }
}

