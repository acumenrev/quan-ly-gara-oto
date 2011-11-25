using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace QuanLyGaraOto.formCSDL
{
    public partial class frmXe : DevComponents.DotNetBar.Office2007Form
    {
        public frmXe()
        {
            InitializeComponent();
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

        private void cbbTim_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cbbTim.Text)
            {
                case "Tên chủ xe":
                case "Hiệu xe":
                case "Biển số":
                case "Địa chỉ":
                    lbTu.Visible = false;
                    lbDen.Visible = false;
                    txtTim.Visible = true;
                    dtpTimDenNgay.Visible = false;
                    dtpTimTuNgay.Visible = false;
                    btnTim.Visible = false;
                    break;
                case "Ngày tiếp nhận":
                    lbTu.Visible = true;
                    lbDen.Visible = true;
                    txtTim.Visible = false;
                    dtpTimDenNgay.Visible = true;
                    dtpTimTuNgay.Visible = true;
                    btnTim.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void frmXe_Load(object sender, EventArgs e)
        {
            // o tim kiem
            lbTu.Visible = false;
            lbDen.Visible = false;
            txtTim.Visible = false;
            dtpTimDenNgay.Visible = false;
            dtpTimTuNgay.Visible = false;
            btnTim.Visible = false;
        }

        private void dtpNgayTiepNhan_ValueChanged(object sender, EventArgs e)
        {
            DateTime dtNow = DateTime.Today;
            if (dtpNgayTiepNhan.Value > dtNow)
            {
                MessageBox.Show("Giá trị ngày tiếp nhận không thể lớn hơn ngày hiện tại.\nXin xem lại",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dtpNgayTiepNhan.Value = dtNow;
            }
        }
    }
}