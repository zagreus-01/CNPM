using PJCNPM.DAL.HocSinh;
using System;
using System.Collections.Generic;
using System.Data;

namespace PJCNPM.BLL.HocSinh
{
    internal class DiemHocSinhBLL
    {
        private readonly DiemDAL dal = new DiemDAL();

        // 🔹 Lấy danh sách năm học dạng chuỗi
        public List<string> GetNamHocHocSinh(int hocSinhID)
        {
            DataTable dt = dal.LayNamHocHocSinh(hocSinhID);
            List<string> list = new List<string>();
            foreach (DataRow row in dt.Rows)
                list.Add(row["NamHoc"].ToString());
            return list;
        }

        // 🔹 Lấy bảng điểm + hạnh kiểm, làm tròn 2 chữ số
        public (DataTable Diem, string HanhKiem) GetBangDiem(int hocSinhID, string namHocStr, string hocKyStr)
        {
            short namHoc = short.Parse(namHocStr);
            int? hocKy = null;
            if (hocKyStr == "Học kỳ 1") hocKy = 1;
            else if (hocKyStr == "Học kỳ 2") hocKy = 2;

            // Lấy dữ liệu điểm và hạnh kiểm
            DataTable dt = dal.LayBangDiemHocSinh(hocSinhID, namHoc, hocKy);
            string hanhKiem = dal.LayHanhKiem(hocSinhID, namHoc, hocKy);

            // ✅ Làm tròn điểm (2 chữ số thập phân)
            foreach (DataColumn col in dt.Columns)
            {
                if (col.DataType == typeof(double) || col.DataType == typeof(float) || col.DataType == typeof(decimal))
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row[col] != DBNull.Value)
                        {
                            double val = Convert.ToDouble(row[col]);
                            row[col] = Math.Round(val, 2, MidpointRounding.AwayFromZero);
                        }
                    }
                }
            }

            return (dt, hanhKiem);
        }
    }
}
