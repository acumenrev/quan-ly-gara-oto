using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Rendering;

namespace QuanLyGaraOto.formHeThong
{
    public partial class frmThayDoiMatKhau : DevComponents.DotNetBar.Office2007Form
    {
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

        public frmThayDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
