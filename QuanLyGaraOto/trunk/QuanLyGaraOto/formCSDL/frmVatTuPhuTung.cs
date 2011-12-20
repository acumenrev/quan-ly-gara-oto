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
    public partial class frmVatTuPhuTung : DevComponents.DotNetBar.Office2007Form
    {
        #region Fields

        DAL.DataService dal = new DataService();
        BLL.VTPTBLL bll = new VTPTBLL();

        #endregion

        #region Constructor & Methods

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
            // TODO: This line of code loads data into the 'gARA1DataSet.VATTUPHUTUNGs' table. You can move, or remove it, as needed.
            this.vATTUPHUTUNGsTableAdapter.Fill(this.gARA1DataSet.VATTUPHUTUNGs);
            // o tim kiem
            txtTim.Visible = false;
            txtTu.Visible = false;
            txtDen.Visible = false;
            lbTu.Visible = false;
            lbDen.Visible = false;
            btnTim.Visible = false;
            // load dữ liệu cho dgvTim
            int rowCount = dgvTim.Rows.Count - 1;
            for (int i = 0; i < rowCount; i++)
            {
                dgvTim.Rows.Remove(dgvTim.CurrentRow);
            }
            dgvTim.DataSource = bll.Select();

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

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaVTPT.Text.Trim() != "" && txtTenVTPT.Text.Trim() != "" &&
                    txtSoLuongTon.Text.ToString().Trim() != "" && txtDonGiaNhap.Text.ToString().Trim() != "" &&
                    txtDonGiaBan.Text.ToString().Trim() != "")
            {
                bll.Insert(txtMaVTPT.Text, txtTenVTPT.Text,
                            int.Parse(txtSoLuongTon.Text),
                            decimal.Parse(txtDonGiaNhap.Text),
                            decimal.Parse(txtDonGiaBan.Text));
                frmVatTuPhuTung_Load(sender, e);
                ClearInput();
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập một trong các thông tin cần thiết sau: mã vtpt, tên vtpt, số lượng tồn, đơn giá nhập, đơn giá bán.\nXin xem lại",
                                "Cảnh báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaVTPT.Text.Trim() != "" && txtTenVTPT.Text.Trim() != "" &&
                    txtSoLuongTon.Text.ToString().Trim() != "" && txtDonGiaNhap.Text.ToString().Trim() != "" &&
                    txtDonGiaBan.Text.ToString().Trim() != "")
            {
                bll.Update(txtMaVTPT.Text, txtTenVTPT.Text, int.Parse(txtSoLuongTon.Text),
                            decimal.Parse(txtDonGiaNhap.Text),
                            decimal.Parse(txtDonGiaBan.Text));
                frmVatTuPhuTung_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập một trong các thông tin cần thiết sau: mã vtpt, tên vtpt, số lượng tồn, đơn giá nhập, đơn giá bán.\nXin xem lại",
                                "Cảnh báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaVTPT.Text.Trim() != "")
            {
                bll.Delete(txtMaVTPT.Text);
                frmVatTuPhuTung_Load(sender, e);
                ClearInput();
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập vào mã vật tư phụ tùng cần xóa.",
                                "Cảnh báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void ClearInput()
        {
            txtDonGiaBan.Text = string.Empty;
            txtDonGiaNhap.Text = string.Empty;
        }

        private void dgvTim_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvTim.SelectedRows.Count == 1)
                {
                    DataGridViewRow r = dgvTim.SelectedRows[0];
                    txtMaVTPT.Text = r.Cells[0].Value.ToString();
                    txtTenVTPT.Text = r.Cells[1].Value.ToString();
                    txtSoLuongTon.Text = r.Cells[2].Value.ToString();
                    txtDonGiaNhap.Text = r.Cells[3].Value.ToString();
                    txtDonGiaBan.Text = r.Cells[4].Value.ToString();
                }
            }
            catch { }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearDataGridView()
        {
            int rowCount = dgvTim.RowCount - 1;
            for (int i = 0; i < rowCount; i++)
            {
                dgvTim.Rows.Remove(dgvTim.CurrentRow);
            }
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            ClearDataGridView();
            switch(cbbTim.Text)
            {
                case "Mã VTPT":
                    dgvTim.DataSource = bll.SearchMa(txtTim.Text);
                    break;
                case "Tên VTPT":
                    dgvTim.DataSource = bll.SearchTen(txtTim.Text);
                    break;
                default:
                    break;
            }

            if (txtTim.Text.Trim() == "")
            {
                dgvTim.DataSource = bll.Select();
                ClearInput();
            }
            else
            {
                if (cbbTim.Text == "Mã VTPT")
                {
                    dgvTim.DataSource = bll.SearchMa(txtTim.Text);
                }
                else
                {
                    if (cbbTim.Text == "Tên VTPT")
                    {
                        dgvTim.DataSource = bll.SearchTen(txtTim.Text);
                    }
                }
            }
            ClearInput();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            ClearDataGridView();
            switch(cbbTim.Text)
            {
                case "Đơn giá nhập":
                    dgvTim.DataSource = bll.SearchDonGiaNhap(decimal.Parse(txtTu.Text),
                                                            decimal.Parse(txtDen.Text));
                    break;
                case "Đơn giá bán":
                    dgvTim.DataSource = bll.SearchDonGiaBan(decimal.Parse(txtTu.Text),
                                        decimal.Parse(txtDen.Text));
                    break;
                case "Số lượng tồn":
                    dgvTim.DataSource = bll.SearchSoLuongTon(int.Parse(txtTu.Text),
                                                            int.Parse(txtDen.Text));
                    break;
                default:
                    break;
            }
            ClearInput();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtDonGiaBan.Text = "";
            txtDonGiaNhap.Text = "";
            txtTenVTPT.Text = "";
            txtSoLuongTon.Text = "";
            string str = "";
            // mã bắt đầu cho vật tư phụ tùng
            if (dgvTim.RowCount - 1 > 1)
            {
                int rowCount = dgvTim.RowCount - 1;
                string temp = dgvTim.Rows[rowCount - 1].Cells[0].Value.ToString().Trim();
                char[] arr = temp.ToCharArray();
                int pos = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (Char.IsDigit(arr[i]))
                    {
                        pos = i;
                        break;
                    }
                }
                string tempSo = temp.Substring(pos, arr.Length - pos);
                int so = int.Parse(tempSo) + 1;
                str = "VT" + so.ToString();
            }
            else
            {
                if (dgvTim.RowCount - 1 == 0)
                {
                    str = "VT1";
                }
                else
                {
                    if (dgvTim.RowCount - 1 == 1)
                    {
                        str = "VT2";
                    }
                }
            }
            txtMaVTPT.Text = str;
        }

        #endregion
    }
}