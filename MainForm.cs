using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyController
{
    public partial class MainForm : Form
    {
        private Form activeForm = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pannelChildForm.Controls.Add(childForm);
            pannelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        #region 트레이 아이콘 설정
        private void MainForm_Load(object sender, EventArgs e)
        {
            Tray_Icon.ContextMenuStrip = Context_TrayIcon;
        }

        private void Tray_Icon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.ShowInTaskbar = true;
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = true;
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileIO fileIO = new FileIO();
            fileIO.Write();
            this.Close();
        }
        #endregion

        private void btnMenu_Games_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_Games());
            //db와 연결 후 링크 초기화
        }

        #region 마우스로 창 이동
        private Point point = new Point();
        private void pannelStatusBar_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }

        private void pannelStatusBar_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                this.Location = new Point(this.Left - (point.X - e.X), this.Top - (point.Y - e.Y));
            }
        }
        #endregion
    }
}
