using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace Nhom3_QLTV
{
    public partial class rptTacGia : DevExpress.XtraReports.UI.XtraReport
    {
        public rptTacGia()
        {
            InitializeComponent();
        }
        public string NguoiLamBaoCao
        {
            get { return rptNguoiIn.Text; }
            set { rptNguoiIn.Text = value; }
        }
    }
}
