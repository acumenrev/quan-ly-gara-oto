using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Data.Sql;
using System.Xml;

using DevComponents.DotNetBar;

namespace QuanLyGaraOto
{
    public partial class frmServer : DevComponents.DotNetBar.Office2007Form
    {
        #region Fields

        private const int WM_NCLBUTTONDBLCLK = 0xA3;
        XmlTextWriter m_writer;
        public static string m_myDocumentsPath;
        public static string m_path;
        public static string m_pathWithFile;
        private XmlTextReader m_reader;
        #endregion

        #region Methods

        // Ngan khong cho phong to cua so khi bam doi chuot vao title bar
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCLBUTTONDBLCLK:
                    if (this.WindowState == FormWindowState.Maximized)
                    {
                        this.WindowState = FormWindowState.Normal;
                    }
                    return;
            }

            base.WndProc(ref m);
        }

        public frmServer()
        {
            InitializeComponent();
            // lay duong dan cua thu muc My documents
            m_myDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            m_path = Path.Combine(m_myDocumentsPath, "GaraOto");
            m_pathWithFile = m_path + "\\GaraOtoConfig.xml";
            ReadFile(m_pathWithFile);
            
            
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            string strThongDiep = "Bạn có chắc chắn với những thông số bạn đã thiết lập ?";

            DialogResult msgThongDiep = MessageBox.Show(strThongDiep, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (DialogResult.OK == msgThongDiep)
            {
                WriteFile();
                this.Hide();
                frmMain frm = new frmMain();
                frm.Show();
            }

        }

        private void frmServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void cbbQuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbQuyen.SelectedIndex == 0)
            {
                txtMatKhau.Enabled = false;
                txtTenTaiKhoan.Enabled = false;
            }
            else
            {
                txtMatKhau.Enabled = true;
                txtTenTaiKhoan.Enabled = true;
            }
        }

        private void frmServer_Load(object sender, EventArgs e)
        {
            cbbQuyen.SelectedIndex = 0;
            string myServer = Environment.MachineName;
            DataTable servers = SqlDataSourceEnumerator.Instance.GetDataSources();
            for (int i = 0; i < servers.Rows.Count; i++)
            {
                if (myServer == servers.Rows[i]["ServerName"].ToString())
                {
                    // lay ten server va instance cua server do
                    cbbServer.Items.Add(servers.Rows[i]["ServerName"] + "\\" +
                        servers.Rows[i]["InstanceName"]);
                }
                else
                {
                    // chi lay ten server1
                    cbbServer.Items.Add(servers.Rows[i]["ServerName"]);
                }
            }
        }

        // kiem tra thu muc da ton tai chua
        private bool IsFolderExists(string path)
        {
            try
            {
                return System.IO.Directory.Exists(path);
            }
            catch
            {
                return false;
            }
        }

        // kiem tra tap tin da ton tai chua
        private bool IsFileExist(string path)
        {
            try
            {
                return System.IO.File.Exists(path);
            }
            catch
            {
                return false;
            }
        }

        // ghi tap tin xml de luu cau hinh server
        private void WriteFile()
        {
            

            // neu thu muc chua ton tai thi tao thu muc voi duong dan path
            if (!IsFolderExists(m_path))
            {
                Directory.CreateDirectory(m_path);
            }
            
            m_writer = new XmlTextWriter(m_pathWithFile,null);
            // xac dinh khoang cach thut dong giua node cha va node con
            m_writer.Formatting = Formatting.Indented;
            m_writer.Indentation = 6;

            m_writer.WriteStartDocument();

            m_writer.WriteStartElement("", "Configuration", "");

            m_writer.WriteStartElement("", "Server", "");
            m_writer.WriteString(cbbServer.Text);
            m_writer.WriteEndElement();

            m_writer.WriteStartElement("", "Database", "");
            m_writer.WriteString(cbbCSDL.Text);
            m_writer.WriteEndElement();

            m_writer.WriteStartElement("", "Username", "");
            m_writer.WriteString(txtTenTaiKhoan.Text);
            m_writer.WriteEndElement();

            m_writer.WriteStartElement("", "Password", "");
            m_writer.WriteString(txtMatKhau.Text);
            m_writer.WriteEndElement();

            m_writer.WriteEndElement();

            m_writer.WriteEndDocument();

            m_writer.Flush();
            m_writer.Close();
        }

        private void ReadFile(string filePath)
        {
            m_reader = new XmlTextReader(filePath);
            if (File.Exists(filePath))
            {
                if (IsFileExist(filePath))
                {
                    while (m_reader.Read())
                    {
                        if (m_reader.NodeType == XmlNodeType.Element)
                        {
                            if (m_reader.LocalName.Equals("Server"))
                            {
                                cbbServer.Text = m_reader.ReadString();
                            }

                            if (m_reader.LocalName.Equals("Database"))
                            {
                                cbbCSDL.Text = m_reader.ReadString();
                            }

                            if (m_reader.LocalName.Equals("Username"))
                            {
                                txtTenTaiKhoan.Text = m_reader.ReadString();
                            }

                            if (m_reader.LocalName.Equals("Password"))
                            {
                                txtMatKhau.Text = m_reader.ReadString();
                            }
                        }
                    }
                }

                m_reader.Close();
            }
        }

        #endregion

        private void btnPhucHoiCSDL_Click(object sender, EventArgs e)
        {
            ofdPhucHoiCSDL.Filter = " Tập tin lưu trữ (*.bak)|*.bak| Tất cả (*.*) | *.*";
            ofdPhucHoiCSDL.Title = "Chọn đường dẫn tập tin cần phục hồi";
            ofdPhucHoiCSDL.DefaultExt = "*.bak";
            ofdPhucHoiCSDL.FileName = "";
            if (ofdPhucHoiCSDL.ShowDialog() == DialogResult)
            {

            }
        }

        private void cbbCSDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnKiemTraKetNoi_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbQuyen.SelectedIndex == 0)
                {
                    SqlConnection con = new SqlConnection("Data Source=" + cbbServer.Text + ";Initial Catalog=" + cbbCSDL.Text + ";Integrated Security=true");
                    try
                    {
                        con.Open();
                        MessageBox.Show("Kết nối thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                        {
                            con.Close();

                        }
                        con.Dispose();
                    }
                }
                if (cbbQuyen.SelectedIndex == 1)
                {
                    SqlConnection con = new SqlConnection("Data Source=" + cbbServer.Text + ";Initial Catalog=" + cbbCSDL.Text + ";User id=" + txtTenTaiKhoan.Text + ";Password=" + txtMatKhau.Text);
                    try
                    {
                        con.Open();

                        MessageBox.Show("Kết nối thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                        {
                            con.Close();
                        }
                        con.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbbServer_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Quyền Windows
            if (cbbQuyen.SelectedIndex == 0)
            {
                cbbCSDL.Items.Clear();
                SqlConnection con = new SqlConnection("Data Source=" + cbbServer.Text + ";Initial Catalog=" + cbbCSDL.Text + ";Integrated Security=true;");
                //Cau lenh SP_DATABASES cho phep liet ke het cac database co tren server
                SqlCommand cmd = new SqlCommand("SP_DATABASES", con);
                SqlDataReader reader;
                try
                {
                    con.Open();
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        cbbCSDL.Items.Add(reader[0].ToString());

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }

                    con.Dispose();
                    cmd.Dispose();
                }
            }

            if (cbbServer.SelectedIndex == 1)
            {
                try
                {
                    cbbCSDL.Items.Clear();
                    SqlConnection con = new SqlConnection("Data Source=" + cbbServer.Text + ";Initial Catalog=" + cbbCSDL.Text + ";User Id=" + txtTenTaiKhoan.Text + ";Password=" + txtMatKhau.Text + ";");
                    SqlCommand cmd = new SqlCommand("SP_DATABASES", con);
                    SqlDataReader reader;
                    try
                    {
                        con.Open();
                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            cbbCSDL.Items.Add(reader[0].ToString());
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                        {
                            con.Close();
                        }
                        con.Dispose();
                        cmd.Dispose();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbbServer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbbServer_SelectedIndexChanged(sender, e);
            }
        }
        
    }
}