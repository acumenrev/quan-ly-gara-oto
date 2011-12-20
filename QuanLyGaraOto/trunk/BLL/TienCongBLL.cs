using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using DAL;
using System.Windows.Forms;

namespace BLL
{
    public class TienCongBLL
    {
        #region Fields

        DAL.DataService dal;
        private SqlDataAdapter m_da;
        private SqlCommand m_cmd;
        private DataTable m_dt;
        private SqlConnection m_conn;

        #endregion

        #region Constructor
        
        public TienCongBLL()
        {
            dal = new DataService();
            m_dt = new DataTable();
            m_cmd = new SqlCommand();
            m_da = new SqlDataAdapter();
            m_conn = dal.GetConnect();
        }
        
        #endregion

        #region Methods

       /// <summary>
       /// Thêm record
       /// </summary>
       /// <param name="noiDung">Nội dung</param>
       /// <param name="tienCong">Tiền công</param>
        public void Insert(string noiDung,decimal tienCong)
        {
            try
            {
                if (noiDung.Trim() != "" && tienCong.ToString().Trim() != "")
                {
                    // mở kết nối CSDL
                    dal.OpenConnection(m_conn);
                    // thiết lập thông số cho SqlCommand
                    m_cmd = new SqlCommand("TienCong_Insert", m_conn);
                    m_cmd.CommandType = CommandType.StoredProcedure;
                    // các đối số 
                    m_cmd.Parameters.Add("@NoiDung", SqlDbType.Char).Value = noiDung;
                    m_cmd.Parameters.Add("@TienCong", SqlDbType.Decimal).Value = tienCong;
                    // thực thi câu truy vấn
                    m_cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập những thông tin cần thiết.\nXin xem lại",
                                "Cảnh báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Nội dung tiền công bạn vừa nhập hiện đã có trong\n" +
                                "cơ sở dữ liệu.\nXin hãy xem lại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // đóng kết nối và xóa dữ liệu tạm
                dal.CloseConnection(m_conn);
                m_dt.Dispose();
            }
        }

        /// <summary>
        /// Cập nhật record
        /// </summary>
        /// <param name="noiDung">Nội dung</param>
        /// <param name="tienCong">Tiền công</param>
        public void Update(string noiDung, decimal tienCong)
        {
            try
            {
                if (noiDung.Trim() != "" && tienCong.ToString().Trim() != "")
                {
                    // mở kết nối CSDL
                    dal.OpenConnection(m_conn);
                    // thiết lập thông số cho SqlCommand
                    m_cmd = new SqlCommand("TienCong_Update", m_conn);
                    m_cmd.CommandType = CommandType.StoredProcedure;
                    // các đối số 
                    m_cmd.Parameters.Add("@NoiDung", SqlDbType.NVarChar).Value = noiDung;
                    m_cmd.Parameters.Add("@TienCong", SqlDbType.Decimal).Value = tienCong;
                    // thực thi câu truy vấn
                    m_cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập những thông tin cần thiết.\nXin xem lại",
                                "Cảnh báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Nội dung tiền công bạn vừa nhập hiện đã có trong\n" +
                                "cơ sở dữ liệu.\nXin hãy xem lại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Bạn chưa nhập nội dung tiền công.\nXin xem lại",
                                "Cảnh báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // đóng kết nối và xóa dữ liệu tạm
                dal.CloseConnection(m_conn);
                m_dt.Dispose();
            }
        }
        /// <summary>
        /// Xóa record
        /// </summary>
        /// <param name="noiDung">Nội dung</param>
        public void Delete(string noiDung)
        {
            try
            {
                // mở kết nối CSDL
                dal.OpenConnection(m_conn);
                // thiết lập thông số cho SqlCommand
                m_cmd = new SqlCommand("TienCong_Delete", m_conn);
                m_cmd.CommandType = CommandType.StoredProcedure;
                // các đối số 
                m_cmd.Parameters.Add("@NoiDung", SqlDbType.Char).Value = noiDung;
                // thực thi câu truy vấn
                m_cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Nội dung bạn đang xóa hiện đang có trong một hóa đơn hoặc báo cáo nên không thể xóa được.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // đóng kết nối và xóa dữ liệu tạm
                dal.CloseConnection(m_conn);
                m_dt.Dispose();
            }
        }

        /// <summary>
        /// Truy vấn các record
        /// </summary>
        /// <returns></returns>
        public DataTable Select()
        {
            // truy vấn tới bảng dữ liệu
            m_da = dal.CreateAdapter("TienCong_Select", m_conn);
            m_da.Fill(m_dt);
            return m_dt;
        }

        public DataTable SearchNoiDung(string noiDungTimKiem)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            // thiết lập thông số cho SqlCommand
            m_cmd = new SqlCommand("TienCong_SearchNoiDung", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;

            m_cmd.Parameters.Add("@NoiDungTimKiem", SqlDbType.NVarChar).Value = noiDungTimKiem;

            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);

            return dt;
        }

        public DataTable SearchSoTien(decimal tienTu, decimal denTien)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            // thiết lập thông số cho SqlCommand
            m_cmd = new SqlCommand("TienCong_SearchTienCong", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;

            m_cmd.Parameters.Add("@TienTu", SqlDbType.Decimal).Value = tienTu;
            m_cmd.Parameters.Add("@DenTien", SqlDbType.Decimal).Value = denTien;
            
            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);

            return dt;
        }

        #endregion
    }
}
