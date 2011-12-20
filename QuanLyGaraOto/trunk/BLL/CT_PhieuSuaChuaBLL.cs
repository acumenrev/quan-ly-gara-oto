using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using DAL;

namespace BLL
{
    public class CT_PhieuSuaChuaBLL
    {
        #region Fields

        DAL.DataService dal;
        private SqlDataAdapter m_da;
        private SqlCommand m_cmd;
        private DataTable m_dt;
        private SqlConnection m_conn;

        #endregion

        #region Constructor
        
        public CT_PhieuSuaChuaBLL()
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
       /// Chén thêm record
       /// </summary>
        /// <param name="maPSC">Mã phiếu sửa chữa</param>
        /// <param name="noiDung">Nội dung sửa chữa</param>
        /// <param name="maVTPT">Mã vật tư phụ tùng</param>
        /// <param name="soLuong">Số lượng VTPT</param>
        /// <param name="donGia">Đơn giá</param>
        /// <param name="thanhTien">Thành tiền</param>
        public void Insert(string maPSC, string noiDung, string maVTPT, decimal tienCong,
                            int soLuong, decimal donGia, decimal thanhTien)
        {
            try
            {
                // mở kết nối CSDL
                dal.OpenConnection(m_conn);
                // thiết lập thông số cho SqlCommand
                m_cmd = new SqlCommand("CT_PhieuSuaChua_Insert", m_conn);
                m_cmd.CommandType = CommandType.StoredProcedure;
                // các đối số 
                m_cmd.Parameters.Add("@MaPSC", SqlDbType.Char).Value = maPSC;
                m_cmd.Parameters.Add("@NoiDung", SqlDbType.NVarChar).Value = noiDung;
                m_cmd.Parameters.Add("@TienCong", SqlDbType.Decimal).Value = tienCong;
                m_cmd.Parameters.Add("@MaVTPT", SqlDbType.Char).Value = maVTPT;
                m_cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = soLuong;
                m_cmd.Parameters.Add("@DonGia", SqlDbType.Decimal).Value = donGia;
                m_cmd.Parameters.Add("@ThanhTien", SqlDbType.Decimal).Value = thanhTien;
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
        /// <param name="maPSC">Mã phiếu sửa chữa</param>
        /// <param name="noiDung">Nội dung sửa chữa</param>
        /// <param name="maVTPT">Mã vật tư phụ tùng</param>
        /// <param name="soLuong">Số lượng VTPT</param>
        /// <param name="donGia">Đơn giá</param>
        /// <param name="thanhTien">Thành tiền</param>
        public void Update(string maPSC, string noiDung, string maVTPT, decimal tienCong,
                            int soLuong, decimal donGia, decimal thanhTien)
        {
            try
            {
                // mở kết nối CSDL
                dal.OpenConnection(m_conn);
                // thiết lập thông số cho SqlCommand
                m_cmd = new SqlCommand("CT_PhieuSuaChua_Update", m_conn);
                m_cmd.CommandType = CommandType.StoredProcedure;
                // các đối số 
                m_cmd.Parameters.Add("@MaPSC", SqlDbType.Char).Value = maPSC;
                m_cmd.Parameters.Add("@NoiDung", SqlDbType.NVarChar).Value = noiDung;
                m_cmd.Parameters.Add("@TienCong", SqlDbType.Decimal).Value = tienCong;
                m_cmd.Parameters.Add("@MaVTPT", SqlDbType.Char).Value = maVTPT;
                m_cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = soLuong;
                m_cmd.Parameters.Add("@DonGia", SqlDbType.Decimal).Value = donGia;
                m_cmd.Parameters.Add("@ThanhTien", SqlDbType.Decimal).Value = thanhTien;
                // thực thi câu truy vấn
                m_cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Bạn không thể thay dổi nội dung.\nNếu muốn thì hãy xóa đi dữ liệu này và tạo lại mới.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        /// Xóa record
        /// </summary>
        /// <param name="maPSC">Mã phiếu sửa chữa</param>
        /// <param name="noiDung">Nội dung sữa chữa</param>
        public void Delete(string maPSC, string noiDung)
        {
            try
            {
                // mở kết nối CSDL
                dal.OpenConnection(m_conn);
                // thiết lập thông số cho SqlCommand
                m_cmd = new SqlCommand("CT_PhieuSuaChua_Delete", m_conn);
                m_cmd.CommandType = CommandType.StoredProcedure;
                // các đối số 
                m_cmd.Parameters.Add("@MaPSC", SqlDbType.Char).Value = maPSC;
                m_cmd.Parameters.Add("@NoiDung", SqlDbType.NVarChar).Value = noiDung;
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
        /// <param name="maPSC">Mã phiếu sửa chữa</param>
        /// <returns></returns>
        public DataTable Select(string maPSC)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            // thiết lập thông số SqlCommand
            m_cmd = new SqlCommand("CT_PhieuSuaChua_Select", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;
            // đối số
            m_cmd.Parameters.Add("@MaPSC", SqlDbType.Char).Value = maPSC;
            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Tìm nội dung
        /// </summary>
        /// <param name="noiDungTimKiem"></param>
        /// <returns></returns>
        public DataTable SearchNoiDung(string noiDungTimKiem,string maPSC)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            // thiết lập thông số SqlCommand
            m_cmd = new SqlCommand("CT_PhieuSuaChua_SearchNoiDung", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;

            m_cmd.Parameters.Add("@NoiDungTimKiem", SqlDbType.VarChar).Value = noiDungTimKiem;
            m_cmd.Parameters.Add("@MaPSC", SqlDbType.Char).Value = maPSC;

            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);

            return dt;
        }

        /// <summary>
        /// Tìm mã VTPT
        /// </summary>
        /// <param name="noiDungTimKiem"></param>
        /// <returns></returns>
        public DataTable SearchMaVTPT(string noiDungTimKiem, string maPSC)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            // thiết lập thông số SqlCommand
            m_cmd = new SqlCommand("CT_PhieuSuaChua_SearchMaVTPT", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;

            m_cmd.Parameters.Add("@NoiDungTimKiem", SqlDbType.VarChar).Value = noiDungTimKiem;
            m_cmd.Parameters.Add("@MaPSC", SqlDbType.Char).Value = maPSC;

            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);

            return dt;
        }

        #endregion
    }
}
