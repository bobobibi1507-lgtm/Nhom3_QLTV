using DevExpress.XtraPrinting;
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

    public partial class frmDMTG : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        BindingSource bsTG = new BindingSource();

        string sql, str;
        Boolean addnewFlag = false;

        public frmDMTG()
        {
            InitializeComponent();
            comTentrgTG.Items.Add("MaTG");
            comTentrgTG.Items.Add("TenTG");
            comTentrgTG.Items.Add("NamSinh");

        }

        private void frmDMTG_Load(object sender, EventArgs e)
        {
            str = "Data Source=LAPTOP-8EI4770R; Initial Catalog=CSDL_TV; Integrated Security=True";
            conn.ConnectionString = str;
            conn.Open();

            Naplaitg(); // nạp dữ liệu lần đầu

            grdTG.DataSource = bsTG; // DataGridView bind với BindingSource
            bdTG.BindingSource = bsTG; // BindingNavigator bind với BindingSource

            txtMaTG.DataBindings.Clear();
            txtMaTG.DataBindings.Add("Text", bsTG, "MaTG");
            txtTenTG.DataBindings.Clear();
            txtTenTG.DataBindings.Add("Text", bsTG, "TenTG");
            txtNamSinh.DataBindings.Clear();
            txtNamSinh.DataBindings.Add("Text", bsTG, "NamSinh");


        }


        public void NapCTtg()
        {
            if (grdTG.CurrentRow == null || grdTG.CurrentRow.IsNewRow)
            {
                ClearTextBoxes();
                return;
            }

            // Kiểm tra từng cell có giá trị không
            var row = grdTG.CurrentRow;
            txtMaTG.Text = row.Cells["MaTG"].Value != null ? row.Cells["MaTG"].Value.ToString().Trim() : "";
            txtTenTG.Text = row.Cells["TenTG"].Value != null ? row.Cells["TenTG"].Value.ToString().Trim() : "";
            txtNamSinh.Text = row.Cells["NamSinh"].Value != null ? row.Cells["NamSinh"].Value.ToString().Trim() : "";
        }

        private void btnThemTG_Click(object sender, EventArgs e)
        {
            addnewFlag = true;
            int i = grdTG.Rows.Count - 1;
            grdTG.CurrentCell = grdTG[0, i];
            NapCTtg();

            MessageBox.Show("Bạn có thể nhập thông tin tác giả mới");
            txtMaTG.Text = SinhMaTG(); // sinh mã và hiển thị
            txtTenTG.Text = "";
            txtNamSinh.Text = "";
            txtMaTG.Focus();

        }

        private void btnSuaTG_Click(object sender, EventArgs e)
        {
            if (grdTG.CurrentRow == null || grdTG.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Vui lòng chọn một tác giả để sửa!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            addnewFlag = false;
            txtMaTG.Enabled = false;
            // Điền dữ liệu vào các ô
            NapCTtg();

        }

        private void btnCapnhatTG_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtMaTG.Text))
            {
                MessageBox.Show("Mã tác giả không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaTG.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTenTG.Text))
            {
                MessageBox.Show("Tên tác giả không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenTG.Focus();
                return;
            }

            try
            {
                if (addnewFlag) // thêm mới
                {
                    string checkSql = "SELECT COUNT(*) FROM TacGia WHERE MaTG = @MaTG";
                    using (SqlCommand checkCmd = new SqlCommand(checkSql, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@MaTG", txtMaTG.Text);
                        int count = (int)checkCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Mã tác giả đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtMaTG.Focus();
                            return;
                        }
                    }

                    string sql = "INSERT INTO TacGia (MaTG, TenTG, NamSinh) VALUES (@MaTG, @TenTG, @NamSinh)";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaTG", txtMaTG.Text.Trim());
                        cmd.Parameters.AddWithValue("@TenTG", txtTenTG.Text.Trim());
                        cmd.Parameters.AddWithValue("@NamSinh", txtNamSinh.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Đã thêm tác giả mới!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else // cập nhật
                {
                    string sql = "UPDATE TacGia SET TenTG=@TenTG, NamSinh=@NamSinh WHERE MaTG=@MaTG";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaTG", txtMaTG.Text.Trim());
                        cmd.Parameters.AddWithValue("@TenTG", txtTenTG.Text.Trim());
                        cmd.Parameters.AddWithValue("@NamSinh", txtNamSinh.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Đã cập nhật thông tin tác giả!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Reload dữ liệu
                Naplaitg();

                // **Đặt BindingSource tới dòng vừa thao tác**
                bsTG.Position = bsTG.Find("MaTG", txtMaTG.Text);

                addnewFlag = false;
                txtMaTG.Enabled = true;
                // **Không gọi NapCTtg() nữa**, TextBox sẽ tự động cập nhật nhờ DataBindings
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnXoadmtg_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa tác giả này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE FROM TacGia WHERE MaTG = @MaTG";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaTG", txtMaTG.Text);
                cmd.ExecuteNonQuery();

                int i = grdTG.CurrentRow.Index;
                dt.Rows.RemoveAt(i); // Xóa khỏi DataTable
                NapCTtg(); // Nạp lại chi tiết nếu có
                MessageBox.Show("Đã xóa tác giả.");
            }

        }

        private void ClearTextBoxes()
        {
            txtMaTG.Clear();
            txtTenTG.Clear();
            txtNamSinh.Clear();
        }

        private string SinhMaTG()
        {
            string sql = "SELECT MAX(MaTG) FROM TacGia WHERE MaTG LIKE 'TG%'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            object result = cmd.ExecuteScalar();

            if (result == DBNull.Value || result == null)
                return "TG001";

            string maCu = result.ToString(); // ví dụ: TG029
            int so = int.Parse(maCu.Substring(2)); // lấy phần số: 29
            so++;
            return "TG" + so.ToString("D3"); // TG030
        }

        private void comTentrgTG_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = "select distinct " + comTentrgTG.Text + " from TacGia";
            da = new SqlDataAdapter(sql, conn);
            DataTable dt1 = new DataTable();
            da.Fill(dt1);
            comGTTG.DataSource = dt1;
            comGTTG.DisplayMember = comTentrgTG.Text;
            comGTTG.ValueMember = comTentrgTG.Text;

        }

        private void btnTimTG_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "select MaTG, TenTG, NamSinh  from TacGia" +
                    " where " + comTentrgTG.Text + "=N'" + comGTTG.Text + "'";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdTG.DataSource = dt;
                NapCTtg();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi cần xử lý" + ex.Message);
            }
        }

        private void btnNaplaiTG_Click(object sender, EventArgs e)
        {
            Naplaitg();
        }

        private void btnDongTG_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grdTG_SelectionChanged(object sender, EventArgs e)
        {
            if (grdTG.CurrentRow != null && !grdTG.CurrentRow.IsNewRow)
            {
                NapCTtg();
            }

        }

        public void Naplaitg()
        {
            try
            {
                sql = "SELECT MaTG, TenTG, NamSinh FROM TacGia";
                da = new SqlDataAdapter(sql, conn);
                DataTable dt1 = new DataTable();
                da.Fill(dt1);

                bsTG.DataSource = dt1; // cập nhật BindingSource
                if (bsTG.Count > 0)
                    NapCTtg();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi cần xử lý: " + ex.Message);
            }
        }



    }
}

    
