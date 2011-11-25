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
    public partial class frmPhieuSuaChua : DevComponents.DotNetBar.Office2007Form
    {
        public frmPhieuSuaChua()
        {
            InitializeComponent();
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

        private void txtTimTuSoTien_TextChanged(object sender, EventArgs e)
        {
            if (txtTimDenSoTien.Text.Trim() != "" && txtTimTuSoTien.Text.Trim() != "")
            {
                if (double.Parse(txtTimTuSoTien.Text) > double.Parse(txtTimDenSoTien.Text))
                {
                    txtTimTuSoTien.Text = txtTimDenSoTien.Text;
                }
            }
        }

        private void txtTimDenSoTien_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTongTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtThanhTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbbTimTTChung_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTimTTChung.Text == "Mã phiếu sửa chữa" || cbbTimTTChung.Text == "Biển số xe")
            {
                lbTu.Visible = false;
                lbDen.Visible = false;
                txtTimTuSoTien.Visible = false;
                txtTimDenSoTien.Visible = false;
                dtpTimDenNgay.Visible = false;
                dtpTimTuNgay.Visible = false;
                btnTim.Visible = false;
                txtTimTTChung.Visible = true;
            }
            else
            {
                if (cbbTimTTChung.Text == "Ngày sửa xe")
                {
                    lbTu.Visible = true;
                    lbDen.Visible = true;
                    txtTimTuSoTien.Visible = false;
                    txtTimDenSoTien.Visible = false;
                    dtpTimDenNgay.Visible = true;
                    dtpTimTuNgay.Visible = true;
                    btnTim.Visible = true;
                    txtTimTTChung.Visible = false;
                }
                else
                {
                    if (cbbTimTTChung.Text == "Tổng tiền")
                    {
                        lbTu.Visible = true;
                        lbDen.Visible = true;
                        txtTimTuSoTien.Visible = true;
                        txtTimDenSoTien.Visible = true;
                        dtpTimDenNgay.Visible = false;
                        dtpTimTuNgay.Visible = false;
                        btnTim.Visible = true;
                        txtTimTTChung.Visible = false;
                    }
                }
            }
        }

        private void frmPhieuSuaChua_Load(object sender, EventArgs e)
        {
            // o tim kiem chung
            lbTu.Visible = false;
            lbDen.Visible = false;
            txtTimTuSoTien.Visible = false;
            txtTimDenSoTien.Visible = false;
            dtpTimDenNgay.Visible = false;
            dtpTimTuNgay.Visible = false;
            btnTim.Visible = false;
            txtTimTTChung.Visible = false;
        }

        private void dtpNgaySuaChua_ValueChanged(object sender, EventArgs e)
        {
            DateTime dtNow = DateTime.Now;
            if (dtpNgaySuaChua.Value > dtNow)
            {
                MessageBox.Show("Ngày thu không thể lớn hơn ngày hiện tại.\nXin xem lại",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dtpNgaySuaChua.Value = dtNow;
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtDonGia_KeyPress(sender, e);
        }

        private void txtTimDenSoTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtDonGia_KeyPress(sender, e);
        }

        private void txtTimTuSoTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtDonGia_KeyPress(sender, e);
        }
    }
}