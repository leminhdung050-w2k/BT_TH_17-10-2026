using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BT4._9
{
    public partial class Form1 : Form
    {
        // Danh sách gốc (toàn bộ lịch hẹn) và danh sách đang hiển thị (sau tìm kiếm/lọc)
        private readonly List<LichHen> _tatCa = new List<LichHen>();
        private readonly BindingList<LichHen> _hienThi = new BindingList<LichHen>();

        private const string TAT_CA = "Tất cả";

        private static readonly Regex SdtHopLe = new Regex(@"^(0|\+84)(3|5|7|8|9)\d{8}$");
        private bool _dangDungLai;

        public Form1()
        {
            InitializeComponent();
            CaiDatBanDau();
            GanSuKien();
            NapDuLieuMau();
            ApDungBoLoc(null);
        }

        //Khởi tạo
        private void CaiDatBanDau()
        {
            cboBacSi.Items.AddRange(new object[]
            {
                "BS. Lê Minh Dũng", "BS. Trần Thị Bình", "BS. Lê Minh Châu", "BS. Phạm Quốc Dũng"
            });
            cboTrangThai.Items.AddRange(TrangThaiHen.TatCa);

            cboLocTrangThai.Items.Add(TAT_CA);
            cboLocTrangThai.Items.AddRange(TrangThaiHen.TatCa);
            cboLocTrangThai.SelectedIndex = 0;

            // AutoGenerateColumns không có trong cửa sổ Properties -> đặt bằng code, TRƯỚC khi gán DataSource
            dgvLichHen.AutoGenerateColumns = false;
            bindingSource1.DataSource = _hienThi;
            dgvLichHen.DataSource = bindingSource1;
        }

        private void GanSuKien()
        {
            btnThem.Click += BtnThem_Click;
            btnCapNhat.Click += BtnCapNhat_Click;
            btnXoa.Click += BtnXoa_Click;
            btnLamMoi.Click += (s, e) => LamMoiNhap();
            btnBoLoc.Click += BtnBoLoc_Click;

            // Tìm kiếm tức thời + lọc
            txtTimKiem.TextChanged += (s, e) => ApDungBoLoc(null);
            dtpLocNgay.ValueChanged += (s, e) => ApDungBoLoc(null);
            cboLocTrangThai.SelectedIndexChanged += (s, e) => ApDungBoLoc(null);
            chkLocNgay.CheckedChanged += (s, e) =>
            {
                dtpLocNgay.Enabled = chkLocNgay.Checked;
                ApDungBoLoc(null);
            };

            dgvLichHen.SelectionChanged += (s, e) => { if (!_dangDungLai) NapLenForm(); };
            dgvLichHen.CellFormatting += DgvLichHen_CellFormatting;

            // Sửa lại trường nào thì xóa biểu tượng lỗi của trường đó
            foreach (Control c in new Control[] { txtMa, txtHoTen, txtSdt, txtLyDo, dtpNgayHen, cboBacSi, cboTrangThai })
            {
                Control ctl = c;
                ctl.TextChanged += (s, e) => errorProvider1.SetError(ctl, "");
            }

            mnuXuatCsv.Click += MnuXuatCsv_Click;
            mnuThoat.Click += (s, e) => Close();

            Shown += (s, e) => LamMoiNhap();
        }

        private void NapDuLieuMau()
        {
            DateTime h = DateTime.Today;
            _tatCa.Add(new LichHen { MaLichHen = "LH001", HoTen = "Nguyễn Văn Nam", SoDienThoai = "0912345678",
                NgayHen = h.AddHours(8), BacSi = "BS. Lê Minh Dũng", LyDo = "Khám tổng quát", TrangThai = TrangThaiHen.HoanTat });
            _tatCa.Add(new LichHen { MaLichHen = "LH002", HoTen = "Trần Thị Hoa", SoDienThoai = "0987654321",
                NgayHen = h.AddHours(9.5), BacSi = "BS. Trần Thị Bình", LyDo = "Đau họng, sốt nhẹ", TrangThai = TrangThaiHen.DangKham });
            _tatCa.Add(new LichHen { MaLichHen = "LH003", HoTen = "Lê Quang Huy", SoDienThoai = "0356789123",
                NgayHen = h.AddHours(17), BacSi = "BS. Lê Minh Châu", LyDo = "Tái khám huyết áp", TrangThai = TrangThaiHen.ChoKham });
            _tatCa.Add(new LichHen { MaLichHen = "LH004", HoTen = "Phạm Thu Trang", SoDienThoai = "0778899001",
                NgayHen = h.AddDays(1).AddHours(9), BacSi = "BS. Phạm Quốc Dũng", LyDo = "Khám da liễu", TrangThai = TrangThaiHen.ChoKham });
            _tatCa.Add(new LichHen { MaLichHen = "LH005", HoTen = "Đỗ Minh Khang", SoDienThoai = "0901122334",
                NgayHen = h.AddDays(1).AddHours(10), BacSi = "BS. Nguyễn Văn An", LyDo = "Đau dạ dày", TrangThai = TrangThaiHen.DaHuy });
        }
        //endregion

        //Hiển thị, tìm kiếm, lọc
        private LichHen DongDangChon
        {
            get
            {
                if (dgvLichHen.SelectedRows.Count == 0) return null;
                return dgvLichHen.SelectedRows[0].DataBoundItem as LichHen;
            }
        }

        private void ApDungBoLoc(LichHen uuTienChon)
        {
            LichHen giuLai = uuTienChon ?? DongDangChon;

            string tuKhoa = BoDau(txtTimKiem.Text.Trim());
            string tuKhoaSo = Regex.Replace(txtTimKiem.Text, @"[\s.\-]", "");
            bool locNgay = chkLocNgay.Checked;
            DateTime ngay = dtpLocNgay.Value.Date;
            string trangThai = cboLocTrangThai.SelectedItem as string ?? TAT_CA;

            List<LichHen> ketQua = _tatCa
                .Where(x => tuKhoa.Length == 0
                         || BoDau(x.HoTen).Contains(tuKhoa)
                         || (tuKhoaSo.Length > 0 && x.SoDienThoai.Contains(tuKhoaSo)))
                .Where(x => !locNgay || x.NgayHen.Date == ngay)
                .Where(x => trangThai == TAT_CA || x.TrangThai == trangThai)
                .OrderBy(x => x.NgayHen)
                .ToList();

            _dangDungLai = true;
            try
            {
                _hienThi.RaiseListChangedEvents = false;
                _hienThi.Clear();
                foreach (LichHen lh in ketQua) _hienThi.Add(lh);
                _hienThi.RaiseListChangedEvents = true;
                _hienThi.ResetBindings();

                int viTri = giuLai == null ? -1 : _hienThi.IndexOf(giuLai);
                if (viTri >= 0)
                    bindingSource1.Position = viTri;
                else
                    dgvLichHen.ClearSelection();
            }
            finally
            {
                _dangDungLai = false;
            }

            CapNhatThanhTrangThai();
        }

        private static string BoDau(string s)
        {
            if (string.IsNullOrEmpty(s)) return "";
            string tachDau = s.ToLowerInvariant().Replace('đ', 'd').Normalize(NormalizationForm.FormD);
            var sb = new StringBuilder(tachDau.Length);
            foreach (char ch in tachDau)
                if (CharUnicodeInfo.GetUnicodeCategory(ch) != UnicodeCategory.NonSpacingMark)
                    sb.Append(ch);
            return sb.ToString().Normalize(NormalizationForm.FormC);
        }

        private void CapNhatThanhTrangThai()
        {
            var demTheoTT = TrangThaiHen.TatCa
                .Select(t => t + ": " + _hienThi.Count(x => x.TrangThai == t));
            tsslSoLuong.Text = string.Format("Hiển thị {0}/{1} lịch hẹn   |   {2}",
                _hienThi.Count, _tatCa.Count, string.Join("  ·  ", demTheoTT));
        }

        private void BtnBoLoc_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            chkLocNgay.Checked = false;
            cboLocTrangThai.SelectedIndex = 0;
            ApDungBoLoc(null);
        }

        private void DgvLichHen_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            LichHen lh = dgvLichHen.Rows[e.RowIndex].DataBoundItem as LichHen;
            if (lh == null) return;
            switch (lh.TrangThai)
            {
                case TrangThaiHen.DangKham:
                    e.CellStyle.BackColor = Color.LightYellow;
                    break;
                case TrangThaiHen.HoanTat:
                    e.CellStyle.ForeColor = Color.DarkGreen;
                    break;
                case TrangThaiHen.DaHuy:
                    e.CellStyle.ForeColor = Color.Gray;
                    break;
            }
        }
        //endregion

        //nhập liệu 
        private void NapLenForm()
        {
            LichHen lh = DongDangChon;
            if (lh == null) return;

            txtMa.Text = lh.MaLichHen;
            txtHoTen.Text = lh.HoTen;
            txtSdt.Text = lh.SoDienThoai;
            dtpNgayHen.Value = lh.NgayHen;
            cboBacSi.SelectedItem = lh.BacSi;
            cboTrangThai.SelectedItem = lh.TrangThai;
            txtLyDo.Text = lh.LyDo;
            errorProvider1.Clear();
        }

        private void LamMoiNhap()
        {
            dgvLichHen.ClearSelection();
            txtMa.Text = TaoMaMoi();
            txtHoTen.Clear();
            txtSdt.Clear();
            txtLyDo.Clear();
            dtpNgayHen.Value = CatGiay(DateTime.Now.AddHours(1));
            cboBacSi.SelectedIndex = -1;
            cboTrangThai.SelectedItem = TrangThaiHen.ChoKham;
            errorProvider1.Clear();
            txtHoTen.Focus();
        }

        private string TaoMaMoi()
        {
            int max = 0;
            foreach (LichHen x in _tatCa)
            {
                int n;
                if (x.MaLichHen.StartsWith("LH") && int.TryParse(x.MaLichHen.Substring(2), out n) && n > max)
                    max = n;
            }
            return "LH" + (max + 1).ToString("000");
        }

        private void GhiTuForm(LichHen lh)
        {
            lh.MaLichHen = txtMa.Text.Trim();
            lh.HoTen = txtHoTen.Text.Trim();
            lh.SoDienThoai = ChuanHoaSdt(txtSdt.Text);
            lh.NgayHen = CatGiay(dtpNgayHen.Value);
            lh.BacSi = cboBacSi.SelectedItem == null ? "" : cboBacSi.SelectedItem.ToString();
            lh.TrangThai = cboTrangThai.SelectedItem == null ? TrangThaiHen.ChoKham : cboTrangThai.SelectedItem.ToString();
            lh.LyDo = txtLyDo.Text.Trim();
        }

        private static string ChuanHoaSdt(string s)
        {
            return Regex.Replace(s ?? "", @"[\s.\-]", "");
        }

        private static DateTime CatGiay(DateTime d)
        {
            return new DateTime(d.Year, d.Month, d.Day, d.Hour, d.Minute, 0);
        }
   

        //Kiểm tra dữ liệu
        /// <param name="dangSua">null khi Thêm; lịch hẹn đang sửa khi Cập nhật</param>
        private bool KiemTraHopLe(LichHen dangSua)
        {
            errorProvider1.Clear();
            Control loiDauTien = null;

            Action<Control, string> baoLoi = (c, thongBao) =>
            {
                errorProvider1.SetError(c, thongBao);
                if (loiDauTien == null) loiDauTien = c;
            };

            string ma = txtMa.Text.Trim();
            if (ma.Length == 0)
                baoLoi(txtMa, "Vui lòng nhập mã lịch hẹn.");
            else if (_tatCa.Any(x => x != dangSua &&
                     string.Equals(x.MaLichHen, ma, StringComparison.OrdinalIgnoreCase)))
                baoLoi(txtMa, "Mã \"" + ma + "\" đã tồn tại, hãy nhập mã khác.");

            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
                baoLoi(txtHoTen, "Vui lòng nhập họ tên bệnh nhân.");

            if (!SdtHopLe.IsMatch(ChuanHoaSdt(txtSdt.Text)))
                baoLoi(txtSdt, "Số điện thoại không hợp lệ: 10 số, bắt đầu bằng 03/05/07/08/09 (hoặc +84).");

            if (cboBacSi.SelectedIndex < 0)
                baoLoi(cboBacSi, "Vui lòng chọn bác sĩ.");
            if (cboTrangThai.SelectedIndex < 0)
                baoLoi(cboTrangThai, "Vui lòng chọn trạng thái.");

            if (string.IsNullOrWhiteSpace(txtLyDo.Text))
                baoLoi(txtLyDo, "Vui lòng nhập lý do khám.");

            DateTime ngayMoi = CatGiay(dtpNgayHen.Value);
            bool coDoiNgay = dangSua == null || dangSua.NgayHen != ngayMoi;
            if (coDoiNgay && ngayMoi < CatGiay(DateTime.Now))
                baoLoi(dtpNgayHen, "Ngày giờ hẹn không được nằm trong quá khứ.");

            if (loiDauTien != null) loiDauTien.Focus();
            return loiDauTien == null;
        }
        //endregion

        //Thêm,cập nhật,xóa 
        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraHopLe(null)) return;
            if (MessageBox.Show("Thêm lịch hẹn mới?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            var lh = new LichHen();
            GhiTuForm(lh);
            _tatCa.Add(lh);
            ApDungBoLoc(lh);

            if (!_hienThi.Contains(lh))
                MessageBox.Show("Đã thêm, nhưng lịch hẹn không khớp bộ lọc hiện tại nên không hiển thị.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnCapNhat_Click(object sender, EventArgs e)
        {
            LichHen lh = DongDangChon;
            if (lh == null)
            {
                MessageBox.Show("Hãy chọn một lịch hẹn trong bảng để cập nhật.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!KiemTraHopLe(lh)) return;
            if (MessageBox.Show("Cập nhật lịch hẹn " + lh.MaLichHen + " - " + lh.HoTen + "?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            GhiTuForm(lh);
            ApDungBoLoc(lh); 
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            LichHen lh = DongDangChon;
            if (lh == null)
            {
                MessageBox.Show("Hãy chọn một lịch hẹn trong bảng để xóa.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Xóa lịch hẹn " + lh.MaLichHen + " của " + lh.HoTen + "?\nThao tác này không thể hoàn tác.",
                    "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

            _tatCa.Remove(lh);
            ApDungBoLoc(null);
            LamMoiNhap();
        }

        //Xuất file CSV
        private void MnuXuatCsv_Click(object sender, EventArgs e)
        {
            if (_hienThi.Count == 0)
            {
                MessageBox.Show("Không có lịch hẹn nào đang hiển thị để xuất.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            saveFileDialog1.FileName = "LichHen_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".csv";
            if (saveFileDialog1.ShowDialog(this) != DialogResult.OK) return;

            var sb = new StringBuilder();
            sb.AppendLine("Mã lịch hẹn,Họ tên,Số điện thoại,Ngày giờ hẹn,Bác sĩ,Lý do khám,Trạng thái");
            foreach (LichHen x in _hienThi)   // chỉ xuất danh sách ĐANG HIỂN THỊ
            {
                sb.AppendLine(string.Join(",", new[]
                {
                    Csv(x.MaLichHen), Csv(x.HoTen), Csv(x.SoDienThoai),
                    Csv(x.NgayHen.ToString("dd/MM/yyyy HH:mm")),
                    Csv(x.BacSi), Csv(x.LyDo), Csv(x.TrangThai)
                }));
            }

            try
            {
                File.WriteAllText(saveFileDialog1.FileName, sb.ToString(), new UTF8Encoding(true));
                MessageBox.Show("Đã xuất " + _hienThi.Count + " lịch hẹn ra:\n" + saveFileDialog1.FileName,
                    "Xuất CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Không ghi được file (có thể file đang mở trong Excel).\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private static string Csv(string s)
        {
            if (s == null) return "";
            if (s.IndexOfAny(new[] { ',', '"', '\n', '\r' }) >= 0)
                return "\"" + s.Replace("\"", "\"\"") + "\"";
            return s;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
