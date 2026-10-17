namespace BT4._9
{
    /// <summary>Các trạng thái của một lịch hẹn.</summary>
    public static class TrangThaiHen
    {
        public const string ChoKham = "Chờ khám";
        public const string DangKham = "Đang khám";
        public const string HoanTat = "Hoàn tất";
        public const string DaHuy = "Đã hủy";

        public static readonly string[] TatCa = { ChoKham, DangKham, HoanTat, DaHuy };
    }

    /// <summary>Một lịch hẹn khám bệnh.</summary>
    public class LichHen
    {
        public string MaLichHen { get; set; } = "";
        public string HoTen { get; set; } = "";
        public string SoDienThoai { get; set; } = "";
        public System.DateTime NgayHen { get; set; }
        public string BacSi { get; set; } = "";
        public string LyDo { get; set; } = "";
        public string TrangThai { get; set; } = TrangThaiHen.ChoKham;
    }
}
