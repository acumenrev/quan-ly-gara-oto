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
    public class CT_PhieuNhapVTPTBLL
    {
        #region Fields

        DAL.DataService dal;
        private SqlDataAdapter m_da;
        private SqlCommand m_cmd;
        private DataTable m_dt;
        private SqlConnection m_conn;

        #endregion

        #region Constructor
        
        public CT_PhieuNhapVTPTBLL()
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
        /// Chèn thêm record
        /// </summary>
        /// <param name="maBC"></param>
        /// <param name="thang"></param>
        /// <param name="nam"></param>
        /// <param name="tongDoanhThu"></param>
        public void Insert(string maPN, string maVTPT, int soLuongNhap,decimal donGiaNhap)
        {
            try
            {
                // mở kết nối CSDL
                dal.OpenConnection(m_conn);
                // thiết lập thông số cho SqlCommand
                m_cmd = new SqlCommand("CT_PhieuNhapVTPT_Insert", m_conn);
                m_cmd.CommandType = CommandType.StoredProcedure;
                // các đối số 
                m_cmd.Parameters.Add("@MaPN", SqlDbType.Char).Value = maPN;
                m_cmd.Parameters.Add("@MaVTPT", SqlDbType.Char).Value = maVTPT;
                m_cmd.Parameters.Add("@SoLuongNhap", SqlDbType.Int).Value = soLuongNhap;
                m_cmd.Parameters.Add("@DonGiaNhap", SqlDbType.Decimal).Value = donGiaNhap;
                // thực thi câu truy vấn
                m_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                m_dt.Dispose();
                // đóng kết nối và xóa dữ liệu tạm
                dal.CloseConnection(m_conn);
            }
        }

        /// <summary>
        /// Cập nhật record
        /// </summary>
        /// <param name="maBC"></param>
        /// <param name="thang"></param>
        /// <param name="nam"></param>
        /// <param name="tongDoanhThu"></param>
        public void Update(string maPN, string maVTPT, int soLuongNhap, decimal donGiaNhap)
        {
            try
            {
                // mở kết nối CSDL
                dal.OpenConnection(m_conn);
                // thiết lập thông số cho SqlCommand
                m_cmd = new SqlCommand("CT_PhieuNhapVTPT_Update", m_conn);
                m_cmd.CommandType = CommandType.StoredProcedure;
                // các đối số 
                m_cmd.Parameters.Add("@MaPN", SqlDbType.Char).Value = maPN;
                m_cmd.Parameters.Add("@MaVTPT", SqlDbType.Char).Value = maVTPT;
                m_cmd.Parameters.Add("@SoLuongNhap", SqlDbType.Int).Value = soLuongNhap;
                m_cmd.Parameters.Add("@DonGiaNhap", SqlDbType.Decimal).Value = donGiaNhap;
                // thực thi câu truy vấn
                m_cmd.ExecuteNonQuery();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                m_dt.Dispose();
                // đóng kết nối và xóa dữ liệu tạm
                dal.CloseConnection(m_conn);
            }
        }

        /// <summary>
        /// Xóa record trong bảng
        /// </summary>
        /// <param name="maBC"></param>
        public void Delete(string maPN, string maVTPT)
        {
            try
            {
                // mở kết nối CSDL
                dal.OpenConnection(m_conn);
                // thiết lập thông số cho SqlCommand
                m_cmd = new SqlCommand("CT_PhieuNhapVTPT_Delete", m_conn);
                m_cmd.CommandType = CommandType.StoredProcedure;
                // các đối số 
                m_cmd.Parameters.Add("@MaPN", SqlDbType.Char).Value = maPN;
                m_cmd.Parameters.Add("@MaVTPT", SqlDbType.Char).Value = maVTPT;

                // thực thi câu truy vấn
                m_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                m_dt.Dispose();
                // đóng kết nối và xóa dữ liệu tạm
                dal.CloseConnection(m_conn);
            }
        }

        /// <summary>
        /// Truy vấn các record
        /// </summary>
        /// <returns></returns>
        public DataTable Select(string maPN)
        {
            // truy vấn tới bảng dữ liệu
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            // thiết lập thông số SqlCommand
            m_cmd = new SqlCommand("CT_PhieuNhapVTPT_Select", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.Parameters.Add("@MaPN", SqlDbType.Char).Value = maPN;
            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Tìm mã vật tư phụ tùng
        /// </summary>
        /// <param name="noiDung"></param>
        /// <returns></returns>
        public DataTable SearchMaVTPT(string noiDung, string maPN)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            // thiết lập thông số SqlCommand
            m_cmd = new SqlCommand("CT_PhieuNhapVTPT_SearchMaVTPT", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.Parameters.Add("@NoiDungTimKiem", SqlDbType.NVarChar).Value = noiDung;
            m_cmd.Parameters.Add("@MaPN", SqlDbType.Char).Value = maPN;
            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);
            return dt;
        }

        #endregion
    }
}
