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

namespace QuanLyGaraOto.formLapPhieu
{
    public partial class frmPhieuNhanXe : DevComponents.DotNetBar.Office2007Form
    {
        #region Fields

        BLL.XeBLL bll;
        DAL.DataService dal;

        #endregion

        #region Constructor

        public frmPhieuNhanXe()
        {
            InitializeComponent();
            dal = new DataService();
            bll = new XeBLL();
        }

        #endregion

        #region Methods

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
            // TODO: This line of code loads data into the 'gARA1DataSet.HIEUXEs' table. You can move, or remove it, as needed.
            this.hIEUXEsTableAdapter.Fill(this.gARA1DataSet.HIEUXEs);
            lbTu.Visible = false;
            lbDen.Visible = false;
            dtpTimTuNgay.Visible = false;
            dtpTimDenNgay.Visible = false;
            btnTim.Visible = false;
            txtTim.Visible = false;
            ClearDataGridView();
            // load dữ liệu cho dgvTim
            dgvTim.DataSource = bll.Select();
            ClearInput();
        }

        /// <summary>
        /// xóa dữ liệu hiện đang được load trong dgvTim
        /// </summary>
        private void ClearDataGridView()
        {
            int rowCount = dgvTim.RowCount - 1;
            for (int i = 0; i < rowCount; i++)
            {
                dgvTim.Rows.Remove(dgvTim.CurrentRow);
            }

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

        private void btnThemCSDL_Click(object sender, EventArgs e)
        {
            if (txtBienSo.Text.Trim() != "" && txtTenChuXe.Text.Trim() != "" &&
                        cbbHieuXe.Text.Trim() != "" && txtDiaChi.Text.Trim() != "" && txtEmail.Text.Trim() != "")
            {
                bll.Insert(txtBienSo.Text, txtTenChuXe.Text, cbbHieuXe.Text,
                            txtDiaChi.Text, dtpNgayTiepNhan.Value,
                            txtEmail.Text, 0, int.Parse(txtDienThoai.Text));
                ClearInput();
                ClearDataGridView();
                dgvTim.DataSource = bll.Select();
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập một trong các thông tin cần thiết sau: biến số xe, tên chủ xe, hiệu xe, địa chỉ, email.\nXin xem lại",
                                    "Cảnh báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoaCSDL_Click(object sender, EventArgs e)
        {
            if (txtBienSo.Text.Trim() != "")
            {
                bll.Delete(txtBienSo.Text);
                ClearInput();
                ClearDataGridView();
                dgvTim.DataSource = bll.Select();
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập vào biển số xe cần xóa.\nXin xem lại",
                                    "Cảnh báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                txtBienSo.Focus();
            }
        }

        private void btnSuaCSDL_Click(object sender, EventArgs e)
        {
            if (txtBienSo.Text.Trim() != "" && txtTenChuXe.Text.Trim() != "" &&
                       cbbHieuXe.Text.Trim() != "" && txtDiaChi.Text.Trim() != "" && txtEmail.Text.Trim() != "")
            {
                bll.Update(txtBienSo.Text, txtTenChuXe.Text, cbbHieuXe.Text,
                            txtDiaChi.Text, dtpNgayTiepNhan.Value, txtEmail.Text,
                            0, int.Parse(txtDienThoai.Text));
                ClearInput();
                ClearDataGridView();
                dgvTim.DataSource = bll.Select();
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập một trong các thông tin cần thiết sau: biến số xe, tên chủ xe, hiệu xe, địa chỉ, email.\nXin xem lại",
                                    "Cảnh báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
            }
        }

        private void ClearInput()
        {
            txtBienSo.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtDienThoai.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtTenChuXe.Text = string.Empty;
            cbbHieuXe.Text = string.Empty;
            dtpNgayTiepNhan.Value = DateTime.Today;
        }

        private void dgvTim_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvTim.SelectedRows.Count == 1)
                {
                    DataGridViewRow r = dgvTim.SelectedRows[0];
                    txtBienSo.Text = r.Cells[0].Value.ToString();
                    txtTenChuXe.Text = r.Cells[1].Value.ToString();
                    cbbHieuXe.Text = r.Cells[2].Value.ToString();
                    txtDiaChi.Text = r.Cells[3].Value.ToString();
                    dtpNgayTiepNhan.Value = DateTime.Parse(r.Cells[4].Value.ToString());
                    txtEmail.Text = r.Cells[5].Value.ToString();
                    txtDienThoai.Text = r.Cells[7].Value.ToString();
                }
            }
            catch { }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            ClearDataGridView();
            dgvTim.DataSource = bll.SearchNgayTiepNhan(dtpTimTuNgay.Value, 
                                    dtpTimDenNgay.Value);
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
                switch (cbbTim.Text)
                {
                    case "Biển số":
                        dgvTim.DataSource = bll.SearchBienSoXe(txtTim.Text);
                        break;
                    case "Hiệu xe":
                        dgvTim.DataSource = bll.SearchHieuXe(txtTim.Text);
                        break;
                    case "Địa chỉ":
                        dgvTim.DataSource = bll.SearchDiaChi(txtTim.Text);
                        break;
                    case "Tên chủ xe":
                        dgvTim.DataSource = bll.SearchTenChuXe(txtTim.Text);
                        break;
                }
            }
        }

        #endregion
    }
}