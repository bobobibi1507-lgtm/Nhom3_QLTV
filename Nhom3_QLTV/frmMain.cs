using DevExpress.XtraCharts.Native;
using DevExpress.XtraReports.UI;
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
    public partial class frmMain : Form
    {

        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        
        string str, sql;
        public bool IsAuthenticated { get; set; } = false;
        public string CurrentUser { get; set; } = "";
        public string CurrentRole { get; set; } = "";
        public string CurrentUserName { get; set; } = "";
        public frmMain()
        {
            InitializeComponent();
        }
        private void LockMainInterface()
        {
            // Khóa toàn bộ menu và nút chức năng
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                if (item.Text != "&Hệ thống")
                {
                    item.Enabled = false;
                }
            }

            // Khóa toàn bộ toolstrip trừ 2 nút đầu tiên
            for (int i = 0; i < toolStrip1.Items.Count; i++)
            {
                toolStrip1.Items[i].Enabled = (i == 0 || i == 1); // chỉ giữ lại 2 nút đầu
            }

            status1.Text = "Vui lòng đăng nhập để sử dụng chức năng!";
        }

        private void UnlockMainInterface()
        {
            // Mở toàn bộ menu
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                item.Enabled = true;
            }

            // Mở toàn bộ toolstrip
            foreach (ToolStripItem item in toolStrip1.Items)
            {
                item.Enabled = true;
            }

            status1.Text = $"Xin chào: {CurrentUser} ({CurrentRole})";


        }        
        private void frmMain_Load(object sender, EventArgs e)
        {
            
            LockMainInterface();
            

        }



        private void đóngChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            status1.Text = "Đăng ngập tài khoản của bạn";
            frmlogin loginForm = new frmlogin(this); // truyền frmMain vào
            loginForm.ShowDialog();

            if (IsAuthenticated)
            {
                UnlockMainInterface(); // mở khóa chức năng
            }

            status1.Text = "Ready!";
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            status2.Text = System.DateTime.Now.ToString();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            status1.Text = "Đăng nhập đi!";
            frmlogin frmlogin = new frmlogin(this);
            frmlogin.ShowDialog();
            if (IsAuthenticated)
            {
                UnlockMainInterface(); // mở khóa chức năng
            }
            status1.Text = "Ready!";
        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            status1.Text = "Đăng nhập đi!";
            frmlogin frmlogin = new frmlogin(this);
            frmlogin.ShowDialog();
            status1.Text = "Ready!";
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void độcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            status1.Text = "Xem hoặc thêm mới độc giả!";
            frmDMDG frmDMDG = new frmDMDG();
            frmDMDG.Width = (int)(Screen.PrimaryScreen.WorkingArea.Width);
            frmDMDG.Height = (int)(Screen.PrimaryScreen.WorkingArea.Height * 0.85);
            frmDMDG.ShowDialog();
            status1.Text = "Ready!";
        }

        private void độcGiảToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            status1.Text = "Xem hoặc thêm mới độc giả!";
            frmDMDG frmDMDG = new frmDMDG();
            frmDMDG.Width = (int)(Screen.PrimaryScreen.WorkingArea.Width);
            frmDMDG.Height = (int)(Screen.PrimaryScreen.WorkingArea.Height * 0.85);
            frmDMDG.ShowDialog();
            status1.Text = "Ready!";
        }

        private void tácGiảToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            status1.Text = "Xem hoặc thêm mới tác giả!";
            frmDMTG frmDMTG = new frmDMTG();
            frmDMTG.Width = (int)(Screen.PrimaryScreen.WorkingArea.Width);
            frmDMTG.Height = (int)(Screen.PrimaryScreen.WorkingArea.Height * 0.85);
            frmDMTG.ShowDialog();
            status1.Text = "Ready!";
        }

        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            status1.Text = "Xem hoặc thêm mới tác giả!";
            frmDMTG frmDMTG = new frmDMTG();
            frmDMTG.Width = (int)(Screen.PrimaryScreen.WorkingArea.Width);
            frmDMTG.Height = (int)(Screen.PrimaryScreen.WorkingArea.Height * 0.85);
            frmDMTG.ShowDialog();
            status1.Text = "Ready!";
        }

        private void tàiLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            status1.Text = "Xem hoặc thêm mới tài liệu!";
            frmDMTailieu frmDMSach = new frmDMTailieu();
            frmDMSach.Width = (int)(Screen.PrimaryScreen.WorkingArea.Width);
            frmDMSach.Height = (int)(Screen.PrimaryScreen.WorkingArea.Height * 0.85);
            frmDMSach.ShowDialog();
            status1.Text = "Ready!";
        }

        private void tàiLiệuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            status1.Text = "Xem hoặc thêm mới tài liệu!";
            frmDMTailieu frmDMSach = new frmDMTailieu();
            frmDMSach.Width = (int)(Screen.PrimaryScreen.WorkingArea.Width);
            frmDMSach.Height = (int)(Screen.PrimaryScreen.WorkingArea.Height * 0.85);
            frmDMSach.ShowDialog();
            status1.Text = "Ready!";
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            status1.Text = "Xem hoặc thêm mới phiếu mượn!";
            frmNhapPM nhapPhieuMuon = new frmNhapPM();
            nhapPhieuMuon.Width = (int)(Screen.PrimaryScreen.WorkingArea.Width);
            nhapPhieuMuon.Height = (int)(Screen.PrimaryScreen.WorkingArea.Height * 0.85);
            nhapPhieuMuon.ShowDialog();
            status1.Text = "Ready!";
        }

        private void quảnLýMượnTrảToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            status1.Text = "Xem hoặc thêm mới phiếu mượn!";
            frmNhapPM nhapPhieuMuon = new frmNhapPM();
            nhapPhieuMuon.Width = (int)(Screen.PrimaryScreen.WorkingArea.Width);
            nhapPhieuMuon.Height = (int)(Screen.PrimaryScreen.WorkingArea.Height * 0.85);
            nhapPhieuMuon.ShowDialog();
            status1.Text = "Ready!";
        }

        private void quảnLýMượnTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            status1.Text = "Trả sách!";
            frmPhieuTra frmPhieuTra = new frmPhieuTra();
            frmPhieuTra.Width = (int)(Screen.PrimaryScreen.WorkingArea.Width);
            frmPhieuTra.Height = (int)(Screen.PrimaryScreen.WorkingArea.Height * 0.85);
            frmPhieuTra.ShowDialog();
            status1.Text = "Ready!";
        }

        private void bạnĐọcTạiChỗToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            status1.Text = "Trả sách!";
            frmPhieuTra frmPhieuTra = new frmPhieuTra();
            frmPhieuTra.Width = (int)(Screen.PrimaryScreen.WorkingArea.Width);
            frmPhieuTra.Height = (int)(Screen.PrimaryScreen.WorkingArea.Height * 0.85);
            frmPhieuTra.ShowDialog();
            status1.Text = "Ready!";
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            status1.Text = "Xem hoặc thêm mới độc giả!";
            frmDMDG frmDMDG = new frmDMDG();
            frmDMDG.Width = (int)(Screen.PrimaryScreen.WorkingArea.Width);
            frmDMDG.Height = (int)(Screen.PrimaryScreen.WorkingArea.Height * 0.85);
            frmDMDG.ShowDialog();
            status1.Text = "Ready!";
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            status1.Text = "Xem hoặc thêm mới tài liệu!";
            frmDMTailieu frmDMSach = new frmDMTailieu();
            frmDMSach.Width = (int)(Screen.PrimaryScreen.WorkingArea.Width);
            frmDMSach.Height = (int)(Screen.PrimaryScreen.WorkingArea.Height * 0.85);
            frmDMSach.ShowDialog();
            status1.Text = "Ready!";
        }

        private void dSDanhMụcTàiLiệuMượnVềđọcTạiChốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Tạo kết nối đúng
                using (SqlConnection conn = new SqlConnection(
                    @"Data Source=LAPTOP-8EI4770R; Initial Catalog=CSDL_TV; Integrated Security=True"))
                {
                    conn.Open();

                    // 2. Tạo SQL
                    string sql = "SELECT * FROM vDanhMucThongKe order by TenTheLoai";


                    // 3. Tạo Adapter đúng
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                    // 4. Nạp DataTable cho report
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // 5. Tạo report
                    rptDSLuotDoc rpt = new rptDSLuotDoc();
                    rpt.DataSource = dt;

                    // 6. Set ngày in
                    rpt.rptngayin.Text =
                        $"Hà Nội, ngày {DateTime.Now.Day} tháng {DateTime.Now.Month} năm {DateTime.Now.Year}";

                    // 7. Người in từ CurrentUser
                    rpt.rptNguoiIn.Text = this.CurrentUserName;


                    // 8. Hiển thị preview
                    rpt.ShowPreviewDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dSMượnQuáHạnChưaTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Tạo kết nối đúng
                using (SqlConnection conn = new SqlConnection(
                    @"Data Source=LAPTOP-8EI4770R; Initial Catalog=CSDL_TV; Integrated Security=True"))
                {
                    conn.Open();

                    // 2. Tạo SQL
                    string sql = "SELECT * FROM DSQuaHanChucVu ORDER BY TenCV";


                    // 3. Tạo Adapter đúng
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                    // 4. Nạp DataTable cho report
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // 5. Tạo report
                    rptTacGia rpt = new rptTacGia();
                    rpt.DataSource = dt;

                    // 6. Set ngày in
                    rpt.rptngayin.Text =
                        $"Hà Nội, ngày {DateTime.Now.Day} tháng {DateTime.Now.Month} năm {DateTime.Now.Year}";

                    // 7. Người in từ CurrentUser
                    rpt.rptNguoiIn.Text = this.CurrentUserName;
                    

                    // 8. Hiển thị preview
                    rpt.ShowPreviewDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}


