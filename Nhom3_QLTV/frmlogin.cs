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

namespace Nhom3_QLTV
{
    public partial class frmlogin : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-8EI4770R; Initial Catalog=CSDL_TV; Integrated Security=True");
        private frmMain mainForm;

        public frmlogin(frmMain form)
        {
            InitializeComponent();
            mainForm = form;
            txtusername.Focus();

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text.Trim();
            string password = txtpassword.Text.Trim();
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                conn.Open();
                string sql = "SELECT VaiTro FROM TaiKhoan WHERE TaiKhoan = @Username AND MatKhau = @Password";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    object roleObj = cmd.ExecuteScalar();
                    if (roleObj != null)
                    {
                        // Đăng nhập thành công
                        mainForm.IsAuthenticated = true;
                        mainForm.CurrentUser = username;
                        mainForm.CurrentRole = roleObj.ToString();
                        this.Close(); // đóng form login
                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally { conn.Close(); }
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }
    }
}

