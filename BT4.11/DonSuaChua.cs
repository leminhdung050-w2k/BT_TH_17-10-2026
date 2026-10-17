using System;

namespace BT4._11
{
    // Các trạng thái của đơn sửa chữa
    public static class TrangThaiDon
    {
        public const string MoiTiepNhan = "Mới tiếp nhận";
        public const string DangSua = "Đang sửa";
        public const string ChoLinhKien = "Chờ linh kiện";
        public const string HoanTat = "Hoàn tất";
        public const string DaHuy = "Đã hủy";
    }

    // Một đơn đăng ký sửa chữa
    public class DonSuaChua
    {
        public string MaDon { get; set; }
        public string TenKhach { get; set; }
        public string SoDienThoai { get; set; }
        public string LoaiThietBi { get; set; }
        public string MoTaLoi { get; set; }
        public DateTime NgayTiepNhan { get; set; }
        public decimal ChiPhi { get; set; }
        public string TrangThai { get; set; }
        public string AnhPath { get; set; }

        // Đơn chưa hoàn tất: không phải Hoàn tất và không bị hủy
        public bool ChuaHoanTat
        {
            get { return TrangThai != TrangThaiDon.HoanTat && TrangThai != TrangThaiDon.DaHuy; }
        }
    }
}
