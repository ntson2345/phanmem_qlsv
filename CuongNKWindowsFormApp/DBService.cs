using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuongNKWindowsFormApp
{
    public class DBService
    {
        private SqlConnection conn;

        public void connect()
        {
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString =
                    "Data Source=LAPTOP-S8OS8CFQ\\SQLEXPRESS;" +
                    "Initial Catalog=qlsv;" +
                    //"User ID=sa;" +
                    //"Password=sa;" +
                    "Integrated Security=True;";
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Chưa kết nối được, bạn kiểm tra lại tên server và tên cơ sở dữ liệu!",
                    "Kết nối",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                MessageBox.Show(ex.Message);
            }
        }

        public bool register(string username, string password)
        {
            try
            {
                string query1 = "SELECT COUNT(*) FROM nguoidung WHERE tk='" + username + "'";
                SqlCommand command1 = new SqlCommand(query1, conn);
                int i = (int)command1.ExecuteScalar();
                command1.Dispose();
                if (i != 0)
                {
                    MessageBox.Show(
                        "Tài khoản đã được đăng ký, vui lòng sử dụng tài khoản khác!",
                        "Đăng ký",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return false;
                }
                else
                {
                    string query2 = "INSERT INTO nguoidung VALUES ('" + username + "', '" + password + "')";
                    SqlCommand command2 = new SqlCommand(query2, conn);
                    command2.ExecuteNonQuery();
                    command2.Dispose();
                    MessageBox.Show(
                        "Đăng ký thành công. Bạn có muốn đăng nhập không?",
                        "Đăng ký",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation
                    );
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Thao tác không thực hiện được. Vui lòng kiểm tra lại!",
                    "Đăng ký",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public string login(string username, string password)
        {
            try
            {
                string query1 = "SELECT count(*) FROM admin WHERE tk = '" + username + "' AND mk = '" + password + "'";
                SqlCommand command1 = new SqlCommand(query1, conn);
                int admin = (int)command1.ExecuteScalar();
                command1.Dispose();

                string query2 = "SELECT count(*) FROM gv WHERE tk = '" + username + "' AND mk = '" + password + "'";
                SqlCommand command2 = new SqlCommand(query2, conn);
                int gv = (int)command2.ExecuteScalar();
                command2.Dispose();

                string query3 = "SELECT count(*) FROM nguoidung WHERE tk = '" + username + "' AND mk = '" + password + "'";
                SqlCommand command3 = new SqlCommand(query3, conn);
                int nguoidung = (int)command3.ExecuteScalar();
                command3.Dispose();

                string query4 = "SELECT count(*) FROM truongkhoa WHERE tk = '" + username + "' AND mk = '" + password + "'";
                SqlCommand command4 = new SqlCommand(query4, conn);
                int truongkhoa = (int)command4.ExecuteScalar();
                command4.Dispose();

                if (admin != 0)
                {
                    MessageBox.Show("Bạn đã đăng nhập vào tài khoản admin!", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return "admin";
                }
                else if (gv != 0)
                {
                    MessageBox.Show("Bạn đã đăng nhập vào tài khoản giáo viên!", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return "gv";
                }
                else if (nguoidung != 0)
                {
                    MessageBox.Show("Bạn đã đăng nhập vào tài khoản user!", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return "nguoidung";
                }
                else if (truongkhoa != 0)
                {
                    MessageBox.Show("Bạn đã đăng nhập vào tài khoản trưởng khoa!", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return "truongkhoa";
                }
                else
                {
                    return "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Thao tác không thực hiện được. Vui lòng kiểm tra lại!",
                    "Đăng nhập",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                MessageBox.Show(ex.Message);
                return "error";
            }
        }

        public SqlDataAdapter getAllAccounts(string table)
        {
            try
            {
                string query = "SELECT tk, mk FROM " + table;
                DataSet dataSet = new DataSet();
                return new SqlDataAdapter(query, conn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Thao tác không thực hiện được. Vui lòng kiểm tra lại!",
                    "Lấy danh sách tài khoản",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public bool createAccount(string table, string username, string password)
        {
            try
            {
                string query = "INSERT INTO " + table + " VALUES ('" + username + "', '" + password + "')";
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
                command.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Dữ liệu đã tồn tại! Bạn vui lòng nhập tài khoản khác!",
                    "Tạo tài khoản",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool updatePassword(string table, string username, string password)
        {
            try
            {
                string query = "UPDATE " + table + " SET mk = '" + password + "' WHERE tk = '" + username + "'";
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
                command.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không tìm thấy tài khoản cần cập nhật!",
                    "Cập nhật mật khẩu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool deleteAccount(string table, string username, string password)
        {
            try
            {
                string query = "DELETE FROM " + table + " WHERE tk = '" + username + "' AND mk = '" + password + "'";
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
                command.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không tìm thấy tài khoản cần xóa!",
                    "Xóa tài khoản",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
