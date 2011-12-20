using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Data.Sql;
using System.Data.SqlClient;
using DAL;
using BLL;

namespace QuanLyGaraOto.formHeThong
{
    public partial class frmQuyDinh : DevComponents.DotNetBar.Office2007Form
    {
        #region Fields
        DataService dal;
        BLL.ThamSoBLL bll;
        private const int WM_NCLBUTTONDBLCLK = 0xA3;
        #endregion

        #region Constructor

        public frmQuyDinh()
        {
            InitializeComponent();
            dal = new DataService();
            bll = new ThamSoBLL();
        }

        #endregion
       
        #region Methods

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSoXe.Text.Trim() != "")
                {
                    bll.Update(int.Parse(txtSoXe.Text));
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập vào số xe tối đa.",
                                    "Cảnh báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSoXe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmQuyDinh_Load(object sender, EventArgs e)
        {
            try
            {
                txtSoXe.Text = bll.Select().Rows[0]["SoXeSuaChuaToiDaTrongNgay"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Ngan khong cho phong to cua so khi bam doi chuot vao title bar
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

        #endregion
    }
}