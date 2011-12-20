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

namespace QuanLyGaraOto.formBaoCao
{
    public partial class frmBaoCaoTon : DevComponents.DotNetBar.Office2007Form
    {

        #region Fields

        BLL.BaoCaoTonBLL bll_baoCaoTon;
        BLL.CT_PhieuNhapVTPTBLL bll_CT_PhieuNhapVTPT;
        BLL.PhieuNhapVTPT bll_phieuNhapVTPT;
        BLL.VTPTBLL bll_vtpt;
        BLL.PhieuSuaChuaBLL bll_phieuSuaChua;
        BLL.CT_PhieuSuaChuaBLL bll_CT_phieuSuaChua;
        DAL.DataService dal;

        #endregion

        #region Constructor

        public frmBaoCaoTon()
        {
            InitializeComponent();
            bll_baoCaoTon = new BaoCaoTonBLL();
            dal = new DataService();
            bll_CT_PhieuNhapVTPT = new CT_PhieuNhapVTPTBLL();
            bll_phieuNhapVTPT = new BLL.PhieuNhapVTPT();
            bll_vtpt = new VTPTBLL();
            bll_phieuSuaChua = new PhieuSuaChuaBLL();
            bll_CT_phieuSuaChua = new CT_PhieuSuaChuaBLL();
        }

        #endregion

        #region Methods

        private void ClearDataGridView(DataGridView dgv)
        {
            int rowCount = dgv.RowCount - 1;
            for (int i = 0; i < rowCount; i++)
            {
                dgv.Rows.Remove(dgv.CurrentRow);
            }
        }

        private void frmBaoCaoTon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gARA1DataSet.VATTUPHUTUNGs' table. You can move, or remove it, as needed.
            this.vATTUPHUTUNGsTableAdapter.Fill(this.gARA1DataSet.VATTUPHUTUNGs);
            dtpTimDenNgay.Visible = false;
            dtpTimTuNgay.Visible = false;
            txtTim.Visible = false;
            btnTim.Visible = false;
            lbTu.Visible = false;
            lbDen.Visible = false;
            ClearDataGridView(dgvTim);
            ClearDataGridView(dgvKetQua);
            dgvTim.DataSource = bll_baoCaoTon.Select();
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
            if (cbbTim.Text == "Mã báo cáo")
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
                if (cbbTim.Text == "Ngày tháng")
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

        private void dgvTim_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvTim.SelectedRows.Count == 1)
                {
                    DataGridViewRow r = dgvTim.SelectedRows[0];
                    DateTime temp = new DateTime(int.Parse(r.Cells[1].Value.ToString()),
                                                 int.Parse(r.Cells[0].Value.ToString()),
                                                 1);
                    dtpThoiGian.Value = temp;
                    cbbMaVTPT.Text = r.Cells[2].Value.ToString();
                }
            }
            catch { }
        }

        private void dgvKetQua_SelectionChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch
            {

            }
        }

        private void ClearInputs()
        {
            dtpThoiGian.Value = DateTime.Today;
        }

        private void ClearDataGridView()
        {
            int rowCount = dgvTim.SelectedRows.Count - 1;
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
                dgvTim.DataSource = bll_baoCaoTon.Select();
            }
            else
            {
                if (cbbTim.Text == "Mã VTPT")
                {
                    dgvTim.DataSource = bll_baoCaoTon.SearchMaVTPT(txtTim.Text);
                }
            }
            ClearInputs();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (cbbTim.Text == "Ngày tháng")
            {
                dgvTim.DataSource = bll_baoCaoTon.SearchNgayThang(dtpTimTuNgay.Value.Month,
                                                        dtpTimDenNgay.Value.Month,
                                                        dtpTimTuNgay.Value.Year,
                                                        dtpTimDenNgay.Value.Year);
            }
            ClearInputs();
        }

        private void btnXuatKetQua_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}