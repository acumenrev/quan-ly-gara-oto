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
    public class VTPTBLL
    {
        #region Fields

        DAL.DataService dal;
        private SqlDataAdapter m_da;
        private SqlCommand m_cmd;
        private DataTable m_dt;
        private SqlConnection m_conn;

        #endregion

        #region Constructor
        
        public VTPTBLL()
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
       /// <param name="maVTPT">Mã vật tư phụ tùng</param>
       /// <param name="tenVTPT">Tên vật tư phụ tùng</param>
       /// <param name="soLuongTon">Số lượng tồn</param>
        /// <param name="donGiaBan">Đơn giá bán</param>
        /// <param name="donGiaNhap">Đơn giá nhập</param>
        public void Insert(string maVTPT, string tenVTPT, int soLuongTon, decimal donGiaNhap,                               decimal donGiaBan)
        {
            try
            {
                if (maVTPT.Trim() != "" && tenVTPT.Trim() != "" &&
                    soLuongTon.ToString().Trim() != "" && donGiaNhap.ToString().Trim() != "" &&
                    donGiaBan.ToString().Trim() != "")
                {
                    // mở kết nối CSDL
                    dal.OpenConnection(m_conn);
                    // thiết lập thông số cho SqlCommand
                    m_cmd = new SqlCommand("VTPT_Insert", m_conn);
                    m_cmd.CommandType = CommandType.StoredProcedure;
                    // các đối số 
                    m_cmd.Parameters.Add("@MaVTPT", SqlDbType.Char).Value = maVTPT;
                    m_cmd.Parameters.Add("@TenVTPT", SqlDbType.NVarChar).Value = tenVTPT;
                    m_cmd.Parameters.Add("@SoLuongTon", SqlDbType.Int).Value = soLuongTon;
                    m_cmd.Parameters.Add("@DonGiaNhap", SqlDbType.Decimal).Value = donGiaNhap;
                    m_cmd.Parameters.Add("@DonGiaBan", SqlDbType.Decimal).Value = donGiaBan;
                    // thực thi câu truy vấn
                    m_cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập một trong các thông tin cần thiết sau: mã vtpt, tên vtpt, số lượng tồn, đơn giá nhập, đơn giá bán.\nXin xem lại",
                                "Cảnh báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Mã vật tư phụ tùng bạn vừa nhập hiện đã có trong\n" +
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
        /// <param name="maVTPT">Mã vật tư phụ tùng</param>
        /// <param name="tenVTPT">Tên vật tư phụ tùng</param>
        /// <param name="soLuongTon">Số lượng tồn</param>
        /// <param name="donGia">Đơn giá</param>
        public void Update(string maVTPT, string tenVTPT, int soLuongTon, decimal donGiaNhap,                           decimal donGiaBan)
        {
            try
            {
                // mở kết nối CSDL
                dal.OpenConnection(m_conn);
                // thiết lập thông số cho SqlCommand
                m_cmd = new SqlCommand("VTPT_Update", m_conn);
                m_cmd.CommandType = CommandType.StoredProcedure;
                // các đối số 
                m_cmd.Parameters.Add("@MaVTPT", SqlDbType.Char).Value = maVTPT;
                m_cmd.Parameters.Add("@TenVTPT", SqlDbType.NVarChar).Value = tenVTPT;
                m_cmd.Parameters.Add("@SoLuongTon", SqlDbType.Int).Value = soLuongTon;
                m_cmd.Parameters.Add("@DonGiaNhap", SqlDbType.Decimal).Value = donGiaNhap;
                m_cmd.Parameters.Add("@DonGiaBan", SqlDbType.Decimal).Value = donGiaBan;
                // thực thi câu truy vấn
                m_cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Bạn không thể thay dổi mã vật tư phụ tùng.\nNếu muốn thì hãy xóa đi dữ liệu này và tạo lại mới.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        /// <param name="maVTPT">Mã vật tư phụ tùng</param>
        public void Delete(string maVTPT)
        {
            try
            {
                // mở kết nối CSDL
                dal.OpenConnection(m_conn);
                // thiết lập thông số cho SqlCommand
                m_cmd = new SqlCommand("VTPT_Delete", m_conn);
                m_cmd.CommandType = CommandType.StoredProcedure;
                // các đối số 
                m_cmd.Parameters.Add("@MaVTPT", SqlDbType.Char).Value = maVTPT;
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
                m_dt.Dispose();
                // đóng kết nối và xóa dữ liệu tạm
                dal.CloseConnection(m_conn);
            }
        }

        /// <summary>
        /// Truy vấn các record
        /// </summary>
        /// <returns></returns>
        public DataTable Select()
        {
            // truy vấn tới bảng dữ liệu
            m_da = dal.CreateAdapter("VTPT_Select", m_conn);
            m_da.Fill(m_dt);
            return m_dt;
        }

        public DataTable Select_SoLuong(string maVTPT)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = m_conn)
            {
                conn.Open();
                // thiêt lập thông số SqlCommand
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "VTPT_SelectSoLuong";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@MaVTPT", SqlDbType.Char).Value = maVTPT;
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        /// <summary>
        /// Tìm số lượng tồn
        /// </summary>
        /// <param name="tu"></param>
        /// <param name="den"></param>
        /// <returns></returns>
        public DataTable SearchSoLuongTon(int tu, int den)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            // thiết lập thông số cho SqlCommand
            m_cmd = new SqlCommand("VTPT_SearchSoLuongTon", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;

            m_cmd.Parameters.Add("@TonTu", SqlDbType.Int).Value = tu;
            m_cmd.Parameters.Add("@TonDen", SqlDbType.Int).Value = den;

            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);

            return dt;
        }

        /// <summary>
        /// Tìm kiếm giá nhập
        /// </summary>
        /// <param name="giaTu"></param>
        /// <param name="giaDen"></param>
        /// <returns></returns>
        public DataTable SearchDonGiaNhap(decimal giaTu, decimal giaDen)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            // thiết lập thông số cho SqlCommand
            m_cmd = new SqlCommand("VTPT_SearchDonGiaNhap", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;

            m_cmd.Parameters.Add("@TienTu", SqlDbType.Decimal).Value = giaTu;
            m_cmd.Parameters.Add("@DenTien", SqlDbType.Decimal).Value = giaDen;

            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);

            return dt;
        }

        /// <summary>
        /// Tìm kiếm giá bán
        /// </summary>
        /// <param name="giaTu"></param>
        /// <param name="giaDen"></param>
        /// <returns></returns>
        public DataTable SearchDonGiaBan(decimal giaTu, decimal giaDen)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            // thiết lập thông số cho SqlCommand
            m_cmd = new SqlCommand("VTPT_SearchDonGiaBan", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;

            m_cmd.Parameters.Add("@TienTu", SqlDbType.Decimal).Value = giaTu;
            m_cmd.Parameters.Add("@DenTien", SqlDbType.Decimal).Value = giaDen;

            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);

            return dt;
        }

        /// <summary>
        /// Tìm kiếm mã vtpt
        /// </summary>
        /// <param name="noiDungTimKiem">Mã vtpt</param>
        /// <returns></returns>
        public DataTable SearchMa(string noiDungTimKiem)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            // thiết lập thông số cho SqlCommand
            m_cmd = new SqlCommand("VTPT_SearchMa", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;

            m_cmd.Parameters.Add("@NoiDungTimKiem", SqlDbType.NVarChar).Value = noiDungTimKiem;

            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);

            return dt;
        }


        /// <summary>
        /// Tìm kiếm tên vtpt
        /// </summary>
        /// <param name="noiDungTimKiem">Tên vtpt</param>
        /// <returns></returns>
        public DataTable SearchTen(string noiDungTimKiem)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            // thiết lập thông số cho SqlCommand
            m_cmd = new SqlCommand("VTPT_SearchTen", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;

            m_cmd.Parameters.Add("@NoiDungTimKiem", SqlDbType.NVarChar).Value = noiDungTimKiem;

            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);

            return dt;
        }

        #endregion
    }
}
