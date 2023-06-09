﻿using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUSDocGia
    {
        private static BUSDocGia instance;
        public static BUSDocGia Instance
        {
            get
            {
                if (instance == null) instance = new BUSDocGia();
                return instance;
            }
            set => instance = value;
        }
        // Lấy danh sách tất cả đọc giả
        public List<DOCGIA> GetAllDocGia()
        {
            return DALDocGia.Instance.GetAllDocGia();
        }
        // Tìm kiếm đọc giả dựa theo tên, email, id loại đọc giả
        public List<DOCGIA> FindDocGia(string tenDocGia, string email, int? idLoaiDocGia)
        {
            return DALDocGia.Instance.FindDocGia(tenDocGia, email, idLoaiDocGia);
        }
        public DOCGIA FindDocGiaByIdND(int idnguoidung)
        {
            return DALDocGia.Instance.FindDocGiaByIdND(idnguoidung);
        }
        public int GetSoSachDangMuon(int id)
        {
            int cnt = 0;
            DOCGIA dg = DALDocGia.Instance.GetDocGiaById(id);
            foreach (PHIEUMUONTRA pmt in dg.PHIEUMUONTRAs)
                if (pmt.NgayTra == null)
                    cnt++;
            return cnt;
        }

        // Lấy ra đọc giả theo số id của đọc giả
        public DOCGIA GetDocGiaById(int id)
        {
            DOCGIA dg;
            try
            {
                dg = DALDocGia.Instance.GetDocGiaById(id);
                return dg;
            }
            catch
            { return null; }
        }
        // Lấy ra đọc giả theo số mã của đọc giả
        public DOCGIA GetDocGiaByMa(string ma) {
            DOCGIA dg;
            try
            {
                dg = DALDocGia.Instance.GetDocGiaByMa(ma);
                return dg;
            }
            catch
            { return null; }
        }
        public bool AddDocGia(string tenDocGia, DateTime ngaySinh, string diaChi,
            DateTime ngayLapThe, DateTime ngayHetHan, int idLoaiDocGia, int tongNoHienTai, int idND)
        {
            //THAMSO thamso = DALThamSo.Instance.GetAllThamSo();
            //int gap = ngayLapThe.Year - ngaySinh.Year;
            //if (ngayLapThe.Month < ngaySinh.Month || (ngayLapThe.Month == ngaySinh.Month && ngayLapThe.Day < ngaySinh.Day))
            //    gap -= 1;

            //if (gap < thamso.TuoiToiThieu || gap > thamso.TuoiToiDa)
            //    return "Tuổi không hợp lệ!";

            //var ldg = BUSLoaiDocGia.Instance.GetLoaiDocGiaById(idLoaiDocGia);
            //if (ldg == null) return "Loai Doc Gia khong hop le";

            //int IdND = Convert.ToInt32(DALDocGia.Instance.AddDocGia(tenDocGia, ngaySinh, diaChi, ngayLapThe, ngayHetHan, idLoaiDocGia, tongNoHienTai, idND));
            //if (idND == -1) return "Tên đăng nhập đã tồn tại";
            //if (DALDocGia.Instance.AddDocGia(tenDocGia, ngaySinh, diaChi, ngayLapThe, ngayHetHan, idLoaiDocGia, 0, idND))
            //    return "";
            //DALNguoiDung.Instance.DelNguoiDung(idND);
            //return "Lỗi khi thêm độc giả";
            return DALDocGia.Instance.AddDocGia(tenDocGia, ngaySinh, diaChi, ngayLapThe, ngayHetHan, idLoaiDocGia, tongNoHienTai, idND);
        }

        public string UpdDocGia(int idDocGia, string tenDocGia, DateTime? ngaySinh, string diaChi,
            DateTime? ngayHetHan, int? idLoaiDocGia)
        {
            var dg = GetDocGiaById(idDocGia);
            if (ngaySinh != null)
            {
                var ngayLapThe = dg.NgayLapThe;
                THAMSO thamso = DALThamSo.Instance.GetAllThamSo();
                int gap = ngayLapThe.Year - ngaySinh.Value.Year;
                if (ngayLapThe.Month < ngaySinh.Value.Month || (ngayLapThe.Month == ngaySinh.Value.Month && ngayLapThe.Day < ngaySinh.Value.Day))
                    gap -= 1;

                if (gap < thamso.TuoiToiThieu || gap > thamso.TuoiToiDa)
                    return "Tuổi không hợp lệ";
                if (gap < thamso.TuoiToiThieu || gap > thamso.TuoiToiDa)
                    return "Tuổi không hợp lệ";
            }
            if (idLoaiDocGia != null)
            {
                var ldg = BUSLoaiDocGia.Instance.GetLoaiDocGiaById((int)idLoaiDocGia);
                if (ldg == null) return "Loại độc giả không hợp lệ";
            }
            if (DALDocGia.Instance.UpdDocGia(idDocGia, tenDocGia, ngaySinh, diaChi, null, idLoaiDocGia))
                return "";
            return "Sửa thông tin thất bại";
        }
        public string UpdTongNo(int id, int TongNo)
        {
            DOCGIA docgia = DALDocGia.Instance.GetDocGiaById(id);
            if (docgia == null) 
                return "Mã độc giả không hợp lệ";
            if (TongNo < 0)
                return "Nợ không hợp lệ";
            DALDocGia.Instance.UpdTongNoDocGia(id, TongNo);
            return "";

        }
    }
}
