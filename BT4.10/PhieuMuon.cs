using System;

namespace BT4._10
{
    /// <summary>Các tình trạng của phiếu mượn.</summary>
    public static class TinhTrangPhieu
    {
        public const string DangMuon = "Đang mượn";
        public const string DaTra = "Đã trả";
        public const string QuaHan = "Quá hạn";
    }

    /// <summary>Một phiếu mượn thiết bị.</summary>
    public class PhieuMuon
    {
        public string MaPhieu { get; set; }
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public string ThietBi { get; set; }
        public int SoLuong { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime HanTra { get; set; }

        // null = chưa trả
        public DateTime? NgayTraThucTe { get; set; }

        // Tình trạng được TỰ TÍNH, không nhập tay:
        //  - Có ngày trả thực tế              -> Đã trả
        //  - Chưa trả và hạn trả < hôm nay    -> Quá hạn
        //  - Còn lại                           -> Đang mượn
        public string TinhTrang
        {
            get
            {
                if (NgayTraThucTe.HasValue) return TinhTrangPhieu.DaTra;
                if (HanTra.Date < DateTime.Today) return TinhTrangPhieu.QuaHan;
                return TinhTrangPhieu.DangMuon;
            }
        }
    }
}
