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
    public partial class frmBaoCaoDoanhSo : DevComponents.DotNetBar.Office2007Form
    {
        #region Fields

        BLL.BaoCaoDoanhSoBLL bll_chung;
        BLL.CT_BaoCaoDoanhSo bll_rieng;

        #endregion

        #region Constructor
        
        public frmBaoCaoDoanhSo()
        {
            InitializeComponent();
            bll_chung = new BaoCaoDoanhSoBLL();
            bll_rieng = new BLL.CT_BaoCaoDoanhSo();
        }

        #endregion

        #region Methods

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

        private void frmBaoCaoDoanhSo_Load(object sender, EventArgs e)
        {
            dtpTimDenNgay.Visible = false;
            dtpTimTuNgay.Visible = false;
            txtTim.Visible = false;
            btnTim.Visible = false;
            lbTu.Visible = false;
            lbDen.Visible = false;
            ClearDataGridView(dgvTim);
            ClearDataGridView(dgvKetQua);
            // load dữ liệu lên datagridview
            dgvTim.DataSource = bll_chung.Select();
            dgvKetQua.DataSource = bll_rieng.Select(dgvTim.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void ClearDataGridView(DataGridView dgv)
        {
            if (dgv.RowCount - 1 > 0)
            {
                int rowCount = dgv.RowCount - 1;
                for (int i = 0; i < rowCount; i++)
                {
                    dgv.Rows.Remove(dgv.Rows[i]);
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
                    txtMaBaoCao.Text = r.Cells[0].Value.ToString();
                    // chuyển các dữ kiện ngày tháng về kiểu DateTime
                    DateTime temp = new DateTime(int.Parse(r.Cells[2].Value.ToString()),
                                                 int.Parse(r.Cells[1].Value.ToString()),
                                                 1);
                    dtpThoiGian.Value = temp;
                    txtTongDoanhThu.Text = r.Cells[3].Value.ToString();
                    dgvKetQua.DataSource = bll_rieng.Select(txtMaBaoCao.Text);
                }

            }
            catch { }
        }

        private void dgvKetQua_SelectionChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch { }
        }

        private void ClearInputs()
        {
            txtMaBaoCao.Text = string.Empty;
            dtpThoiGian.Value = DateTime.Today;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            //ClearDataGridView(dgvTim);
            if (cbbTim.Text == "Ngày tháng")
            {
                dgvTim.DataSource = bll_chung.SearchNgayThang(dtpTimTuNgay.Value.Month,
                                                            dtpTimDenNgay.Value.Month,
                                                            dtpTimTuNgay.Value.Year,
                                                            dtpTimDenNgay.Value.Year);
            }
            ClearInputs();
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            ClearDataGridView(dgvTim);
            if (txtTim.Text.Trim() == "")
            {
                dgvTim.DataSource = bll_chung.Select();
                ClearInputs();
            }
            else
            {
                if (cbbTim.Text == "Mã báo cáo")
                {
                    dgvTim.DataSource = bll_chung.SearchMaBC(txtTim.Text);
                }
            }
            ClearInputs();
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

        private void btnXuatKetQua_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}