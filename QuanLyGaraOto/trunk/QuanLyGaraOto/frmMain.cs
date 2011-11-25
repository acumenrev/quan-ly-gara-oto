using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Rendering;

namespace QuanLyGaraOto
{
    public partial class frmMain : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region Menu
        
        private void btnThoatCT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdChuDe_Executed(object sender, EventArgs e)
        {
            ICommandSource source = sender as ICommandSource;
            if (source.CommandParameter is string)
            {
                eStyle style = (eStyle)Enum.Parse(typeof(eStyle), source.CommandParameter.ToString());

                StyleManager.ChangeStyle(style, Color.Empty);
                if (style == eStyle.Office2007Blue || style == eStyle.Office2007Black ||
                    style == eStyle.Office2007Silver)
                {
                    btnStartButton.BackstageTabEnabled = false;
                }
                else
                {
                    btnStartButton.BackstageTabEnabled = true;
                }
            }
            
        }

        private void btnThongTinChuongTrinh_Click(object sender, EventArgs e)
        {
            frmThongTinChuongTrinh frm = new frmThongTinChuongTrinh();
            frm.ShowDialog();
        }
        #endregion

        #region Form Hệ thống
        private void txtSoXeToiDa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThayDoiMatKhau_Click(object sender, EventArgs e)
        {
            formHeThong.frmThayDoiMatKhau frm = new formHeThong.frmThayDoiMatKhau();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnSaoLuuDuLieu_Click(object sender, EventArgs e)
        {
            sfdSaoLuuCSDL.Filter = " Tập tin lưu trữ (*.bak)|*.bak| Tất cả (*.*) | *.*";
            sfdSaoLuuCSDL.Title = "Chọn đường dẫn để lưu tập tin";
            sfdSaoLuuCSDL.DefaultExt = "*.bak";
            if (sfdSaoLuuCSDL.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnThongTinNguoiSuDung_Click(object sender, EventArgs e)
        {
            formHeThong.frmThongTinNguoiSuDung frm = new formHeThong.frmThongTinNguoiSuDung();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnThietLapCSDL_Click(object sender, EventArgs e)
        {
            formHeThong.frmCauHinhLaiCSDL frm = new formHeThong.frmCauHinhLaiCSDL();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnPhucHoiDuLieu_Click(object sender, EventArgs e)
        {
            ofdPhucHoiCSDL.Filter = " Tập tin lưu trữ (*.bak)|*.bak| Tất cả (*.*) | *.*";
            ofdPhucHoiCSDL.Title = "Chọn đường dẫn tập tin cần phục hồi";
            ofdPhucHoiCSDL.DefaultExt = "*.bak";
            ofdPhucHoiCSDL.FileName = "";
            if (ofdPhucHoiCSDL.ShowDialog() == DialogResult)
            {

            }
        }
        #endregion

        #region Form Cơ sở dữ liệu

        private void btnXe_Click(object sender, EventArgs e)
        {
            formCSDL.frmXe frm = new formCSDL.frmXe();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnHieuXe_Click(object sender, EventArgs e)
        {
            formCSDL.frmHieuXe frm = new formCSDL.frmHieuXe();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnTienCong_Click(object sender, EventArgs e)
        {
            formCSDL.frmTienCong frm = new formCSDL.frmTienCong();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnVatTuPhuTung_Click(object sender, EventArgs e)
        {
            formCSDL.frmVatTuPhuTung frm = new formCSDL.frmVatTuPhuTung();
            frm.MdiParent = this;
            frm.Show();
        }


        #endregion

        #region Form Lập phiếu

        private void btnPhieuNhanXe_Click(object sender, EventArgs e)
        {
            formLapPhieu.frmPhieuNhanXe frm = new formLapPhieu.frmPhieuNhanXe();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnPhieuSuaChua_Click(object sender, EventArgs e)
        {
            formLapPhieu.frmPhieuSuaChua frm = new formLapPhieu.frmPhieuSuaChua();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnPhieuThuTien_Click(object sender, EventArgs e)
        {
            formLapPhieu.frmPhieuThuTien frm = new formLapPhieu.frmPhieuThuTien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnPhieuNhapVTPT_Click(object sender, EventArgs e)
        {
            formLapPhieu.frmPhieuNhapVTPT frm = new formLapPhieu.frmPhieuNhapVTPT();
            frm.MdiParent = this;
            frm.Show();
        }

        #endregion

        #region Form Báo cáo

        private void btnBaoCaoDoanhSo_Click(object sender, EventArgs e)
        {
            formBaoCao.frmBaoCaoDoanhSo frm = new formBaoCao.frmBaoCaoDoanhSo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnBaoCaoTon_Click(object sender, EventArgs e)
        {
            formBaoCao.frmBaoCaoTon frm = new formBaoCao.frmBaoCaoTon();
            frm.MdiParent = this;
            frm.Show();
        }

        #endregion



    }
}
