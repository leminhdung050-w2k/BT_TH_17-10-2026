using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BT4._11
{
    public partial class Form1 : Form
    {
        //DỮ LIỆU
        private List<DonSuaChua> dsDon = new List<DonSuaChua>();
        private BindingList<DonSuaChua> dsHienThi = new BindingList<DonSuaChua>();

        // Đường dẫn ảnh đang hiển thị trên form (lưu vào đơn khi bấm Thêm / Cập nhật)
        private string anhDangChon = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TaoDuLieuMau();

            dgvDon.AutoGenerateColumns = false;
            bsDon.DataSource = dsHienThi;
            dgvDon.DataSource = bsDon;

            cboLoc.SelectedIndex = 0;
            ApDungLoc(null);
        }

        private void TaoDuLieuMau()
        {
            DateTime hom = DateTime.Today;
            dsDon.Add(new DonSuaChua { MaDon = "DH001", TenKhach = "Nguyễn Văn An", SoDienThoai = "0901234567", LoaiThietBi = "Điện thoại", MoTaLoi = "Vỡ màn hình, cảm ứng không nhận", NgayTiepNhan = hom.AddDays(-6), ChiPhi = 1500000, TrangThai = TrangThaiDon.DangSua, AnhPath = "" });
            dsDon.Add(new DonSuaChua { MaDon = "DH002", TenKhach = "Trần Thị Bình", SoDienThoai = "0912345678", LoaiThietBi = "Laptop", MoTaLoi = "Không lên nguồn", NgayTiepNhan = hom.AddDays(-4), ChiPhi = 2200000, TrangThai = TrangThaiDon.ChoLinhKien, AnhPath = "" });
            dsDon.Add(new DonSuaChua { MaDon = "DH003", TenKhach = "Lê Minh Dũng", SoDienThoai = "0987654321", LoaiThietBi = "Tivi", MoTaLoi = "Mất tiếng, hình bị sọc", NgayTiepNhan = hom.AddDays(-10), ChiPhi = 800000, TrangThai = TrangThaiDon.HoanTat, AnhPath = "" });
            dsDon.Add(new DonSuaChua { MaDon = "DH004", TenKhach = "Phạm Thu Hà", SoDienThoai = "0934567890", LoaiThietBi = "Máy in", MoTaLoi = "Kẹt giấy liên tục", NgayTiepNhan = hom.AddDays(-1), ChiPhi = 350000, TrangThai = TrangThaiDon.MoiTiepNhan, AnhPath = "" });
            dsDon.Add(new DonSuaChua { MaDon = "DH005", TenKhach = "Đỗ Minh Long", SoDienThoai = "0976543210", LoaiThietBi = "Máy tính bảng", MoTaLoi = "Pin chai, sạc không vào", NgayTiepNhan = hom.AddDays(-8), ChiPhi = 600000, TrangThai = TrangThaiDon.DaHuy, AnhPath = "" });
        }

        //Tìm kiếm tức thời và lọc trạng thái
        private void BoLoc_Changed(object sender, EventArgs e)
        {
            ApDungLoc(bsDon.Current as DonSuaChua);
        }

        // chọn đơn muốn giữ dòng chọn sau khi lọc lại (null = dòng đầu)
        private void ApDungLoc(DonSuaChua chon)
        {
            string tuKhoa = txtTimKiem.Text.Trim().ToLower();
            string loc = cboLoc.SelectedIndex > 0 ? cboLoc.Text : "";

            var ketQua = dsDon.Where(d =>
                (tuKhoa == "" || d.MaDon.ToLower().Contains(tuKhoa) || d.TenKhach.ToLower().Contains(tuKhoa) || d.SoDienThoai.Contains(tuKhoa)) &&
                (loc == "" || d.TrangThai == loc));

            dsHienThi.RaiseListChangedEvents = false;
            dsHienThi.Clear();
            foreach (DonSuaChua d in ketQua)
            {
                dsHienThi.Add(d);
            }
            dsHienThi.RaiseListChangedEvents = true;
            bsDon.ResetBindings(false);

            int viTri = chon == null ? -1 : dsHienThi.IndexOf(chon);
            if (viTri >= 0) bsDon.Position = viTri;
            HienThiDon(bsDon.Current as DonSuaChua);

            CapNhatThongKe();
        }

        // StatusStrip: số đơn theo bộ lọc + tổng chi phí dự kiến của các đơn chưa hoàn tất (đang hiển thị)
        private void CapNhatThongKe()
        {
            decimal tong = dsHienThi.Where(d => d.ChuaHoanTat).Sum(d => d.ChiPhi);
            lblSoDon.Text = "Số đơn: " + dsHienThi.Count + " / " + dsDon.Count;
            lblTongChiPhi.Text = "Tổng chi phí dự kiến (chưa hoàn tất): " + tong.ToString("N0") + " VNĐ";
        }

        //Chọn dòng và cho dữ liệu vào ô nhập
        private void bsDon_CurrentChanged(object sender, EventArgs e)
        {
            HienThiDon(bsDon.Current as DonSuaChua);
        }

        private void HienThiDon(DonSuaChua d)
        {
            errorProvider1.Clear();
            if (d == null)
            {
                XoaTrangForm();
                return;
            }

            txtMaDon.Text = d.MaDon;
            txtTenKhach.Text = d.TenKhach;
            txtSoDienThoai.Text = d.SoDienThoai;
            cboLoaiThietBi.SelectedItem = d.LoaiThietBi;
            txtMoTaLoi.Text = d.MoTaLoi;
            dtpNgayTiepNhan.Value = d.NgayTiepNhan;
            txtChiPhi.Text = d.ChiPhi.ToString("N0");
            cboTrangThai.SelectedItem = d.TrangThai;
            HienThiAnh(d.AnhPath);
        }

        private void XoaTrangForm()
        {
            txtMaDon.Text = TaoMaDonMoi();
            txtTenKhach.Clear();
            txtSoDienThoai.Clear();
            cboLoaiThietBi.SelectedIndex = -1;
            txtMoTaLoi.Clear();
            dtpNgayTiepNhan.Value = DateTime.Today;
            txtChiPhi.Text = "0";
            cboTrangThai.SelectedItem = TrangThaiDon.MoiTiepNhan;
            HienThiAnh("");
            errorProvider1.Clear();
        }

        // Gợi ý mã đơn kế tiếp: DH001, DH002,...
        private string TaoMaDonMoi()
        {
            int so = 1;
            while (dsDon.Any(d => d.MaDon.Equals("DH" + so.ToString("D3"), StringComparison.OrdinalIgnoreCase)))
                so++;
            return "DH" + so.ToString("D3");
        }

        //Ảnh thiết bị (PictureBox SizeMode = Zoom -> giữ đúng tỷ lệ, không méo)
        private void HienThiAnh(string path)
        {
            if (!string.IsNullOrEmpty(path) && File.Exists(path))
            {
                anhDangChon = path;
                picAnh.ImageLocation = path;
            }
            else
            {
                anhDangChon = "";
                picAnh.ImageLocation = null;
                picAnh.Image = null;
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            if (ofdChonAnh.ShowDialog() == DialogResult.OK)
            {
                HienThiAnh(ofdChonAnh.FileName);
            }
        }

        private void btnXoaAnh_Click(object sender, EventArgs e)
        {
            HienThiAnh("");
        }

        // Đọc chi phí: bỏ dấu phân cách hàng nghìn, cho phép số âm để còn báo lỗi
        private bool DocChiPhi(out decimal chiPhi)
        {
            string s = txtChiPhi.Text.Trim().Replace(",", "").Replace(".", "").Replace(" ", "");
            return decimal.TryParse(s, NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture, out chiPhi);
        }

        // Kiểm tra dữ liệu (ERRORPROVIDER)
        // dangSua = null  -> đang THÊM mới ; dangSua = đơn -> đang CẬP NHẬT đơn đó
        private bool KiemTraDuLieu(DonSuaChua dangSua)
        {
            errorProvider1.Clear();
            bool hopLe = true;
            string maDon = txtMaDon.Text.Trim();

            if (maDon == "")
            {
                errorProvider1.SetError(txtMaDon, "Mã đơn không được để trống.");
                hopLe = false;
            }
            else if (dsDon.Any(d => d != dangSua && d.MaDon.Equals(maDon, StringComparison.OrdinalIgnoreCase)))
            {
                errorProvider1.SetError(txtMaDon, "Mã đơn đã tồn tại.");
                hopLe = false;
            }

            if (txtTenKhach.Text.Trim() == "")
            {
                errorProvider1.SetError(txtTenKhach, "Tên khách hàng không được để trống.");
                hopLe = false;
            }

            if (txtSoDienThoai.Text.Trim() == "")
            {
                errorProvider1.SetError(txtSoDienThoai, "Số điện thoại không được để trống.");
                hopLe = false;
            }

            if (cboLoaiThietBi.SelectedIndex < 0)
            {
                errorProvider1.SetError(cboLoaiThietBi, "Vui lòng chọn loại thiết bị.");
                hopLe = false;
            }

            if (txtMoTaLoi.Text.Trim() == "")
            {
                errorProvider1.SetError(txtMoTaLoi, "Mô tả lỗi là bắt buộc.");
                hopLe = false;
            }

            decimal chiPhi;
            if (!DocChiPhi(out chiPhi))
            {
                errorProvider1.SetError(txtChiPhi, "Chi phí dự kiến phải là số.");
                hopLe = false;
            }
            else if (chiPhi < 0)
            {
                errorProvider1.SetError(txtChiPhi, "Chi phí dự kiến không được âm.");
                hopLe = false;
            }

            if (cboTrangThai.SelectedIndex < 0)
            {
                errorProvider1.SetError(cboTrangThai, "Vui lòng chọn trạng thái.");
                hopLe = false;
            }

            if (!hopLe)
            {
                MessageBox.Show("Dữ liệu chưa hợp lệ, không thể lưu. Di chuột vào biểu tượng (!) để xem chi tiết lỗi.",
                    "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return hopLe;
        }

        // Ghi dữ liệu từ các ô nhập vào đối tượng đơn
        private void GhiVaoDon(DonSuaChua d)
        {
            decimal chiPhi;
            DocChiPhi(out chiPhi);

            d.MaDon = txtMaDon.Text.Trim();
            d.TenKhach = txtTenKhach.Text.Trim();
            d.SoDienThoai = txtSoDienThoai.Text.Trim();
            d.LoaiThietBi = cboLoaiThietBi.SelectedItem.ToString();
            d.MoTaLoi = txtMoTaLoi.Text.Trim();
            d.NgayTiepNhan = dtpNgayTiepNhan.Value.Date;
            d.ChiPhi = chiPhi;
            d.TrangThai = cboTrangThai.SelectedItem.ToString();
            d.AnhPath = anhDangChon;
        }

        // Thêm, cập nhật, xóa
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu(null)) return;

            if (MessageBox.Show("Thêm đơn " + txtMaDon.Text.Trim() + "?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            DonSuaChua d = new DonSuaChua();
            GhiVaoDon(d);
            dsDon.Add(d);

            // Bỏ tìm kiếm, lọc để chắc chắn thấy đơn vừa thêm
            txtTimKiem.TextChanged -= BoLoc_Changed;
            cboLoc.SelectedIndexChanged -= BoLoc_Changed;
            txtTimKiem.Clear();
            cboLoc.SelectedIndex = 0;
            txtTimKiem.TextChanged += BoLoc_Changed;
            cboLoc.SelectedIndexChanged += BoLoc_Changed;

            ApDungLoc(d);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            DonSuaChua d = bsDon.Current as DonSuaChua;
            if (d == null)
            {
                MessageBox.Show("Vui lòng chọn đơn cần cập nhật.", "Thông báo");
                return;
            }
            if (!KiemTraDuLieu(d)) return;

            if (MessageBox.Show("Cập nhật đơn " + d.MaDon + "?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            GhiVaoDon(d);
            ApDungLoc(d); 
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DonSuaChua d = bsDon.Current as DonSuaChua;
            if (d == null)
            {
                MessageBox.Show("Vui lòng chọn đơn cần xóa.", "Thông báo");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa đơn " + d.MaDon + "?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            dsDon.Remove(d);
            ApDungLoc(null);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            XoaTrangForm();
            txtTenKhach.Focus();
        }

        // Menu: xuất danh sách đang hiển thị ra CSV (sfdXuatCSV kéo từ Toolbox)
        private static string CsvField(string value)
        {
            if (string.IsNullOrEmpty(value)) return "";
            if (value.Contains(",") || value.Contains("\"") || value.Contains("\n"))
                return "\"" + value.Replace("\"", "\"\"") + "\"";
            return value;
        }

        private void mnuXuatCSV_Click(object sender, EventArgs e)
        {
            if (dsHienThi.Count == 0)
            {
                MessageBox.Show("Không có đơn nào để xuất!", "Thông báo");
                return;
            }

            sfdXuatCSV.FileName = "DonSuaChua_" + DateTime.Now.ToString("yyyyMMdd") + ".csv";
            if (sfdXuatCSV.ShowDialog() != DialogResult.OK) return;

            try
            {
                // UTF-8 có BOM để Excel đọc đúng tiếng Việt
                using (StreamWriter sw = new StreamWriter(sfdXuatCSV.FileName, false, new UTF8Encoding(true)))
                {
                    sw.WriteLine("Mã đơn,Tên khách hàng,Số điện thoại,Loại thiết bị,Mô tả lỗi,Ngày tiếp nhận,Chi phí dự kiến,Trạng thái");
                    foreach (DonSuaChua d in dsHienThi)
                    {
                        sw.WriteLine(string.Join(",",
                            CsvField(d.MaDon),
                            CsvField(d.TenKhach),
                            CsvField(d.SoDienThoai),
                            CsvField(d.LoaiThietBi),
                            CsvField(d.MoTaLoi),
                            d.NgayTiepNhan.ToString("dd/MM/yyyy"),
                            d.ChiPhi.ToString("0"),
                            CsvField(d.TrangThai)));
                    }
                }
                MessageBox.Show("Đã xuất " + dsHienThi.Count + " đơn ra file CSV.", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi xuất file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Menu: thoát ứng dụng
        private void mnuThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
