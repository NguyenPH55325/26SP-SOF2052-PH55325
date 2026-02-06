using DuAnMauC_.DAL;
using DuAnMauC_.DAO;
using System;
using System.Windows.Forms;

namespace DuAnMauC_
{
    public partial class FrmLogin : Form
    {
        public static TaiKhoan TaiKhoanDangNhap; // dùng toàn app

        public FrmLogin()
        {
            InitializeComponent();

            txtPass.UseSystemPasswordChar = true;
            this.AcceptButton = btnLogin;
            this.CancelButton = btnExit;

            chkShowPass.CheckedChanged += chkShowPass_CheckedChanged;
            btnLogin.Click += btnLogin_Click;
            btnExit.Click += btnExit_Click;
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = !chkShowPass.Checked;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // user: admin    ;   pw: 123 
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.Trim();
            string pass = txtPass.Text;

            // validate rỗng
            if (string.IsNullOrWhiteSpace(user))
            {
                MessageBox.Show("Vui lòng nhập tài khoản!");
                txtUser.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
                txtPass.Focus();
                return;
            }

            // check DB
            var tk = TaiKhoanDAL.DangNhap(user, pass);

            if (tk == null)
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");

                // 👉 UX chuẩn
                txtPass.Clear();
                txtPass.Focus();      // ⭐ focus vào mật khẩu
                txtPass.SelectAll();  // bôi đen nếu còn text

                return;
            }

            // login OK
            this.Hide();
            MainForm main = new MainForm();
            main.FormClosed += (_, __) => this.Close();
            main.Show();
        }

    }
}
