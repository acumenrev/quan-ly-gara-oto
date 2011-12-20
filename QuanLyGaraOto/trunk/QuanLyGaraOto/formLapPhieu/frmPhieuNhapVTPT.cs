using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using BLL;
using DAL;

namespace QuanLyGaraOto.formLapPhieu
{
    public partial class frmPhieuNhapVTPT : DevComponents.DotNetBar.Office2007Form
    {
        #region Fields
        
        private BLL.PhieuNhapVTPT bll_phieuNhapChung;
        private BLL.CT_PhieuNhapVTPTBLL bll_phieuNhapRieng;
        private DAL.DataService dal;

        #endregion

        #region Constructor

        public frmPhieuNhapVTPT()
        {
            InitializeComponent();
            bll_phieuNhapChung = new BLL.PhieuNhapVTPT();
            bll_phieuNhapRieng = new CT_PhieuNhapVTPTBLL();
            dal = new DataService();
        }

        #endregion

        #region Methods

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

        /// <summary>
        /// Xóa dữ liệu có trong dgvThongTinChung
        /// </summary>
        private void XoaTTChung()
        {
            int iChung = dgvThongTinChung.RowCount - 1;
            for (int i = 0; i < iChung; i++)
            {
                dgvThongTinChung.Rows.Remove(dgvThongTinChung.CurrentRow);
            }
        }

        /// <summary>
        /// Xóa dữ liệu có trong dgvThongTinRieng
        /// </summary>
        private void XoaTTRieng()
        {
            int iRieng = dgvThongTinRieng.RowCount - 1;
            for (int i = 0; i < iRieng; i++)
            {
                dgvThongTinRieng.Rows.Remove(dgvThongTinRieng.CurrentRow);
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

        private void btnThemTTChung_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSuaTTChung_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXoaTTChung_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThemTTRieng_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSuaTTRieng_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXoaTTRieng_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvThongTinChung_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvThongTinChung.SelectedRows.Count == 1)
                {
                    DataGridViewRow r = dgvThongTinChung.SelectedRows[0];
                    txtMaPhieuNhap.Text = r.Cells[0].Value.ToString();
                    dtpNgayNhap.Value = DateTime.Parse(r.Cells[1].Value.ToString());
                    dgvThongTinRieng.DataSource = bll_phieuNhapRieng.Select(dgvThongTinChung.SelectedRows[0].Cells[0].Value.ToString());
                    cbbMaVTPT.Enabled = true;
                    txtSoLuongNhap.Enabled = true;
                    txtDonGiaNhap.Enabled = true;
                }
            }
            catch { }
        }

        private void dgvThongTinRieng_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvThongTinRieng.SelectedRows.Count == 1)
                {
                    DataGridViewRow r = dgvThongTinRieng.SelectedRows[0];
                    cbbMaVTPT.Text = r.Cells[0].Value.ToString();
                    txtSoLuongNhap.Text = r.Cells[1].Value.ToString();
                    txtDonGiaNhap.Text = r.Cells[2].Value.ToString();
                }
            }
            catch { }
        }

        private void cbbTimRieng_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTimRieng.Text != "")
            {
                txtTimRieng.Visible = true;
            }
        }

        private void ClearGeneralInputs()
        {
            txtMaPhieuNhap.Text = "";
            dtpNgayNhap.Value = DateTime.Today;
        }

        private void ClearDetailInputs()
        {
            cbbMaVTPT.Text = "";
            txtSoLuongNhap.Text = "";
            txtDonGiaNhap.Text = "";
        }

        private void frmPhieuNhapVTPT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gARA1DataSet.VATTUPHUTUNGs' table. You can move, or remove it, as needed.
            this.vATTUPHUTUNGsTableAdapter.Fill(this.gARA1DataSet.VATTUPHUTUNGs);
            // TODO: This line of code loads data into the 'gARA1DataSet.VATTUPHUTUNGs' table. You can move, or remove it, as needed.
            try
            {
                // TODO: This line of code loads data into the 'gARA1DataSet.VATTUPHUTUNGs' table. You can move, or remove it, as needed.

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // o tim kiem
            lbTu.Visible = false;
            lbDen.Visible = false;
            txtTimTTChung.Visible = false;
            txtTimRieng.Visible = false;
            btnTim.Visible = false;
            dtpTimDenNgay.Visible = false;
            dtpTimTuNgay.Visible = false;
            cbbMaVTPT.Enabled = false;
            txtDonGiaNhap.Enabled = false;
            txtSoLuongNhap.Enabled = false;
            ClearDataGridView(dgvThongTinChung);
            ClearDataGridView(dgvThongTinRieng);
            // load dữ liệu cho datagridview
            dgvThongTinChung.DataSource = bll_phieuNhapChung.Select();
            dgvThongTinRieng.DataSource = bll_phieuNhapRieng.Select(dgvThongTinChung.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void ClearDataGridView(DataGridView dgv)
        {
            int rowCount = dgv.RowCount - 1;
            for (int i = 0; i < rowCount; i++)
            {
                dgv.Rows.Remove(dgv.CurrentRow);
            }
        }

        private void txtTimTTChung_TextChanged(object sender, EventArgs e)
        {
            ClearDataGridView(dgvThongTinChung);
            if (txtTimTTChung.Text.Trim() == "")
            {
                dgvThongTinChung.DataSource = bll_phieuNhapChung.Select();
                ClearGeneralInputs();
            }
            else
            {
                if (cbbTimTTChung.Text == "Mã phiếu nhập")
                {
                    dgvThongTinChung.DataSource = bll_phieuNhapChung.SearchMaPhieuNhap(txtTimTTChung.Text);
                }
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            ClearDataGridView(dgvThongTinChung);
            if (cbbTimTTChung.Text == "Ngày nhập")
            {
                dgvThongTinChung.DataSource = bll_phieuNhapChung.SearchNgayNhap(dtpTimTuNgay.Value, dtpTimDenNgay.Value);
            }
        }

        private void txtTimRieng_TextChanged(object sender, EventArgs e)
        {
            ClearDataGridView(dgvThongTinRieng);
            if(txtTimRieng.Text.Trim() == "")
            {
                dgvThongTinRieng.DataSource = bll_phieuNhapRieng.Select(txtMaPhieuNhap.Text);
            }
            else 
            {
                if (cbbTimRieng.Text == "Mã vật tư phụ tùng")
                {
                    dgvThongTinRieng.DataSource = bll_phieuNhapRieng.SearchMaVTPT(txtTimRieng.Text,
                                dgvThongTinChung.SelectedRows[0].Cells[0].Value.ToString());
                }
            }
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            try
            {
                txtMaPhieuNhap.Text = "";
                dtpNgayNhap.Value = DateTime.Today;
                string str = "";
                // mã bắt đầu cho mã phiếu thu tiền
                if (dgvThongTinChung.RowCount - 1 > 1)
                {
                    int rowCount = dgvThongTinChung.RowCount - 1;
                    string temp = dgvThongTinChung.Rows[rowCount - 1].Cells[0].Value.ToString().Trim();
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
                    str = "PN" + so.ToString();
                }
                else
                {
                    if (dgvThongTinChung.RowCount - 1 == 0)
                    {
                        str = "PN1";
                    }
                    else
                    {
                        if (dgvThongTinChung.RowCount - 1 == 1)
                        {
                            str = "PN2";
                        }
                    }
                }
                txtMaPhieuNhap.Text = str;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Mã phiếu đã nhập không chính xác theo quy chuẩn.\n Mã phiếu phải bắt đầu với PN",
                            "Cảnh báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}