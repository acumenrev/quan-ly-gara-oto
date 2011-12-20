using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using DAL;

namespace BLL
{
    public class BaoCaoTonBLL
    {
        #region Fields

        DAL.DataService dal;
        private SqlDataAdapter m_da;
        private SqlCommand m_cmd;
        private DataTable m_dt;
        private SqlConnection m_conn;

        #endregion

        #region Constructor
        
        public BaoCaoTonBLL()
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
        /// <param name="thang">Tháng được báo cáo</param>
        /// <param name="nam">Năm được báo cáo</param>
        /// <param name="maVTPT">Mã vật tư phụ tùng</param>
        /// <param name="tonDau">Tồn đầu</param>
        /// <param name="phatSinh">Phát sinh</param>
        /// <param name="tonCuoi">Tồn cuối</param>
        public void Insert(int thang, int nam, string maVTPT, 
                            int tonDau, int phatSinh, int tonCuoi)
        {
            try
            {
                // mở kết nối CSDL
                dal.OpenConnection(m_conn);
                // thiết lập thông số cho SqlCommand
                m_cmd = new SqlCommand("BaoCaoTon_Insert", m_conn);
                m_cmd.CommandType = CommandType.StoredProcedure;
                // các đối số 
                m_cmd.Parameters.Add("@Thang", SqlDbType.Int).Value = thang;
                m_cmd.Parameters.Add("@Nam", SqlDbType.Int).Value = nam;
                m_cmd.Parameters.Add("@MaVTPT", SqlDbType.Char).Value = maVTPT;
                m_cmd.Parameters.Add("@TonDau", SqlDbType.Int).Value = tonDau;
                m_cmd.Parameters.Add("@PhatSinh", SqlDbType.Int).Value = phatSinh;
                m_cmd.Parameters.Add("@TonCuoi", SqlDbType.Int).Value = tonCuoi;
                // thực thi câu truy vấn
                m_cmd.ExecuteNonQuery();
            }
            catch { }
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
        /// <param name="thang">Tháng được báo cáo</param>
        /// <param name="nam">Năm được báo cáo</param>
        /// <param name="maVTPT">Mã vật tư phụ tùng</param>
        /// <param name="tonDau">Tồn đầu</param>
        /// <param name="phatSinh">Phát sinh</param>
        /// <param name="tonCuoi">Tồn cuối</param>
        public void Update(int thang, int nam, string maVTPT,
                            int tonDau, int phatSinh, int tonCuoi)
        {
            try
            {
                // mở kết nối CSDL
                dal.OpenConnection(m_conn);
                // thiết lập thông số cho SqlCommand
                m_cmd = new SqlCommand("BaoCaoTon_Update", m_conn);
                m_cmd.CommandType = CommandType.StoredProcedure;
                // các đối số 
                m_cmd.Parameters.Add("@Thang", SqlDbType.Int).Value = thang;
                m_cmd.Parameters.Add("@Nam", SqlDbType.Int).Value = nam;
                m_cmd.Parameters.Add("@MaVTPT", SqlDbType.Char).Value = maVTPT;
                m_cmd.Parameters.Add("@TonDau", SqlDbType.Int).Value = tonDau;
                m_cmd.Parameters.Add("@PhatSinh", SqlDbType.Int).Value = phatSinh;
                m_cmd.Parameters.Add("@TonCuoi", SqlDbType.Int).Value = tonCuoi;
                // thực thi câu truy vấn
                m_cmd.ExecuteNonQuery();
            }
            catch { }
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
        /// <param name="thang">Tháng được báo cáo</param>
        /// <param name="nam">Năm được báo cáo</param>
        /// <param name="maVTPT">Mã vật tư phụ tùng</param>
        public void Delete(int thang, int nam, string maVTPT)
        {
            try
            {
                // mở kết nối CSDL
                dal.OpenConnection(m_conn);
                // thiết lập thông số cho SqlCommand
                m_cmd = new SqlCommand("BaoCaoTon_Delete", m_conn);
                m_cmd.CommandType = CommandType.StoredProcedure;
                // các đối số 
                m_cmd.Parameters.Add("@Thang", SqlDbType.Int).Value = thang;
                m_cmd.Parameters.Add("@Nam", SqlDbType.Int).Value = nam;
                m_cmd.Parameters.Add("@MaVTPT", SqlDbType.Char).Value = maVTPT;
                // thực thi câu truy vấn
                m_cmd.ExecuteNonQuery();
            }
            catch { }
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
            m_da = dal.CreateAdapter("BaoCaoTon_Select", m_conn);
            m_da.Fill(m_dt);
            return m_dt;
        }

        public DataTable SearchMaVTPT(string noiDungTimKiem)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            // thiết lập thông số SqlCommand
            m_cmd = new SqlCommand("BaoCaoTon_SearchMaVTPT", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;

            m_cmd.Parameters.Add("@NoiDungTimKiem", SqlDbType.VarChar).Value = noiDungTimKiem;

            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);

            return dt;
        }

        public DataTable SearchNgayThang(int thangTu, int thangDen, int namTu, int namDen)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            // thiết lập thông số SqlCommand
            m_cmd = new SqlCommand("BaoCaoTon_SearchNgayThang", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;
            // các đối số
            m_cmd.Parameters.Add("@TuThang", SqlDbType.Int).Value = thangTu;
            m_cmd.Parameters.Add("@DenThang", SqlDbType.Int).Value = thangDen;
            m_cmd.Parameters.Add("@TuNam", SqlDbType.Int).Value = namTu;
            m_cmd.Parameters.Add("@DenNam", SqlDbType.Int).Value = namDen;
            // thực thi câu truy vấn
            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);
            return dt;
        }

        #endregion
    }
}
