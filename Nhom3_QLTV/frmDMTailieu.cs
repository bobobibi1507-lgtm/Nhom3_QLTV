using DevExpress.XtraEditors.TableLayout;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom3_QLTV
{
    public partial class frmDMTailieu : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter daCT = new SqlDataAdapter();
        SqlDataAdapter daDM= new SqlDataAdapter();
        DataTable dtDM = new DataTable();
        DataTable dtCT = new DataTable();
        DataTable dtgocDM = new DataTable();
        DataTable dtgocCT = new DataTable();
        string sql, str;
        BindingSource bsDM = new BindingSource();
        BindingSource bsCT = new BindingSource();

        public frmDMTailieu()
        {
            InitializeComponent();
        }

        private void frmDMTailieu_Load(object sender, EventArgs e)
        {
            str = "Data Source=LAPTOP-8EI4770R; " + "Initial Catalog=CSDL_TV;" + "Integrated Security=True";
            conn.ConnectionString = str;
            conn.Open();

            LoadDM();
            dscomTruong();
            LoadListTG();
            LoadTrangThai();

        }

        private void dscomTruong ()
        {
            comTruong.Items.Clear();
            comTruong.Items.Add("MaDMTL");
            comTruong.Items.Add("TenDMTL");
            comTruong.Items.Add("TenTheLoai");
            comTruong.Items.Add("TenTG");

        }

        private void LoadDM()
        {
            LoadLoaiTL();
            sql = "SELECT DMTL.MaDMTL, DMTL.TenDMTL,  DMTL.MaTheLoai, LoaiTL.TenTheLoai FROM DMTL, LoaiTL where DMTL.MaTheLoai = LoaiTL.MaTheLoai";
            daDM = new SqlDataAdapter(sql, conn);

            dtgocDM.Clear();
            daDM.Fill(dtgocDM);

            dtDM = dtgocDM.Copy();
            bsDM.DataSource = dtDM;
            dgvDMTL.DataSource = bsDM;
            bdDMTL.BindingSource = bsDM;

            dgvDMTL.SelectionChanged += dgvDMTL_SelectionChanged;

            // Load chi tiết lần đầu
            if (dgvDMTL.Rows.Count > 0)
            {
                dgvDMTL.CurrentCell = dgvDMTL.Rows[0].Cells[0]; // chọn ô đầu tiên
                LoadCT(dgvDMTL.Rows[0].Cells["MaDMTL"].Value.ToString());
                NapCT_DM(); // load dữ liệu lên các TextBox/ComboBox
            }
            cbMaDM.DataBindings.Clear();
            txtTenTL.DataBindings.Clear();
            cbLoaiTL.DataBindings.Clear();
            lbTG.DataBindings.Clear();

            cbMaDM.DataBindings.Add("selectedValue", bsDM, "MaDMTL");
            txtTenTL.DataBindings.Add("Text", bsDM, "TenDMTL");
            cbLoaiTL.DataBindings.Add("SelectedValue", bsDM, "MaTheLoai");
        }

        private void LoadLoaiTL()
        {
            sql = "SELECT * FROM LoaiTL";
            SqlDataAdapter daLoai = new SqlDataAdapter(sql, conn);
            DataTable dtLoai = new DataTable();
            daLoai.Fill(dtLoai);
            cbLoaiTL.DataSource = dtLoai;
            cbLoaiTL.DisplayMember = "TenTheLoai";
            cbLoaiTL.ValueMember = "MaTheLoai";
        }


        private void dgvDMTL_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDMTL.CurrentRow == null) return;

            string maDM = dgvDMTL.CurrentRow.Cells["MaDMTL"].Value.ToString();

                 // đưa dữ liệu vào khu nhập danh mục
            LoadCT(maDM);
            NapCT_DM();
        }


        private void LoadCT(string maDM)
        {
            dtgocCT.Clear();

            sql = "SELECT * FROM TaiLieu tl, TrangThai tt WHERE tl.MaDMTL = @MaDMTL and tl.MaTT = tt.MaTT";
            daCT = new SqlDataAdapter(sql, conn);
            daCT.SelectCommand.Parameters.AddWithValue("@MaDMTL", maDM);

            daCT.Fill(dtgocCT);

            dtCT = dtgocCT.Copy();
            bsCT.DataSource = dtCT;
            dgvCTTL.DataSource = bsCT;
            bdCTTL.BindingSource = bsCT;

            // chỉ gọi khi có dữ liệu
            if (dgvCTTL.Rows.Count > 0)
                NapCT_CT();
            else
            {
                txtMaTL.Text = "";
                cbTrangThai.Text = "";
            }

        }
        private void NapCT_CT()
        {
            if (dgvCTTL.CurrentRow == null)
            {
                txtMaTL.Text = "";
                cbTrangThai.Text = "";
                return;
            }

            var maTL = dgvCTTL.CurrentRow.Cells["MaTL"].Value;
            var trangThai = dgvCTTL.CurrentRow.Cells["TenTT"].Value;

            txtMaTL.Text = maTL != null ? maTL.ToString() : "";
            cbTrangThai.Text = trangThai != null ? trangThai.ToString() : "";

        }

        private void NapCT_DM()
        {
            if (dgvDMTL.CurrentRow == null) return;

            cbMaDM.Text = dgvDMTL.CurrentRow.Cells["MaDMTL"].Value.ToString();
            cbLoaiTL.SelectedValue = dgvDMTL.CurrentRow.Cells["MaTheLoai"].Value.ToString();
            txtTenTL.Text = dgvDMTL.CurrentRow.Cells["TenDMTL"].Value.ToString();

            LoadTG(cbMaDM.Text);
        }



        private void dgvDMTL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCTTL_SelectionChanged(object sender, EventArgs e)
        {
            NapCT_CT();
        }
        
        private void LoadTrangThai ()
        {
            string sql = "select MaTT, TenTT from TrangThai";
            SqlDataAdapter daTT = new SqlDataAdapter(sql, conn);
            DataTable dtTT = new DataTable();
            daTT.Fill(dtTT);

            cbTrangThai.DataSource = dtTT;
            cbTrangThai.DisplayMember = "TenTT";
            cbTrangThai.ValueMember = "MaTT";
            cbTrangThai.SelectedIndex = -1;

        }
        private void LoadTG (string chuoiTG)
        {
           
            sql = "select tg.MaTG, tg.TenTG from TacGia tg, DMTL_TG tl " +
                "where tg.MaTG = tl.MaTG and tl.MaDMTL = @MaDMTL";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@MaDMTL", chuoiTG);

            DataTable dtTG = new DataTable();
            da.Fill(dtTG);

            lbTG.DataSource = null;

            if (dtTG.Columns.Contains("MaTG") && dtTG.Rows.Count > 0)
            {
                lbTG.DataSource = dtTG;
                lbTG.DisplayMember = "TenTG";
                lbTG.ValueMember = "MaTG";
            }
            else
                lbTG.Items.Clear();
        }

        // Load danh sách tác giả vào combobox cbTacGia
        private void LoadListTG()
        {
            string sql = "SELECT MaTG, TenTG FROM TacGia";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cbChonTG.DataSource = dt;
            cbChonTG.DisplayMember = "TenTG"; // hiển thị tên tác giả
            cbChonTG.ValueMember = "MaTG";     // lấy MaTG khi thêm
        }


        private void cbLoaiTL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLoaiTL.SelectedIndex != -1)
            {
                string selectedMaCV = cbLoaiTL.SelectedValue.ToString();
            }
        }

        private void btnAddTG_Click(object sender, EventArgs e)
        {
            string maDMTL = cbMaDM.Text;
            string maTG = cbChonTG.SelectedValue.ToString();

            foreach (DataRowView row in lbTG.Items)
            {
                if (row["TenTG"].ToString() == cbChonTG.Text)
                {
                    MessageBox.Show("Tác giả đã tồn tại trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            sql = "INSERT INTO DMTL_TG (MaDMTL, MaTG) VALUES (@MaDMTL, @MaTG)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaDMTL", maDMTL);
            cmd.Parameters.AddWithValue("@MaTG", maTG);
            cmd.ExecuteNonQuery();

            LoadTG(maDMTL);
        }

        private void btnDelTG_Click(object sender, EventArgs e)
        {
            if (lbTG.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn tác giả để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                DataRowView selectRow = lbTG.SelectedItem as DataRowView;
                if (selectRow == null) return;

                string maDMTL = cbMaDM.Text;
                string maTG = lbTG.SelectedValue.ToString(); // bây giờ SelectedValue sẽ có MaTG

                sql = "DELETE FROM DMTL_TG WHERE MaDMTL=@MaDMTL AND MaTG=@MaTG";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaDMTL", maDMTL);
                cmd.Parameters.AddWithValue("@MaTG", maTG);
                cmd.ExecuteNonQuery();

                LoadTG(maDMTL);
            }
            
        }

        private void btnAddDM_Click(object sender, EventArgs e)
        {
            string newMaDM = "DM001";
            // Tạo mã danh mục tài liệu mới
            if (dtgocDM.Rows.Count > 0)
            {
                // Lấy mã danh mục tài liệu lớn nhất hiện có
                string lastMaDM = dtgocDM.AsEnumerable()
                    .Select(row => row.Field<string>("MaDMTL"))
                    .OrderByDescending(ma => ma)
                    .FirstOrDefault();
                // Tăng số cuối cùng lên 1 để tạo mã mới
                int number = int.Parse(lastMaDM.Substring(2)) + 1;
                newMaDM = "DM" + number.ToString("D3");
            }
            // Thêm danh mục tài liệu mới vào cơ sở dữ liệu
            string sqlInsert = "INSERT INTO DMTL(MaDMTL, TenDMTL, MaTheLoai) VALUES (@MaDMTL, @TenDMTL, @MaTheLoai)";
            SqlCommand cmdInsert = new SqlCommand(sqlInsert, conn);
            cmdInsert.Parameters.AddWithValue("@MaDMTL", newMaDM);
            cmdInsert.Parameters.AddWithValue("@TenDMTL", ""); // hoặc giá trị mặc định
            cmdInsert.Parameters.AddWithValue("@MaTheLoai", cbLoaiTL.SelectedValue.ToString());
            cmdInsert.ExecuteNonQuery();

            // Cập nhật lại DataTable gốc và BindingSource
            DataRow dataRow = dtgocDM.NewRow();
            dataRow["MaDMTL"] = newMaDM;
            dataRow["TenDMTL"] = "";
            dataRow["MaTheLoai"] = cbLoaiTL.SelectedValue.ToString();
            dtgocDM.Rows.Add(dataRow);

            dtDM = dtgocDM.Copy();
            bsDM.DataSource = dtDM;
            bsDM.Position = bsDM.Find("MaDMTL", newMaDM);
            // Cập nhật DataGridView và chi tiết
            dtCT.Clear();
            bsCT.DataSource = dtCT;
            dgvCTTL.DataSource = bsCT;
            // Chuyển đến dòng mới trong DataGridView
            NapCT_DM();
            NapCT_CT();

            MessageBox.Show("Nhập thông tin danh mục tài liệu mới, nhấn nút cập nhật và nhập chi tiết tài liệu!");
            cbMaDM.Focus();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                string trg = comTruong.Text;
                string gt = ComGT.Text.Trim();

                if (string.IsNullOrEmpty(gt))
                {
                    dtDM = dtgocDM.Copy();
                }
                else if (trg == "TenTG")
                {
                    // Lọc theo tác giả
                    dtDM = dtgocDM.Clone();
                    foreach (DataRow row in dtgocDM.Rows)
                    {
                        string maDMTL = row["MaDMTL"].ToString();

                        sql = @"SELECT COUNT(*) FROM DMTL_TG dtg
                        INNER JOIN TacGia tg ON dtg.MaTG = tg.MaTG
                        WHERE dtg.MaDMTL = @MaDMTL AND tg.TenTG LIKE @TenTG";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@MaDMTL", maDMTL);
                        cmd.Parameters.AddWithValue("@TenTG", "%" + gt + "%");

                        int count = (int)cmd.ExecuteScalar();
                        if (count > 0)
                            dtDM.Rows.Add(row.ItemArray);
                    }
                }
                else
                {
                    // Lọc theo các trường còn lại
                    dtDM = dtgocDM.Clone();
                    foreach (DataRow row in dtgocDM.Rows)
                    {
                        if (row[trg].ToString().Contains(gt))
                            dtDM.Rows.Add(row.ItemArray);
                    }
                }

                bsDM.DataSource = dtDM;
                dgvDMTL.DataSource = bsDM;
                NapCT_DM();
                NapCT_CT();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lọc dữ liệu: " + ex.Message);
            }
        }


        private void comTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string field = comTruong.Text;
            DataTable com = new DataTable();

            if (field == "TenTG")
            {
                // Lấy danh sách tác giả của tất cả DMTL
                sql = @"SELECT DISTINCT tg.TenTG 
                FROM TacGia tg
                INNER JOIN DMTL_TG dtg ON tg.MaTG = dtg.MaTG";
            }
            else
            {
                // Lấy các trường từ DMTL/LoaiTL
                sql = $@"SELECT DISTINCT dm.{field} 
                 FROM DMTL dm
                 INNER JOIN LoaiTL ltl ON dm.MaTheLoai = ltl.MaTheLoai";
            }

            daDM = new SqlDataAdapter(sql, conn);
            daDM.Fill(com);

            ComGT.DataSource = com;
            ComGT.DisplayMember = field;
            ComGT.ValueMember = field;
            ComGT.SelectedIndex = -1;
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                dtDM = dtgocDM.Copy();
                bsDM.DataSource = dtDM;
                dgvDMTL.DataSource = bsDM;
                NapCT_DM();
                NapCT_CT();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi làm mới dữ liệu: " + ex.Message);
            }
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddTL_Click(object sender, EventArgs e)
        {
            if(string .IsNullOrWhiteSpace(txtMaTL.Text))
            {
                MessageBox.Show("Nhập mã tài liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string maTLMoi = txtMaTL.Text.Trim();
            if (dtCT.Rows.Cast<DataRow>().Any(r => r["MaTL"].ToString() == maTLMoi))
            {
                MessageBox.Show("Mã tài liệu đã tồn tại trong danh sách chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // kiểm tra trùng trong csdl
            SqlCommand checkcmd = new SqlCommand("SELECT COUNT(*) FROM TaiLieu WHERE MaTL = @MaTL", conn);
            checkcmd.Parameters.AddWithValue("@MaTL", maTLMoi);
            int count = (int)checkcmd.ExecuteScalar();
            if (count > 0)
            {
                MessageBox.Show("Mã tài liệu đã tồn tại trong cơ sở dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            DataRow newrow = dtCT.NewRow();
            newrow["MaTL"] = txtMaTL.Text;
            newrow["MaTT"] = cbTrangThai.SelectedValue;
            newrow["TenTT"] = cbTrangThai.Text;
            dtCT.Rows.Add(newrow);

            bsCT.DataSource = dtCT;
            dgvCTTL.DataSource = bsCT;

            txtMaTL.Clear();
            cbTrangThai.SelectedIndex = -1;
            txtMaTL.Focus();


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string maDMTL = cbMaDM.Text;
            string tenDMTL = txtTenTL.Text;
            string maTheLoai = cbLoaiTL.SelectedValue.ToString();

            SqlCommand checkcmd = new SqlCommand("SELECT COUNT(*) FROM DMTL WHERE MaDMTL = @MaDMTL", conn);
            checkcmd.Parameters.AddWithValue("@MaDMTL", maDMTL);
            int count = (int)checkcmd.ExecuteScalar();

            if(count == 0)
            {
                SqlCommand cmdDM = new SqlCommand("INSERT INTO DMTL (MaDMTL, TenDMTL, MaTheLoai) VALUES (@MaDMTL, @TenDMTL, @MaTheLoai)", conn);
                cmdDM.Parameters.AddWithValue("@MaDMTL", maDMTL);
                cmdDM.Parameters.AddWithValue("@TenDMTL", tenDMTL);
                cmdDM.Parameters.AddWithValue("@MaTheLoai", maTheLoai);
                cmdDM.ExecuteNonQuery();
            }
            else
            {
                SqlCommand cmdDM = new SqlCommand("UPDATE DMTL SET TenDMTL = @TenDMTL, MaTheLoai = @MaTheLoai WHERE MaDMTL = @MaDMTL", conn);
                cmdDM.Parameters.AddWithValue("@MaDMTL", maDMTL);
                cmdDM.Parameters.AddWithValue("@TenDMTL", tenDMTL);
                cmdDM.Parameters.AddWithValue("@MaTheLoai", maTheLoai);
                cmdDM.ExecuteNonQuery();
            }

            // Cập nhật chi tiết tài liệu
            foreach(DataRow row in dtCT.Rows)
            {
                string maTL = row["MaTL"].ToString();
                string maTT = row["MaTT"].ToString();

                SqlCommand checkTLcmd = new SqlCommand("SELECT COUNT(*) FROM TaiLieu WHERE MaTL = @MaTL", conn);
                checkTLcmd.Parameters.AddWithValue("@MaTL", maTL);
                int tlCount = (int)checkTLcmd.ExecuteScalar();

                if (tlCount == 0)
                {
                    SqlCommand cmdTL = new SqlCommand("INSERT INTO TaiLieu (MaTL, MaDMTL, MaTT) VALUES (@MaTL, @MaDMTL, @MaTT)", conn);
                    cmdTL.Parameters.AddWithValue("@MaTL", maTL);
                    cmdTL.Parameters.AddWithValue("@MaDMTL", maDMTL);
                    cmdTL.Parameters.AddWithValue("@MaTT", maTT);
                    cmdTL.ExecuteNonQuery();
                }
                else
                {
                    SqlCommand cmdTL = new SqlCommand("UPDATE TaiLieu SET MaDMTL = @MaDMTL, MaTT = @MaTT WHERE MaTL = @MaTL", conn);
                    cmdTL.Parameters.AddWithValue("@MaTL", maTL);
                    cmdTL.Parameters.AddWithValue("@MaDMTL", maDMTL);
                    cmdTL.Parameters.AddWithValue("@MaTT", maTT);
                    cmdTL.ExecuteNonQuery();
                }
                }
            MessageBox.Show("Cập nhật danh mục tài liệu và chi tiết thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDM();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chỉnh sửa thông tin danh mục tài liệu và chi tiết trong các ô nhập liệu, sau đó nhấn nút Cập nhật để lưu thay đổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       private void btnDel_Click(object sender, EventArgs e)
{
    try
    {
        // ======= ƯU TIÊN XÓA DÒNG ĐANG CHỌN Ở CHI TIẾT (dgvCTTL) =======
        if (dgvCTTL.CurrentRow != null && dgvCTTL.CurrentRow.Index >= 0)
        {
            string maTL = dgvCTTL.CurrentRow.Cells["MaTL"].Value?.ToString();
            string maDMTL = cbMaDM.Text;

            if (string.IsNullOrEmpty(maTL))
            {
                MessageBox.Show("Không tìm thấy mã tài liệu để xóa.", "Lỗi");
                return;
            }

            if (MessageBox.Show($"Bạn có chắc muốn xóa tài liệu {maTL} ?",
                                "Xác nhận",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning) == DialogResult.No)
                return;

            // Xóa trong DB
            using (var cmd = new SqlCommand("DELETE FROM TaiLieu WHERE MaTL = @MaTL", conn))
            {
                cmd.Parameters.AddWithValue("@MaTL", maTL);
                cmd.ExecuteNonQuery();
            }

            // Xóa trong DataTable
            var row = dtCT.Rows.Cast<DataRow>()
                               .FirstOrDefault(r => r["MaTL"].ToString() == maTL);
            if (row != null) dtCT.Rows.Remove(row);

            LoadCT(maDMTL);   // cập nhật lại lưới CT

            MessageBox.Show("Đã xóa tài liệu.");
            return;
        }


        // ======= NẾU KHÔNG CHỌN CHI TIẾT → XÓA DANH MỤC (dgvDMTL) =======
        if (dgvDMTL.CurrentRow != null && dgvDMTL.CurrentRow.Index >= 0)
        {
            string maDMTL = dgvDMTL.CurrentRow.Cells["MaDMTL"].Value?.ToString();

            if (string.IsNullOrEmpty(maDMTL))
            {
                MessageBox.Show("Không tìm thấy mã danh mục để xóa.");
                return;
            }

            if (MessageBox.Show($"Xóa danh mục {maDMTL} ?",
                                "Xác nhận",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning) == DialogResult.No)
                return;

            // Xóa liên quan trước (tác giả, tài liệu)
            using (var tran = conn.BeginTransaction())
            {
                try
                {
                    using (var cmd1 = new SqlCommand(
                        "DELETE FROM DMTL_TG WHERE MaDMTL=@MaDMTL", conn, tran))
                    {
                        cmd1.Parameters.AddWithValue("@MaDMTL", maDMTL);
                        cmd1.ExecuteNonQuery();
                    }

                    using (var cmd2 = new SqlCommand(
                        "DELETE FROM TaiLieu WHERE MaDMTL=@MaDMTL", conn, tran))
                    {
                        cmd2.Parameters.AddWithValue("@MaDMTL", maDMTL);
                        cmd2.ExecuteNonQuery();
                    }

                    using (var cmd3 = new SqlCommand(
                        "DELETE FROM DMTL WHERE MaDMTL=@MaDMTL", conn, tran))
                    {
                        cmd3.Parameters.AddWithValue("@MaDMTL", maDMTL);
                        cmd3.ExecuteNonQuery();
                    }

                    tran.Commit();
                }
                catch
                {
                    tran.Rollback();
                    throw;
                }
            }

            LoadDM();
            MessageBox.Show("Đã xóa danh mục.");

            return;
        }


        // ======= KHÔNG CHỌN DÒNG NÀO =======
        MessageBox.Show("Hãy chọn dòng cần xóa.");
    }
    catch (Exception ex)
    {
        MessageBox.Show("Lỗi khi xóa: " + ex.Message);
    }
}

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Chỉnh sửa thông tin danh mục tài liệu và chi tiết trong các ô nhập liệu, sau đó nhấn nút Cập nhật để lưu thay đổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvCTTL.CurrentRow != null)
            {
                string maTL = dgvCTTL.CurrentRow.Cells["MaTL"].Value.ToString();

                DataRow row = dtCT.AsEnumerable()
                                   .FirstOrDefault(r => r.RowState != DataRowState.Deleted &&
                                                        r.Field<string>("MaTL") == maTL);
                if (row != null && cbTrangThai.SelectedValue != null)
                {
                    row["MaTT"] = cbTrangThai.SelectedValue;
                    row["TenTT"] = cbTrangThai.Text;
                }
            }
        }

        private void btnDongDG_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
