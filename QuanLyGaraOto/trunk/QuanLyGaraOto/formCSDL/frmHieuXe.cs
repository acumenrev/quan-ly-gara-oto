using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Data.SqlClient;
using System.Data.Sql;
using BLL;
using DAL;

namespace QuanLyGaraOto.formCSDL
{
    public partial class frmHieuXe : DevComponents.DotNetBar.Office2007Form
    {
        #region Fields

        BLL.HieuXeBLL m_hieuXeBLL = new HieuXeBLL();
        DAL.DataService dal = new DataService();

        #endregion

        #region Constructor

        public frmHieuXe()
        {
            InitializeComponent();    
        }

        #endregion

        #region Methods

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtHieuXe.Text.Trim() != "")
            {
                m_hieuXeBLL.Insert(txtHieuXe.Text, txtGhiChu.Text);
                ClearDataGridView();
                frmHieuXe_Load(sender, e);
                ClearInput();
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập vào hiệu xe cần thêm.",
                                "Cảnh báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtHieuXe.Focus();
            }
        }

        private void frmHieuXe_Load(object sender, EventArgs e)
        {
            int rowCount = dgvTim.Rows.Count - 1;
            for (int i = 0; i < rowCount; i++)
            {
                dgvTim.Rows.Remove(dgvTim.CurrentRow);
            }
            dgvTim.DataSource = m_hieuXeBLL.Select();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtHieuXe.Text.Trim() != "")
            {
                m_hieuXeBLL.Update(txtHieuXe.Text, txtGhiChu.Text);
                ClearDataGridView();
                frmHieuXe_Load(sender, e);
                ClearInput();
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập vào hiệu xe cần sửa.",
                                "Cảnh báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtHieuXe.Focus();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtHieuXe.Text.Trim() != "")
            {
                m_hieuXeBLL.Delete(txtHieuXe.Text);
                ClearDataGridView();
                frmHieuXe_Load(sender, e);
                ClearInput();
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập vào hiệu xe cần xóa.",
                                "Cảnh báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtHieuXe.Focus();
            }
        }

        private void ClearInput()
        {
            txtHieuXe.Text = "";
            txtGhiChu.Text = "";
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            ClearDataGridView();
            if (txtTim.Text.Trim() == "")
            {
                dgvTim.DataSource = m_hieuXeBLL.Select();
                ClearInput();
            }
            else
            {
                dgvTim.DataSource = m_hieuXeBLL.Search(txtTim.Text);
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

        private void dgvTim_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvTim.SelectedRows.Count == 1)
                {
                    DataGridViewRow r = dgvTim.SelectedRows[0];
                    txtHieuXe.Text = r.Cells[0].Value.ToString();
                    txtGhiChu.Text = r.Cells[1].Value.ToString();
                }
            }
            catch{ }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}