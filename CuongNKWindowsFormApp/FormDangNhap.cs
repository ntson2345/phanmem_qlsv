using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuongNKWindowsFormApp
{
    public partial class FormDangNhap : Form
    {
        DBService dbService = new DBService();
        int attemptCount = 5;

        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            dbService.connect();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                if (username.Trim() == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên tài khoản!", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (password.Trim() == "")
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu!", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (attemptCount > 0)
                {
                    string res = dbService.login(username, password);
                    if (res == "admin")
                    {
                        FormAdmin form = new FormAdmin();
                        form.Show();
                        this.Close();
                        // ...
                    }
                    else if (res == "truongkhoa")
                    {
                        FormReadOnly form = new FormReadOnly();
                        form.Show();
                        this.Close();
                        // ...
                    }
                    else if (res == "gv")
                    {
                        FormReadOnly form = new FormReadOnly();
                        form.Show();
                        this.Close();
                        // ...
                    }
                    else if (res == "nguoidung")
                    {
                        FormReadOnly form = new FormReadOnly();
                        form.Show();
                        this.Close();
                    }
                    else if (res == "")
                    {
                        attemptCount--;
                        MessageBox.Show(
                            "Username hoặc password sai! Bạn còn " + attemptCount + " lần đăng nhập!",
                            "Đăng nhập",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                    else
                    {
                        MessageBox.Show(
                            "Table ngoại lệ!",
                            "Đăng nhập",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                }
                else
                {
                    MessageBox.Show("Đã hết lượt đăng nhập. Mời bạn truy cập lại!", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormMenu form = new FormMenu();
                    form.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra. Vui lòng kiểm tra lại!", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormMenu form = new FormMenu();
            form.Show();
            this.Close();
        }
    }
}
