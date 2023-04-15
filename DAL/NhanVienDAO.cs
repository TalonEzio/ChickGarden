﻿using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhanVienDAO
    {
        private static NhanVienDAO instance;
        public static NhanVienDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVienDAO();
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
        public TrangThai CapNhatThongTin(NhanVien nhanVien,string username)
        {
            int result = DatabaseAccess.Instance.ExecuteNonQuery(
                "usp_CapNhatThongTinNhanVien",CachThucHien.StoredProcedure,
                new string[] { "@HoTen", "@NgaySinh", "@GioiTinh", "@QueQuan", "@SoDienThoai", "@Username" },
                new object[] { nhanVien.HoTen, nhanVien.NgaySinh, nhanVien.GioiTinh,nhanVien.QueQuan, nhanVien.SoDienThoai,username }
                );
            if (result == 0) return TrangThai.ThatBai;
            return TrangThai.ThanhCong;   
        }
    }
}
