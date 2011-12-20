using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;
using DAL;

namespace BLL
{
    public class BaoCaoDoanhSoBLL
    {
        #region Fields

        DAL.DataService dal;
        private SqlDataAdapter m_da;
        private SqlCommand m_cmd;
        private DataTable m_dt;
        private SqlConnection m_conn;

        #endregion

        #region Constructor
        
        public BaoCaoDoanhSoBLL()
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
        /// <param name="maBC">Mã báo cáo</param>
        /// <param name="thang">Tháng được báo cáo</param>
        /// <param name="nam">Năm được báo cáo</param>
        /// <param name="tongDoanhThu">Tổng doanh thu</param>
        public void Insert(string maBC, int thang, int nam, decimal tongDoanhThu)
        {
            try
            {
                // mở kết nối CSDL
                dal.OpenConnection(m_conn);
                // thiết lập thông số cho SqlCommand
                m_cmd = new SqlCommand("BaoCaoDoanhSo_Insert", m_conn);
                m_cmd.CommandType = CommandType.StoredProcedure;
                // các đối số 
                m_cmd.Parameters.Add("@MaBC", SqlDbType.Char).Value = maBC;
                m_cmd.Parameters.Add("@Thang", SqlDbType.Int).Value = thang;
                m_cmd.Parameters.Add("@Nam", SqlDbType.Int).Value = nam;
                m_cmd.Parameters.Add("@TongDoanhThu", SqlDbType.Decimal).Value = tongDoanhThu;
                // thực thi câu truy vấn
                m_cmd.ExecuteNonQuery();

            }
            catch { }
            finally
            {
                // đóng kết nối và xóa dữ liệu tạm
                dal.CloseConnection(m_conn);
                m_cmd.Dispose();
            }
        }

        /// <summary>
        /// Cập nhật record
        /// </summary>
        /// <param name="maBC">Mã báo cáo</param>
        /// <param name="thang">Tháng được báo cáo</param>
        /// <param name="nam">Năm được báo cáo</param>
        /// <param name="tongDoanhThu">Tổng doanh thu</param>
        public void Update(string maBC, int thang, int nam, decimal tongDoanhThu)
        {
            try
            {
                // mở kết nối CSDL
                dal.OpenConnection(m_conn);
                // thiết lập thông số cho SqlCommand
                m_cmd = new SqlCommand("BaoCaoDoanhSo_Update", m_conn);
                m_cmd.CommandType = CommandType.StoredProcedure;
                // các đối số 
                m_cmd.Parameters.Add("@MaBC", SqlDbType.Char).Value = maBC;
                m_cmd.Parameters.Add("@Thang", SqlDbType.Int).Value = thang;
                m_cmd.Parameters.Add("@Nam", SqlDbType.Int).Value = nam;
                m_cmd.Parameters.Add("@TongDoanhThu", SqlDbType.Decimal).Value = tongDoanhThu;
                // thực thi câu truy vấn
                m_cmd.ExecuteNonQuery();

            }
            catch { }
            finally
            {
                // đóng kết nối và xóa dữ liệu tạm
                dal.CloseConnection(m_conn);
                m_cmd.Dispose();
            }
        }

        /// <summary>
        /// Xóa record
        /// </summary>
        /// <param name="maBC">Mã báo cáo</param>
        public void Delete(string maBC)
        {
            try
            {
                // mở kết nối CSDL
                dal.OpenConnection(m_conn);
                // thiết lập thông số cho SqlCommand
                m_cmd = new SqlCommand("BaoCaoDoanhSo_Delete", m_conn);
                m_cmd.CommandType = CommandType.StoredProcedure;
                // các đối số 
                m_cmd.Parameters.Add("@MaBC", SqlDbType.Char).Value = maBC;
                // thực thi câu truy vấn
                m_cmd.ExecuteNonQuery();

            }
            catch { }
            finally
            {
                dal.CloseConnection(m_conn);
                m_cmd.Dispose();
            }
        }

        /// <summary>
        /// Truy vấn bảng
        /// </summary>
        /// <returns></returns>
        public DataTable Select()
        {
            // truy vấn tới bảng dữ liệu
            m_da = dal.CreateAdapter("BaoCaoDoanhSo_Select", m_conn);
            m_da.Fill(m_dt);
            return m_dt;
        }

        /// <summary>
        /// Tìm theo mã báo cáo
        /// </summary>
        /// <param name="noiDungTimKiem"></param>
        /// <returns></returns>
        public DataTable SearchMaBC(string noiDungTimKiem)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            // thiết lập thông số SqlCommand
            m_cmd = new SqlCommand("BaoCaoDoanhSo_SearchMaBC", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;

            m_cmd.Parameters.Add("@NoiDungTimKiem", SqlDbType.VarChar).Value = noiDungTimKiem;
            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);

            return dt;
        }

        /// <summary>
        /// Tìm theo ngày tháng
        /// </summary>
        /// <param name="thangTu"></param>
        /// <param name="thangDen"></param>
        /// <param name="namTu"></param>
        /// <param name="namDen"></param>
        /// <returns></returns>
        public DataTable SearchNgayThang(int thangTu, int thangDen,
                                        int namTu, int namDen)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            // thiết lập thông số SqlCommand
            m_cmd = new SqlCommand("BaoCaoDoanhSo_SearchNgayThang", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;

            m_cmd.Parameters.Add("@TuThang", SqlDbType.Int).Value = thangTu;
            m_cmd.Parameters.Add("@DenThang", SqlDbType.Int).Value = thangDen;
            m_cmd.Parameters.Add("@TuNam", SqlDbType.Int).Value = namTu;
            m_cmd.Parameters.Add("@DenNam", SqlDbType.Int).Value = namDen;

            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);

            return dt;
        }

        #endregion
    }
}
