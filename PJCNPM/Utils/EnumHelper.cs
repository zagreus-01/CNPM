using System;

namespace PJCNPM.Utils
{
    public static class EnumHelper
    {
        // 🔹 Chuyển từ số (trong DB) sang chuỗi hiển thị
        public static string TrangThaiHocSinhToText(byte value)
        {
            switch (value)
            {
                case 0: return "Nghỉ học";
                case 1: return "Đang học";
                case 2: return "Tạm dừng";
                default: return "Không xác định";
            }
        }

        // 🔹 Chuyển từ chuỗi hiển thị sang số (để lưu DB)
        public static byte TrangThaiHocSinhToValue(string text)
        {
            if (string.IsNullOrEmpty(text)) return 1;
            text = text.Trim().ToLower();

            if (text == "đang học" || text == "dang hoc")
                return 1;
            if (text == "nghỉ học" || text == "nghi hoc")
                return 0;
            if (text == "tạm dừng" || text == "tam dung")
                return 2;

            return 1; // mặc định "Đang học"
        }

        // 🔹 Giới tính
        public static string GioiTinhToText(bool gioiTinh)
        {
            return gioiTinh ? "Nam" : "Nữ";
        }

        public static bool GioiTinhToValue(string text)
        {
            if (string.IsNullOrEmpty(text)) return true;
            text = text.Trim().ToLower();
            return text == "nam" || text == "true" || text == "1";
        }
    }
}
