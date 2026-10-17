using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BT4._10
{
    public partial class Form1 : Form
    {
        //DỮ LIỆU
        private List<PhieuMuon> dsPhieu = new List<PhieuMuon>();
        private BindingList<PhieuMuon> dsHienThi = new BindingList<PhieuMuon>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TaoDuLieuMau();

            // DataGridView dùng các cột đã cấu hình (AutoGenerateColumns không có trong Properties nên đặt bằng code)
            // bsPhieu là BindingSource kéo từ Toolbox; chỉ gán nguồn dữ liệu lúc chạy
            dgvPhieu.AutoGenerateColumns = false;
            bsPhieu.DataSource = dsHienThi;
            dgvPhieu.DataSource = bsPhieu;

            cboThietBi.SelectedIndex = -1;
            cboLoc.SelectedIndex = 0;
            ApDungLoc(null);
        }

        private void TaoDuLieuMau()
        {
            DateTime hom = DateTime.Today;
            dsPhieu.Add(new PhieuMuon { MaPhieu = "PM001", MaSV = "SV001", HoTen = "Nguyễn Hữu Trường", ThietBi = "Laptop", SoLuong = 1, NgayMuon = hom.AddDays(-10), HanTra = hom.AddDays(-3) });
            dsPhieu.Add(new PhieuMuon { MaPhieu = "PM002", MaSV = "SV002", HoTen = "Lê Minh Dũng", ThietBi = "Đèn pin", SoLuong = 2, NgayMuon = hom.AddDays(-2), HanTra = hom.AddDays(5) });
            dsPhieu.Add(new PhieuMuon { MaPhieu = "PM003", MaSV = "SV003", HoTen = "Nguyễn Minh Trí", ThietBi = "Máy chiếu", SoLuong = 1, NgayMuon = hom.AddDays(-15), HanTra = hom.AddDays(-8), NgayTraThucTe = hom.AddDays(-9) });
            dsPhieu.Add(new PhieuMuon { MaPhieu = "PM004", MaSV = "SV004", HoTen = "Nguyễn Văn An", ThietBi = "Đồng hồ vạn năng", SoLuong = 3, NgayMuon = hom.AddDays(-1), HanTra = hom.AddDays(6) });
            dsPhieu.Add(new PhieuMuon { MaPhieu = "PM005", MaSV = "SV005", HoTen = "Phạm Minh Đức", ThietBi = "Quạt cầm tay", SoLuong = 1, NgayMuon = hom.AddDays(-20), HanTra = hom.AddDays(-5) });
        }

        //Tìm kiếm và lọc
        private void BoLoc_Changed(object sender, EventArgs e)
        {
            ApDungLoc(bsPhieu.Current as PhieuMuon);
        }

        // chọn phiếu muốn giữ dòng chọn sau khi lọc lại (null = dòng đầu)
        private void ApDungLoc(PhieuMuon chon)
        {
            string tuKhoa = txtTimKiem.Text.Trim().ToLower();
            string loc = cboLoc.SelectedIndex > 0 ? cboLoc.Text : "";

            var ketQua = dsPhieu.Where(p =>
                (tuKhoa == "" || p.MaSV.ToLower().Contains(tuKhoa) || p.ThietBi.ToLower().Contains(tuKhoa)) &&
                (loc == "" || p.TinhTrang == loc));

            dsHienThi.RaiseListChangedEvents = false;
            dsHienThi.Clear();
            foreach (PhieuMuon p in ketQua)
            {
                dsHienThi.Add(p);
            }
            dsHienThi.RaiseListChangedEvents = true;
            bsPhieu.ResetBindings(false);

            int viTri = chon == null ? -1 : dsHienThi.IndexOf(chon);
            if (viTri >= 0) bsPhieu.Position = viTri;
            HienThiPhieu(bsPhieu.Current as PhieuMuon);

            CapNhatThongKe();
        }

        // StatusStrip: tổng số phiếu, số phiếu quá hạn, số phiếu đang hiển thị
        private void CapNhatThongKe()
        {
            lblTongPhieu.Text = "Tổng số phiếu: " + dsPhieu.Count;
            lblQuaHan.Text = "Phiếu quá hạn: " + dsPhieu.Count(p => p.TinhTrang == TinhTrangPhieu.QuaHan);
            lblDangHienThi.Text = "Đang hiển thị: " + dsHienThi.Count;
        }

        //Chọn dòng và cho dữ liệu vào ô nhập
        private void bsPhieu_CurrentChanged(object sender, EventArgs e)
        {
            HienThiPhieu(bsPhieu.Current as PhieuMuon);
        }

        private void HienThiPhieu(PhieuMuon p)
        {
            errorProvider1.Clear();
            if (p == null)
            {
                XoaTrangForm();
                return;
            }

            txtMaPhieu.Text = p.MaPhieu;
            txtMaSV.Text = p.MaSV;
            txtHoTen.Text = p.HoTen;
            cboThietBi.SelectedItem = p.ThietBi;
            numSoLuong.Value = Math.Min(numSoLuong.Maximum, p.SoLuong);
            dtpNgayMuon.Value = p.NgayMuon;
            dtpHanTra.Value = p.HanTra;
            chkDaTra.Checked = p.NgayTraThucTe.HasValue;
            dtpNgayTra.Value = p.NgayTraThucTe ?? DateTime.Today;
            HienThiTinhTrang(p.TinhTrang);
            errorProvider1.Clear();
        }

        private void XoaTrangForm()
        {
            txtMaPhieu.Text = TaoMaPhieuMoi();
            txtMaSV.Clear();
            txtHoTen.Clear();
            cboThietBi.SelectedIndex = -1;
            numSoLuong.Value = 1;
            dtpNgayMuon.Value = DateTime.Today;
            dtpHanTra.Value = DateTime.Today.AddDays(7);
            chkDaTra.Checked = false;
            dtpNgayTra.Value = DateTime.Today;
            HienThiTinhTrang("-");
            errorProvider1.Clear();
        }

        private void HienThiTinhTrang(string tinhTrang)
        {
            lblTinhTrangGiaTri.Text = tinhTrang;
            if (tinhTrang == TinhTrangPhieu.QuaHan) lblTinhTrangGiaTri.ForeColor = Color.Red;
            else if (tinhTrang == TinhTrangPhieu.DaTra) lblTinhTrangGiaTri.ForeColor = Color.Green;
            else lblTinhTrangGiaTri.ForeColor = Color.RoyalBlue;
        }

        // Gợi ý mã phiếu kế tiếp: PM001, PM002, ...
        private string TaoMaPhieuMoi()
        {
            int so = 1;
            while (dsPhieu.Any(p => p.MaPhieu.Equals("PM" + so.ToString("D3"), StringComparison.OrdinalIgnoreCase)))
                so++;
            return "PM" + so.ToString("D3");
        }


        // Kiểm tra dữ liệu (ERRORPROVIDER)
        private bool KiemTraDuLieu(PhieuMuon dangSua)
        {
            errorProvider1.Clear();
            bool hopLe = true;
            string maPhieu = txtMaPhieu.Text.Trim();

            if (maPhieu == "")
            {
                errorProvider1.SetError(txtMaPhieu, "Mã phiếu không được để trống.");
                hopLe = false;
            }
            else if (dsPhieu.Any(p => p != dangSua && p.MaPhieu.Equals(maPhieu, StringComparison.OrdinalIgnoreCase)))
            {
                errorProvider1.SetError(txtMaPhieu, "Mã phiếu đã tồn tại.");
                hopLe = false;
            }

            if (txtMaSV.Text.Trim() == "")
            {
                errorProvider1.SetError(txtMaSV, "Mã sinh viên không được để trống.");
                hopLe = false;
            }

            if (cboThietBi.SelectedIndex < 0)
            {
                errorProvider1.SetError(cboThietBi, "Vui lòng chọn thiết bị.");
                hopLe = false;
            }

            if (numSoLuong.Value <= 0)
            {
                errorProvider1.SetError(numSoLuong, "Số lượng phải lớn hơn 0.");
                hopLe = false;
            }

            if (!KiemTraNgay()) hopLe = false;

            if (!hopLe)
            {
                MessageBox.Show("Dữ liệu chưa hợp lệ. Di chuột vào biểu tượng (!) để xem chi tiết lỗi.",
                    "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return hopLe;
        }

        // Hạn trả và ngày trả thực tế không được trước ngày mượn
        private bool KiemTraNgay()
        {
            bool hopLe = true;
            DateTime ngayMuon = dtpNgayMuon.Value.Date;

            if (dtpHanTra.Value.Date < ngayMuon)
            {
                errorProvider1.SetError(dtpHanTra, "Hạn trả không được trước ngày mượn.");
                hopLe = false;
            }
            else errorProvider1.SetError(dtpHanTra, "");

            if (chkDaTra.Checked && dtpNgayTra.Value.Date < ngayMuon)
            {
                errorProvider1.SetError(dtpNgayTra, "Ngày trả thực tế không được trước ngày mượn.");
                hopLe = false;
            }
            else errorProvider1.SetError(dtpNgayTra, "");

            return hopLe;
        }

        // Báo lỗi ngay khi người dùng đổi ngày
        private void KiemTraNgay_ValueChanged(object sender, EventArgs e)
        {
            KiemTraNgay();
        }

        private void chkDaTra_CheckedChanged(object sender, EventArgs e)
        {
            dtpNgayTra.Enabled = chkDaTra.Checked;
            KiemTraNgay();
        }

        // Ghi dữ liệu từ các ô nhập vào đối tượng phiếu
        private void GhiVaoPhieu(PhieuMuon p)
        {
            p.MaPhieu = txtMaPhieu.Text.Trim();
            p.MaSV = txtMaSV.Text.Trim();
            p.HoTen = txtHoTen.Text.Trim();
            p.ThietBi = cboThietBi.SelectedItem.ToString();
            p.SoLuong = (int)numSoLuong.Value;
            p.NgayMuon = dtpNgayMuon.Value.Date;
            p.HanTra = dtpHanTra.Value.Date;
            p.NgayTraThucTe = chkDaTra.Checked ? dtpNgayTra.Value.Date : (DateTime?)null;
        }

        // Thêm, cập nhật, xóa, đánh dấu đã trả
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu(null)) return;

            PhieuMuon p = new PhieuMuon();
            GhiVaoPhieu(p);
            dsPhieu.Add(p);

            // Bỏ tìm kiếm / lọc để chắc chắn thấy phiếu vừa thêm
            txtTimKiem.TextChanged -= BoLoc_Changed;
            cboLoc.SelectedIndexChanged -= BoLoc_Changed;
            txtTimKiem.Clear();
            cboLoc.SelectedIndex = 0;
            txtTimKiem.TextChanged += BoLoc_Changed;
            cboLoc.SelectedIndexChanged += BoLoc_Changed;

            ApDungLoc(p);
            MessageBox.Show("Đã thêm phiếu " + p.MaPhieu + ".", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            PhieuMuon p = bsPhieu.Current as PhieuMuon;
            if (p == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu cần cập nhật.", "Thông báo");
                return;
            }
            if (!KiemTraDuLieu(p)) return;

            if (MessageBox.Show("Cập nhật phiếu " + p.MaPhieu + "?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            GhiVaoPhieu(p);
            ApDungLoc(p);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            PhieuMuon p = bsPhieu.Current as PhieuMuon;
            if (p == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu cần xóa.", "Thông báo");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa phiếu " + p.MaPhieu + "?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            dsPhieu.Remove(p);
            ApDungLoc(null);
        }

        // Đánh dấu đã trả: ngày trả thực tế = hôm nay -> tình trạng tự chuyển thành "Đã trả"
        private void btnDanhDauDaTra_Click(object sender, EventArgs e)
        {
            PhieuMuon p = bsPhieu.Current as PhieuMuon;
            if (p == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu cần đánh dấu đã trả.", "Thông báo");
                return;
            }
            if (p.NgayTraThucTe.HasValue)
            {
                MessageBox.Show("Phiếu " + p.MaPhieu + " đã được trả trước đó.", "Thông báo");
                return;
            }
            if (DateTime.Today < p.NgayMuon.Date)
            {
                errorProvider1.SetError(dtpNgayTra, "Ngày trả thực tế không được trước ngày mượn.");
                MessageBox.Show("Ngày trả (hôm nay) đang trước ngày mượn của phiếu!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            p.NgayTraThucTe = DateTime.Today;
            ApDungLoc(p);
            MessageBox.Show("Phiếu " + p.MaPhieu + " đã được đánh dấu ĐÃ TRẢ ngày " + DateTime.Today.ToString("dd/MM/yyyy") + ".",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            XoaTrangForm();
            txtMaSV.Focus();
        }

        // Màu cho tình trạng
        private void dgvPhieu_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            PhieuMuon p = dgvPhieu.Rows[e.RowIndex].DataBoundItem as PhieuMuon;
            if (p == null) return;

            if (p.TinhTrang == TinhTrangPhieu.QuaHan) e.CellStyle.ForeColor = Color.Red;
            else if (p.TinhTrang == TinhTrangPhieu.DaTra) e.CellStyle.ForeColor = Color.Green;
        }


        // Xuất file CSV
        private static string CsvField(string value)
        {
            if (string.IsNullOrEmpty(value)) return "";
            if (value.Contains(",") || value.Contains("\"") || value.Contains("\n"))
                return "\"" + value.Replace("\"", "\"\"") + "\"";
            return value;
        }

        private void btnXuatCSV_Click(object sender, EventArgs e)
        {
            if (dsHienThi.Count == 0)
            {
                MessageBox.Show("Không có phiếu nào để xuất!", "Thông báo");
                return;
            }

            // sfdXuatCSV là SaveFileDialog kéo từ Toolbox (Filter, DefaultExt, Title đặt trong Properties)
            sfdXuatCSV.FileName = "PhieuMuon_" + DateTime.Now.ToString("yyyyMMdd") + ".csv";
            if (sfdXuatCSV.ShowDialog() != DialogResult.OK) return;

            try
            {
                using (StreamWriter sw = new StreamWriter(sfdXuatCSV.FileName, false, new UTF8Encoding(true)))
                {
                    sw.WriteLine("Mã phiếu,Mã SV,Họ tên SV,Thiết bị,Số lượng,Ngày mượn,Hạn trả,Ngày trả thực tế,Tình trạng");
                    foreach (PhieuMuon p in dsHienThi)
                    {
                        sw.WriteLine(string.Join(",",
                            CsvField(p.MaPhieu),
                            CsvField(p.MaSV),
                            CsvField(p.HoTen),
                            CsvField(p.ThietBi),
                            p.SoLuong,
                            p.NgayMuon.ToString("dd/MM/yyyy"),
                            p.HanTra.ToString("dd/MM/yyyy"),
                            p.NgayTraThucTe.HasValue ? p.NgayTraThucTe.Value.ToString("dd/MM/yyyy") : "",
                            CsvField(p.TinhTrang)));
                    }
                }
                MessageBox.Show("Đã xuất " + dsHienThi.Count + " phiếu ra file CSV.", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi xuất file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
