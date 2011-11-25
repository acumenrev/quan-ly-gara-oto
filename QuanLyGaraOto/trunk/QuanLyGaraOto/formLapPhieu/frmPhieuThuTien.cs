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
    public partial class frmPhieuThuTien : DevComponents.DotNetBar.Office2007Form
    {
        public frmPhieuThuTien()
        {
            InitializeComponent();
        }

        private void cbbTim_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cbbTim.Text == "Mã phiếu thu tiền" || cbbTim.Text== "Biển số xe")
            {
                txtTim.Visible = true;
                txtTimDenSoTien.Visible = false;
                txtTimTuSoTien.Visible = false;
                dtpTimDenNgay.Visible = false;
                dtpTimTuNgay.Visible = false;
                lbDen.Visible = false;
                lbTu.Visible = false;
                btnTim.Visible = false;
            }
            else
            {
                if (cbbTim.Text == "Ngày thu")
                {
                    txtTim.Visible = false;
                    txtTimDenSoTien.Visible = false;
                    txtTimTuSoTien.Visible = false;
                    dtpTimDenNgay.Visible = true;
                    dtpTimTuNgay.Visible = true;
                    lbDen.Visible = true;
                    lbTu.Visible = true;
                    btnTim.Visible = true;
                }
                else
                {
                    if (cbbTim.Text == "Số tiền thu")
                    {
                        txtTim.Visible = false;
                        txtTimDenSoTien.Visible = true;
                        txtTimTuSoTien.Visible = true;
                        dtpTimDenNgay.Visible = false;
                        dtpTimTuNgay.Visible = false;
                        lbDen.Visible = true;
                        lbTu.Visible = true;
                        btnTim.Visible = true;
                    }
                }
            }
        }

        private void frmPhieuThuTien_Load(object sender, EventArgs e)
        {
            // O tim kiem
            txtTim.Visible = false;
            txtTimDenSoTien.Visible = false;
            txtTimTuSoTien.Visible = false;
            dtpTimDenNgay.Visible = false;
            dtpTimTuNgay.Visible = false;
            lbDen.Visible = false;
            lbTu.Visible = false;
            btnTim.Visible = false;
        }

        private void txtTimTuSoTien_TextChanged(object sender, EventArgs e)
        {
            if (txtTimTuSoTien.Text.Trim() != "" && txtTimDenSoTien.Text.Trim() != "")
            {
                if (double.Parse(txtTimTuSoTien.Text) > double.Parse(txtTimDenSoTien.Text))
                {
                    txtTimTuSoTien.Text = txtTimDenSoTien.Text;
                }
            }
        }

        private void txtTimTuSoTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTimDenSoTien_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSoTienThu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dtpNgayThu_ValueChanged(object sender, EventArgs e)
        {
            DateTime dtNow = DateTime.Now;
            if (dtpNgayThu.Value > dtNow)
            {
                MessageBox.Show("Ngày thu không thể lớn hơn ngày hiện tại.\nXin xem lại",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dtpNgayThu.Value = dtNow;
            }

        }

        
    }
}