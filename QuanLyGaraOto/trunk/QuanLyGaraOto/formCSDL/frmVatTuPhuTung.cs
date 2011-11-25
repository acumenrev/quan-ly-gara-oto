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
    public partial class frmVatTuPhuTung : DevComponents.DotNetBar.Office2007Form
    {
        public frmVatTuPhuTung()
        {
            InitializeComponent();
        }

        private void cbbTim_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cbbTim.Text)
            {
                case "Mã VTPT":
                case "Tên VTPT":
                    txtTim.Visible = true;
                    txtTu.Visible = false;
                    txtDen.Visible = false;
                    lbTu.Visible = false;
                    lbDen.Visible = false;
                    btnTim.Visible = false;
                    break;
                case "Đơn giá nhập":
                case "Đơn giá bán":
                case "Số lượng tồn":
                    txtTim.Visible = false;
                    txtTu.Visible = true;
                    txtDen.Visible = true;
                    lbTu.Visible = true;
                    lbDen.Visible = true;
                    btnTim.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void frmVatTuPhuTung_Load(object sender, EventArgs e)
        {
            // o tim kiem
            txtTim.Visible = false;
            txtTu.Visible = false;
            txtDen.Visible = false;
            lbTu.Visible = false;
            lbDen.Visible = false;
            btnTim.Visible = false;
        }

        private void txtSoLuongTon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDonGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtSoLuongTon_KeyPress(sender, e);
        }

        private void txtDonGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtSoLuongTon_KeyPress(sender, e);
        }

        private void txtTu_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtSoLuongTon_KeyPress(sender, e);
        }

        private void txtDen_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtSoLuongTon_KeyPress(sender, e);
        }

        private void txtTu_TextChanged(object sender, EventArgs e)
        {
            double soTu = double.Parse(txtTu.Text);
            double soDen = double.Parse(txtDen.Text);
            if (soTu > soDen)
            {
                soTu = soDen;
                txtTu.Text = soTu.ToString();
            }
        }

      
    }
}