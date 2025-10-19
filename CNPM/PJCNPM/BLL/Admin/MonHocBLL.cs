using PJCNPM.DAL.Admin;
using PJCNPM.Mod;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace PJCNPM.BLL.Admin
{
    public class MonHocBLL
    {
        private MonHocDB _monHocDB;

        public MonHocBLL()
        {
            _monHocDB = new MonHocDB();
        }

        public DataTable LoadMonHoc()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MonHocID", typeof(int));
            dt.Columns.Add("Môn học");
            dt.Columns.Add("Môn đôi");
            dt.Columns.Add("Môn năng khiếu");
            dt.Columns.Add("Trạng thái");

            List<MonHoc> dsmh = _monHocDB.GetAllMonHoc();

            foreach (var mon in dsmh)
            {
                dt.Rows.Add(
                    mon.MonHocID,
                    mon.TenMon,
                    mon.LaMonDoi ? "Có" : "Không",
                    mon.LaMonNangKhieu ? "Có" : "Không",
                    mon.TrangThai ? "Mở" : "Khoá"
                );
            }

            return dt;
        }

        public DataTable LoadMonHocByFilter(bool showAll, bool showLocked)
        {
            List<MonHoc> dsmh;

            if (showAll)
            {
                dsmh = _monHocDB.GetAllMonHoc();
            }
            else if (showLocked)
            {
                dsmh = _monHocDB.GetAllMonHocLocked();
            }
            else
            {
                dsmh = _monHocDB.GetAllMonHocActive();
            }

            return BindMonHocToGrid(dsmh);
        }

        private DataTable BindMonHocToGrid(List<MonHoc> dsmh)
        {
            var dt = new DataTable();
            dt.Columns.Add("MonHocID", typeof(int));
            dt.Columns.Add("Môn học");
            dt.Columns.Add("Môn đôi");
            dt.Columns.Add("Môn năng khiếu");
            dt.Columns.Add("Trạng thái");

            foreach (var mon in dsmh)
            {
                dt.Rows.Add(
                    mon.MonHocID,
                    mon.TenMon,
                    mon.LaMonDoi ? "Có" : "Không",
                    mon.LaMonNangKhieu ? "Có" : "Không",
                    mon.TrangThai ? "Mở" : "Khoá"
                );
            }

            return dt;
        }

        public bool AddMonHoc(string tenMon, bool laMonDoi, bool laMonNangKhieu, bool trangThai)
        {
            if (string.IsNullOrEmpty(tenMon))
            {
                return false;
            }

            MonHoc newMH = new MonHoc
            {
                TenMon = tenMon,
                LaMonDoi = laMonDoi,
                LaMonNangKhieu = laMonNangKhieu,
                TrangThai = trangThai
            };

            return _monHocDB.InsertMonHoc(newMH);
        }

        public bool UpdateMonHoc(int monHocID, string tenMon, bool laMonDoi, bool laMonNangKhieu, bool trangThai)
        {
            if (string.IsNullOrEmpty(tenMon) || monHocID <= 0)
            {
                return false;
            }

            MonHoc mh = new MonHoc
            {
                MonHocID = monHocID,
                TenMon = tenMon,
                LaMonDoi = laMonDoi,
                LaMonNangKhieu = laMonNangKhieu,
                TrangThai = trangThai
            };

            return _monHocDB.UpdateMonHoc(mh);
        }

        public bool DeleteMonHoc(int monHocID)
        {
            if (monHocID <= 0)
            {
                return false;
            }

            return _monHocDB.DeleteMonHoc(monHocID);
        }

        public bool PermanentlyDeleteMonHoc(int monHocID)
        {
            if (monHocID <= 0)
            {
                return false;
            }

            return _monHocDB.PermanentlyDeleteMonHoc(monHocID);
        }

        public List<MonHoc> GetAllMonHocActive()
        {
            return _monHocDB.GetAllMonHocActive();
        }
    }
}
