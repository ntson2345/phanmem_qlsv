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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label2.Right >= groupBox1.ClientRectangle.Left)
                label2.Left = label2.Left - 10;
            else
                label2.Left = groupBox1.ClientRectangle.Right;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FormDangKy form = new FormDangKy();
            form.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormDangNhap form = new FormDangNhap();
            form.Show();
            this.Hide();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            string tt = "Phần mềm: QUẢN LÝ SINH VIÊN\n\n" +
                "Version: 1.1\n\n" +
                "Học phần thực tập:\n" +
                "Thực tập lập trình .NET\n\n" +
                "Copyright @ 2023\n" +
                "Designer: Nguyễn Kim Cương\n" +
                "Email: cuongnk@thinhtientech.com";
            MessageBox.Show(tt, "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Ban co muon thoat khong?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    MessageBox.Show("Cam on ban da su dung phan mem", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    Application.Exit();
            //}
            Application.Exit();
        }

        //private void Ts_Btn_admin_Click(object sender, EventArgs e)
        //{
        //    admin f = new admin();
        //    f.Show();
        //}

        //private void Ts_Btn_user_Click(object sender, EventArgs e)
        //{
        //    user f = new user();
        //    f.Show();
        //}

        //private void Ts_Btn_tt_sinhvien_Click(object sender, EventArgs e)
        //{
        //    Sinhvien f = new sinhvien();
        //    f.Show();
        //}

        //private void Ts_Btn_tt_giaovien_click(object sender, EventArgs e)
        //{
        //    giaovien f = new giaovien();
        //    f.Show();
        //}

        //private void Ts_Btn_tt_lop_CLick(object sender, EventArgs e)
        //{
        //    lop f = new lop();
        //    f.Show();
        //}

        //private void Ts_Btn_tt_khoa_CLick(object sender, EventArgs e)
        //{
        //    khoa f = new khoa();
        //    f.Show();
        //}

        //private void Ts_Btn_tt_monhoc_CLick(object sender, EventArgs e)
        //{
        //    monhoc f = new monhoc();
        //    f.Show();
        //}

        //private void Ts_Btn_tt_chinhsach_CLick(object sender, EventArgs e)
        //{
        //    chinhsach f = new chinhsach();
        //    f.Show();
        //}

        //private void Ts_Btn_tt_diem_CLick(object sender, EventArgs e)
        //{
        //    diem f = new diem();
        //    f.Show();
        //}

        //private void Ts_Btn_tk_sinhvien_CLick(object sender, EventArgs e)
        //{
        //    tk.sinhvien f = new tk_sinhvien();
        //    f.Show();
        //}

        //private void Ts_Btn_tk_giaovien_CLick(object sender, EventArgs e)
        //{
        //    tk.giaovien f = new tk_giaovien();
        //    f.Show();
        //}
        //private void Ts_Btn_tk_lop_CLick(object sender, EventArgs e)
        //{
        //    tk.lop f = new tk_lop();
        //    f.Show();
        //}

        //private void Ts_Btn_tk_khoa_CLick(object sender, EventArgs e)
        //{
        //    tk.khoa f = new tk_khoa();
        //    f.Show();
        //}

        //private void Ts_Btn_tk_monhoc_CLick(object sender, EventArgs e)
        //{
        //    tk.monhoc f = new tk_monhoc();
        //    f.Show();
        //}

        //private void Ts_Btn_tk_chinhsach_CLick(object sender, EventArgs e)
        //{
        //    tk.chinhsach f = new tk_chinhsach();
        //    f.Show();
        //}

        //private void Ts_Btn_ql_sinhvien_Click(Object sender, EventArgs e)
        //{
        //    cn_sinhvien f = new cn_sinhvien();
        //    f.Show();
        //}

        //private void Ts_Btn_ql_giaovien_Click(Object sender, EventArgs e)
        //{
        //    cn_giaovien f = new cn_giaovien();
        //    f.Show();
        //}

        //private void Ts_Btn_ql_lop_Click(Object sender, EventArgs e)
        //{
        //    cn_lop f = new cn_lop();
        //    f.Show();
        //}

        //private void Ts_Btn_ql_khoa_Click(Object sender, EventArgs e)
        //{
        //    cn_khoa f = new cn_khoa();
        //    f.Show();
        //}

        //private void Ts_Btn_ql_monhoc_Click(Object sender, EventArgs e)
        //{
        //    cn_monhoc f = new cn_monhoc();
        //    f.Show();
        //}

        //private void Ts_Btn_ql_chinhsach_Click(Object sender, EventArgs e)
        //{
        //    cn_chinhsach f = new cn_chinhsach();
        //    f.Show();
        //}

        //private void Ts_Btn_ql_diem_Click(Object sender, EventArgs e)
        //{
        //    cn_diem f = new cn_diem();
        //    f.Show();
        //}

        //Doan ma ve tien ich
        private void Ts_Btn_ti_paint_Click(Object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mspaint.exe");
        }

        private void Ts_Btn_ti_cmd_Click(Object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd.exe");
        }

        private void notepad_Click(Object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }

        private void Ts_Btn_ti_maytinh_Click(Object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void Ts_Btn_t1_word_click(Object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword.exe");
        }

        private void Ts_Btn_ht_capnhat_Click(Object sender, EventArgs e)
        {
            MessageBox.Show("Ban dang su dung phan mem moi nhat", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Ts_Btn_ht_baocao_Click(Object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Winword.exe");
        }

        //private void Timer2_Tick(Object sender, EventArgs e)
        //{
        //    time.Text = Date.Now.Hour + ": " + Date.Now.Minute + ": " + Date.Now.Second;
        //}

        //private void Ts_Btn_khoa_Click(Object sender, EventArgs e)
        //{
        //    Ts.Btn_dangnhap.Visible = True;
        //    Ts.Btn_admin.Visible = False;
        //    Ts.Btn_user.Visible = False;
        //    Ts.Btn_dangxuat.Visible = False;
        //    Ts.Btn_khoa.Visible = False;
        //    Ts.Btn_thongtin.Enable = False;
        //    Ts_Btn_timkiem.Enable = False;
        //    Ts_Btn_quanly.Enable = False;
        //    Ts_Btn_hienthi.Enable = False;
        //    Ts_Btn_tienich.Enable = False;
        //    Ts_Btn_ht_capnhat.Visible = False;
        //    Ts_capnhatdiem_Visible = False;
        //    Ts_gv.Visible = False;
        //    Ts_truongkhoa.Visible = False;
        //    //ĐổiMậtKhẩuToolStripMenuItem.Visible =False;
        //    khoamay f = new khoamay();
        //    f.Show();
        //}

        //private void Ts_Btn_dangnhap_Click(Object sender, EventArgs e)
        //{
        //    khoamay f = new khoamay();
        //    f.show();
        //}

        //private void Btn_ht_100_Click(Object sender, EventArgs e)
        //{
        //    this.Opacity = 0.45;
        //    dangnhap.Opacity = 0.45;
        //    dangky.Opacity = 0.45;
        //    khoamay.Opacity = 0.45;
        //    admin.Opacity = 0.45;
        //    user.Opacity = 0.45;
        //    sinhvien.Opacity = 0.45;
        //    giaovien.Opacity = 0.45;
        //    lop.Opacity = 0.45;
        //    khoa.Opacity = 0.45;
        //    monhoc.Opacity = 0.45;
        //    chinhsach.Opacity = 0.45;
        //    diem.Opacity = 0.45;

        //    cn_chinhsach.Opacity = 0.45;
        //    cn_diem.Opacity = 0.45;
        //    cn_giaovien.Opacity = 0.45;
        //    cn_khoa.Opacity = 0.45;
        //    cn_lop.Opacity = 0.45;
        //    cn_monhoc.Opacity = 0.45;
        //    cn_sinhvien.Opacity = 0.45;
        //    khoamay.Opacity = 0.45;
        //}

        //private void Btn_ht_50_Click(Object sender, EventArgs e)
        //{
        //    this.Opacity = 0.8;
        //    dangnhap.Opacity = 0.8;
        //    dangky.Opacity = 0.8;
        //    khoamay.Opacity = 0.8;
        //    admin.Opacity = 0.8;
        //    user.Opacity = 0.8;
        //    sinhvien.Opacity = 0.8;
        //    giaovien.Opacity = 0.8;
        //    lop.Opacity = 0.8;
        //    khoa.Opacity = 0.8;
        //    monhoc.Opacity = 0.8;
        //    chinhsach.Opacity = 0.8;
        //    diem.Opacity = 0.8;
        //    tk_gv.Opacity = 0.8;
        //    cn_chinhsach.Opacity = 0.8;
        //    cn_diem.Opacity = 0.8;
        //    cn_giaovien.Opacity = 0.8;
        //    cn_khoa.Opacity = 0.8;
        //    cn_lop.Opacity = 0.8;
        //    cn_monhoc.Opacity = 0.8;
        //    cn_sinhvien.Opacity = 0.8;
        //    khoamay.Opacity = 0.8;
        //}
    }
}
