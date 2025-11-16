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

        }

        private void dscomTruong ()
        {
            comTruong.Items.Clear();
            comTruong.Items.Add("MaDMTL");
            comTruong.Items.Add("TenDMTL");
            comTruong.Items.Add("TenTheLoai");

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

            sql = "SELECT tl.MaTL, tt.TenTT FROM TaiLieu tl, TrangThai tt WHERE tl.MaDMTL = @MaDMTL and tl.MaTT = tt.MaTT";
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
                 if (dgvDMTL.CurrentRow != null && dgvDMTL.CurrentRow.Cells["MaDMTL"].Value != null)
            {
                txtMaTL.Text ="";
                cbTrangThai.Text = "";
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
            
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                string trg = comTruong.Text;
                string gt = ComGT.Text;

                dtDM = dtgocDM.Clone();

                // Lọc dữ liệu
                foreach (DataRow row in dtgocDM.Rows)
                {
                    if (row[trg].ToString().Contains(gt))
                    {
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
            sql = "SELECT DISTINCT " + comTruong.Text + " FROM DMTL, LoaiTL where DMTL.MaTheLoai=LoaiTL.MaTheLoai";
            DataTable com = new DataTable();
            daDM = new SqlDataAdapter(sql, conn);
            daDM.Fill(com);
            ComGT.DataSource = com;
            ComGT.DisplayMember = comTruong.Text;
            ComGT.ValueMember = comTruong.Text;
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

        private void btnDongDG_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
