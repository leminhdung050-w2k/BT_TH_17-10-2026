namespace BT4._9
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuTep = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXuatCsv = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslSoLuong = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.tlpNhap = new System.Windows.Forms.TableLayoutPanel();
            this.lblMa = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.lblNgayHen = new System.Windows.Forms.Label();
            this.dtpNgayHen = new System.Windows.Forms.DateTimePicker();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblBacSi = new System.Windows.Forms.Label();
            this.cboBacSi = new System.Windows.Forms.ComboBox();
            this.lblSdt = new System.Windows.Forms.Label();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.lblLyDo = new System.Windows.Forms.Label();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.flpNut = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.flpLoc = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTim = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.chkLocNgay = new System.Windows.Forms.CheckBox();
            this.dtpLocNgay = new System.Windows.Forms.DateTimePicker();
            this.lblLocTT = new System.Windows.Forms.Label();
            this.cboLocTrangThai = new System.Windows.Forms.ComboBox();
            this.btnBoLoc = new System.Windows.Forms.Button();
            this.dgvLichHen = new System.Windows.Forms.DataGridView();
            this.colMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayHen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBacSi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLyDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.grpThongTin.SuspendLayout();
            this.tlpNhap.SuspendLayout();
            this.flpNut.SuspendLayout();
            this.flpLoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichHen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTep});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1084, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuTep
            // 
            this.mnuTep.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuXuatCsv,
            this.mnuSep1,
            this.mnuThoat});
            this.mnuTep.Name = "mnuTep";
            this.mnuTep.Size = new System.Drawing.Size(48, 24);
            this.mnuTep.Text = "&Tệp";
            // 
            // mnuXuatCsv
            // 
            this.mnuXuatCsv.Name = "mnuXuatCsv";
            this.mnuXuatCsv.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.mnuXuatCsv.Size = new System.Drawing.Size(227, 26);
            this.mnuXuatCsv.Text = "Xuất file CSV";
            // 
            // mnuSep1
            // 
            this.mnuSep1.Name = "mnuSep1";
            this.mnuSep1.Size = new System.Drawing.Size(224, 6);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(227, 26);
            this.mnuThoat.Text = "Thoát";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslSoLuong});
            this.statusStrip1.Location = new System.Drawing.Point(0, 635);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1084, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslSoLuong
            // 
            this.tsslSoLuong.Name = "tsslSoLuong";
            this.tsslSoLuong.Size = new System.Drawing.Size(68, 20);
            this.tsslSoLuong.Text = "Sẵn sàng";
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.grpThongTin, 0, 0);
            this.tlpMain.Controls.Add(this.flpLoc, 0, 1);
            this.tlpMain.Controls.Add(this.dgvLichHen, 0, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 28);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.Padding = new System.Windows.Forms.Padding(6);
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(1084, 607);
            this.tlpMain.TabIndex = 1;
            // 
            // grpThongTin
            // 
            this.grpThongTin.AutoSize = true;
            this.grpThongTin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpThongTin.Controls.Add(this.tlpNhap);
            this.grpThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpThongTin.Location = new System.Drawing.Point(9, 9);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Padding = new System.Windows.Forms.Padding(8, 4, 8, 6);
            this.grpThongTin.Size = new System.Drawing.Size(1066, 215);
            this.grpThongTin.TabIndex = 0;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin lịch hẹn";
            // 
            // tlpNhap
            // 
            this.tlpNhap.AutoSize = true;
            this.tlpNhap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpNhap.ColumnCount = 4;
            this.tlpNhap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tlpNhap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpNhap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tlpNhap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpNhap.Controls.Add(this.lblMa, 0, 0);
            this.tlpNhap.Controls.Add(this.txtMa, 1, 0);
            this.tlpNhap.Controls.Add(this.lblNgayHen, 2, 0);
            this.tlpNhap.Controls.Add(this.dtpNgayHen, 3, 0);
            this.tlpNhap.Controls.Add(this.lblHoTen, 0, 1);
            this.tlpNhap.Controls.Add(this.txtHoTen, 1, 1);
            this.tlpNhap.Controls.Add(this.lblBacSi, 2, 1);
            this.tlpNhap.Controls.Add(this.cboBacSi, 3, 1);
            this.tlpNhap.Controls.Add(this.lblSdt, 0, 2);
            this.tlpNhap.Controls.Add(this.txtSdt, 1, 2);
            this.tlpNhap.Controls.Add(this.lblTrangThai, 2, 2);
            this.tlpNhap.Controls.Add(this.cboTrangThai, 3, 2);
            this.tlpNhap.Controls.Add(this.lblLyDo, 0, 3);
            this.tlpNhap.Controls.Add(this.txtLyDo, 1, 3);
            this.tlpNhap.Controls.Add(this.flpNut, 0, 4);
            this.tlpNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpNhap.Location = new System.Drawing.Point(8, 24);
            this.tlpNhap.Name = "tlpNhap";
            this.tlpNhap.RowCount = 5;
            this.tlpNhap.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpNhap.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpNhap.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpNhap.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpNhap.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpNhap.Size = new System.Drawing.Size(1050, 185);
            this.tlpNhap.TabIndex = 0;
            // 
            // lblMa
            // 
            this.lblMa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(3, 7);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(88, 20);
            this.lblMa.TabIndex = 0;
            this.lblMa.Text = "Mã lịch hẹn:";
            // 
            // txtMa
            // 
            this.txtMa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMa.Location = new System.Drawing.Point(113, 4);
            this.txtMa.Margin = new System.Windows.Forms.Padding(3, 4, 22, 4);
            this.txtMa.MaxLength = 10;
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(390, 27);
            this.txtMa.TabIndex = 1;
            // 
            // lblNgayHen
            // 
            this.lblNgayHen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNgayHen.AutoSize = true;
            this.lblNgayHen.Location = new System.Drawing.Point(528, 7);
            this.lblNgayHen.Name = "lblNgayHen";
            this.lblNgayHen.Size = new System.Drawing.Size(101, 20);
            this.lblNgayHen.TabIndex = 8;
            this.lblNgayHen.Text = "Ngày giờ hẹn:";
            // 
            // dtpNgayHen
            // 
            this.dtpNgayHen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgayHen.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpNgayHen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayHen.Location = new System.Drawing.Point(638, 4);
            this.dtpNgayHen.Margin = new System.Windows.Forms.Padding(3, 4, 22, 4);
            this.dtpNgayHen.Name = "dtpNgayHen";
            this.dtpNgayHen.Size = new System.Drawing.Size(390, 27);
            this.dtpNgayHen.TabIndex = 9;
            // 
            // lblHoTen
            // 
            this.lblHoTen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(3, 43);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(57, 20);
            this.lblHoTen.TabIndex = 2;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHoTen.Location = new System.Drawing.Point(113, 39);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(3, 4, 22, 4);
            this.txtHoTen.MaxLength = 100;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(390, 27);
            this.txtHoTen.TabIndex = 3;
            // 
            // lblBacSi
            // 
            this.lblBacSi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBacSi.AutoSize = true;
            this.lblBacSi.Location = new System.Drawing.Point(528, 43);
            this.lblBacSi.Name = "lblBacSi";
            this.lblBacSi.Size = new System.Drawing.Size(50, 20);
            this.lblBacSi.TabIndex = 10;
            this.lblBacSi.Text = "Bác sĩ:";
            // 
            // cboBacSi
            // 
            this.cboBacSi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboBacSi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBacSi.FormattingEnabled = true;
            this.cboBacSi.Location = new System.Drawing.Point(638, 39);
            this.cboBacSi.Margin = new System.Windows.Forms.Padding(3, 4, 22, 4);
            this.cboBacSi.Name = "cboBacSi";
            this.cboBacSi.Size = new System.Drawing.Size(390, 28);
            this.cboBacSi.TabIndex = 11;
            // 
            // lblSdt
            // 
            this.lblSdt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSdt.AutoSize = true;
            this.lblSdt.Location = new System.Drawing.Point(3, 78);
            this.lblSdt.Name = "lblSdt";
            this.lblSdt.Size = new System.Drawing.Size(100, 20);
            this.lblSdt.TabIndex = 4;
            this.lblSdt.Text = "Số điện thoại:";
            // 
            // txtSdt
            // 
            this.txtSdt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSdt.Location = new System.Drawing.Point(113, 75);
            this.txtSdt.Margin = new System.Windows.Forms.Padding(3, 4, 22, 4);
            this.txtSdt.MaxLength = 15;
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(390, 27);
            this.txtSdt.TabIndex = 5;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(528, 78);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(78, 20);
            this.lblTrangThai.TabIndex = 12;
            this.lblTrangThai.Text = "Trạng thái:";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Location = new System.Drawing.Point(638, 76);
            this.cboTrangThai.Margin = new System.Windows.Forms.Padding(3, 4, 22, 4);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(390, 28);
            this.cboTrangThai.TabIndex = 13;
            // 
            // lblLyDo
            // 
            this.lblLyDo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLyDo.AutoSize = true;
            this.lblLyDo.Location = new System.Drawing.Point(3, 113);
            this.lblLyDo.Name = "lblLyDo";
            this.lblLyDo.Size = new System.Drawing.Size(87, 20);
            this.lblLyDo.TabIndex = 6;
            this.lblLyDo.Text = "Lý do khám:";
            // 
            // txtLyDo
            // 
            this.txtLyDo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpNhap.SetColumnSpan(this.txtLyDo, 3);
            this.txtLyDo.Location = new System.Drawing.Point(113, 110);
            this.txtLyDo.Margin = new System.Windows.Forms.Padding(3, 4, 22, 4);
            this.txtLyDo.MaxLength = 200;
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(915, 27);
            this.txtLyDo.TabIndex = 7;
            // 
            // flpNut
            // 
            this.flpNut.AutoSize = true;
            this.flpNut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpNhap.SetColumnSpan(this.flpNut, 4);
            this.flpNut.Controls.Add(this.btnThem);
            this.flpNut.Controls.Add(this.btnCapNhat);
            this.flpNut.Controls.Add(this.btnXoa);
            this.flpNut.Controls.Add(this.btnLamMoi);
            this.flpNut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpNut.Location = new System.Drawing.Point(110, 144);
            this.flpNut.Margin = new System.Windows.Forms.Padding(110, 3, 3, 3);
            this.flpNut.Name = "flpNut";
            this.flpNut.Size = new System.Drawing.Size(937, 38);
            this.flpNut.TabIndex = 14;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(3, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(105, 32);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "&Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(114, 3);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(105, 32);
            this.btnCapNhat.TabIndex = 1;
            this.btnCapNhat.Text = "&Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(225, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(105, 32);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(336, 3);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(105, 32);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "&Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // flpLoc
            // 
            this.flpLoc.AutoSize = true;
            this.flpLoc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpLoc.Controls.Add(this.lblTim);
            this.flpLoc.Controls.Add(this.txtTimKiem);
            this.flpLoc.Controls.Add(this.chkLocNgay);
            this.flpLoc.Controls.Add(this.dtpLocNgay);
            this.flpLoc.Controls.Add(this.lblLocTT);
            this.flpLoc.Controls.Add(this.cboLocTrangThai);
            this.flpLoc.Controls.Add(this.btnBoLoc);
            this.flpLoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpLoc.Location = new System.Drawing.Point(9, 230);
            this.flpLoc.Name = "flpLoc";
            this.flpLoc.Size = new System.Drawing.Size(1066, 36);
            this.flpLoc.TabIndex = 1;
            // 
            // lblTim
            // 
            this.lblTim.AutoSize = true;
            this.lblTim.Location = new System.Drawing.Point(3, 9);
            this.lblTim.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.lblTim.Name = "lblTim";
            this.lblTim.Size = new System.Drawing.Size(113, 20);
            this.lblTim.TabIndex = 0;
            this.lblTim.Text = "Tìm (tên / SĐT):";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(122, 5);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 5, 20, 3);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(240, 27);
            this.txtTimKiem.TabIndex = 1;
            // 
            // chkLocNgay
            // 
            this.chkLocNgay.AutoSize = true;
            this.chkLocNgay.Location = new System.Drawing.Point(385, 8);
            this.chkLocNgay.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.chkLocNgay.Name = "chkLocNgay";
            this.chkLocNgay.Size = new System.Drawing.Size(127, 24);
            this.chkLocNgay.TabIndex = 2;
            this.chkLocNgay.Text = "Lọc theo ngày:";
            this.chkLocNgay.UseVisualStyleBackColor = true;
            // 
            // dtpLocNgay
            // 
            this.dtpLocNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpLocNgay.Enabled = false;
            this.dtpLocNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLocNgay.Location = new System.Drawing.Point(518, 5);
            this.dtpLocNgay.Margin = new System.Windows.Forms.Padding(3, 5, 20, 3);
            this.dtpLocNgay.Name = "dtpLocNgay";
            this.dtpLocNgay.Size = new System.Drawing.Size(120, 27);
            this.dtpLocNgay.TabIndex = 3;
            // 
            // lblLocTT
            // 
            this.lblLocTT.AutoSize = true;
            this.lblLocTT.Location = new System.Drawing.Point(661, 9);
            this.lblLocTT.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.lblLocTT.Name = "lblLocTT";
            this.lblLocTT.Size = new System.Drawing.Size(78, 20);
            this.lblLocTT.TabIndex = 4;
            this.lblLocTT.Text = "Trạng thái:";
            // 
            // cboLocTrangThai
            // 
            this.cboLocTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocTrangThai.FormattingEnabled = true;
            this.cboLocTrangThai.Location = new System.Drawing.Point(745, 5);
            this.cboLocTrangThai.Margin = new System.Windows.Forms.Padding(3, 5, 20, 3);
            this.cboLocTrangThai.Name = "cboLocTrangThai";
            this.cboLocTrangThai.Size = new System.Drawing.Size(140, 28);
            this.cboLocTrangThai.TabIndex = 5;
            // 
            // btnBoLoc
            // 
            this.btnBoLoc.Location = new System.Drawing.Point(908, 3);
            this.btnBoLoc.Name = "btnBoLoc";
            this.btnBoLoc.Size = new System.Drawing.Size(90, 29);
            this.btnBoLoc.TabIndex = 6;
            this.btnBoLoc.Text = "Bỏ lọc";
            this.btnBoLoc.UseVisualStyleBackColor = true;
            // 
            // dgvLichHen
            // 
            this.dgvLichHen.AllowUserToAddRows = false;
            this.dgvLichHen.AllowUserToDeleteRows = false;
            this.dgvLichHen.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvLichHen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichHen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMa,
            this.colHoTen,
            this.colSdt,
            this.colNgayHen,
            this.colBacSi,
            this.colLyDo,
            this.colTrangThai});
            this.dgvLichHen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLichHen.Location = new System.Drawing.Point(9, 272);
            this.dgvLichHen.MultiSelect = false;
            this.dgvLichHen.Name = "dgvLichHen";
            this.dgvLichHen.ReadOnly = true;
            this.dgvLichHen.RowHeadersVisible = false;
            this.dgvLichHen.RowHeadersWidth = 51;
            this.dgvLichHen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichHen.Size = new System.Drawing.Size(1066, 326);
            this.dgvLichHen.TabIndex = 2;
            // 
            // colMa
            // 
            this.colMa.DataPropertyName = "MaLichHen";
            this.colMa.HeaderText = "Mã lịch hẹn";
            this.colMa.MinimumWidth = 6;
            this.colMa.Name = "colMa";
            this.colMa.ReadOnly = true;
            this.colMa.Width = 90;
            // 
            // colHoTen
            // 
            this.colHoTen.DataPropertyName = "HoTen";
            this.colHoTen.HeaderText = "Họ tên";
            this.colHoTen.MinimumWidth = 6;
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.ReadOnly = true;
            this.colHoTen.Width = 160;
            // 
            // colSdt
            // 
            this.colSdt.DataPropertyName = "SoDienThoai";
            this.colSdt.HeaderText = "Số điện thoại";
            this.colSdt.MinimumWidth = 6;
            this.colSdt.Name = "colSdt";
            this.colSdt.ReadOnly = true;
            this.colSdt.Width = 110;
            // 
            // colNgayHen
            // 
            this.colNgayHen.DataPropertyName = "NgayHen";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy HH:mm";
            this.colNgayHen.DefaultCellStyle = dataGridViewCellStyle1;
            this.colNgayHen.HeaderText = "Ngày giờ hẹn";
            this.colNgayHen.MinimumWidth = 6;
            this.colNgayHen.Name = "colNgayHen";
            this.colNgayHen.ReadOnly = true;
            this.colNgayHen.Width = 125;
            // 
            // colBacSi
            // 
            this.colBacSi.DataPropertyName = "BacSi";
            this.colBacSi.HeaderText = "Bác sĩ";
            this.colBacSi.MinimumWidth = 6;
            this.colBacSi.Name = "colBacSi";
            this.colBacSi.ReadOnly = true;
            this.colBacSi.Width = 150;
            // 
            // colLyDo
            // 
            this.colLyDo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLyDo.DataPropertyName = "LyDo";
            this.colLyDo.HeaderText = "Lý do khám";
            this.colLyDo.MinimumWidth = 6;
            this.colLyDo.Name = "colLyDo";
            this.colLyDo.ReadOnly = true;
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            this.colTrangThai.Width = 125;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "csv";
            this.saveFileDialog1.Filter = "CSV (*.csv)|*.csv";
            this.saveFileDialog1.Title = "Xuất danh sách lịch hẹn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.tlpMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý lịch hẹn phòng khám";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.tlpNhap.ResumeLayout(false);
            this.tlpNhap.PerformLayout();
            this.flpNut.ResumeLayout(false);
            this.flpLoc.ResumeLayout(false);
            this.flpLoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichHen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuTep;
        private System.Windows.Forms.ToolStripMenuItem mnuXuatCsv;
        private System.Windows.Forms.ToolStripSeparator mnuSep1;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslSoLuong;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.TableLayoutPanel tlpNhap;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label lblNgayHen;
        private System.Windows.Forms.DateTimePicker dtpNgayHen;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblBacSi;
        private System.Windows.Forms.ComboBox cboBacSi;
        private System.Windows.Forms.Label lblSdt;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Label lblLyDo;
        private System.Windows.Forms.TextBox txtLyDo;
        private System.Windows.Forms.FlowLayoutPanel flpNut;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.FlowLayoutPanel flpLoc;
        private System.Windows.Forms.Label lblTim;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.CheckBox chkLocNgay;
        private System.Windows.Forms.DateTimePicker dtpLocNgay;
        private System.Windows.Forms.Label lblLocTT;
        private System.Windows.Forms.ComboBox cboLocTrangThai;
        private System.Windows.Forms.Button btnBoLoc;
        private System.Windows.Forms.DataGridView dgvLichHen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayHen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBacSi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLyDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
