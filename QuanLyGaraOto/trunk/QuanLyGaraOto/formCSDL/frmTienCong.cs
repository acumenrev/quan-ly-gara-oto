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
    public partial class frmTienCong : DevComponents.DotNetBar.Office2007Form
    {
        public frmTienCong()
        {
            InitializeComponent();
        }

        private void cbbTim_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cbbTim.Text)
            {
                case "Nội dung":
                    lbTu.Visible = false;
                    lbDen.Visible = false;
                    btnTim.Visible = false;
                    txtTu.Visible = false;
                    txtDen.Visible = false;
                    txtTim.Visible = true;
                    break;
                case "Tiền công":
                    lbTu.Visible = true;
                    lbDen.Visible = true;
                    btnTim.Visible = true;
                    txtTu.Visible = true;
                    txtDen.Visible = true;
                    txtTim.Visible = false;
                    break;
                default:
                    lbTu.Visible = false;
                    lbDen.Visible = false;
                    btnTim.Visible = false;
                    txtTu.Visible = false;
                    txtDen.Visible = false;
                    txtTim.Visible = false;
                    break;
            }
        }

        private void frmTienCong_Load(object sender, EventArgs e)
        {
            // o tim kiem
            lbTu.Visible = false;
            lbDen.Visible = false;
            btnTim.Visible = false;
            txtTu.Visible = false;
            txtDen.Visible = false;
            txtTim.Visible = false;
        }

        private void txtTienCong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTu_TextChanged(object sender, EventArgs e)
        {
            if (txtTu.Text.Trim() != "" && txtDen.Text.Trim() != "")
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
}