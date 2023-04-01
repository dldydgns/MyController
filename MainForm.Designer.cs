namespace MyController
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pannelStatusBar = new System.Windows.Forms.Panel();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.pannelBackground = new System.Windows.Forms.Panel();
            this.pannelChildForm = new System.Windows.Forms.Panel();
            this.pannelMenuBar = new System.Windows.Forms.Panel();
            this.btnMenu_Games = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Tray_Icon = new System.Windows.Forms.NotifyIcon(this.components);
            this.Context_TrayIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pannelStatusBar.SuspendLayout();
            this.pannelBackground.SuspendLayout();
            this.pannelMenuBar.SuspendLayout();
            this.Context_TrayIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // pannelStatusBar
            // 
            this.pannelStatusBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.pannelStatusBar.Controls.Add(this.btnCloseForm);
            this.pannelStatusBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pannelStatusBar.Location = new System.Drawing.Point(0, 0);
            this.pannelStatusBar.Margin = new System.Windows.Forms.Padding(0);
            this.pannelStatusBar.Name = "pannelStatusBar";
            this.pannelStatusBar.Size = new System.Drawing.Size(700, 15);
            this.pannelStatusBar.TabIndex = 1;
            this.pannelStatusBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pannelStatusBar_MouseDown);
            this.pannelStatusBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pannelStatusBar_MouseMove);
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCloseForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCloseForm.FlatAppearance.BorderSize = 0;
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm.Font = new System.Drawing.Font("굴림", 7F);
            this.btnCloseForm.Location = new System.Drawing.Point(680, 0);
            this.btnCloseForm.Margin = new System.Windows.Forms.Padding(0);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(20, 15);
            this.btnCloseForm.TabIndex = 0;
            this.btnCloseForm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCloseForm.UseVisualStyleBackColor = false;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // pannelBackground
            // 
            this.pannelBackground.Controls.Add(this.pannelChildForm);
            this.pannelBackground.Controls.Add(this.pannelMenuBar);
            this.pannelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pannelBackground.Location = new System.Drawing.Point(0, 15);
            this.pannelBackground.Name = "pannelBackground";
            this.pannelBackground.Size = new System.Drawing.Size(700, 385);
            this.pannelBackground.TabIndex = 2;
            // 
            // pannelChildForm
            // 
            this.pannelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pannelChildForm.Location = new System.Drawing.Point(150, 0);
            this.pannelChildForm.Name = "pannelChildForm";
            this.pannelChildForm.Size = new System.Drawing.Size(550, 385);
            this.pannelChildForm.TabIndex = 2;
            // 
            // pannelMenuBar
            // 
            this.pannelMenuBar.AutoScroll = true;
            this.pannelMenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.pannelMenuBar.Controls.Add(this.btnMenu_Games);
            this.pannelMenuBar.Controls.Add(this.panel4);
            this.pannelMenuBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pannelMenuBar.Location = new System.Drawing.Point(0, 0);
            this.pannelMenuBar.Margin = new System.Windows.Forms.Padding(0);
            this.pannelMenuBar.Name = "pannelMenuBar";
            this.pannelMenuBar.Size = new System.Drawing.Size(150, 385);
            this.pannelMenuBar.TabIndex = 1;
            // 
            // btnMenu_Games
            // 
            this.btnMenu_Games.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu_Games.FlatAppearance.BorderSize = 0;
            this.btnMenu_Games.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu_Games.Font = new System.Drawing.Font("Snap ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu_Games.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMenu_Games.Location = new System.Drawing.Point(0, 60);
            this.btnMenu_Games.Name = "btnMenu_Games";
            this.btnMenu_Games.Size = new System.Drawing.Size(150, 40);
            this.btnMenu_Games.TabIndex = 1;
            this.btnMenu_Games.Text = "Games";
            this.btnMenu_Games.UseVisualStyleBackColor = true;
            this.btnMenu_Games.Click += new System.EventHandler(this.btnMenu_Games_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(150, 60);
            this.panel4.TabIndex = 0;
            // 
            // Tray_Icon
            // 
            this.Tray_Icon.Icon = ((System.Drawing.Icon)(resources.GetObject("Tray_Icon.Icon")));
            this.Tray_Icon.Text = "notifyIcon1";
            this.Tray_Icon.Visible = true;
            this.Tray_Icon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Tray_Icon_MouseDoubleClick);
            // 
            // Context_TrayIcon
            // 
            this.Context_TrayIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.Context_TrayIcon.Name = "Context_TrayIcon";
            this.Context_TrayIcon.Size = new System.Drawing.Size(181, 70);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.pannelBackground);
            this.Controls.Add(this.pannelStatusBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pannelStatusBar.ResumeLayout(false);
            this.pannelBackground.ResumeLayout(false);
            this.pannelMenuBar.ResumeLayout(false);
            this.Context_TrayIcon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pannelStatusBar;
        private System.Windows.Forms.Panel pannelBackground;
        private System.Windows.Forms.Panel pannelMenuBar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.NotifyIcon Tray_Icon;
        private System.Windows.Forms.ContextMenuStrip Context_TrayIcon;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnMenu_Games;
        private System.Windows.Forms.Panel pannelChildForm;
    }
}

