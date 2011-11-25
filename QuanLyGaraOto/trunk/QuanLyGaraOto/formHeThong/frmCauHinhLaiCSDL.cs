using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace QuanLyGaraOto.formHeThong
{
    public partial class frmCauHinhLaiCSDL : DevComponents.DotNetBar.Office2007Form
    {
        public frmCauHinhLaiCSDL()
        {
            InitializeComponent();
        }
        // Ngan khong cho phong to cua so khi bam doi chuot vao title bar
        private const int WM_NCLBUTTONDBLCLK = 0xA3;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
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

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}