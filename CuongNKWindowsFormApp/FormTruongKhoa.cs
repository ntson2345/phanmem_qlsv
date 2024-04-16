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
    public partial class FormTruongKhoa : Form
    {
        DBService dbService = new DBService();
        string table = "truongkhoa";

        public FormTruongKhoa()
        {
            InitializeComponent();
        }

        private void FormTruongKhoa_Load(object sender, EventArgs e)
        {
            dbService.connect();
            updateDgvAccounts();
        }

        private void updateDgvAccounts()
        {
            SqlDataAdapter dataAdapter = dbService.getAllAccounts(table);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dgvAccounts.DataSource = dataSet.Tables[0];
            dataSet.Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (username.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập tên tài khoản!", "Tạo tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (password.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu!", "Tạo tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dbService.createAccount(table, username, password);
            updateDgvAccounts();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (username.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập tên tài khoản!", "Cập nhật mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (password.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu!", "Cập nhật mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dbService.updatePassword(table, username, password);
            updateDgvAccounts();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (username.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập tên tài khoản!", "Xóa tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (password.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu!", "Xóa tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dbService.deleteAccount(table, username, password);
            updateDgvAccounts();
        }

        private void btnRetype_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAccounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtUsername.Text = dgvAccounts.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtPassword.Text = dgvAccounts.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
