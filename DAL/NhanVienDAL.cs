using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhanVienDAL
    {
        private static NhanVienDAL instance;
        public static NhanVienDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVienDAL();
                return instance;
            }
            set
            { instance = value; }
        }
        public NhanVien LayThongTinNhanVien(string username)
        {
            NhanVien nhanVien = new NhanVien();

            DataTable dt = DatabaseAccess.Instance.ExecuteReader(
                "usp_LayThongTinNhanVien", CachThucHien.StoredProcedure,
                new string[] { "@Username" },
                new string[] { username }
                );
            DataRow dataRow = dt.Rows[0];

            nhanVien.HoTen = dataRow.ItemArray[0].ToString();
            nhanVien.NgaySinh= Convert.ToDateTime(dataRow.ItemArray[1]);
            nhanVien.GioiTinh = (int)dataRow.ItemArray[2];
            nhanVien.QueQuan = dataRow.ItemArray[3].ToString();
            nhanVien.SoDienThoai = dataRow.ItemArray[4].ToString();
            return nhanVien;
        }
        public TrangThai CapNhatThongTin(NhanVien nhanVien,int maChucVu,string username)
        {
            int result = DatabaseAccess.Instance.ExecuteNonQuery(
                "usp_CapNhatThongTinNhanVien",CachThucHien.StoredProcedure,
                new string[] { "@HoTen", "@NgaySinh", "@GioiTinh", "@QueQuan", "@SoDienThoai","@MaChucVu", "@Username" },
                new object[] { nhanVien.HoTen, nhanVien.NgaySinh, nhanVien.GioiTinh, nhanVien.QueQuan, nhanVien.SoDienThoai, maChucVu,username }
                );
            if (result == 0) return TrangThai.ThatBai;
            return TrangThai.ThanhCong;   
        }
        public DataTable LayDanhSach(string username)
        {
            return DatabaseAccess.Instance.ExecuteReader(
                "usp_LayDanhSachNhanVien", CachThucHien.StoredProcedure,
                new string[] {"@username"},
                new object[] { username }

                );
        }
    }
}
