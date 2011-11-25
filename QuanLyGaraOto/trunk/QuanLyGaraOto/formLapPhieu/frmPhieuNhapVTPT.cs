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
    public partial class frmPhieuNhapVTPT : DevComponents.DotNetBar.Office2007Form
    {
        public frmPhieuNhapVTPT()
        {
            InitializeComponent();
        }

        private void txtSoLuongNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDonGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbbTimTTChung_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTimTTChung.Text == "Mã phiếu nhập")
            {
                lbTu.Visible = false;
                lbDen.Visible = false;
                dtpTimDenNgay.Visible = false;
                dtpTimTuNgay.Visible = false;
                btnTim.Visible = false;
                txtTimTTChung.Visible = true;
            }
            else
            {
                if (cbbTimTTChung.Text == "Ngày nhập")
                {
                    lbTu.Visible = true;
                    lbDen.Visible = true;
                    dtpTimDenNgay.Visible = true;
                    dtpTimTuNgay.Visible = true;
                    btnTim.Visible = true;
                    txtTimTTChung.Visible = false;
                }
            }
        }

        private void frmPhieuNhapVTPT_Load(object sender, EventArgs e)
        {
            // o tim kiem
            lbTu.Visible = false;
            lbDen.Visible = false;
            dtpTimDenNgay.Visible = false;
            dtpTimTuNgay.Visible = false;
            btnTim.Visible = false;
            txtTimTTChung.Visible = false;
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

        private void dtpNgayNhap_ValueChanged(object sender, EventArgs e)
        {
            DateTime dtNow = DateTime.Now;
            if (dtpNgayNhap.Value > dtNow)
            {
                MessageBox.Show("Ngày thu không thể lớn hơn ngày hiện tại.\nXin xem lại",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dtpNgayNhap.Value = dtNow;
            }
        }
    }
}