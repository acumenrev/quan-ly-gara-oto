using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;

using DevComponents.DotNetBar;

namespace QuanLyGaraOto
{
    public partial class frmServer : DevComponents.DotNetBar.Office2007Form
    {
        // Ngan khong cho phong to cua so khi bam doi chuot vao title bar
        private const int WM_NCLBUTTONDBLCLK = 0xA3;
        protected override void WndProc(ref Message m)
        {
            switch(m.Msg)
            {
                case WM_NCLBUTTONDBLCLK:
                    if (this.WindowState == FormWindowState.Maximized)
                    {
                        this.WindowState = FormWindowState.Normal;
                    }
                    return;
            }

            base.WndProc(ref m);
        }

        public frmServer()
        {
            InitializeComponent();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain frm = new frmMain();
            frm.Show();
            
        }
    }
}