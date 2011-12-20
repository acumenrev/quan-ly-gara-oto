using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.IO;
using DevComponents.DotNetBar.Rendering;
using BLL;
using DAL;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Xml;

namespace QuanLyGaraOto
{
    public partial class frmMain : DevComponents.DotNetBar.Office2007RibbonForm
    {
        #region Fields

        DataService dal;
        SqlCommand m_cmd;
        SqlConnection m_conn;
        XmlReader m_reader;
        string m_server;
        public static string m_myDocumentsPath;
        public static string m_path;
        public static string m_pathWithFile;

        #endregion

        #region Constructor
        
        public frmMain()
        {
            InitializeComponent();
            dal = new DataService();
            m_conn = dal.GetConnect();
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            m_myDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            m_path = Path.Combine(m_myDocumentsPath, "GaraOto");
           
            m_pathWithFile = m_path + "\\GaraOtoConfig.xml";
            ReadFile(m_pathWithFile);
        }

        #endregion

        #region Menu

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        

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

        private void btnSaoLuuDuLieu_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Bạn không được lưu trên ổ đĩa được dùng để cài     Windows.\nBấm OK để tiếp tục.", 
                                "Lưu ý", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Information);
                sfdSaoLuuCSDL.Filter = " Tập tin lưu trữ (*.bak)|*.bak| Tất cả (*.*) | *.*";
                sfdSaoLuuCSDL.Title = "Chọn đường dẫn để lưu tập tin";
                sfdSaoLuuCSDL.FileName = "";
                sfdSaoLuuCSDL.DefaultExt = "*.bak";
                
                if (sfdSaoLuuCSDL.ShowDialog() == DialogResult.OK)
                {
                    dal.OpenConnection(m_conn);
                    m_cmd = new SqlCommand("BackupCSDL", m_conn);
                    m_cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    m_cmd.Parameters.Add("@TenDB", SqlDbType.VarChar).Value = m_server;
                    m_cmd.Parameters.Add("@DuongDan", SqlDbType.VarChar).Value = sfdSaoLuuCSDL.FileName;

                    m_cmd.ExecuteNonQuery();

                    MessageBox.Show("Đã sao lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dal.CloseConnection(m_conn);
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

        /// <summary>
        /// Lấy tên CSDL
        /// </summary>
        private string LayTenDatabase(string path)
        {
            string tenDB = "";
            char[] arr = path.ToCharArray();
            int pos = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == '\\')
                {
                    pos = i;
                }
            }
            int viTriBatDau = pos + 1;
            int viTriKetThuc = path.Length;
            int soLuong = viTriKetThuc - pos;
            int soLuongCanLay = soLuong - 5;
            tenDB = path.Substring(viTriBatDau, soLuongCanLay);
            return tenDB;
        }

        private void btnPhucHoiDuLieu_Click(object sender, EventArgs e)
        {
            try
            {
                ofdPhucHoiCSDL.Filter = " Tập tin lưu trữ (*.bak)|*.bak| Tất cả (*.*) | *.*";
                ofdPhucHoiCSDL.Title = "Chọn đường dẫn tập tin cần phục hồi";
                ofdPhucHoiCSDL.DefaultExt = "*.bak";
                ofdPhucHoiCSDL.FileName = "";
                if (ofdPhucHoiCSDL.ShowDialog() == DialogResult.OK)
                {
                    string thongBao = "Cơ sở dữ liệu mới sẽ có tên trùng với tên file .bak.\n" +
                                      "mà bạn vừa mới chọn. Bạn có muốn tiếp tục không ?";
                    DialogResult msgBox = MessageBox.Show(thongBao, "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                    if (DialogResult.Yes == msgBox)
                    {
                        // thiết lập thông số cho SqlCommand
                        dal.OpenConnection(m_conn);
                        m_cmd = new SqlCommand("RestoreCSDL", m_conn);
                        m_cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        // các đối số
                        m_cmd.Parameters.Add("@TenDB", SqlDbType.VarChar).Value = LayTenDatabase(ofdPhucHoiCSDL.FileName);
                        m_cmd.Parameters.Add("@DuongDan", SqlDbType.VarChar).Value = ofdPhucHoiCSDL.FileName;
                        m_cmd.ExecuteNonQuery();
                        MessageBox.Show("Đã phục hồi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dal.CloseConnection(m_conn);
            }
        }

        /// <summary>
        /// Đọc file XML
        /// </summary>
        /// <param name="filePath">Đường dẫn đến file</param>
        private void ReadFile(string filePath)
        {
            m_reader = new XmlTextReader(filePath);
            if (File.Exists(filePath))
            {
                if (File.Exists(filePath))
                {
                    while (m_reader.Read())
                    {
                        if (m_reader.NodeType == XmlNodeType.Element)
                        {
                            if (m_reader.LocalName.Equals("Database"))
                            {
                                m_server = m_reader.ReadString();
                            }
                        }
                    }
                }
                m_reader.Close();
            }
        }

        private void btnQuyDinh_Click(object sender, EventArgs e)
        {
            formHeThong.frmQuyDinh frm = new formHeThong.frmQuyDinh();
            frm.MdiParent = this;
            frm.Show();
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
