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
    public partial class frmDMDG : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataTable dtgoc = new DataTable();
        string str, sql;
        BindingSource bs = new BindingSource();
        Boolean addnewflag = false;

        public frmDMDG()
        {
            InitializeComponent();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void lblNgaycap_Click(object sender, EventArgs e)
        {

        }

        private void comTentrgDG_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLuuDG_Click(object sender, EventArgs e)
        {

        }

        private void Naplai()
        {
            try
            {
                                dt = dtgoc.Copy();     // khôi phục hoàn toàn datasheet ban đầu

                bs.DataSource = dt;
                grdDMDG.DataSource = bs;
               
                NapCT();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nạp lại: " + ex.Message);
                return;
            }
        }

        private void btnTimDG_Click(object sender, EventArgs e)
        {
            try 
            {


                string col = comTentrgDG.Text;
                string val = comGTDG.Text;

                dt = dtgoc.Clone();   // tạo bảng rỗng nhưng giữ cột
                foreach (DataRow r in dtgoc.Select($"{col} = '{val}'"))
                dt.Rows.Add(r.ItemArray);

                bs.DataSource = dt;
                grdDMDG.DataSource = bs;
                NapCT();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
                return;
            }
        }

        private void btnNaplaiDG_Click(object sender, EventArgs e)
        {
            LoadData();
        }


        private void btnDongDG_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDMDG_Load(object sender, EventArgs e)
        {
            
            str = "Data Source=LAPTOP-8EI4770R; " + "Initial Catalog=CSDL_TV;" + "Integrated Security=True";
            conn.ConnectionString = str;
            conn.Open();
            sql = "SELECT dg.SoThe, dg.TenDG, dg.NgayCap, cv.MaCV, cv.TenCV FROM DOCGIA dg, ChucVu cv where dg.MaCV=cv.MaCV";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dtgoc);
            dt = dtgoc.Copy();                  // Sao chép dữ liệu từ dtgoc sang dt

            bs.DataSource = dt;                    // GÁN datasource vào BindingSource
            grdDMDG.DataSource = bs;               // Datagridview dùng BindingSource
            bindingnavDG.BindingSource = bs;
            // Đưa dữ liệu vào các điều khiển text, combobox
            txtSoThe.DataBindings.Add("Text", bs, "SoThe");
            txtTenDG.DataBindings.Add("Text", bs, "TenDG");
            dtpNgaycap.DataBindings.Add("Value", bs, "NgayCap");
            cbChucVu.DataBindings.Add("SelectedValue", bs, "MaCV");
            // Thêm các tiêu đề cột vào comTentrgDG
            comTentrgDG.Items.Add("SoThe");
            comTentrgDG.Items.Add("TenDG");
            comTentrgDG.Items.Add("NgayCap");
            comTentrgDG.Items.Add("TenCV");

            LoadCV();
            NapCT();
            
            
            
        }

        public void NapCT()
        {
            if (grdDMDG.CurrentRow == null)
                return;

            int i = grdDMDG.CurrentRow.Index;
            txtSoThe.Text = grdDMDG.Rows[i].Cells["SoThe"].Value.ToString();
            txtTenDG.Text = grdDMDG.Rows[i].Cells["TenDG"].Value.ToString();
            dtpNgaycap.Value = Convert.ToDateTime(grdDMDG.Rows[i].Cells["NgayCap"].Value);
            cbChucVu.SelectedValue = grdDMDG.Rows[i].Cells["MaCV"].Value.ToString();
        }

        private void LoadCV()
        {
            sql = "SELECT MaCV, TenCV FROM CHUCVU";
            DataTable dtCV = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
            {
                da.Fill(dtCV);
            }
            cbChucVu.DataSource = dtCV;
            cbChucVu.DisplayMember = "TenCV";
            cbChucVu.ValueMember = "MaCV";
            cbChucVu.SelectedIndex = -1;
        }

        private void grdDMDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
           
        }

        private void comTentrgDG_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comTentrgDG.SelectedIndex ==-1) return;
            string col = comTentrgDG.Text;
            sql = "select distinct " + col + " from DocGia dg, ChucVu cv where dg.MaCV=cv.MaCV";

            DataTable dt1 = new DataTable();
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt1);

            comGTDG.DataSource = dt1;
            comGTDG.DisplayMember=col;
            comGTDG.ValueMember = col;
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {

            string newSoThe = "DG0001";

            if (dt.Rows.Count > 0) {
                string lastSoThe = dt.Rows[dt.Rows.Count - 1]["SoThe"].ToString();
                // Tách phần chữ và phần số
                string tiento = lastSoThe.Substring(0, 2); // "DG"
                int number = int.Parse(lastSoThe.Substring(3)); // 0001 -> 1
                number++; // Tăng số lên 1
                newSoThe = tiento + number.ToString("D5"); // Định dạng lại với 5 chữ số, có thêm các số 0 ở đầu nếu cần
            }

            DataRow dataRow = dt.NewRow();
            dataRow["SoThe"] = newSoThe;
            dataRow["TenDG"] = "";
            dataRow["NgayCap"] = DateTime.Now;
            dataRow["MaCV"] = DBNull.Value;

            dt.Rows.Add(dataRow);

            int i = grdDMDG.Rows.Count - 1;
            grdDMDG.CurrentCell = grdDMDG[0, i];

            NapCT();

            MessageBox.Show("Nhập thông tin độc giả mới vào các ô text và nhấn nút cập nhật!");
            txtSoThe.Focus();
            addnewflag = true;

        }
        private void LoadData()
        {
            dtgoc.Clear();

            sql = "select dg.SoThe, dg.TenDG, dg.NgayCap, cv.MaCV, cv.TenCV FROM DOCGIA dg, ChucVu cv where dg.MaCV=cv.MaCV";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dtgoc);

            dt = dtgoc.Copy();
            bs.DataSource = dt;
            grdDMDG.DataSource = bs;

            NapCT();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSoThe.Text))
            {
                MessageBox.Show("Số thẻ không được để trống!");
                txtSoThe.Focus();
                return;
            }

            try
            {
                if (addnewflag)
                {
                    string checkSql = "SELECT COUNT(*) FROM DocGia WHERE SoThe = @SoThe";
                    SqlCommand checkCmd = new SqlCommand(checkSql, conn);
                    checkCmd.Parameters.AddWithValue("@SoThe", txtSoThe.Text);

                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Số thẻ này đã tồn tại. Vui lòng nhập số khác!",
                                        "Cảnh báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                        return;  // Dừng luôn, không cho insert
                    }
                    sql = @"INSERT INTO DocGia (SoThe, TenDG, NgayCap, MaCV) 
                    VALUES (@SoThe, @TenDG, @NgayCap, @MaCV)";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@SoThe", txtSoThe.Text);
                    cmd.Parameters.AddWithValue("@TenDG", txtTenDG.Text);
                    cmd.Parameters.Add("@NgayCap", SqlDbType.Date).Value = dtpNgaycap.Value;

                    if (cbChucVu.SelectedIndex == -1)
                        cmd.Parameters.Add("@MaCV", SqlDbType.VarChar).Value = DBNull.Value;
                    else
                        cmd.Parameters.Add("@MaCV", SqlDbType.VarChar).Value = cbChucVu.SelectedValue;

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Đã thêm độc giả mới");

                }
                else
                {
                    sql = @"UPDATE DocGia 
                    SET TenDG = @TenDG, NgayCap = @NgayCap, MaCV = @MaCV
                    WHERE SoThe = @SoThe";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@SoThe", txtSoThe.Text);
                    cmd.Parameters.AddWithValue("@TenDG", txtTenDG.Text);
                    cmd.Parameters.Add("@NgayCap", SqlDbType.Date).Value = dtpNgaycap.Value;
                    if (cbChucVu.SelectedIndex == -1)
                        cmd.Parameters.Add("@MaCV", SqlDbType.VarChar).Value = DBNull.Value;
                    else
                        cmd.Parameters.Add("@MaCV", SqlDbType.VarChar).Value = cbChucVu.SelectedValue;
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Đã cập nhật thông tin độc giả!");
                    else
                        MessageBox.Show("Không tìm thấy hàng hóa để cập nhật!");
                }
                LoadData();
                addnewflag = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu dữ liệu:" + ex.Message);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn xóa độc giả này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE FROM DocGia WHERE SoThe = @SoThe";
                SqlCommand cmd = new SqlCommand(sql, conn); // Tạo đối tượng SqlCommand
                cmd.Parameters.AddWithValue("@SoThe", txtSoThe.Text); // Thêm tham số
                cmd.ExecuteNonQuery(); // Thực thi lệnh xóa

                int i = grdDMDG.CurrentRow.Index;   
                dt.Rows.RemoveAt(i); // Xóa dòng khỏi DataTable
                NapCT();
                MessageBox.Show("Đã xóa độc giả.");
            }
        }

        private void cbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbChucVu.SelectedIndex != -1)
            {
                string selectedMaCV = cbChucVu.SelectedValue.ToString();
            }

        }


        
    }
}
