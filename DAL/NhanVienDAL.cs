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
        public DataTable LayDanhSachNgoaiTru(string username)
        {
            return DatabaseAccess.Instance.ExecuteReader(
                "usp_LayDanhSachNhanVien", CachThucHien.StoredProcedure,
                new string[] {"@username"},
                new object[] { username });
        }
        public List<NhanVien> LayTatCaNhanVien()
        {
            List<NhanVien> DSNV = new List<NhanVien>();
            DataTable dt = DatabaseAccess.Instance.ExecuteReader("usp_LayTatCaNhanVien", CachThucHien.StoredProcedure);
            foreach (DataRow dr in dt.Rows)
            {
                DSNV.Add(new NhanVien()
                {
                    Id = (int)dr.ItemArray[0],
                    HoTen = dr.ItemArray[1].ToString(),
                    NgaySinh = DateTime.Parse(dr.ItemArray[2].ToString()),
                    GioiTinh = (int)dr.ItemArray[3],
                    QueQuan = dr.ItemArray[4].ToString(),
                    SoDienThoai = dr.ItemArray[5].ToString()
                }); ;
            }
            return DSNV;
        }
        public int LayMaNhanVien(string userName)
        {
            return (int)DatabaseAccess.Instance.ExecuteScalar("usp_LayMaNhanVien", CachThucHien.StoredProcedure,
                new string[] { "@UserName" }, new object[] { userName });
        }
    }
}
