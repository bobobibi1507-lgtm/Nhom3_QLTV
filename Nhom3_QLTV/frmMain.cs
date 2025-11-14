using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom3_QLTV
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void dSDanhMụcTàiLiệuMượnVềđọcTạiChốToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void đóngChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
           status1.Text = "Đăng nhập đi!";
            frmlogin frmlogin = new frmlogin();
            frmlogin.ShowDialog();
            status1.Text = "Ready!";
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            status2.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            status1.Text = "Đăng nhập đi!";
            frmlogin frmlogin = new frmlogin();
            frmlogin.ShowDialog();
            status1.Text = "Ready!";
        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            status1.Text = "Đăng nhập đi!";
            frmlogin frmlogin = new frmlogin();
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
            frmDMDG.ShowDialog();
            status1.Text = "Ready!";
        }

        private void độcGiảToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            status1.Text = "Xem hoặc thêm mới độc giả!";
            frmDMDG frmDMDG = new frmDMDG();
            frmDMDG.ShowDialog();
            status1.Text = "Ready!";
        }

        private void tácGiảToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            status1.Text = "Xem hoặc thêm mới tác giả!";
            frmDMDG frmDMDG = new frmDMDG();
            frmDMDG.ShowDialog();
            status1.Text = "Ready!";
        }
    }
}
