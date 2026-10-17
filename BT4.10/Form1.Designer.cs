namespace BT4._10
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpPhieu = new System.Windows.Forms.GroupBox();
            this.lblMaPhieu = new System.Windows.Forms.Label();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblThietBi = new System.Windows.Forms.Label();
            this.cboThietBi = new System.Windows.Forms.ComboBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.lblTinhTrangGiaTri = new System.Windows.Forms.Label();
            this.lblNgayMuon = new System.Windows.Forms.Label();
            this.dtpNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.lblHanTra = new System.Windows.Forms.Label();
            this.dtpHanTra = new System.Windows.Forms.DateTimePicker();
            this.chkDaTra = new System.Windows.Forms.CheckBox();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnDanhDauDaTra = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.pnlTimKiem = new System.Windows.Forms.Panel();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblLoc = new System.Windows.Forms.Label();
            this.cboLoc = new System.Windows.Forms.ComboBox();
            this.btnXuatCSV = new System.Windows.Forms.Button();
            this.dgvPhieu = new System.Windows.Forms.DataGridView();
            this.colMaPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThietBi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHanTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblTongPhieu = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblQuaHan = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDangHienThi = new System.Windows.Forms.ToolStripStatusLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bsPhieu = new System.Windows.Forms.BindingSource(this.components);
            this.sfdXuatCSV = new System.Windows.Forms.SaveFileDialog();
            this.grpPhieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.pnlTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieu)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPhieu)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPhieu
            // 
            this.grpPhieu.Controls.Add(this.lblMaPhieu);
            this.grpPhieu.Controls.Add(this.txtMaPhieu);
            this.grpPhieu.Controls.Add(this.lblMaSV);
            this.grpPhieu.Controls.Add(this.txtMaSV);
            this.grpPhieu.Controls.Add(this.lblHoTen);
            this.grpPhieu.Controls.Add(this.txtHoTen);
            this.grpPhieu.Controls.Add(this.lblThietBi);
            this.grpPhieu.Controls.Add(this.cboThietBi);
            this.grpPhieu.Controls.Add(this.lblSoLuong);
            this.grpPhieu.Controls.Add(this.numSoLuong);
            this.grpPhieu.Controls.Add(this.lblTinhTrang);
            this.grpPhieu.Controls.Add(this.lblTinhTrangGiaTri);
            this.grpPhieu.Controls.Add(this.lblNgayMuon);
            this.grpPhieu.Controls.Add(this.dtpNgayMuon);
            this.grpPhieu.Controls.Add(this.lblHanTra);
            this.grpPhieu.Controls.Add(this.dtpHanTra);
            this.grpPhieu.Controls.Add(this.chkDaTra);
            this.grpPhieu.Controls.Add(this.dtpNgayTra);
            this.grpPhieu.Controls.Add(this.btnThem);
            this.grpPhieu.Controls.Add(this.btnCapNhat);
            this.grpPhieu.Controls.Add(this.btnXoa);
            this.grpPhieu.Controls.Add(this.btnDanhDauDaTra);
            this.grpPhieu.Controls.Add(this.btnLamMoi);
            this.grpPhieu.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpPhieu.Location = new System.Drawing.Point(0, 0);
            this.grpPhieu.Name = "grpPhieu";
            this.grpPhieu.Size = new System.Drawing.Size(1182, 205);
            this.grpPhieu.TabIndex = 0;
            this.grpPhieu.TabStop = false;
            this.grpPhieu.Text = "Thông tin phiếu mượn";
            // 
            // lblMaPhieu
            // 
            this.lblMaPhieu.AutoSize = true;
            this.lblMaPhieu.Location = new System.Drawing.Point(15, 33);
            this.lblMaPhieu.Name = "lblMaPhieu";
            this.lblMaPhieu.Size = new System.Drawing.Size(62, 16);
            this.lblMaPhieu.TabIndex = 0;
            this.lblMaPhieu.Text = "Mã phiếu";
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(115, 30);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(200, 22);
            this.txtMaPhieu.TabIndex = 1;
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(15, 68);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(81, 16);
            this.lblMaSV.TabIndex = 2;
            this.lblMaSV.Text = "Mã sinh viên";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(115, 65);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(200, 22);
            this.txtMaSV.TabIndex = 3;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(15, 103);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(67, 16);
            this.lblHoTen.TabIndex = 4;
            this.lblHoTen.Text = "Họ tên SV";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(115, 100);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(200, 22);
            this.txtHoTen.TabIndex = 5;
            // 
            // lblThietBi
            // 
            this.lblThietBi.AutoSize = true;
            this.lblThietBi.Location = new System.Drawing.Point(350, 33);
            this.lblThietBi.Name = "lblThietBi";
            this.lblThietBi.Size = new System.Drawing.Size(51, 16);
            this.lblThietBi.TabIndex = 6;
            this.lblThietBi.Text = "Thiết bị";
            // 
            // cboThietBi
            // 
            this.cboThietBi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThietBi.FormattingEnabled = true;
            this.cboThietBi.Items.AddRange(new object[] {
            "Laptop",
            "Máy chiếu",
            "Đèn pin",
            "Quạt cầm tay",
            "Đồng hồ vạn năng",
            "Máy hiện sóng",
            "Bộ nguồn DC",
            "Mainboard"});
            this.cboThietBi.Location = new System.Drawing.Point(440, 29);
            this.cboThietBi.Name = "cboThietBi";
            this.cboThietBi.Size = new System.Drawing.Size(220, 24);
            this.cboThietBi.TabIndex = 7;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(350, 68);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(60, 16);
            this.lblSoLuong.TabIndex = 8;
            this.lblSoLuong.Text = "Số lượng";
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(440, 65);
            this.numSoLuong.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(220, 22);
            this.numSoLuong.TabIndex = 9;
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.AutoSize = true;
            this.lblTinhTrang.Location = new System.Drawing.Point(350, 103);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(66, 16);
            this.lblTinhTrang.TabIndex = 10;
            this.lblTinhTrang.Text = "Tình trạng";
            // 
            // lblTinhTrangGiaTri
            // 
            this.lblTinhTrangGiaTri.AutoSize = true;
            this.lblTinhTrangGiaTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTinhTrangGiaTri.Location = new System.Drawing.Point(440, 102);
            this.lblTinhTrangGiaTri.Name = "lblTinhTrangGiaTri";
            this.lblTinhTrangGiaTri.Size = new System.Drawing.Size(14, 18);
            this.lblTinhTrangGiaTri.TabIndex = 11;
            this.lblTinhTrangGiaTri.Text = "-";
            // 
            // lblNgayMuon
            // 
            this.lblNgayMuon.AutoSize = true;
            this.lblNgayMuon.Location = new System.Drawing.Point(700, 33);
            this.lblNgayMuon.Name = "lblNgayMuon";
            this.lblNgayMuon.Size = new System.Drawing.Size(76, 16);
            this.lblNgayMuon.TabIndex = 12;
            this.lblNgayMuon.Text = "Ngày mượn";
            // 
            // dtpNgayMuon
            // 
            this.dtpNgayMuon.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayMuon.Location = new System.Drawing.Point(849, 29);
            this.dtpNgayMuon.Name = "dtpNgayMuon";
            this.dtpNgayMuon.Size = new System.Drawing.Size(180, 22);
            this.dtpNgayMuon.TabIndex = 13;
            this.dtpNgayMuon.ValueChanged += new System.EventHandler(this.KiemTraNgay_ValueChanged);
            // 
            // lblHanTra
            // 
            this.lblHanTra.AutoSize = true;
            this.lblHanTra.Location = new System.Drawing.Point(700, 68);
            this.lblHanTra.Name = "lblHanTra";
            this.lblHanTra.Size = new System.Drawing.Size(50, 16);
            this.lblHanTra.TabIndex = 14;
            this.lblHanTra.Text = "Hạn trả";
            // 
            // dtpHanTra
            // 
            this.dtpHanTra.CustomFormat = "dd/MM/yyyy";
            this.dtpHanTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHanTra.Location = new System.Drawing.Point(849, 64);
            this.dtpHanTra.Name = "dtpHanTra";
            this.dtpHanTra.Size = new System.Drawing.Size(180, 22);
            this.dtpHanTra.TabIndex = 15;
            this.dtpHanTra.ValueChanged += new System.EventHandler(this.KiemTraNgay_ValueChanged);
            // 
            // chkDaTra
            // 
            this.chkDaTra.AutoSize = true;
            this.chkDaTra.Location = new System.Drawing.Point(700, 102);
            this.chkDaTra.Name = "chkDaTra";
            this.chkDaTra.Size = new System.Drawing.Size(121, 20);
            this.chkDaTra.TabIndex = 16;
            this.chkDaTra.Text = "Ngày trả thực tế";
            this.chkDaTra.UseVisualStyleBackColor = true;
            this.chkDaTra.CheckedChanged += new System.EventHandler(this.chkDaTra_CheckedChanged);
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayTra.Enabled = false;
            this.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTra.Location = new System.Drawing.Point(849, 99);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(180, 22);
            this.dtpNgayTra.TabIndex = 17;
            this.dtpNgayTra.ValueChanged += new System.EventHandler(this.KiemTraNgay_ValueChanged);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(15, 148);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(110, 38);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(135, 148);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(110, 38);
            this.btnCapNhat.TabIndex = 19;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(255, 148);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 38);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnDanhDauDaTra
            // 
            this.btnDanhDauDaTra.Location = new System.Drawing.Point(375, 148);
            this.btnDanhDauDaTra.Name = "btnDanhDauDaTra";
            this.btnDanhDauDaTra.Size = new System.Drawing.Size(150, 38);
            this.btnDanhDauDaTra.TabIndex = 21;
            this.btnDanhDauDaTra.Text = "Đánh dấu đã trả";
            this.btnDanhDauDaTra.UseVisualStyleBackColor = true;
            this.btnDanhDauDaTra.Click += new System.EventHandler(this.btnDanhDauDaTra_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(535, 148);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(110, 38);
            this.btnLamMoi.TabIndex = 22;
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
            this.pnlTimKiem.Controls.Add(this.btnXuatCSV);
            this.pnlTimKiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTimKiem.Location = new System.Drawing.Point(0, 205);
            this.pnlTimKiem.Name = "pnlTimKiem";
            this.pnlTimKiem.Size = new System.Drawing.Size(1182, 50);
            this.pnlTimKiem.TabIndex = 1;
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Location = new System.Drawing.Point(12, 17);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(170, 16);
            this.lblTimKiem.TabIndex = 0;
            this.lblTimKiem.Text = "Tìm kiếm (Mã SV / Thiết bị):";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(205, 14);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(250, 22);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.BoLoc_Changed);
            // 
            // lblLoc
            // 
            this.lblLoc.AutoSize = true;
            this.lblLoc.Location = new System.Drawing.Point(480, 17);
            this.lblLoc.Name = "lblLoc";
            this.lblLoc.Size = new System.Drawing.Size(68, 16);
            this.lblLoc.TabIndex = 2;
            this.lblLoc.Text = "Lọc phiếu:";
            // 
            // cboLoc
            // 
            this.cboLoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoc.FormattingEnabled = true;
            this.cboLoc.Items.AddRange(new object[] {
            "Tất cả",
            "Đang mượn",
            "Quá hạn",
            "Đã trả"});
            this.cboLoc.Location = new System.Drawing.Point(555, 13);
            this.cboLoc.Name = "cboLoc";
            this.cboLoc.Size = new System.Drawing.Size(150, 24);
            this.cboLoc.TabIndex = 3;
            this.cboLoc.SelectedIndexChanged += new System.EventHandler(this.BoLoc_Changed);
            // 
            // btnXuatCSV
            // 
            this.btnXuatCSV.Location = new System.Drawing.Point(730, 8);
            this.btnXuatCSV.Name = "btnXuatCSV";
            this.btnXuatCSV.Size = new System.Drawing.Size(150, 34);
            this.btnXuatCSV.TabIndex = 4;
            this.btnXuatCSV.Text = "Xuất CSV";
            this.btnXuatCSV.UseVisualStyleBackColor = true;
            this.btnXuatCSV.Click += new System.EventHandler(this.btnXuatCSV_Click);
            // 
            // dgvPhieu
            // 
            this.dgvPhieu.AllowUserToAddRows = false;
            this.dgvPhieu.AllowUserToDeleteRows = false;
            this.dgvPhieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaPhieu,
            this.colMaSV,
            this.colHoTen,
            this.colThietBi,
            this.colSoLuong,
            this.colNgayMuon,
            this.colHanTra,
            this.colNgayTra,
            this.colTinhTrang});
            this.dgvPhieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieu.Location = new System.Drawing.Point(0, 255);
            this.dgvPhieu.MultiSelect = false;
            this.dgvPhieu.Name = "dgvPhieu";
            this.dgvPhieu.ReadOnly = true;
            this.dgvPhieu.RowHeadersWidth = 30;
            this.dgvPhieu.RowTemplate.Height = 24;
            this.dgvPhieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieu.Size = new System.Drawing.Size(1182, 368);
            this.dgvPhieu.TabIndex = 2;
            this.dgvPhieu.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPhieu_CellFormatting);
            // 
            // colMaPhieu
            // 
            this.colMaPhieu.DataPropertyName = "MaPhieu";
            this.colMaPhieu.FillWeight = 70F;
            this.colMaPhieu.HeaderText = "Mã phiếu";
            this.colMaPhieu.MinimumWidth = 6;
            this.colMaPhieu.Name = "colMaPhieu";
            this.colMaPhieu.ReadOnly = true;
            // 
            // colMaSV
            // 
            this.colMaSV.DataPropertyName = "MaSV";
            this.colMaSV.FillWeight = 80F;
            this.colMaSV.HeaderText = "Mã SV";
            this.colMaSV.MinimumWidth = 6;
            this.colMaSV.Name = "colMaSV";
            this.colMaSV.ReadOnly = true;
            // 
            // colHoTen
            // 
            this.colHoTen.DataPropertyName = "HoTen";
            this.colHoTen.FillWeight = 130F;
            this.colHoTen.HeaderText = "Họ tên SV";
            this.colHoTen.MinimumWidth = 6;
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.ReadOnly = true;
            // 
            // colThietBi
            // 
            this.colThietBi.DataPropertyName = "ThietBi";
            this.colThietBi.FillWeight = 120F;
            this.colThietBi.HeaderText = "Thiết bị";
            this.colThietBi.MinimumWidth = 6;
            this.colThietBi.Name = "colThietBi";
            this.colThietBi.ReadOnly = true;
            // 
            // colSoLuong
            // 
            this.colSoLuong.DataPropertyName = "SoLuong";
            this.colSoLuong.FillWeight = 60F;
            this.colSoLuong.HeaderText = "Số lượng";
            this.colSoLuong.MinimumWidth = 6;
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.ReadOnly = true;
            // 
            // colNgayMuon
            // 
            this.colNgayMuon.DataPropertyName = "NgayMuon";
            dataGridViewCellStyle7.Format = "dd/MM/yyyy";
            this.colNgayMuon.DefaultCellStyle = dataGridViewCellStyle7;
            this.colNgayMuon.FillWeight = 85F;
            this.colNgayMuon.HeaderText = "Ngày mượn";
            this.colNgayMuon.MinimumWidth = 6;
            this.colNgayMuon.Name = "colNgayMuon";
            this.colNgayMuon.ReadOnly = true;
            // 
            // colHanTra
            // 
            this.colHanTra.DataPropertyName = "HanTra";
            dataGridViewCellStyle8.Format = "dd/MM/yyyy";
            this.colHanTra.DefaultCellStyle = dataGridViewCellStyle8;
            this.colHanTra.FillWeight = 85F;
            this.colHanTra.HeaderText = "Hạn trả";
            this.colHanTra.MinimumWidth = 6;
            this.colHanTra.Name = "colHanTra";
            this.colHanTra.ReadOnly = true;
            // 
            // colNgayTra
            // 
            this.colNgayTra.DataPropertyName = "NgayTraThucTe";
            dataGridViewCellStyle9.Format = "dd/MM/yyyy";
            this.colNgayTra.DefaultCellStyle = dataGridViewCellStyle9;
            this.colNgayTra.FillWeight = 95F;
            this.colNgayTra.HeaderText = "Ngày trả thực tế";
            this.colNgayTra.MinimumWidth = 6;
            this.colNgayTra.Name = "colNgayTra";
            this.colNgayTra.ReadOnly = true;
            // 
            // colTinhTrang
            // 
            this.colTinhTrang.DataPropertyName = "TinhTrang";
            this.colTinhTrang.FillWeight = 80F;
            this.colTinhTrang.HeaderText = "Tình trạng";
            this.colTinhTrang.MinimumWidth = 6;
            this.colTinhTrang.Name = "colTinhTrang";
            this.colTinhTrang.ReadOnly = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTongPhieu,
            this.lblQuaHan,
            this.lblDangHienThi});
            this.statusStrip1.Location = new System.Drawing.Point(0, 623);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1182, 30);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblTongPhieu
            // 
            this.lblTongPhieu.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblTongPhieu.Name = "lblTongPhieu";
            this.lblTongPhieu.Size = new System.Drawing.Size(122, 24);
            this.lblTongPhieu.Text = "Tổng số phiếu: 0";
            // 
            // lblQuaHan
            // 
            this.lblQuaHan.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblQuaHan.ForeColor = System.Drawing.Color.Red;
            this.lblQuaHan.Name = "lblQuaHan";
            this.lblQuaHan.Size = new System.Drawing.Size(121, 24);
            this.lblQuaHan.Text = "Phiếu quá hạn: 0";
            // 
            // lblDangHienThi
            // 
            this.lblDangHienThi.Name = "lblDangHienThi";
            this.lblDangHienThi.Size = new System.Drawing.Size(113, 24);
            this.lblDangHienThi.Text = "Đang hiển thị: 0";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // bsPhieu
            // 
            this.bsPhieu.CurrentChanged += new System.EventHandler(this.bsPhieu_CurrentChanged);
            // 
            // sfdXuatCSV
            // 
            this.sfdXuatCSV.DefaultExt = "csv";
            this.sfdXuatCSV.Filter = "CSV File (*.csv)|*.csv";
            this.sfdXuatCSV.Title = "Xuất danh sách phiếu mượn ra CSV";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.dgvPhieu);
            this.Controls.Add(this.pnlTimKiem);
            this.Controls.Add(this.grpPhieu);
            this.Controls.Add(this.statusStrip1);
            this.MinimumSize = new System.Drawing.Size(1080, 560);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab Equipment Checkout - Quản lý mượn trả thiết bị";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpPhieu.ResumeLayout(false);
            this.grpPhieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.pnlTimKiem.ResumeLayout(false);
            this.pnlTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieu)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPhieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPhieu;
        private System.Windows.Forms.Label lblMaPhieu;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblThietBi;
        private System.Windows.Forms.ComboBox cboThietBi;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.Label lblTinhTrangGiaTri;
        private System.Windows.Forms.Label lblNgayMuon;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon;
        private System.Windows.Forms.Label lblHanTra;
        private System.Windows.Forms.DateTimePicker dtpHanTra;
        private System.Windows.Forms.CheckBox chkDaTra;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnDanhDauDaTra;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Panel pnlTimKiem;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblLoc;
        private System.Windows.Forms.ComboBox cboLoc;
        private System.Windows.Forms.Button btnXuatCSV;
        private System.Windows.Forms.DataGridView dgvPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThietBi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHanTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTinhTrang;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblTongPhieu;
        private System.Windows.Forms.ToolStripStatusLabel lblQuaHan;
        private System.Windows.Forms.ToolStripStatusLabel lblDangHienThi;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource bsPhieu;
        private System.Windows.Forms.SaveFileDialog sfdXuatCSV;
    }
}
