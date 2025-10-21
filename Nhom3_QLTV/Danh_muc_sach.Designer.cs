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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDMSach));
            this.panelheaderDMS = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDMS = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.grdDSTL = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelInput = new Guna.UI2.WinForms.Guna2Panel();
            this.btnTimTL = new Guna.UI2.WinForms.Guna2Button();
            this.btnDongTL = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimTL = new Guna.UI2.WinForms.Guna2TextBox();
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
            this.btnSuaTL = new Guna.UI2.WinForms.Guna2Button();
            this.txtMaTL = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenTL = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboLoaiTL = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboTG = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnLuuTL = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemTL = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaTL = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelheaderDMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDSTL)).BeginInit();
            this.panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingnavTL)).BeginInit();
            this.bindingnavTL.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelheaderDMS
            // 
            this.panelheaderDMS.BackColor = System.Drawing.Color.Brown;
            this.panelheaderDMS.Controls.Add(this.lblDMS);
            this.panelheaderDMS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheaderDMS.Location = new System.Drawing.Point(0, 0);
            this.panelheaderDMS.Name = "panelheaderDMS";
            this.panelheaderDMS.Size = new System.Drawing.Size(900, 65);
            this.panelheaderDMS.TabIndex = 0;
            // 
            // lblDMS
            // 
            this.lblDMS.BackColor = System.Drawing.Color.Transparent;
            this.lblDMS.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDMS.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDMS.ForeColor = System.Drawing.Color.White;
            this.lblDMS.Location = new System.Drawing.Point(0, 0);
            this.lblDMS.Name = "lblDMS";
            this.lblDMS.Size = new System.Drawing.Size(225, 40);
            this.lblDMS.TabIndex = 0;
            this.lblDMS.Text = "Danh mục tài liệu";
            // 
            // grdDSTL
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.grdDSTL.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDSTL.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdDSTL.ColumnHeadersHeight = 34;
            this.grdDSTL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDSTL.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdDSTL.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grdDSTL.Location = new System.Drawing.Point(23, 72);
            this.grdDSTL.Name = "grdDSTL";
            this.grdDSTL.RowHeadersVisible = false;
            this.grdDSTL.RowHeadersWidth = 62;
            this.grdDSTL.RowTemplate.Height = 28;
            this.grdDSTL.Size = new System.Drawing.Size(848, 200);
            this.grdDSTL.TabIndex = 1;
            this.grdDSTL.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grdDSTL.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grdDSTL.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grdDSTL.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grdDSTL.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grdDSTL.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grdDSTL.ThemeStyle.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            // panelInput
            // 
            this.panelInput.BackColor = System.Drawing.Color.White;
            this.panelInput.Controls.Add(this.btnTimTL);
            this.panelInput.Controls.Add(this.btnDongTL);
            this.panelInput.Controls.Add(this.txtTimTL);
            this.panelInput.Controls.Add(this.bindingnavTL);
            this.panelInput.Controls.Add(this.grdDSTL);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInput.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelInput.Location = new System.Drawing.Point(0, 311);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(900, 339);
            this.panelInput.TabIndex = 2;
            // 
            // btnTimTL
            // 
            this.btnTimTL.BackColor = System.Drawing.Color.Brown;
            this.btnTimTL.BorderColor = System.Drawing.Color.White;
            this.btnTimTL.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimTL.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimTL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimTL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimTL.FillColor = System.Drawing.Color.Brown;
            this.btnTimTL.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTimTL.ForeColor = System.Drawing.Color.White;
            this.btnTimTL.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.btnTimTL.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnTimTL.Location = new System.Drawing.Point(386, 13);
            this.btnTimTL.Name = "btnTimTL";
            this.btnTimTL.PressedColor = System.Drawing.Color.DarkRed;
            this.btnTimTL.ShadowDecoration.Color = System.Drawing.Color.RosyBrown;
            this.btnTimTL.ShadowDecoration.Depth = 20;
            this.btnTimTL.ShadowDecoration.Enabled = true;
            this.btnTimTL.Size = new System.Drawing.Size(160, 43);
            this.btnTimTL.TabIndex = 17;
            this.btnTimTL.Text = "Tìm kiếm";
            // 
            // btnDongTL
            // 
            this.btnDongTL.BackColor = System.Drawing.Color.Brown;
            this.btnDongTL.BorderColor = System.Drawing.Color.White;
            this.btnDongTL.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDongTL.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDongTL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDongTL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDongTL.FillColor = System.Drawing.Color.Brown;
            this.btnDongTL.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDongTL.ForeColor = System.Drawing.Color.White;
            this.btnDongTL.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.btnDongTL.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnDongTL.Location = new System.Drawing.Point(735, 284);
            this.btnDongTL.Name = "btnDongTL";
            this.btnDongTL.PressedColor = System.Drawing.Color.DarkRed;
            this.btnDongTL.ShadowDecoration.Color = System.Drawing.Color.RosyBrown;
            this.btnDongTL.ShadowDecoration.Depth = 20;
            this.btnDongTL.ShadowDecoration.Enabled = true;
            this.btnDongTL.Size = new System.Drawing.Size(102, 43);
            this.btnDongTL.TabIndex = 19;
            this.btnDongTL.Text = "Đóng";
            // 
            // txtTimTL
            // 
            this.txtTimTL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimTL.DefaultText = "";
            this.txtTimTL.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimTL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimTL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimTL.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimTL.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimTL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimTL.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimTL.Location = new System.Drawing.Point(573, 12);
            this.txtTimTL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimTL.Name = "txtTimTL";
            this.txtTimTL.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTimTL.PlaceholderText = "Tên tài liệu";
            this.txtTimTL.SelectedText = "";
            this.txtTimTL.Size = new System.Drawing.Size(264, 45);
            this.txtTimTL.TabIndex = 15;
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
            this.bindingnavTL.Location = new System.Drawing.Point(282, 284);
            this.bindingnavTL.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingnavTL.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingnavTL.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingnavTL.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingnavTL.Name = "bindingnavTL";
            this.bindingnavTL.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingnavTL.Size = new System.Drawing.Size(280, 33);
            this.bindingnavTL.TabIndex = 6;
            this.bindingnavTL.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // btnSuaTL
            // 
            this.btnSuaTL.BackColor = System.Drawing.Color.Brown;
            this.btnSuaTL.BorderColor = System.Drawing.Color.White;
            this.btnSuaTL.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaTL.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaTL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuaTL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSuaTL.FillColor = System.Drawing.Color.Brown;
            this.btnSuaTL.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSuaTL.ForeColor = System.Drawing.Color.White;
            this.btnSuaTL.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.btnSuaTL.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnSuaTL.Location = new System.Drawing.Point(504, 186);
            this.btnSuaTL.Name = "btnSuaTL";
            this.btnSuaTL.PressedColor = System.Drawing.Color.DarkRed;
            this.btnSuaTL.ShadowDecoration.Color = System.Drawing.Color.RosyBrown;
            this.btnSuaTL.ShadowDecoration.Depth = 20;
            this.btnSuaTL.ShadowDecoration.Enabled = true;
            this.btnSuaTL.Size = new System.Drawing.Size(102, 43);
            this.btnSuaTL.TabIndex = 2;
            this.btnSuaTL.Text = "Sửa";
            // 
            // txtMaTL
            // 
            this.txtMaTL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaTL.DefaultText = "";
            this.txtMaTL.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaTL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaTL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaTL.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaTL.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaTL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaTL.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaTL.Location = new System.Drawing.Point(177, 15);
            this.txtMaTL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaTL.Name = "txtMaTL";
            this.txtMaTL.PlaceholderText = "";
            this.txtMaTL.SelectedText = "";
            this.txtMaTL.Size = new System.Drawing.Size(202, 36);
            this.txtMaTL.TabIndex = 5;
            this.txtMaTL.TextChanged += new System.EventHandler(this.txtMaTL_TextChanged);
            // 
            // txtTenTL
            // 
            this.txtTenTL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenTL.DefaultText = "";
            this.txtTenTL.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenTL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenTL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenTL.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenTL.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenTL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenTL.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenTL.Location = new System.Drawing.Point(550, 15);
            this.txtTenTL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenTL.Name = "txtTenTL";
            this.txtTenTL.PlaceholderText = "";
            this.txtTenTL.SelectedText = "";
            this.txtTenTL.Size = new System.Drawing.Size(287, 36);
            this.txtTenTL.TabIndex = 6;
            // 
            // cboLoaiTL
            // 
            this.cboLoaiTL.BackColor = System.Drawing.Color.Transparent;
            this.cboLoaiTL.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLoaiTL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiTL.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLoaiTL.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLoaiTL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiTL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboLoaiTL.ItemHeight = 30;
            this.cboLoaiTL.Location = new System.Drawing.Point(177, 100);
            this.cboLoaiTL.Name = "cboLoaiTL";
            this.cboLoaiTL.Size = new System.Drawing.Size(202, 36);
            this.cboLoaiTL.TabIndex = 12;
            // 
            // cboTG
            // 
            this.cboTG.BackColor = System.Drawing.Color.Transparent;
            this.cboTG.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTG.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTG.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTG.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboTG.ItemHeight = 30;
            this.cboTG.Location = new System.Drawing.Point(550, 96);
            this.cboTG.Name = "cboTG";
            this.cboTG.Size = new System.Drawing.Size(287, 36);
            this.cboTG.TabIndex = 14;
            // 
            // btnLuuTL
            // 
            this.btnLuuTL.BackColor = System.Drawing.Color.Brown;
            this.btnLuuTL.BorderColor = System.Drawing.Color.White;
            this.btnLuuTL.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuuTL.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuuTL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuuTL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuuTL.FillColor = System.Drawing.Color.Brown;
            this.btnLuuTL.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuuTL.ForeColor = System.Drawing.Color.White;
            this.btnLuuTL.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.btnLuuTL.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnLuuTL.Location = new System.Drawing.Point(786, 186);
            this.btnLuuTL.Name = "btnLuuTL";
            this.btnLuuTL.PressedColor = System.Drawing.Color.DarkRed;
            this.btnLuuTL.ShadowDecoration.Color = System.Drawing.Color.RosyBrown;
            this.btnLuuTL.ShadowDecoration.Depth = 20;
            this.btnLuuTL.ShadowDecoration.Enabled = true;
            this.btnLuuTL.Size = new System.Drawing.Size(102, 43);
            this.btnLuuTL.TabIndex = 15;
            this.btnLuuTL.Text = "Lưu";
            // 
            // btnThemTL
            // 
            this.btnThemTL.BackColor = System.Drawing.Color.Brown;
            this.btnThemTL.BorderColor = System.Drawing.Color.White;
            this.btnThemTL.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemTL.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemTL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemTL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemTL.FillColor = System.Drawing.Color.Brown;
            this.btnThemTL.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThemTL.ForeColor = System.Drawing.Color.White;
            this.btnThemTL.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.btnThemTL.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnThemTL.Location = new System.Drawing.Point(363, 186);
            this.btnThemTL.Name = "btnThemTL";
            this.btnThemTL.PressedColor = System.Drawing.Color.DarkRed;
            this.btnThemTL.ShadowDecoration.Color = System.Drawing.Color.RosyBrown;
            this.btnThemTL.ShadowDecoration.Depth = 20;
            this.btnThemTL.ShadowDecoration.Enabled = true;
            this.btnThemTL.Size = new System.Drawing.Size(102, 43);
            this.btnThemTL.TabIndex = 16;
            this.btnThemTL.Text = "Thêm";
            // 
            // btnXoaTL
            // 
            this.btnXoaTL.BackColor = System.Drawing.Color.Brown;
            this.btnXoaTL.BorderColor = System.Drawing.Color.White;
            this.btnXoaTL.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaTL.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaTL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaTL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaTL.FillColor = System.Drawing.Color.Brown;
            this.btnXoaTL.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoaTL.ForeColor = System.Drawing.Color.White;
            this.btnXoaTL.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.btnXoaTL.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnXoaTL.Location = new System.Drawing.Point(645, 186);
            this.btnXoaTL.Name = "btnXoaTL";
            this.btnXoaTL.PressedColor = System.Drawing.Color.DarkRed;
            this.btnXoaTL.ShadowDecoration.Color = System.Drawing.Color.RosyBrown;
            this.btnXoaTL.ShadowDecoration.Depth = 20;
            this.btnXoaTL.ShadowDecoration.Enabled = true;
            this.btnXoaTL.Size = new System.Drawing.Size(102, 43);
            this.btnXoaTL.TabIndex = 18;
            this.btnXoaTL.Text = "Xóa";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.btnThemTL);
            this.guna2Panel1.Controls.Add(this.btnXoaTL);
            this.guna2Panel1.Controls.Add(this.btnLuuTL);
            this.guna2Panel1.Controls.Add(this.cboTG);
            this.guna2Panel1.Controls.Add(this.cboLoaiTL);
            this.guna2Panel1.Controls.Add(this.txtTenTL);
            this.guna2Panel1.Controls.Add(this.txtMaTL);
            this.guna2Panel1.Controls.Add(this.btnSuaTL);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 65);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(900, 246);
            this.guna2Panel1.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(421, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Tác giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Loại tài liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(421, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tên tài liệu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Mã tài liệu";
            // 
            // frmDMSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.panelheaderDMS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDMSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh_muc_sach";
            this.panelheaderDMS.ResumeLayout(false);
            this.panelheaderDMS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDSTL)).EndInit();
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingnavTL)).EndInit();
            this.bindingnavTL.ResumeLayout(false);
            this.bindingnavTL.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelheaderDMS;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDMS;
        private Guna.UI2.WinForms.Guna2DataGridView grdDSTL;
        private Guna.UI2.WinForms.Guna2Panel panelInput;
        private Guna.UI2.WinForms.Guna2Button btnSuaTL;
        private Guna.UI2.WinForms.Guna2TextBox txtMaTL;
        private Guna.UI2.WinForms.Guna2TextBox txtTenTL;
        private Guna.UI2.WinForms.Guna2ComboBox cboLoaiTL;
        private Guna.UI2.WinForms.Guna2ComboBox cboTG;
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
        private Guna.UI2.WinForms.Guna2TextBox txtTimTL;
        private Guna.UI2.WinForms.Guna2Button btnXoaTL;
        private Guna.UI2.WinForms.Guna2Button btnThemTL;
        private Guna.UI2.WinForms.Guna2Button btnLuuTL;
        private Guna.UI2.WinForms.Guna2Button btnTimTL;
        private Guna.UI2.WinForms.Guna2Button btnDongTL;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}