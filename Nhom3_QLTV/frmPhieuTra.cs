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
    public partial class frmPhieuTra : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        string sql, str;
        BindingSource bd = new BindingSource();
        Boolean addnewFlag = false;
        private string currentMaPhieuMuon = "";
        private string currentMaTaiLieu = ""; // DÙNG ĐỂ CẬP NHẬT MaTT
        private bool isAddingNgayTra = false;
        private bool isEditingNgayTra = false;
        private bool isDeletingNgayTra = false;

        public frmPhieuTra()
        {
            InitializeComponent();
        }

        private void frmPhieuTra_Load(object sender, EventArgs e)
        {
            str = "Data Source=LAPTOP-8EI4770R; Initial Catalog=CSDL_TV; Integrated Security=True";
            conn.ConnectionString = str;
            conn.Open();

            LoadData();

            grdPT.DataSource = bd;

            txtMaPM.DataBindings.Add("Text", bd, "MaPM");
            txtMaTL.DataBindings.Add("Text", bd, "MaTL");
            dtpHanTra.DataBindings.Add("Value", bd, "HanTra");

            // **Bind DateTimePicker với BindingSource**
            Binding bdNgayTra = new Binding("Value", bd, "NgayThucTra", true, DataSourceUpdateMode.OnPropertyChanged);
            bdNgayTra.NullValue = DateTime.Today;
            dtNgayThucTra.DataBindings.Add(bdNgayTra);


            // Khởi tạo ComboBox chọn trường lọc
            comTentrgPT.Items.Clear();
            comTentrgPT.Items.AddRange(new string[] {
        "MaPM","SoThe","MaTL","TenDMTL","TenTT","NgayMuon","HanTra"
    });
            comTentrgPT.SelectedIndex = 0;
            comGTPT.DataSource = null;


        }

        private void LoadData()
        {
            sql = @"
        SELECT CTPM.MaPM, PhieuMuon.SoThe, CTPM.MaTL, DMTL.TenDMTL,
               PhieuMuon.NgayMuon, TrangThai.TenTT, PhieuMuon.HanTra, CTPM.NgayThucTra
        FROM CTPM
        JOIN PhieuMuon ON CTPM.MaPM = PhieuMuon.MaPM
        JOIN TaiLieu ON CTPM.MaTL = TaiLieu.MaTL
        JOIN DMTL ON TaiLieu.MaDMTL = DMTL.MaDMTL
        JOIN TrangThai ON TaiLieu.MaTT = TrangThai.MaTT";

            dt.Clear();
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);

            bd.DataSource = dt;
            bdPhieuTra.BindingSource = bd;
        }


        private void grdPT_SelectionChanged(object sender, EventArgs e)
        {
            if (grdPT.CurrentRow == null) return;

            var ngayTra = grdPT.CurrentRow.Cells["NgayThucTra"].Value;

            if (ngayTra == DBNull.Value || ngayTra == null)
            {
                dtNgayThucTra.Format = DateTimePickerFormat.Custom;
                dtNgayThucTra.CustomFormat = " --/--/---- ";
            }
            else
            {
                dtNgayThucTra.Format = DateTimePickerFormat.Custom;
                dtNgayThucTra.CustomFormat = "dd/MM/yyyy";
                dtNgayThucTra.Value = Convert.ToDateTime(ngayTra);
            }

            // Lưu khóa chính
            currentMaPhieuMuon = txtMaPM.Text;
            currentMaTaiLieu = txtMaTL.Text;


        }

        private void NapLaipt()
        {
            try
            {
                dt.Clear();
                da.Fill(dt);
                bd.DataSource = dt;
                bd.ResetBindings(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải lại dữ liệu: " + ex.Message);
            }
        }
        private string GetFullColumnName(string shortName)
        {
            {
                switch (shortName)
                {
                    case "MaPM":
                        return "CTPM.MaPM";
                    case "SoThe":
                        return "PhieuMuon.SoThe";
                    case "MaTL":
                        return "CTPM.MaTL";
                    case "TenDMTL":
                        return "DMTL.TenDMTL";
                    case "MaTT":
                        return "TaiLieu.MaTT";
                    case "NgayMuon":
                        return "PhieuMuon.NgayMuon";
                    case "HanTra":
                        return "PhieuMuon.HanTra";
                   
                    default:
                        return shortName;
                }
            }
        }

        private void comTentrgPT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comTentrgPT.SelectedItem == null) return;

            string columnName = comTentrgPT.SelectedItem.ToString();
            // Là tên cột thật: MaPM, SoThe,...
            string fullColumn = GetFullColumnName(columnName);

            // Xây dựng SQL lấy DISTINCT giá trị
            string sql = $@"
        SELECT DISTINCT {fullColumn}
        FROM CTPM 
        JOIN PhieuMuon ON CTPM.MaPM = PhieuMuon.MaPM 
        JOIN TaiLieu ON CTPM.MaTL = TaiLieu.MaTL 
        JOIN DMTL ON TaiLieu.MaDMTL = DMTL.MaDMTL 
        join TrangThai TT on TaiLieu.MaTT = TT.MaTT
      
        ORDER BY {fullColumn}";

            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    SqlDataAdapter daFilter = new SqlDataAdapter(cmd);
                    DataTable dtFilter = new DataTable();
                    daFilter.Fill(dtFilter);

                    comGTPT.DataSource = dtFilter;
                    comGTPT.DisplayMember = columnName;
                    comGTPT.ValueMember = columnName;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải giá trị: " + ex.Message);
            }
        }

        private void btnTimPT_Click(object sender, EventArgs e)
        {
            if (comTentrgPT.SelectedItem == null || comGTPT.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn trường và giá trị!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string shortName = comTentrgPT.SelectedItem.ToString();
            string fullColumn = GetFullColumnName(shortName);// MaPM, SoThe,...
            string searchValue = comGTPT.SelectedValue.ToString();

            // Xác định kiểu dữ liệu
            bool isString = shortName == "SoThe" || shortName == "TenDMTL" || shortName == "MaTT";
            bool isDate = shortName == "NgayMuon" || shortName == "NgayThucTra" || shortName == "HanTra";

            string condition = isString
        ? $"{fullColumn} LIKE @{shortName}"
        : $"{fullColumn} = @{shortName}";

            if (isDate)
                searchValue = Convert.ToDateTime(searchValue).ToString("yyyy-MM-dd");

            // Câu SQL tìm kiếm
            sql = $@"
        SELECT CTPM.MaPM as MaPM, PhieuMuon.SoThe, CTPM.MaTL as MaTL, DMTL.TenDMTL,
               PhieuMuon.NgayMuon, TrangThai.TenTT, CTPM.NgayThucTra, PhieuMuon.HanTra
        FROM CTPM 
        JOIN PhieuMuon ON CTPM.MaPM = PhieuMuon.MaPM 
        JOIN TaiLieu ON CTPM.MaTL = TaiLieu.MaTL 
        JOIN DMTL ON TaiLieu.MaDMTL = DMTL.MaDMTL
        JOIN TrangThai ON TaiLieu.MaTT = TrangThai.MaTT
        WHERE {condition}";

            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    string param = "@" + shortName;
                    cmd.Parameters.AddWithValue(param, isString ? $"%{searchValue}%" : searchValue);

                    SqlDataAdapter daSearch = new SqlDataAdapter(cmd);
                    DataTable dtSearch = new DataTable();
                    dtSearch.Clear();
                    daSearch.Fill(dtSearch);
                    bd.DataSource = dtSearch;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
        }

        private void btnTraTL_Click(object sender, EventArgs e)
        {
            if (grdPT.CurrentRow == null) { /* ... */ return; }

            var cellValue = grdPT.CurrentRow.Cells["NgayThucTra"].Value;

            if (cellValue != null && cellValue != DBNull.Value)
            {
                MessageBox.Show("Tài liệu trong phiếu mượn này đã được trả!");
                return;

            }
            // Chuyển từ "Chưa trả" → cho phép chọn ngày
            dtNgayThucTra.Format = DateTimePickerFormat.Custom;
            dtNgayThucTra.CustomFormat = "dd/MM/yyyy";
            dtNgayThucTra.Value = DateTime.Today;
            dtNgayThucTra.Focus();

            MessageBox.Show("Hãy chọn ngày trả và cập nhật lại trạng thái cho tài liệu");
            isAddingNgayTra = true;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (grdPT.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một bản ghi!");
                return;
            }

            if (!isAddingNgayTra && !isEditingNgayTra)
            {
                MessageBox.Show("Vui lòng chọn [Thêm ngày trả] hoặc [Sửa ngày trả] trước!");
                return;
            }

            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                // === TỰ ĐỘNG ĐẶT MaTT = 'Av' KHI TRẢ SÁCH ===
                string maTT_Available = "Av";  // ← Mã trạng thái "Có sẵn"

                int rowsCTPM = 0;
                int rowsTaiLieu = 0;

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;

                    // === 1. CẬP NHẬT NGÀY TRẢ TRONG CTPM ===
                    if (isAddingNgayTra)
                    {
                        cmd.CommandText = "UPDATE CTPM SET NgayThucTra = @NgayThucTra " +
                                          "WHERE MaPM = @MaPM AND MaTL = @MaTL AND NgayThucTra IS NULL";
                    }
                    else // isEditingNgayTra
                    {
                        cmd.CommandText = "UPDATE CTPM SET NgayThucTra = @NgayThucTra " +
                                          "WHERE MaPM = @MaPM AND MaTL = @MaTL";
                    }

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@NgayThucTra", dtNgayThucTra.Value);
                    cmd.Parameters.AddWithValue("@MaPM", currentMaPhieuMuon);
                    cmd.Parameters.AddWithValue("@MaTL", currentMaTaiLieu);

                    rowsCTPM = cmd.ExecuteNonQuery();

                    // === 2. TỰ ĐỘNG CẬP NHẬT MaTT = 'Av' TRONG TaiLieu ===
                    cmd.Parameters.Clear();
                    cmd.CommandText = "UPDATE TaiLieu SET MaTT = @MaTT_Available WHERE MaTL = @MaTL";
                    cmd.Parameters.AddWithValue("@MaTT_Available", maTT_Available);
                    cmd.Parameters.AddWithValue("@MaTL", currentMaTaiLieu);

                    rowsTaiLieu = cmd.ExecuteNonQuery();
                }

                // === KIỂM TRA KẾT QUẢ ===
                if (rowsCTPM > 0 || rowsTaiLieu > 0)
                {
                    MessageBox.Show("Đã trả sách thành công!\nTài liệu đã được đánh dấu 'Có sẵn' (Av).",
                                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    

                    NapLaipt();
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật: Kiểm tra MaPM, MaTL hoặc trạng thái!",
                                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                isAddingNgayTra = false;
                isEditingNgayTra = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (grdPT.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một phiếu mượn!");
                return;
            }

            var cellValue = grdPT.CurrentRow.Cells["NgayThucTra"].Value;
            if (cellValue == null || cellValue == DBNull.Value)
            {
                MessageBox.Show("Phiếu mượn này chưa có ngày trả để sửa!");
                return;
            }

            MessageBox.Show("Hãy chọn lại ngày trả tài liệu");
            dtNgayThucTra.CustomFormat = "dd/MM/yyyy";
            dtNgayThucTra.Value = Convert.ToDateTime(cellValue);
            dtNgayThucTra.Focus();

            isEditingNgayTra = true;  // BẮT BUỘC ĐẶT CỜ NÀY
            isAddingNgayTra = false;

        }

        private void btnHuyTra_Click(object sender, EventArgs e)
        {
            if (grdPT.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu mượn!");
                return;
            }

            var cellValue = grdPT.CurrentRow.Cells["NgayThucTra"].Value;
            if (cellValue == null || cellValue == DBNull.Value)
            {
                MessageBox.Show("Phiếu này chưa có ngày trả để xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa ngày thực trả?\nTài liệu sẽ được coi là CHƯA TRẢ.",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
            {
                return;
            }

            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                // === KHÔI PHỤC MaTT VỀ 'Bor' (Đang mượn) ===
                string maTTDangMuon = "Bor";  // ← Mã trạng thái "Đang mượn"

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;

                    // 1. XÓA NGÀY TRẢ
                    cmd.CommandText = "UPDATE CTPM SET NgayThucTra = NULL WHERE MaPM = @MaPM AND MaTL = @MaTL";
                    cmd.Parameters.AddWithValue("@MaPM", currentMaPhieuMuon);
                    cmd.Parameters.AddWithValue("@MaTL", currentMaTaiLieu);
                    int rowsCTPM = cmd.ExecuteNonQuery();

                    // 2. KHÔI PHỤC MaTT VỀ 'Bor'
                    cmd.Parameters.Clear();
                    cmd.CommandText = "UPDATE TaiLieu SET MaTT = @MaTTDangMuon WHERE MaTL = @MaTL";
                    cmd.Parameters.AddWithValue("@MaTTDangMuon", maTTDangMuon);
                    cmd.Parameters.AddWithValue("@MaTL", currentMaTaiLieu);
                    int rowsTaiLieu = cmd.ExecuteNonQuery();

                    // === KIỂM TRA KẾT QUẢ ===
                    if (rowsCTPM > 0 || rowsTaiLieu > 0)
                    {
                        MessageBox.Show("Đã xóa ngày trả và khôi phục trạng thái 'Đang mượn' thành công!",
                                        "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Cập nhật giao diện
                        grdPT.CurrentRow.Cells["NgayThucTra"].Value = DBNull.Value;
                        dtNgayThucTra.CustomFormat = " --/--/---- ";
                        

                        NapLaipt(); // Tải lại dữ liệu
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa: Kiểm tra MaPM, MaTL!");
                    }
                }

                isAddingNgayTra = false;
                isEditingNgayTra = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa: " + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            NapLaipt();
        }

        private void btnDongDG_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
