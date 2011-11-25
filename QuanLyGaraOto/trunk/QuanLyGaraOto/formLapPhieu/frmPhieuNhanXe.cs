using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace QuanLyGaraOto.formLapPhieu
{
    public partial class frmPhieuNhanXe : DevComponents.DotNetBar.Office2007Form
    {
        public frmPhieuNhanXe()
        {
            InitializeComponent();
        }

        private void cbbTim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTim.Text == "Tên chủ xe" || cbbTim.Text == "Hiệu xe"
                || cbbTim.Text == "Biến số" || cbbTim.Text == "Địa chỉ")
            {
                lbTu.Visible = false;
                lbDen.Visible = false;
                dtpTimTuNgay.Visible = false;
                dtpTimDenNgay.Visible = false;
                btnTim.Visible = false;
                txtTim.Visible = true;
            }
            else
            {
                if (cbbTim.Text == "Ngày tiếp nhận")
                {
                    lbTu.Visible = true;
                    lbDen.Visible = true;
                    dtpTimTuNgay.Visible = true;
                    dtpTimDenNgay.Visible = true;
                    btnTim.Visible = true;
                    txtTim.Visible = false;
                }
            }
        }

        private void frmPhieuNhanXe_Load(object sender, EventArgs e)
        {
            lbTu.Visible = false;
            lbDen.Visible = false;
            dtpTimTuNgay.Visible = false;
            dtpTimDenNgay.Visible = false;
            btnTim.Visible = false;
            txtTim.Visible = false;
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
           
        }

        private void dtpTimTuNgay_ValueChanged(object sender, EventArgs e)
        {
            if (dtpTimTuNgay.Value > dtpTimDenNgay.Value)
            {
                MessageBox.Show("Giá trị không hợp logic.\nXin xem lại",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dtpTimTuNgay.Value = DateTime.Today;
            }
        }

        private void dtpTimDenNgay_ValueChanged(object sender, EventArgs e)
        {
            if (dtpTimTuNgay.Value > dtpTimDenNgay.Value)
            {
                MessageBox.Show("Giá trị không hợp logic.\nXin xem lại",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dtpTimDenNgay.Value = DateTime.Today;
            }
        }

        private void dtpNgayTiepNhan_ValueChanged(object sender, EventArgs e)
        {
            DateTime dtNow = DateTime.Now;
            if (dtpNgayTiepNhan.Value > dtNow)
            {
                MessageBox.Show("Ngày tiếp nhận không thể lớn hơn ngày hiện tại.\nXin xem lại",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dtpNgayTiepNhan.Value = dtNow;
            }
        }
    }
}