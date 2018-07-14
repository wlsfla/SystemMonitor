namespace SystemMonitor
{
    partial class ProcessWatch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.메뉴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.음원선택ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.탐색프로세스설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvProcess = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.메뉴ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(472, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 메뉴ToolStripMenuItem
            // 
            this.메뉴ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.음원선택ToolStripMenuItem,
            this.탐색프로세스설정ToolStripMenuItem});
            this.메뉴ToolStripMenuItem.Name = "메뉴ToolStripMenuItem";
            this.메뉴ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.메뉴ToolStripMenuItem.Text = "메뉴";
            // 
            // 음원선택ToolStripMenuItem
            // 
            this.음원선택ToolStripMenuItem.Name = "음원선택ToolStripMenuItem";
            this.음원선택ToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.음원선택ToolStripMenuItem.Text = "음원 선택";
            // 
            // 탐색프로세스설정ToolStripMenuItem
            // 
            this.탐색프로세스설정ToolStripMenuItem.Name = "탐색프로세스설정ToolStripMenuItem";
            this.탐색프로세스설정ToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.탐색프로세스설정ToolStripMenuItem.Text = "탐색 프로세스 설정";
            this.탐색프로세스설정ToolStripMenuItem.Click += new System.EventHandler(this.탐색프로세스설정ToolStripMenuItem_Click);
            // 
            // lvProcess
            // 
            this.lvProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvProcess.Location = new System.Drawing.Point(0, 28);
            this.lvProcess.Name = "lvProcess";
            this.lvProcess.Size = new System.Drawing.Size(472, 364);
            this.lvProcess.TabIndex = 1;
            this.lvProcess.UseCompatibleStateImageBehavior = false;
            // 
            // ProcessWatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 392);
            this.Controls.Add(this.lvProcess);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProcessWatch";
            this.Text = "ProcessWatch";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 메뉴ToolStripMenuItem;
        private System.Windows.Forms.ListView lvProcess;
        private System.Windows.Forms.ToolStripMenuItem 음원선택ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 탐색프로세스설정ToolStripMenuItem;
    }
}