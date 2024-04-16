using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuongNKWindowsFormApp
{
    public partial class FormDangKy : Form
    {
        DBService dbService = new DBService();

        public FormDangKy()
        {
            InitializeComponent();
        }

        private void FormDangKy_Load(object sender, EventArgs e)
        {
            dbService.connect();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                string confirmPassword = txtConfirmPassword.Text;
                if (password == confirmPassword)
                {
                    if (username.Trim() == "")
                    {
                        MessageBox.Show("Bạn chưa nhập tên người dùng!", "Đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    if (password.Trim() == "")
                    {
                        MessageBox.Show("Bạn chưa nhập mật khẩu!", "Đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    bool res = dbService.register(username, password);
                    if (res)
                    {
                        FormDangNhap form = new FormDangNhap();
                        form.Show();
                        this.Close();
                    }
                    else
                    {
                        // ...
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu bạn nhập lại không khớp! Bạn vui lòng kiểm tra lại!", "Đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                    txtConfirmPassword.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thao tác không thực hiện được. Vui lòng kiểm tra lại!", "Đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormMenu form = new FormMenu();
            form.Show();
            this.Close();
        }

        private void FormDangKy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnOK.PerformClick();
            }
        }
    }
}
