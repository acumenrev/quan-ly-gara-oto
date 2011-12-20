using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DAL;
using BLL;

namespace QuanLyGaraOto.formCSDL
{
    public partial class frmTienCong : DevComponents.DotNetBar.Office2007Form
    {
        #region Fields

        BLL.TienCongBLL bll = new TienCongBLL();
        DAL.DataService dal = new DataService();

        #endregion

        #region Methods & Constructor

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

            // load dữ liệu cho DataGridView
            int rowCount = dgvTim.Rows.Count - 1;
            for (int i = 0; i < rowCount; i++)
            {
                dgvTim.Rows.Remove(dgvTim.CurrentRow);
            }
            dgvTim.DataSource = bll.Select();
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

        private void txtTu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDen_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtTu_KeyPress(sender, e);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtNoiDung.Text.Trim() != "" && txtTienCong.Text.ToString().Trim() != "")
            {
                bll.Insert(txtNoiDung.Text, decimal.Parse(txtTienCong.Text));
                frmTienCong_Load(sender, e);
                ClearInput();
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập những thông tin cần thiết.\nXin xem lại",
                                "Cảnh báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtNoiDung.Text.Trim() != "" && txtTienCong.Text.ToString().Trim() != "")
            {
                bll.Update(txtNoiDung.Text, decimal.Parse(txtTienCong.Text));
                frmTienCong_Load(sender, e);
                ClearInput();
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập những thông tin cần thiết.\nXin xem lại",
                                "Cảnh báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtNoiDung.Text.Trim() != "")
            {
                bll.Delete(txtNoiDung.Text);
                frmTienCong_Load(sender, e);
                ClearInput();
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập vào nội dung cần xóa",
                                "Cảnh báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtNoiDung.Focus();
            }
        }

        private void ClearInput()
        {
            txtNoiDung.Text = "";
            txtTienCong.Text = "";
        }

        private void dgvTim_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvTim.SelectedRows.Count == 1)
                {
                    DataGridViewRow r = dgvTim.SelectedRows[0];
                    txtNoiDung.Text = r.Cells[0].Value.ToString();
                    txtTienCong.Text = r.Cells[1].Value.ToString();
                }
            }
            catch { }
        }

        private void ClearDataGridView()
        {
            int rowCount = dgvTim.RowCount - 1;
            for (int i = 0; i < rowCount; i++)
            {
                dgvTim.Rows.Remove(dgvTim.CurrentRow);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            ClearDataGridView();
            dgvTim.DataSource = bll.SearchSoTien(decimal.Parse(txtTu.Text),
                                                decimal.Parse(txtDen.Text));
            ClearInput();
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            ClearDataGridView();
            if (txtTim.Text.Trim() == "")
            {
                dgvTim.DataSource = bll.Select();
                ClearInput();
            }
            else
            {
                dgvTim.DataSource = bll.SearchNoiDung(txtTim.Text);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}