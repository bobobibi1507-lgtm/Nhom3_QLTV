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
    public partial class frmNhapPM : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter daPM = new SqlDataAdapter();
        SqlDataAdapter daCTPM = new SqlDataAdapter();
        DataTable dtPM = new DataTable();
        DataTable dtCTPM = new DataTable();
        DataTable dtgocPM = new DataTable();
        DataTable dtgocCTPM = new DataTable();
        string sql, str;
        BindingSource bsPM = new BindingSource();
        BindingSource bsCTPM = new BindingSource();

        public frmNhapPM()
        {
            InitializeComponent();
        }

        private void frmNhapPM_Load(object sender, EventArgs e)
        {
            str = "Data Source=LAPTOP-8EI4770R; " + "Initial Catalog=CSDL_TV;" + "Integrated Security=True";
            conn.ConnectionString = str;
            conn.Open();
            LoadPM();
            dscomTruong();

        }

        private void LoadPM ()
        {
            LoadTenDG();
            LoadKM();
            LoadMaTL();
            sql = "SELECT * FROM PHIEUMUON pm, DocGia dg, HinhThucMuon km " +
                "where pm.SoThe = dg.SoThe and pm.MaKM = km.MaKM";
            daPM = new SqlDataAdapter(sql, conn);
            dtgocPM.Clear();
            daPM.Fill(dtgocPM);
            dtPM = dtgocPM.Copy();
            bsPM.DataSource = dtPM;
            grdPM.DataSource = bsPM;
            bdPM.BindingSource = bsPM;

            //Load chi tiết phiếu mượn
            if(dtgocPM.Rows.Count > 0)
            {
                grdPM.CurrentCell = grdPM.Rows[0].Cells[0];
                LoadCTPM(grdPM.Rows[0].Cells["MaPM"].Value.ToString());
                NapCT_PM();
            }
            
            txtMaPM.DataBindings.Clear();
            cbTenDG.DataBindings.Clear();
            cbKM.DataBindings.Clear();
            dtpNM.DataBindings.Clear();
            dtpHT.DataBindings.Clear();
            
            txtMaPM.DataBindings.Add("Text", bsPM, "MaPM");
            cbTenDG.DataBindings.Add("selectedValue", bsPM, "SoThe");
            cbKM.DataBindings.Add("selectedValue", bsPM, "MaKM");
            dtpHT.DataBindings.Add("Value", bsPM, "HanTra");
            dtpNM.DataBindings.Add("Value", bsPM, "NgayMuon");
        }

        private void LoadTenDG()
        {
            sql = "Select * from DocGia";
            SqlDataAdapter dadg = new SqlDataAdapter(sql, conn);
            DataTable dtdg = new DataTable();
            dadg.Fill(dtdg);
            cbTenDG.DataSource = dtdg;
            cbTenDG.DisplayMember = "TenDG";
            cbTenDG.ValueMember = "SoThe";
        }

        private void LoadKM()
        {
            sql = "select * from HinhThucMuon";
            SqlDataAdapter daKM = new SqlDataAdapter(sql, conn);
            DataTable dtKM= new DataTable();
            daKM.Fill(dtKM);
            cbKM.DataSource = dtKM;
            cbKM.DisplayMember = "TenKM";
            cbKM.ValueMember = "MaKM";
        }

        private void LoadTT ()
        {
            sql = "Select * from TrangThai";
            SqlDataAdapter daTT = new SqlDataAdapter(sql, conn);
            DataTable dtTT = new DataTable();
            daTT.Fill(dtTT);
            cbTT.DataSource = dtTT;
            cbTT.DisplayMember = "TenTT";
            cbTT.ValueMember = "MaTT";
        }
        
        private void LoadCTPM(string maPM)
        {
            LoadTT();
            dtgocCTPM.Clear();            
            sql = "SELECT * FROM CTPM ctpm, TaiLieu tl, DMTL dm, TrangThai tt " +
                "where ctpm.MaTL = tl.MaTL and tl.MaDMTL=dm.MaDMTL and tl.MaTT=tt.MaTT " +
                "and ctpm.MaPM = '" + maPM + "'";
            daCTPM = new SqlDataAdapter(sql, conn);            
            daCTPM.Fill(dtgocCTPM);
            dtCTPM = dtgocCTPM.Copy();
            bsCTPM.DataSource = dtCTPM;
            grdCTPM.DataSource = bsCTPM;
            bdCTPM.BindingSource = bsCTPM;
        }

        private void NapCT_PM()
        {
            if(grdPM.CurrentRow != null)
            {
                DataRowView row = (DataRowView)bsPM.Current;

                txtMaPM.Text = row["MaPM"].ToString();
                cbTenDG.SelectedValue = row["SoThe"].ToString();
                cbKM.SelectedValue = row["MaKM"].ToString();
                dtpNM.Value = Convert.ToDateTime(row["NgayMuon"]);
                dtpHT.Value = Convert.ToDateTime(row["HanTra"]);
            }
        }

        private void NapCT_CTPM()
        {
            if (bsCTPM == null) return;
            if(bsCTPM.Count==0)
            {
                cbMaTL.SelectedIndex = -1;
                cbTT.SelectedIndex = -1;
                txtTenTL.Text = "";
                return;
            }
                DataRowView row = (DataRowView)bsCTPM.Current as DataRowView;
            if (row == null) return;
            if (row["MaTL"] == DBNull.Value) return;
            string maTL = row["MaTL"].ToString();
            cbMaTL.SelectedValue = maTL;
            if (cbMaTL.SelectedValue != null)
            {
                txtTenTL.Text = LayTenTL();
                cbTT.Text = LayTT_TL();
            }
            else
            {
                txtTenTL.Text = "";
                cbTT.SelectedIndex = -1;
            }

        }

        private string LayTenTL()
        {
            if (cbMaTL.SelectedValue == null)
                return "";
            string tenTL = "";
            sql = "Select dm.TenDMTL from DMTL dm, TaiLieu tl " +
                "where dm.MaDMTL=tl.MaDMTL and MaTL = '" + cbMaTL.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            
            object kq = cmd.ExecuteScalar();
            if (kq != null)
                tenTL = kq.ToString();
            return tenTL;
        }

        private string LayTT_TL()
        {
            string maTT = "";
            sql = "Select tl.MaTT, tt.TenTT from TaiLieu tl, TrangThai tt " +
                "where tl.MaTT=tt.MaTT and tl.MaTL = '" + cbMaTL.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            object kq = cmd.ExecuteScalar(); // Lấy MaTT
            if (kq != null)
            {
                
                maTT = kq.ToString();// Lấy MaTT
                cbTT.SelectedValue = maTT; // Chọn trạng thái tương ứng trong ComboBox

            }
            return maTT;
        }

        private void LoadMaTL()
        {
            sql = "Select * from TaiLieu";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            
            cbMaTL.DataSource = dt;
            cbMaTL.DisplayMember = "MaTL";
            cbMaTL.ValueMember = "MaTL";


        }

        private void grdPM_SelectionChanged(object sender, EventArgs e)
        {

            if (bsPM.Current == null) return; // Check if there is a current item

            string maPM = ((DataRowView)bsPM.Current)["MaPM"].ToString(); // Get the MaPM of the current item
            LoadCTPM(maPM);
            NapCT_PM();
        }

        private void cbKM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbKM.SelectedIndex !=-1) // Check if an item is selected
            
            {
                string chonMaKM = cbKM.SelectedValue.ToString();
            }    
        }

        private void grdCTPM_SelectionChanged(object sender, EventArgs e)
        {
            if (grdCTPM.CurrentRow == null) return;

            if (grdCTPM.CurrentRow.Cells["MaTL"].Value == null) return;
            NapCT_CTPM();
        }

        private void dscomTruong()
        {
            comTruong.Items.Clear();
            comTruong.Items.Add("MaPM");
            comTruong.Items.Add("TenDG");
            comTruong.Items.Add("TenKM");
            comTruong.Items.Add("NgayMuon");
            comTruong.Items.Add("HanTra");

        }

        private void comTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string com = comTruong.Text;
            DataTable dtTrg = new DataTable();

            if (com == "NgayMuon" || com == "HanTra")
            {
                sql = $"SELECT DISTINCT {com} FROM PHIEUMUON pm, DocGia dg, HinhThucMuon km " +
                      "WHERE pm.SoThe = dg.SoThe AND pm.MaKM = km.MaKM";

                daPM = new SqlDataAdapter(sql, conn);
                daPM.Fill(dtTrg);

                // Tạo cột tạm kiểu string chỉ chứa ngày
                dtTrg.Columns.Add("NgayText", typeof(string));

                foreach (DataRow row in dtTrg.Rows)
                {
                    if (row[com] != DBNull.Value)
                        row["NgayText"] = ((DateTime)row[com]).ToString("yyyy-MM-dd");
                    else
                        row["NgayText"] = "";
                }

                comGT.DataSource = dtTrg;
                comGT.DisplayMember = "NgayText";
                comGT.ValueMember = "NgayText";
                comGT.SelectedIndex = -1;
            }
            else
            {
                sql = "SELECT DISTINCT " + com +
                      " FROM PHIEUMUON pm, DocGia dg, HinhThucMuon km " +
                      "WHERE pm.SoThe = dg.SoThe AND pm.MaKM = km.MaKM";

                daPM = new SqlDataAdapter(sql, conn);
                daPM.Fill(dtTrg);

                comGT.DataSource = dtTrg;
                comGT.DisplayMember = com;
                comGT.ValueMember = com;
                comGT.SelectedIndex = -1;
            }

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                string trg = comTruong.Text;
                string gt = comGT.Text;

                if (trg == "" || gt == "")
                {
                    MessageBox.Show("Vui lòng chọn trường và giá trị để lọc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dtPM = dtgocPM.Clone();
                foreach (DataRow row in dtgocPM.Rows)
                {
                    if (row[trg] == DBNull.Value) continue; // bỏ qua giá trị rỗng

                    if (trg == "NgayMuon" || trg == "HanTra")
                    {
                        // Chuyển giá trị row và giá trị chọn về DateTime để so sánh
                        DateTime dateValue = Convert.ToDateTime(row[trg]);
                        DateTime selectedDate = DateTime.Parse(gt);

                        if (dateValue.Date == selectedDate.Date)
                        {
                            dtPM.Rows.Add(row.ItemArray);
                        }
                    }
                    else
                    {
                        // Cột text bình thường
                        if (row[trg].ToString().Contains(gt))
                        {
                            dtPM.Rows.Add(row.ItemArray);
                        }
                    }
                }

                bsPM.DataSource = dtPM;
                grdPM.DataSource = bsPM;
                

                NapCT_PM();
                NapCT_CTPM();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lọc dữ liệu: " + ex.Message);

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                dtPM = dtgocPM.Copy();
                bsPM.DataSource = dtPM;
                grdPM.DataSource = bsPM;
               
                NapCT_PM();
                NapCT_CTPM();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi làm mới dữ liệu: " + ex.Message);
            }
        }

        private void btnAddPM_Click(object sender, EventArgs e)
        {
            string newMaPM = "PM001";

            if (dtgocPM.Rows.Count > 0)
            {
                // Lấy mã phiếu mượn cuối cùng và tăng số thứ tự lên 1
                string lastMaPM = dtgocPM.Rows[dtgocPM.Rows.Count - 1]["MaPM"].ToString();
                int numericPart = int.Parse(lastMaPM.Substring(2));
                newMaPM = "PM" + (numericPart + 1).ToString("D3");

            }

            sql = "INSERT INTO PHIEUMUON (MaPM, SoThe, MaKM, NgayMuon, HanTra) " +
                  "VALUES (@MaPM, @SoThe, @MaKM, @NgayMuon, @HanTra)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaPM", newMaPM);
            cmd.Parameters.AddWithValue("@SoThe", cbTenDG.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@MaKM", cbKM.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@NgayMuon", dtpNM.Value);
            cmd.Parameters.AddWithValue("@HanTra", dtpHT.Value);
            cmd.ExecuteNonQuery();

            DataRow row = dtgocPM.NewRow();
            row["MaPM"] = newMaPM;
            row["SoThe"] = "";
            row["MaKM"] = "";
            row["NgayMuon"] = DateTime.Today;
            row["HanTra"] = DateTime.Today;
            dtgocPM.Rows.Add(row);
            dtPM = dtgocPM.Copy();
            bsPM.DataSource = dtPM;
            grdPM.DataSource = bsPM;
            bsPM.Position = bsPM.Find("MaPM", newMaPM);

            dtCTPM.Clear();
            bsCTPM.DataSource = dtCTPM;
            grdCTPM.DataSource = bsCTPM;

            NapCT_PM();
            NapCT_CTPM();

            MessageBox.Show("Nhập thông tin phiếu mượn mới và tài liệu mượn rồi nhấn cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtMaPM.Focus();
        }

        private void btnAddTL_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbMaTL.Text))
            {
                MessageBox.Show("Vui lòng chọn mã tài liệu để thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbMaTL.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn mã tài liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maTL = cbMaTL.SelectedValue.ToString();
            string tenTT = LayTrangThai(maTL);

            if (tenTT == null)
            {
                MessageBox.Show("Tài liệu " + maTL + " đang được mượn. Vui lòng chọn tài liệu khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!dtCTPM.Columns.Contains("TenTL"))
                dtCTPM.Columns.Add("TenTL", typeof(string));
            if (!dtCTPM.Columns.Contains("TenTT"))
                dtCTPM.Columns.Add("TenTT", typeof(string));

            DataRow row = dtCTPM.NewRow();
            row["MaPM"] = txtMaPM.Text;
            row["MaTL"] = maTL;
            row["TenTL"] = LayTenTL();
            row["TenTT"] = tenTT;

            dtCTPM.Rows.Add(row);
            bsCTPM.DataSource = dtCTPM;
            grdCTPM.DataSource = bsCTPM;

            cbMaTL.SelectedIndex = -1;
            txtTenTL.Text = "";
            cbTT.SelectedIndex = -1;
        }


        private string LayTrangThai(string MaTL)
        {
            string sql = "SELECT tl.MaTT, tt.TenTT " +
                 "FROM TaiLieu tl " +
                 "JOIN TrangThai tt ON tl.MaTT = tt.MaTT " +
                 "WHERE tl.MaTL = @MaTL";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaTL", MaTL);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    string maTT = reader["MaTT"].ToString().Trim(); // loại bỏ khoảng trắng
                    string tenTT = reader["TenTT"].ToString();

                    if (maTT.Equals("Bor", StringComparison.OrdinalIgnoreCase))
                    {
                        return null; // đang mượn -> trả về null
                    }
                    return tenTT; // còn lại -> trả tên trạng thái
                }
            }
            return null; // không tìm thấy -> trả null
        }

        private void cbMaTL_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (cbMaTL.SelectedValue == null)
            {
                txtTenTL.Text = "";
                cbTT.SelectedIndex = -1;
                return;
            }

            string maTL = cbMaTL.SelectedValue.ToString();

            string tt = "";
            sql = "Select dm.TenDMTL, tt.TenTT, tl.MaTT from DMTL dm, TaiLieu tl, TrangThai tt " +
                "where dm.MaDMTL=tl.MaDMTL and tl.MaTT = tt.MaTT and MaTL = '" + maTL + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtTenTL.Text = reader["TenDMTL"].ToString();
                cbTT.Text = reader["TenTT"].ToString();
                tt = reader["MaTT"].ToString();
            }
            reader.Close();

            

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlTransaction tran = null;

            try
            {
                tran = conn.BeginTransaction();

                // --- Cập nhật PHIEUMUON ---
                SqlCommand cmdPM = new SqlCommand();
                cmdPM.Connection = conn;
                cmdPM.Transaction = tran;
                cmdPM.CommandText = @"UPDATE PHIEUMUON 
                              SET SoThe=@SoThe, MaKM=@MaKM, NgayMuon=@NgayMuon, HanTra=@HanTra 
                              WHERE MaPM=@MaPM";

                foreach (DataRow row in dtPM.Rows)
                {
                    cmdPM.Parameters.Clear();
                    cmdPM.Parameters.AddWithValue("@MaPM", row["MaPM"]);
                    cmdPM.Parameters.AddWithValue("@SoThe", row["SoThe"]);
                    cmdPM.Parameters.AddWithValue("@MaKM", row["MaKM"]);
                    cmdPM.Parameters.AddWithValue("@NgayMuon", row["NgayMuon"]);
                    cmdPM.Parameters.AddWithValue("@HanTra", row["HanTra"]);
                    cmdPM.ExecuteNonQuery();
                }

                // --- Cập nhật / thêm CTPM ---
                SqlCommand cmdCTPM = new SqlCommand();
                cmdCTPM.Connection = conn;
                cmdCTPM.Transaction = tran;
                cmdCTPM.CommandText = @"IF NOT EXISTS (SELECT 1 FROM CTPM WHERE MaPM=@MaPM AND MaTL=@MaTL)
                                INSERT INTO CTPM (MaPM, MaTL) VALUES (@MaPM, @MaTL)";

                // --- Cập nhật trạng thái TaiLieu ---
                SqlCommand cmdTL = new SqlCommand();
                cmdTL.Connection = conn;
                cmdTL.Transaction = tran;
                cmdTL.CommandText = @"UPDATE TaiLieu SET MaTT=@MaTT WHERE MaTL=@MaTL";

                foreach (DataRow row in dtCTPM.Rows)
                {
                    // Thêm CTPM nếu chưa có
                    cmdCTPM.Parameters.Clear();
                    cmdCTPM.Parameters.AddWithValue("@MaPM", row["MaPM"]);
                    cmdCTPM.Parameters.AddWithValue("@MaTL", row["MaTL"]);
                    cmdCTPM.ExecuteNonQuery();

                    // Cập nhật trạng thái TaiLieu
                    if (row["MaTT"] != DBNull.Value)
                    {
                        cmdTL.Parameters.Clear();
                        cmdTL.Parameters.AddWithValue("@MaTT", row["MaTT"]);
                        cmdTL.Parameters.AddWithValue("@MaTL", row["MaTL"]);
                        cmdTL.ExecuteNonQuery();
                    }
                }

                tran.Commit();
                MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Làm mới lại dữ liệu từ DB
                LoadPM();
            }
            catch (Exception ex)
            {
                if (tran != null)
                    tran.Rollback();
                MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbTT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTT.SelectedValue == null) return;
            if (bsCTPM.Current == null) return;

            DataRowView drv = (DataRowView)bsCTPM.Current;
            string maTT = cbTT.SelectedValue.ToString();
            drv["MaTT"] = maTT;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            SqlTransaction tran = null;

            try
            {
                tran = conn.BeginTransaction();

                // 1. Kiểm tra có đang chọn dòng CTPM không
                if (bsCTPM.Current != null)
                {
                    DataRowView drv = (DataRowView)bsCTPM.Current;
                    string maPM = drv["MaPM"].ToString();
                    string maTL = drv["MaTL"].ToString();

                    DialogResult dr = MessageBox.Show(
                        $"Bạn có chắc muốn xóa tài liệu {maTL} khỏi phiếu mượn {maPM} không?",
                        "Xác nhận xóa",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {
                        // Xóa chi tiết phiếu mượn
                        SqlCommand cmdDelCTPM = new SqlCommand("DELETE FROM CTPM WHERE MaPM=@MaPM AND MaTL=@MaTL", conn, tran);
                        cmdDelCTPM.Parameters.AddWithValue("@MaPM", maPM);
                        cmdDelCTPM.Parameters.AddWithValue("@MaTL", maTL);
                        cmdDelCTPM.ExecuteNonQuery();

                        // Cập nhật trạng thái tài liệu về "Có sẵn"
                        SqlCommand cmdUpdateTL = new SqlCommand("UPDATE TaiLieu SET MaTT='Av' WHERE MaTL=@MaTL", conn, tran);
                        cmdUpdateTL.Parameters.AddWithValue("@MaTL", maTL);
                        cmdUpdateTL.ExecuteNonQuery();

                        tran.Commit();

                        bsCTPM.RemoveCurrent();
                        MessageBox.Show("Xóa chi tiết phiếu mượn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                // 2. Nếu không chọn CTPM, kiểm tra có đang chọn PM không
                else if (bsPM.Current != null)
                {
                    DataRowView drv = (DataRowView)bsPM.Current;
                    string maPM = drv["MaPM"].ToString();

                    DialogResult dr = MessageBox.Show(
                        $"Bạn có chắc muốn xóa phiếu mượn {maPM} và tất cả chi tiết của nó không?",
                        "Xác nhận xóa",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {
                        // Lấy danh sách MaTL trong phiếu mượn để cập nhật trạng thái
                        SqlCommand cmdGetTL = new SqlCommand("SELECT MaTL FROM CTPM WHERE MaPM=@MaPM", conn, tran);
                        cmdGetTL.Parameters.AddWithValue("@MaPM", maPM);
                        List<string> dsMaTL = new List<string>();
                        using (SqlDataReader reader = cmdGetTL.ExecuteReader())
                        {
                            while (reader.Read())
                                dsMaTL.Add(reader["MaTL"].ToString());
                        }

                        // Xóa tất cả chi tiết phiếu mượn
                        SqlCommand cmdDelCTPM = new SqlCommand("DELETE FROM CTPM WHERE MaPM=@MaPM", conn, tran);
                        cmdDelCTPM.Parameters.AddWithValue("@MaPM", maPM);
                        cmdDelCTPM.ExecuteNonQuery();

                        // Xóa phiếu mượn
                        SqlCommand cmdDelPM = new SqlCommand("DELETE FROM PHIEUMUON WHERE MaPM=@MaPM", conn, tran);
                        cmdDelPM.Parameters.AddWithValue("@MaPM", maPM);
                        cmdDelPM.ExecuteNonQuery();

                        // Cập nhật trạng thái các tài liệu về "Có sẵn"
                        foreach (string maTL in dsMaTL)
                        {
                            SqlCommand cmdUpdateTL = new SqlCommand("UPDATE TaiLieu SET MaTT='Av' WHERE MaTL=@MaTL", conn, tran);
                            cmdUpdateTL.Parameters.AddWithValue("@MaTL", maTL);
                            cmdUpdateTL.ExecuteNonQuery();
                        }

                        tran.Commit();

                        bsPM.RemoveCurrent();
                        dtCTPM.Clear(); // Xóa chi tiết
                        MessageBox.Show("Xóa phiếu mượn và tất cả chi tiết thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn phiếu mượn hoặc chi tiết phiếu mượn để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                tran?.Rollback();
                MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (bsPM.Current == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu mượn để chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            

            MessageBox.Show("Bạn có thể sửa thông tin phiếu mượn và chi tiết. Sau khi sửa xong bấm 'Cập nhật'.",
                            "Chỉnh sửa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDongDG_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
