using System;
using System.Windows.Forms;

namespace Nhom3_QLTV
{
    partial class frmDMSach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelheaderDMS = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox2TL = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1TL = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblDMS = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.grdDSTL = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelInputTL = new Guna.UI2.WinForms.Guna2Panel();
            this.btnUpdateDMTL = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnThemTL1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnDongTL1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnLuuTL1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnXoaTL1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSuaTL1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.bindingnavTL = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.guna2Panel1TL = new Guna.UI2.WinForms.Guna2Panel();
            this.grbLocTL = new System.Windows.Forms.GroupBox();
            this.comGTTL = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnTimTL1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblTentrgTL = new System.Windows.Forms.Label();
            this.lblGiatriTL = new System.Windows.Forms.Label();
            this.btnNaplai = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label6TL = new System.Windows.Forms.Label();
            this.comTentrgTL1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.groupBox1TL = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2ComboBox2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2GradientPanel1TL = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2DragControl2TL = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelheaderDMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDSTL)).BeginInit();
            this.panelInputTL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingnavTL)).BeginInit();
            this.bindingnavTL.SuspendLayout();
            this.guna2Panel1TL.SuspendLayout();
            this.grbLocTL.SuspendLayout();
            this.groupBox1TL.SuspendLayout();
            this.guna2GradientPanel1TL.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelheaderDMS
            // 
            this.panelheaderDMS.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelheaderDMS.Controls.Add(this.guna2ControlBox2TL);
            this.panelheaderDMS.Controls.Add(this.guna2ControlBox1TL);
            this.panelheaderDMS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheaderDMS.Location = new System.Drawing.Point(0, 0);
            this.panelheaderDMS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelheaderDMS.Name = "panelheaderDMS";
            this.panelheaderDMS.Size = new System.Drawing.Size(1200, 38);
            this.panelheaderDMS.TabIndex = 0;
            this.panelheaderDMS.Paint += new System.Windows.Forms.PaintEventHandler(this.panelheaderDMS_Paint);
            // 
            // guna2ControlBox2TL
            // 
            this.guna2ControlBox2TL.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2TL.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2ControlBox2TL.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2TL.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ControlBox2TL.ForeColor = System.Drawing.Color.Brown;
            this.guna2ControlBox2TL.HoverState.FillColor = System.Drawing.Color.Black;
            this.guna2ControlBox2TL.HoverState.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2TL.IconColor = System.Drawing.Color.Brown;
            this.guna2ControlBox2TL.Location = new System.Drawing.Point(1056, 0);
            this.guna2ControlBox2TL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2ControlBox2TL.Name = "guna2ControlBox2TL";
            this.guna2ControlBox2TL.Size = new System.Drawing.Size(72, 38);
            this.guna2ControlBox2TL.TabIndex = 1;
            // 
            // guna2ControlBox1TL
            // 
            this.guna2ControlBox1TL.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2ControlBox1TL.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1TL.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ControlBox1TL.ForeColor = System.Drawing.Color.Brown;
            this.guna2ControlBox1TL.HoverState.FillColor = System.Drawing.Color.Black;
            this.guna2ControlBox1TL.HoverState.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1TL.IconColor = System.Drawing.Color.Brown;
            this.guna2ControlBox1TL.Location = new System.Drawing.Point(1128, 0);
            this.guna2ControlBox1TL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2ControlBox1TL.Name = "guna2ControlBox1TL";
            this.guna2ControlBox1TL.Size = new System.Drawing.Size(72, 38);
            this.guna2ControlBox1TL.TabIndex = 0;
            // 
            // lblDMS
            // 
            this.lblDMS.BackColor = System.Drawing.Color.Transparent;
            this.lblDMS.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDMS.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDMS.ForeColor = System.Drawing.Color.White;
            this.lblDMS.Location = new System.Drawing.Point(0, 0);
            this.lblDMS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblDMS.Name = "lblDMS";
            this.lblDMS.Size = new System.Drawing.Size(307, 52);
            this.lblDMS.TabIndex = 0;
            this.lblDMS.Text = "Danh mục tài liệu";
            // 
            // grdDSTL
            // 
            this.grdDSTL.AllowUserToAddRows = false;
            this.grdDSTL.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.grdDSTL.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdDSTL.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdDSTL.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDSTL.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdDSTL.ColumnHeadersHeight = 34;
            this.grdDSTL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grdDSTL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTL,
            this.TenTL,
            this.LoaiTL,
            this.TenTG});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDSTL.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdDSTL.GridColor = System.Drawing.Color.Black;
            this.grdDSTL.Location = new System.Drawing.Point(43, 100);
            this.grdDSTL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdDSTL.Name = "grdDSTL";
            this.grdDSTL.RowHeadersVisible = false;
            this.grdDSTL.RowHeadersWidth = 62;
            this.grdDSTL.RowTemplate.Height = 28;
            this.grdDSTL.Size = new System.Drawing.Size(1096, 234);
            this.grdDSTL.TabIndex = 1;
            this.grdDSTL.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grdDSTL.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grdDSTL.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grdDSTL.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grdDSTL.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grdDSTL.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.grdDSTL.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.grdDSTL.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.grdDSTL.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdDSTL.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdDSTL.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grdDSTL.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grdDSTL.ThemeStyle.HeaderStyle.Height = 34;
            this.grdDSTL.ThemeStyle.ReadOnly = false;
            this.grdDSTL.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grdDSTL.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdDSTL.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdDSTL.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grdDSTL.ThemeStyle.RowsStyle.Height = 28;
            this.grdDSTL.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdDSTL.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // MaTL
            // 
            this.MaTL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaTL.DataPropertyName = "MaTL";
            this.MaTL.HeaderText = "Mã tài liệu";
            this.MaTL.MinimumWidth = 8;
            this.MaTL.Name = "MaTL";
            this.MaTL.Width = 178;
            // 
            // TenTL
            // 
            this.TenTL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenTL.DataPropertyName = "TenTL";
            this.TenTL.HeaderText = "Tên tài liệu";
            this.TenTL.MinimumWidth = 8;
            this.TenTL.Name = "TenTL";
            // 
            // LoaiTL
            // 
            this.LoaiTL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LoaiTL.DataPropertyName = "LoaiTL";
            this.LoaiTL.HeaderText = "Loại tài liệu";
            this.LoaiTL.MinimumWidth = 8;
            this.LoaiTL.Name = "LoaiTL";
            this.LoaiTL.Width = 189;
            // 
            // TenTG
            // 
            this.TenTG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TenTG.DataPropertyName = "TenTG";
            this.TenTG.HeaderText = "Tác giả";
            this.TenTG.MinimumWidth = 8;
            this.TenTG.Name = "TenTG";
            this.TenTG.Width = 136;
            // 
            // panelInputTL
            // 
            this.panelInputTL.BackColor = System.Drawing.Color.White;
            this.panelInputTL.BorderColor = System.Drawing.Color.LightGray;
            this.panelInputTL.Controls.Add(this.btnUpdateDMTL);
            this.panelInputTL.Controls.Add(this.btnThemTL1);
            this.panelInputTL.Controls.Add(this.btnDongTL1);
            this.panelInputTL.Controls.Add(this.btnLuuTL1);
            this.panelInputTL.Controls.Add(this.btnXoaTL1);
            this.panelInputTL.Controls.Add(this.btnSuaTL1);
            this.panelInputTL.Controls.Add(this.bindingnavTL);
            this.panelInputTL.Controls.Add(this.grdDSTL);
            this.panelInputTL.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInputTL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelInputTL.Location = new System.Drawing.Point(0, 396);
            this.panelInputTL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelInputTL.Name = "panelInputTL";
            this.panelInputTL.Size = new System.Drawing.Size(1200, 416);
            this.panelInputTL.TabIndex = 2;
            // 
            // btnUpdateDMTL
            // 
            this.btnUpdateDMTL.BackColor = System.Drawing.Color.Brown;
            this.btnUpdateDMTL.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateDMTL.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateDMTL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateDMTL.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateDMTL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateDMTL.FillColor = System.Drawing.Color.Brown;
            this.btnUpdateDMTL.FillColor2 = System.Drawing.Color.Transparent;
            this.btnUpdateDMTL.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDMTL.ForeColor = System.Drawing.Color.White;
            this.btnUpdateDMTL.HoverState.FillColor = System.Drawing.Color.DarkRed;
            this.btnUpdateDMTL.HoverState.FillColor2 = System.Drawing.Color.DarkRed;
            this.btnUpdateDMTL.Location = new System.Drawing.Point(777, 29);
            this.btnUpdateDMTL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateDMTL.Name = "btnUpdateDMTL";
            this.btnUpdateDMTL.ShadowDecoration.Color = System.Drawing.Color.RosyBrown;
            this.btnUpdateDMTL.ShadowDecoration.Enabled = true;
            this.btnUpdateDMTL.Size = new System.Drawing.Size(184, 42);
            this.btnUpdateDMTL.TabIndex = 25;
            this.btnUpdateDMTL.Text = "Cập nhật";
            // 
            // btnThemTL1
            // 
            this.btnThemTL1.BackColor = System.Drawing.Color.Brown;
            this.btnThemTL1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemTL1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemTL1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemTL1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemTL1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemTL1.FillColor = System.Drawing.Color.Transparent;
            this.btnThemTL1.FillColor2 = System.Drawing.Color.Transparent;
            this.btnThemTL1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTL1.ForeColor = System.Drawing.Color.White;
            this.btnThemTL1.HoverState.FillColor = System.Drawing.Color.DarkRed;
            this.btnThemTL1.HoverState.FillColor2 = System.Drawing.Color.DarkRed;
            this.btnThemTL1.Location = new System.Drawing.Point(404, 29);
            this.btnThemTL1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemTL1.Name = "btnThemTL1";
            this.btnThemTL1.ShadowDecoration.Color = System.Drawing.Color.RosyBrown;
            this.btnThemTL1.ShadowDecoration.Enabled = true;
            this.btnThemTL1.Size = new System.Drawing.Size(136, 42);
            this.btnThemTL1.TabIndex = 20;
            this.btnThemTL1.Text = "Thêm";
            // 
            // btnDongTL1
            // 
            this.btnDongTL1.BackColor = System.Drawing.Color.Brown;
            this.btnDongTL1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDongTL1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDongTL1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDongTL1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDongTL1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDongTL1.FillColor = System.Drawing.Color.Brown;
            this.btnDongTL1.FillColor2 = System.Drawing.Color.Transparent;
            this.btnDongTL1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongTL1.ForeColor = System.Drawing.Color.White;
            this.btnDongTL1.HoverState.FillColor = System.Drawing.Color.DarkRed;
            this.btnDongTL1.HoverState.FillColor2 = System.Drawing.Color.DarkRed;
            this.btnDongTL1.Location = new System.Drawing.Point(992, 359);
            this.btnDongTL1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDongTL1.Name = "btnDongTL1";
            this.btnDongTL1.ShadowDecoration.Color = System.Drawing.Color.RosyBrown;
            this.btnDongTL1.ShadowDecoration.Enabled = true;
            this.btnDongTL1.Size = new System.Drawing.Size(136, 42);
            this.btnDongTL1.TabIndex = 24;
            this.btnDongTL1.Text = "Đóng";
            // 
            // btnLuuTL1
            // 
            this.btnLuuTL1.BackColor = System.Drawing.Color.Brown;
            this.btnLuuTL1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuuTL1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuuTL1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuuTL1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuuTL1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuuTL1.FillColor = System.Drawing.Color.Brown;
            this.btnLuuTL1.FillColor2 = System.Drawing.Color.Transparent;
            this.btnLuuTL1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuTL1.ForeColor = System.Drawing.Color.White;
            this.btnLuuTL1.HoverState.FillColor = System.Drawing.Color.DarkRed;
            this.btnLuuTL1.HoverState.FillColor2 = System.Drawing.Color.DarkRed;
            this.btnLuuTL1.Location = new System.Drawing.Point(820, 359);
            this.btnLuuTL1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLuuTL1.Name = "btnLuuTL1";
            this.btnLuuTL1.ShadowDecoration.Color = System.Drawing.Color.RosyBrown;
            this.btnLuuTL1.ShadowDecoration.Enabled = true;
            this.btnLuuTL1.Size = new System.Drawing.Size(136, 42);
            this.btnLuuTL1.TabIndex = 23;
            this.btnLuuTL1.Text = "Lưu";
            // 
            // btnXoaTL1
            // 
            this.btnXoaTL1.BackColor = System.Drawing.Color.Brown;
            this.btnXoaTL1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaTL1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaTL1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaTL1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaTL1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaTL1.FillColor = System.Drawing.Color.Brown;
            this.btnXoaTL1.FillColor2 = System.Drawing.Color.Transparent;
            this.btnXoaTL1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTL1.ForeColor = System.Drawing.Color.White;
            this.btnXoaTL1.HoverState.FillColor = System.Drawing.Color.DarkRed;
            this.btnXoaTL1.HoverState.FillColor2 = System.Drawing.Color.DarkRed;
            this.btnXoaTL1.Location = new System.Drawing.Point(1003, 29);
            this.btnXoaTL1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoaTL1.Name = "btnXoaTL1";
            this.btnXoaTL1.ShadowDecoration.Color = System.Drawing.Color.RosyBrown;
            this.btnXoaTL1.ShadowDecoration.Enabled = true;
            this.btnXoaTL1.Size = new System.Drawing.Size(136, 42);
            this.btnXoaTL1.TabIndex = 22;
            this.btnXoaTL1.Text = "Xóa";
            // 
            // btnSuaTL1
            // 
            this.btnSuaTL1.BackColor = System.Drawing.Color.Brown;
            this.btnSuaTL1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaTL1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaTL1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuaTL1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuaTL1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSuaTL1.FillColor = System.Drawing.Color.Brown;
            this.btnSuaTL1.FillColor2 = System.Drawing.Color.Transparent;
            this.btnSuaTL1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaTL1.ForeColor = System.Drawing.Color.White;
            this.btnSuaTL1.HoverState.FillColor = System.Drawing.Color.DarkRed;
            this.btnSuaTL1.HoverState.FillColor2 = System.Drawing.Color.DarkRed;
            this.btnSuaTL1.Location = new System.Drawing.Point(588, 29);
            this.btnSuaTL1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSuaTL1.Name = "btnSuaTL1";
            this.btnSuaTL1.ShadowDecoration.Color = System.Drawing.Color.RosyBrown;
            this.btnSuaTL1.ShadowDecoration.Enabled = true;
            this.btnSuaTL1.Size = new System.Drawing.Size(136, 42);
            this.btnSuaTL1.TabIndex = 21;
            this.btnSuaTL1.Text = "Sửa";
            // 
            // bindingnavTL
            // 
            this.bindingnavTL.AddNewItem = null;
            this.bindingnavTL.CountItem = this.bindingNavigatorCountItem;
            this.bindingnavTL.DeleteItem = null;
            this.bindingnavTL.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingnavTL.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingnavTL.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingnavTL.Location = new System.Drawing.Point(385, 368);
            this.bindingnavTL.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingnavTL.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingnavTL.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingnavTL.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingnavTL.Name = "bindingnavTL";
            this.bindingnavTL.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.bindingnavTL.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingnavTL.Size = new System.Drawing.Size(364, 39);
            this.bindingnavTL.TabIndex = 6;
            this.bindingnavTL.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(70, 33);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(46, 33);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(46, 33);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 39);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(46, 33);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(46, 33);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // guna2Panel1TL
            // 
            this.guna2Panel1TL.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel1TL.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Panel1TL.Controls.Add(this.grbLocTL);
            this.guna2Panel1TL.Controls.Add(this.groupBox1TL);
            this.guna2Panel1TL.Controls.Add(this.guna2GradientPanel1TL);
            this.guna2Panel1TL.CustomBorderColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel1TL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1TL.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel1TL.Location = new System.Drawing.Point(0, 38);
            this.guna2Panel1TL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Panel1TL.Name = "guna2Panel1TL";
            this.guna2Panel1TL.Size = new System.Drawing.Size(1200, 358);
            this.guna2Panel1TL.TabIndex = 19;
            // 
            // grbLocTL
            // 
            this.grbLocTL.Controls.Add(this.comGTTL);
            this.grbLocTL.Controls.Add(this.btnTimTL1);
            this.grbLocTL.Controls.Add(this.lblTentrgTL);
            this.grbLocTL.Controls.Add(this.lblGiatriTL);
            this.grbLocTL.Controls.Add(this.btnNaplai);
            this.grbLocTL.Controls.Add(this.label6TL);
            this.grbLocTL.Controls.Add(this.comTentrgTL1);
            this.grbLocTL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbLocTL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLocTL.Location = new System.Drawing.Point(507, 61);
            this.grbLocTL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbLocTL.Name = "grbLocTL";
            this.grbLocTL.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbLocTL.Size = new System.Drawing.Size(693, 297);
            this.grbLocTL.TabIndex = 28;
            this.grbLocTL.TabStop = false;
            this.grbLocTL.Text = "Lọc dữ liệu";
            // 
            // comGTTL
            // 
            this.comGTTL.BackColor = System.Drawing.Color.Transparent;
            this.comGTTL.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comGTTL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comGTTL.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comGTTL.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comGTTL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comGTTL.ForeColor = System.Drawing.Color.DarkGray;
            this.comGTTL.ItemHeight = 18;
            this.comGTTL.Location = new System.Drawing.Point(313, 126);
            this.comGTTL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comGTTL.Name = "comGTTL";
            this.comGTTL.Size = new System.Drawing.Size(307, 24);
            this.comGTTL.TabIndex = 28;
            // 
            // btnTimTL1
            // 
            this.btnTimTL1.BackColor = System.Drawing.Color.Brown;
            this.btnTimTL1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimTL1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimTL1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimTL1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimTL1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimTL1.FillColor = System.Drawing.Color.Brown;
            this.btnTimTL1.FillColor2 = System.Drawing.Color.Transparent;
            this.btnTimTL1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimTL1.ForeColor = System.Drawing.Color.White;
            this.btnTimTL1.HoverState.FillColor = System.Drawing.Color.DarkRed;
            this.btnTimTL1.HoverState.FillColor2 = System.Drawing.Color.DarkRed;
            this.btnTimTL1.Location = new System.Drawing.Point(365, 204);
            this.btnTimTL1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimTL1.Name = "btnTimTL1";
            this.btnTimTL1.ShadowDecoration.Color = System.Drawing.Color.RosyBrown;
            this.btnTimTL1.ShadowDecoration.Enabled = true;
            this.btnTimTL1.Size = new System.Drawing.Size(136, 42);
            this.btnTimTL1.TabIndex = 26;
            this.btnTimTL1.Text = "Lọc";
            // 
            // lblTentrgTL
            // 
            this.lblTentrgTL.AutoSize = true;
            this.lblTentrgTL.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTentrgTL.Location = new System.Drawing.Point(48, 71);
            this.lblTentrgTL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTentrgTL.Name = "lblTentrgTL";
            this.lblTentrgTL.Size = new System.Drawing.Size(135, 32);
            this.lblTentrgTL.TabIndex = 18;
            this.lblTentrgTL.Text = "Tên trường";
            // 
            // lblGiatriTL
            // 
            this.lblGiatriTL.AutoSize = true;
            this.lblGiatriTL.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiatriTL.Location = new System.Drawing.Point(405, 71);
            this.lblGiatriTL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGiatriTL.Name = "lblGiatriTL";
            this.lblGiatriTL.Size = new System.Drawing.Size(81, 32);
            this.lblGiatriTL.TabIndex = 19;
            this.lblGiatriTL.Text = "Giá trị";
            // 
            // btnNaplai
            // 
            this.btnNaplai.BackColor = System.Drawing.Color.Brown;
            this.btnNaplai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNaplai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNaplai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNaplai.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNaplai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNaplai.FillColor = System.Drawing.Color.Brown;
            this.btnNaplai.FillColor2 = System.Drawing.Color.Transparent;
            this.btnNaplai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNaplai.ForeColor = System.Drawing.Color.White;
            this.btnNaplai.HoverState.FillColor = System.Drawing.Color.DarkRed;
            this.btnNaplai.HoverState.FillColor2 = System.Drawing.Color.DarkRed;
            this.btnNaplai.Location = new System.Drawing.Point(63, 204);
            this.btnNaplai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNaplai.Name = "btnNaplai";
            this.btnNaplai.ShadowDecoration.Color = System.Drawing.Color.RosyBrown;
            this.btnNaplai.ShadowDecoration.Enabled = true;
            this.btnNaplai.Size = new System.Drawing.Size(136, 42);
            this.btnNaplai.TabIndex = 27;
            this.btnNaplai.Text = "Nạp lại";
            // 
            // label6TL
            // 
            this.label6TL.AutoSize = true;
            this.label6TL.Location = new System.Drawing.Point(251, 126);
            this.label6TL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6TL.Name = "label6TL";
            this.label6TL.Size = new System.Drawing.Size(31, 32);
            this.label6TL.TabIndex = 20;
            this.label6TL.Text = "=";
            // 
            // comTentrgTL1
            // 
            this.comTentrgTL1.BackColor = System.Drawing.Color.Transparent;
            this.comTentrgTL1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comTentrgTL1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comTentrgTL1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comTentrgTL1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comTentrgTL1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comTentrgTL1.ForeColor = System.Drawing.Color.DarkGray;
            this.comTentrgTL1.ItemHeight = 18;
            this.comTentrgTL1.Location = new System.Drawing.Point(49, 126);
            this.comTentrgTL1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comTentrgTL1.Name = "comTentrgTL1";
            this.comTentrgTL1.Size = new System.Drawing.Size(175, 24);
            this.comTentrgTL1.TabIndex = 21;
            this.comTentrgTL1.SelectedIndexChanged += new System.EventHandler(this.comTentrgTL1_SelectedIndexChanged);
            // 
            // groupBox1TL
            // 
            this.groupBox1TL.Controls.Add(this.label5);
            this.groupBox1TL.Controls.Add(this.label6);
            this.groupBox1TL.Controls.Add(this.guna2TextBox1);
            this.groupBox1TL.Controls.Add(this.guna2ComboBox1);
            this.groupBox1TL.Controls.Add(this.guna2TextBox2);
            this.groupBox1TL.Controls.Add(this.label7);
            this.groupBox1TL.Controls.Add(this.label8);
            this.groupBox1TL.Controls.Add(this.guna2ComboBox2);
            this.groupBox1TL.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1TL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1TL.Location = new System.Drawing.Point(0, 61);
            this.groupBox1TL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1TL.Name = "groupBox1TL";
            this.groupBox1TL.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1TL.Size = new System.Drawing.Size(507, 297);
            this.groupBox1TL.TabIndex = 26;
            this.groupBox1TL.TabStop = false;
            this.groupBox1TL.Text = "Thông tin chi tiết";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 59);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 32);
            this.label5.TabIndex = 20;
            this.label5.Text = "Mã tài liệu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 114);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 32);
            this.label6.TabIndex = 21;
            this.label6.Text = "Tên tài liệu";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(208, 114);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(269, 45);
            this.guna2TextBox1.TabIndex = 6;
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.guna2ComboBox1.IntegralHeight = false;
            this.guna2ComboBox1.ItemHeight = 18;
            this.guna2ComboBox1.Location = new System.Drawing.Point(208, 224);
            this.guna2ComboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(268, 24);
            this.guna2ComboBox1.TabIndex = 14;
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox2.ForeColor = System.Drawing.Color.DarkGray;
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Location = new System.Drawing.Point(208, 59);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.Size = new System.Drawing.Size(269, 45);
            this.guna2TextBox2.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 224);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 32);
            this.label7.TabIndex = 23;
            this.label7.Text = "Tác giả";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 169);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 32);
            this.label8.TabIndex = 22;
            this.label8.Text = "Loại tài liệu";
            // 
            // guna2ComboBox2
            // 
            this.guna2ComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2ComboBox2.ForeColor = System.Drawing.Color.DarkGray;
            this.guna2ComboBox2.ItemHeight = 18;
            this.guna2ComboBox2.Items.AddRange(new object[] {
            "Giáo trình",
            "Tạp chí"});
            this.guna2ComboBox2.Location = new System.Drawing.Point(208, 169);
            this.guna2ComboBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2ComboBox2.Name = "guna2ComboBox2";
            this.guna2ComboBox2.Size = new System.Drawing.Size(268, 24);
            this.guna2ComboBox2.TabIndex = 5;
            // 
            // guna2GradientPanel1TL
            // 
            this.guna2GradientPanel1TL.BackColor = System.Drawing.Color.Brown;
            this.guna2GradientPanel1TL.Controls.Add(this.lblDMS);
            this.guna2GradientPanel1TL.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1TL.FillColor = System.Drawing.Color.Brown;
            this.guna2GradientPanel1TL.FillColor2 = System.Drawing.Color.Brown;
            this.guna2GradientPanel1TL.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1TL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2GradientPanel1TL.Name = "guna2GradientPanel1TL";
            this.guna2GradientPanel1TL.Size = new System.Drawing.Size(1200, 61);
            this.guna2GradientPanel1TL.TabIndex = 24;
            // 
            // guna2DragControl2TL
            // 
            this.guna2DragControl2TL.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl2TL.TargetControl = this.panelheaderDMS;
            this.guna2DragControl2TL.UseTransparentDrag = true;
            // 
            // frmDMSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 812);
            this.Controls.Add(this.guna2Panel1TL);
            this.Controls.Add(this.panelInputTL);
            this.Controls.Add(this.panelheaderDMS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDMSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh_muc_sach";
            this.panelheaderDMS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDSTL)).EndInit();
            this.panelInputTL.ResumeLayout(false);
            this.panelInputTL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingnavTL)).EndInit();
            this.bindingnavTL.ResumeLayout(false);
            this.bindingnavTL.PerformLayout();
            this.guna2Panel1TL.ResumeLayout(false);
            this.grbLocTL.ResumeLayout(false);
            this.grbLocTL.PerformLayout();
            this.groupBox1TL.ResumeLayout(false);
            this.groupBox1TL.PerformLayout();
            this.guna2GradientPanel1TL.ResumeLayout(false);
            this.guna2GradientPanel1TL.PerformLayout();
            this.ResumeLayout(false);

        }

        private void panelheaderDMS_Paint(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void comTentrgTL1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelheaderDMS;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDMS;
        private Guna.UI2.WinForms.Guna2DataGridView grdDSTL;
        private Guna.UI2.WinForms.Guna2Panel panelInputTL;
        private System.Windows.Forms.BindingNavigator bindingnavTL;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1TL;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1TL;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1TL;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2TL;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2TL;
        private System.Windows.Forms.Label label6TL;
        private System.Windows.Forms.Label lblGiatriTL;
        private System.Windows.Forms.Label lblTentrgTL;
        private Guna.UI2.WinForms.Guna2GradientButton btnThemTL1;
        private Guna.UI2.WinForms.Guna2GradientButton btnNaplai;
        private Guna.UI2.WinForms.Guna2GradientButton btnDongTL1;
        private Guna.UI2.WinForms.Guna2GradientButton btnLuuTL1;
        private Guna.UI2.WinForms.Guna2GradientButton btnXoaTL1;
        private Guna.UI2.WinForms.Guna2GradientButton btnSuaTL1;
        private Guna.UI2.WinForms.Guna2GradientButton btnTimTL1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTG;
        private Guna.UI2.WinForms.Guna2ComboBox comTentrgTL1;
        private System.Windows.Forms.GroupBox grbLocTL;
        private System.Windows.Forms.GroupBox groupBox1TL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox2;
        private Guna.UI2.WinForms.Guna2ComboBox comGTTL;
        private Guna.UI2.WinForms.Guna2GradientButton btnUpdateDMTL;
    }
}