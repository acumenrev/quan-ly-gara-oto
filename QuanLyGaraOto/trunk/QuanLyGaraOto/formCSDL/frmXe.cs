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
    public partial class frmXe : DevComponents.DotNetBar.Office2007Form
    {
        #region Fields

        DAL.DataService dal = new DataService();
        BLL.XeBLL bll = new XeBLL();

        #endregion

        #region Constructor

        public frmXe()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

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
                    txtTienNoTu.Visible = false;
                    txtTienNoDen.Visible = false;
                    break;
                case "Ngày tiếp nhận":
                    lbTu.Visible = true;
                    lbDen.Visible = true;
                    txtTim.Visible = false;
                    dtpTimDenNgay.Visible = true;
                    dtpTimTuNgay.Visible = true;
                    btnTim.Visible = true;
                    txtTienNoTu.Visible = false;
                    txtTienNoDen.Visible = false;
                    break;
                case "Tiền nợ":
                    lbTu.Visible = true;
                    lbDen.Visible = true;
                    txtTim.Visible = false;
                    dtpTimDenNgay.Visible = false;
                    dtpTimTuNgay.Visible = false;
                    btnTim.Visible = true;
                    txtTienNoTu.Visible = true;
                    txtTienNoDen.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void frmXe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gARA1DataSet.HIEUXEs' table. You can move, or remove it, as needed.
            this.hIEUXEsTableAdapter.Fill(this.gARA1DataSet.HIEUXEs);
            // các controls cho tìm kiếm
            lbTu.Visible = false;
            lbDen.Visible = false;
            txtTim.Visible = false;
            dtpTimDenNgay.Visible = false;
            dtpTimTuNgay.Visible = false;
            btnTim.Visible = false;
            txtTienNoTu.Visible = false;
            txtTienNoDen.Visible = false;
            ClearDataGridView();
            // load dữ liệu cho dgvTim
            dgvTim.DataSource = bll.Select();
            // load dữ liệu cho cbbHieuXe
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

        private void btnXoaCSDL_Click(object sender, EventArgs e)
        {
            bll.Delete(txtBienSo.Text);
            frmXe_Load(sender, e);
            ClearInput();
        }

        private void btnSuaCSDL_Click(object sender, EventArgs e)
        {
            bll.Update(txtBienSo.Text, txtTenChuXe.Text, cbbHieuXe.Text,
                        txtDiaChi.Text, dtpNgayTiepNhan.Value,
                        txtEmail.Text, decimal.Parse(txtTienNo.Text),
                        int.Parse(txtDienThoai.Text));
            frmXe_Load(sender, e);
            ClearInput();
        }

        private void ClearInput()
        {
            txtBienSo.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtDienThoai.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtTenChuXe.Text = string.Empty;
            cbbHieuXe.Text = string.Empty;
            txtTienNo.Text = string.Empty;
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
                    txtTienNo.Text = r.Cells[6].Value.ToString();
                    txtDienThoai.Text = r.Cells[7].Value.ToString();
                }
            }
            catch (Exception ex)
            {
            }
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
            if (txtTim.Text.Trim() == "")
            {
                dgvTim.DataSource = bll.Select();
            }
            else
            {
                switch(cbbTim.Text)
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
            ClearInput();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            ClearDataGridView();
            dgvTim.DataSource = bll.SearchNgayTiepNhan(dtpTimTuNgay.Value,
                                    dtpTimDenNgay.Value);
            ClearInput();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}