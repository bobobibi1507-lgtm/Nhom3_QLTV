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
            txtTenTL.Text = LayTenTL();
            cbTT.Text = LayTT_TL();

        }

        private string LayTenTL()
        {
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
            
        }

        private void btnDongDG_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
