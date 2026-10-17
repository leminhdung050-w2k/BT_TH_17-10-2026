namespace BT4._11
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuTep = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXuatCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.grpDon = new System.Windows.Forms.GroupBox();
            this.lblMaDon = new System.Windows.Forms.Label();
            this.txtMaDon = new System.Windows.Forms.TextBox();
            this.lblTenKhach = new System.Windows.Forms.Label();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.lblLoaiThietBi = new System.Windows.Forms.Label();
            this.cboLoaiThietBi = new System.Windows.Forms.ComboBox();
            this.lblNgayTiepNhan = new System.Windows.Forms.Label();
            this.dtpNgayTiepNhan = new System.Windows.Forms.DateTimePicker();
            this.lblChiPhi = new System.Windows.Forms.Label();
            this.txtChiPhi = new System.Windows.Forms.TextBox();
            this.lblDonVi = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.lblMoTaLoi = new System.Windows.Forms.Label();
            this.txtMoTaLoi = new System.Windows.Forms.TextBox();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.btnXoaAnh = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.pnlTimKiem = new System.Windows.Forms.Panel();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblLoc = new System.Windows.Forms.Label();
            this.cboLoc = new System.Windows.Forms.ComboBox();
            this.dgvDon = new System.Windows.Forms.DataGridView();
            this.colMaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenKhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiThietBi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMoTaLoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayTiepNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChiPhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblSoDon = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTongChiPhi = new System.Windows.Forms.ToolStripStatusLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bsDon = new System.Windows.Forms.BindingSource(this.components);
            this.sfdXuatCSV = new System.Windows.Forms.SaveFileDialog();
            this.ofdChonAnh = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.grpDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.pnlTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDon)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDon)).BeginInit();
            this.SuspendLayout();
            //
            // menuStrip1
            //
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTep});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1182, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            //
            // mnuTep
            //
            this.mnuTep.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuXuatCSV,
            this.mnuSeparator1,
            this.mnuThoat});
            this.mnuTep.Name = "mnuTep";
            this.mnuTep.Size = new System.Drawing.Size(46, 24);
            this.mnuTep.Text = "&Tệp";
            //
            // mnuXuatCSV
            //
            this.mnuXuatCSV.Name = "mnuXuatCSV";
            this.mnuXuatCSV.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuXuatCSV.Size = new System.Drawing.Size(290, 26);
            this.mnuXuatCSV.Text = "Xuất danh sách ra CSV...";
            this.mnuXuatCSV.Click += new System.EventHandler(this.mnuXuatCSV_Click);
            //
            // mnuSeparator1
            //
            this.mnuSeparator1.Name = "mnuSeparator1";
            this.mnuSeparator1.Size = new System.Drawing.Size(287, 6);
            //
            // mnuThoat
            //
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuThoat.Size = new System.Drawing.Size(290, 26);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            //
            // grpDon
            //
            this.grpDon.Controls.Add(this.lblMaDon);
            this.grpDon.Controls.Add(this.txtMaDon);
            this.grpDon.Controls.Add(this.lblTenKhach);
            this.grpDon.Controls.Add(this.txtTenKhach);
            this.grpDon.Controls.Add(this.lblSoDienThoai);
            this.grpDon.Controls.Add(this.txtSoDienThoai);
            this.grpDon.Controls.Add(this.lblLoaiThietBi);
            this.grpDon.Controls.Add(this.cboLoaiThietBi);
            this.grpDon.Controls.Add(this.lblNgayTiepNhan);
            this.grpDon.Controls.Add(this.dtpNgayTiepNhan);
            this.grpDon.Controls.Add(this.lblChiPhi);
            this.grpDon.Controls.Add(this.txtChiPhi);
            this.grpDon.Controls.Add(this.lblDonVi);
            this.grpDon.Controls.Add(this.lblTrangThai);
            this.grpDon.Controls.Add(this.cboTrangThai);
            this.grpDon.Controls.Add(this.lblMoTaLoi);
            this.grpDon.Controls.Add(this.txtMoTaLoi);
            this.grpDon.Controls.Add(this.picAnh);
            this.grpDon.Controls.Add(this.btnChonAnh);
            this.grpDon.Controls.Add(this.btnXoaAnh);
            this.grpDon.Controls.Add(this.btnThem);
            this.grpDon.Controls.Add(this.btnCapNhat);
            this.grpDon.Controls.Add(this.btnXoa);
            this.grpDon.Controls.Add(this.btnLamMoi);
            this.grpDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDon.Location = new System.Drawing.Point(0, 28);
            this.grpDon.Name = "grpDon";
            this.grpDon.Size = new System.Drawing.Size(1182, 255);
            this.grpDon.TabIndex = 1;
            this.grpDon.TabStop = false;
            this.grpDon.Text = "Thông tin đơn sửa chữa";
            //
            // lblMaDon
            //
            this.lblMaDon.AutoSize = true;
            this.lblMaDon.Location = new System.Drawing.Point(15, 33);
            this.lblMaDon.Name = "lblMaDon";
            this.lblMaDon.Size = new System.Drawing.Size(52, 16);
            this.lblMaDon.TabIndex = 0;
            this.lblMaDon.Text = "Mã đơn";
            //
            // txtMaDon
            //
            this.txtMaDon.Location = new System.Drawing.Point(130, 30);
            this.txtMaDon.Name = "txtMaDon";
            this.txtMaDon.Size = new System.Drawing.Size(220, 22);
            this.txtMaDon.TabIndex = 1;
            //
            // lblTenKhach
            //
            this.lblTenKhach.AutoSize = true;
            this.lblTenKhach.Location = new System.Drawing.Point(15, 68);
            this.lblTenKhach.Name = "lblTenKhach";
            this.lblTenKhach.Size = new System.Drawing.Size(101, 16);
            this.lblTenKhach.TabIndex = 2;
            this.lblTenKhach.Text = "Tên khách hàng";
            //
            // txtTenKhach
            //
            this.txtTenKhach.Location = new System.Drawing.Point(130, 65);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.Size = new System.Drawing.Size(220, 22);
            this.txtTenKhach.TabIndex = 3;
            //
            // lblSoDienThoai
            //
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Location = new System.Drawing.Point(15, 103);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(85, 16);
            this.lblSoDienThoai.TabIndex = 4;
            this.lblSoDienThoai.Text = "Số điện thoại";
            //
            // txtSoDienThoai
            //
            this.txtSoDienThoai.Location = new System.Drawing.Point(130, 100);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(220, 22);
            this.txtSoDienThoai.TabIndex = 5;
            //
            // lblLoaiThietBi
            //
            this.lblLoaiThietBi.AutoSize = true;
            this.lblLoaiThietBi.Location = new System.Drawing.Point(15, 138);
            this.lblLoaiThietBi.Name = "lblLoaiThietBi";
            this.lblLoaiThietBi.Size = new System.Drawing.Size(80, 16);
            this.lblLoaiThietBi.TabIndex = 6;
            this.lblLoaiThietBi.Text = "Loại thiết bị";
            //
            // cboLoaiThietBi
            //
            this.cboLoaiThietBi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiThietBi.FormattingEnabled = true;
            this.cboLoaiThietBi.Items.AddRange(new object[] {
            "Điện thoại",
            "Laptop",
            "Máy tính bảng",
            "Tivi",
            "Máy in",
            "Tủ lạnh",
            "Máy giặt",
            "Khác"});
            this.cboLoaiThietBi.Location = new System.Drawing.Point(130, 134);
            this.cboLoaiThietBi.Name = "cboLoaiThietBi";
            this.cboLoaiThietBi.Size = new System.Drawing.Size(220, 24);
            this.cboLoaiThietBi.TabIndex = 7;
            //
            // lblNgayTiepNhan
            //
            this.lblNgayTiepNhan.AutoSize = true;
            this.lblNgayTiepNhan.Location = new System.Drawing.Point(15, 173);
            this.lblNgayTiepNhan.Name = "lblNgayTiepNhan";
            this.lblNgayTiepNhan.Size = new System.Drawing.Size(99, 16);
            this.lblNgayTiepNhan.TabIndex = 8;
            this.lblNgayTiepNhan.Text = "Ngày tiếp nhận";
            //
            // dtpNgayTiepNhan
            //
            this.dtpNgayTiepNhan.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayTiepNhan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTiepNhan.Location = new System.Drawing.Point(130, 170);
            this.dtpNgayTiepNhan.Name = "dtpNgayTiepNhan";
            this.dtpNgayTiepNhan.Size = new System.Drawing.Size(220, 22);
            this.dtpNgayTiepNhan.TabIndex = 9;
            //
            // lblChiPhi
            //
            this.lblChiPhi.AutoSize = true;
            this.lblChiPhi.Location = new System.Drawing.Point(380, 33);
            this.lblChiPhi.Name = "lblChiPhi";
            this.lblChiPhi.Size = new System.Drawing.Size(103, 16);
            this.lblChiPhi.TabIndex = 10;
            this.lblChiPhi.Text = "Chi phí dự kiến";
            //
            // txtChiPhi
            //
            this.txtChiPhi.Location = new System.Drawing.Point(500, 30);
            this.txtChiPhi.Name = "txtChiPhi";
            this.txtChiPhi.Size = new System.Drawing.Size(200, 22);
            this.txtChiPhi.TabIndex = 11;
            this.txtChiPhi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // lblDonVi
            //
            this.lblDonVi.AutoSize = true;
            this.lblDonVi.Location = new System.Drawing.Point(706, 33);
            this.lblDonVi.Name = "lblDonVi";
            this.lblDonVi.Size = new System.Drawing.Size(36, 16);
            this.lblDonVi.TabIndex = 12;
            this.lblDonVi.Text = "VNĐ";
            //
            // lblTrangThai
            //
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(380, 68);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(69, 16);
            this.lblTrangThai.TabIndex = 13;
            this.lblTrangThai.Text = "Trạng thái";
            //
            // cboTrangThai
            //
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Mới tiếp nhận",
            "Đang sửa",
            "Chờ linh kiện",
            "Hoàn tất",
            "Đã hủy"});
            this.cboTrangThai.Location = new System.Drawing.Point(500, 64);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(200, 24);
            this.cboTrangThai.TabIndex = 14;
            //
            // lblMoTaLoi
            //
            this.lblMoTaLoi.AutoSize = true;
            this.lblMoTaLoi.Location = new System.Drawing.Point(380, 103);
            this.lblMoTaLoi.Name = "lblMoTaLoi";
            this.lblMoTaLoi.Size = new System.Drawing.Size(63, 16);
            this.lblMoTaLoi.TabIndex = 15;
            this.lblMoTaLoi.Text = "Mô tả lỗi";
            //
            // txtMoTaLoi
            //
            this.txtMoTaLoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMoTaLoi.Location = new System.Drawing.Point(500, 100);
            this.txtMoTaLoi.Multiline = true;
            this.txtMoTaLoi.Name = "txtMoTaLoi";
            this.txtMoTaLoi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMoTaLoi.Size = new System.Drawing.Size(420, 92);
            this.txtMoTaLoi.TabIndex = 16;
            //
            // picAnh
            //
            this.picAnh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picAnh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAnh.Location = new System.Drawing.Point(950, 22);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(215, 170);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnh.TabIndex = 17;
            this.picAnh.TabStop = false;
            //
            // btnChonAnh
            //
            this.btnChonAnh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChonAnh.Location = new System.Drawing.Point(950, 200);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(105, 34);
            this.btnChonAnh.TabIndex = 18;
            this.btnChonAnh.Text = "Chọn ảnh...";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            //
            // btnXoaAnh
            //
            this.btnXoaAnh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaAnh.Location = new System.Drawing.Point(1060, 200);
            this.btnXoaAnh.Name = "btnXoaAnh";
            this.btnXoaAnh.Size = new System.Drawing.Size(105, 34);
            this.btnXoaAnh.TabIndex = 19;
            this.btnXoaAnh.Text = "Bỏ ảnh";
            this.btnXoaAnh.UseVisualStyleBackColor = true;
            this.btnXoaAnh.Click += new System.EventHandler(this.btnXoaAnh_Click);
            //
            // btnThem
            //
            this.btnThem.Location = new System.Drawing.Point(15, 205);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(110, 36);
            this.btnThem.TabIndex = 20;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            //
            // btnCapNhat
            //
            this.btnCapNhat.Location = new System.Drawing.Point(135, 205);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(110, 36);
            this.btnCapNhat.TabIndex = 21;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            //
            // btnXoa
            //
            this.btnXoa.Location = new System.Drawing.Point(255, 205);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 36);
            this.btnXoa.TabIndex = 22;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            //
            // btnLamMoi
            //
            this.btnLamMoi.Location = new System.Drawing.Point(375, 205);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(110, 36);
            this.btnLamMoi.TabIndex = 23;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            //
            // pnlTimKiem
            //
            this.pnlTimKiem.Controls.Add(this.lblTimKiem);
            this.pnlTimKiem.Controls.Add(this.txtTimKiem);
            this.pnlTimKiem.Controls.Add(this.lblLoc);
            this.pnlTimKiem.Controls.Add(this.cboLoc);
            this.pnlTimKiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTimKiem.Location = new System.Drawing.Point(0, 283);
            this.pnlTimKiem.Name = "pnlTimKiem";
            this.pnlTimKiem.Size = new System.Drawing.Size(1182, 48);
            this.pnlTimKiem.TabIndex = 2;
            //
            // lblTimKiem
            //
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Location = new System.Drawing.Point(12, 16);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(196, 16);
            this.lblTimKiem.TabIndex = 0;
            this.lblTimKiem.Text = "Tìm (Mã đơn / Tên KH / SĐT):";
            //
            // txtTimKiem
            //
            this.txtTimKiem.Location = new System.Drawing.Point(215, 13);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(260, 22);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.BoLoc_Changed);
            //
            // lblLoc
            //
            this.lblLoc.AutoSize = true;
            this.lblLoc.Location = new System.Drawing.Point(500, 16);
            this.lblLoc.Name = "lblLoc";
            this.lblLoc.Size = new System.Drawing.Size(97, 16);
            this.lblLoc.TabIndex = 2;
            this.lblLoc.Text = "Lọc trạng thái:";
            //
            // cboLoc
            //
            this.cboLoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoc.FormattingEnabled = true;
            this.cboLoc.Items.AddRange(new object[] {
            "Tất cả",
            "Mới tiếp nhận",
            "Đang sửa",
            "Chờ linh kiện",
            "Hoàn tất",
            "Đã hủy"});
            this.cboLoc.Location = new System.Drawing.Point(605, 12);
            this.cboLoc.Name = "cboLoc";
            this.cboLoc.Size = new System.Drawing.Size(170, 24);
            this.cboLoc.TabIndex = 3;
            this.cboLoc.SelectedIndexChanged += new System.EventHandler(this.BoLoc_Changed);
            //
            // dgvDon
            //
            this.dgvDon.AllowUserToAddRows = false;
            this.dgvDon.AllowUserToDeleteRows = false;
            this.dgvDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDon,
            this.colTenKhach,
            this.colSoDienThoai,
            this.colLoaiThietBi,
            this.colMoTaLoi,
            this.colNgayTiepNhan,
            this.colChiPhi,
            this.colTrangThai});
            this.dgvDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDon.Location = new System.Drawing.Point(0, 331);
            this.dgvDon.MultiSelect = false;
            this.dgvDon.Name = "dgvDon";
            this.dgvDon.ReadOnly = true;
            this.dgvDon.RowHeadersWidth = 30;
            this.dgvDon.RowTemplate.Height = 24;
            this.dgvDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDon.Size = new System.Drawing.Size(1182, 343);
            this.dgvDon.TabIndex = 3;
            //
            // colMaDon
            //
            this.colMaDon.DataPropertyName = "MaDon";
            this.colMaDon.FillWeight = 65F;
            this.colMaDon.HeaderText = "Mã đơn";
            this.colMaDon.Name = "colMaDon";
            this.colMaDon.ReadOnly = true;
            //
            // colTenKhach
            //
            this.colTenKhach.DataPropertyName = "TenKhach";
            this.colTenKhach.FillWeight = 120F;
            this.colTenKhach.HeaderText = "Tên khách hàng";
            this.colTenKhach.Name = "colTenKhach";
            this.colTenKhach.ReadOnly = true;
            //
            // colSoDienThoai
            //
            this.colSoDienThoai.DataPropertyName = "SoDienThoai";
            this.colSoDienThoai.FillWeight = 85F;
            this.colSoDienThoai.HeaderText = "Số điện thoại";
            this.colSoDienThoai.Name = "colSoDienThoai";
            this.colSoDienThoai.ReadOnly = true;
            //
            // colLoaiThietBi
            //
            this.colLoaiThietBi.DataPropertyName = "LoaiThietBi";
            this.colLoaiThietBi.FillWeight = 85F;
            this.colLoaiThietBi.HeaderText = "Loại thiết bị";
            this.colLoaiThietBi.Name = "colLoaiThietBi";
            this.colLoaiThietBi.ReadOnly = true;
            //
            // colMoTaLoi
            //
            this.colMoTaLoi.DataPropertyName = "MoTaLoi";
            this.colMoTaLoi.FillWeight = 160F;
            this.colMoTaLoi.HeaderText = "Mô tả lỗi";
            this.colMoTaLoi.Name = "colMoTaLoi";
            this.colMoTaLoi.ReadOnly = true;
            //
            // colNgayTiepNhan
            //
            this.colNgayTiepNhan.DataPropertyName = "NgayTiepNhan";
            this.colNgayTiepNhan.DefaultCellStyle.Format = "dd/MM/yyyy";
            this.colNgayTiepNhan.FillWeight = 80F;
            this.colNgayTiepNhan.HeaderText = "Ngày tiếp nhận";
            this.colNgayTiepNhan.Name = "colNgayTiepNhan";
            this.colNgayTiepNhan.ReadOnly = true;
            //
            // colChiPhi
            //
            this.colChiPhi.DataPropertyName = "ChiPhi";
            this.colChiPhi.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colChiPhi.DefaultCellStyle.Format = "N0";
            this.colChiPhi.FillWeight = 85F;
            this.colChiPhi.HeaderText = "Chi phí dự kiến";
            this.colChiPhi.Name = "colChiPhi";
            this.colChiPhi.ReadOnly = true;
            //
            // colTrangThai
            //
            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.FillWeight = 85F;
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            //
            // statusStrip1
            //
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSoDon,
            this.lblTongChiPhi});
            this.statusStrip1.Location = new System.Drawing.Point(0, 674);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1182, 26);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            //
            // lblSoDon
            //
            this.lblSoDon.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblSoDon.Name = "lblSoDon";
            this.lblSoDon.Size = new System.Drawing.Size(120, 20);
            this.lblSoDon.Text = "Số đơn: 0";
            //
            // lblTongChiPhi
            //
            this.lblTongChiPhi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTongChiPhi.Name = "lblTongChiPhi";
            this.lblTongChiPhi.Size = new System.Drawing.Size(300, 20);
            this.lblTongChiPhi.Text = "Tổng chi phí dự kiến (chưa hoàn tất): 0 VNĐ";
            //
            // errorProvider1
            //
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            //
            // bsDon
            //
            this.bsDon.CurrentChanged += new System.EventHandler(this.bsDon_CurrentChanged);
            //
            // sfdXuatCSV
            //
            this.sfdXuatCSV.DefaultExt = "csv";
            this.sfdXuatCSV.FileName = "DonSuaChua.csv";
            this.sfdXuatCSV.Filter = "CSV File (*.csv)|*.csv";
            this.sfdXuatCSV.Title = "Xuất danh sách đơn ra CSV";
            //
            // ofdChonAnh
            //
            this.ofdChonAnh.Filter = "Ảnh (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
            this.ofdChonAnh.Title = "Chọn ảnh thiết bị";
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 700);
            this.Controls.Add(this.dgvDon);
            this.Controls.Add(this.pnlTimKiem);
            this.Controls.Add(this.grpDon);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1100, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repair Service Tracker - Quản lý đơn sửa chữa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpDon.ResumeLayout(false);
            this.grpDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.pnlTimKiem.ResumeLayout(false);
            this.pnlTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDon)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuTep;
        private System.Windows.Forms.ToolStripMenuItem mnuXuatCSV;
        private System.Windows.Forms.ToolStripSeparator mnuSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.GroupBox grpDon;
        private System.Windows.Forms.Label lblMaDon;
        private System.Windows.Forms.TextBox txtMaDon;
        private System.Windows.Forms.Label lblTenKhach;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label lblLoaiThietBi;
        private System.Windows.Forms.ComboBox cboLoaiThietBi;
        private System.Windows.Forms.Label lblNgayTiepNhan;
        private System.Windows.Forms.DateTimePicker dtpNgayTiepNhan;
        private System.Windows.Forms.Label lblChiPhi;
        private System.Windows.Forms.TextBox txtChiPhi;
        private System.Windows.Forms.Label lblDonVi;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Label lblMoTaLoi;
        private System.Windows.Forms.TextBox txtMoTaLoi;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.Button btnXoaAnh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Panel pnlTimKiem;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblLoc;
        private System.Windows.Forms.ComboBox cboLoc;
        private System.Windows.Forms.DataGridView dgvDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiThietBi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoTaLoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayTiepNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChiPhi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblSoDon;
        private System.Windows.Forms.ToolStripStatusLabel lblTongChiPhi;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource bsDon;
        private System.Windows.Forms.SaveFileDialog sfdXuatCSV;
        private System.Windows.Forms.OpenFileDialog ofdChonAnh;
    }
}
