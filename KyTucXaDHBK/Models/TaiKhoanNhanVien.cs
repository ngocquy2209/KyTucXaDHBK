using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    [Table("tblTAIKHOANNHANVIEN")]
    public class TaiKhoanNhanVien
    {
        [Key]
        public string idTaiKhoan { set; get; }
        public string idNhanVien { set; get; }
        public string tenDangNhap { set; get; }
        public string matKhau { set; get; }
        public DateTime khoaTaiKhoanDen { set; get; }
        public string idNhom { set; get; }
        [ForeignKey("idNhanVien")]
        public virtual NhanVien NhanVien { set; get; }
        [ForeignKey("idNhom")]
        public virtual Nhom Nhom { set; get; }
        public virtual ICollection<FileTaiLen> FileTaiLen { set; get; }
        public virtual ICollection<LichSuQuanLy> LichSuQuanLy { set; get; }
        public virtual ICollection<TinTucTrangChu> TinTucTrangChu { set; get; }
        public virtual ICollection<SuaChua> SuaChua { set; get; }
        public TaiKhoanNhanVien() { }
        public TaiKhoanNhanVien(string idTaiKhoan, string idNhanVien, string tenDangNhap,
            string matKhau, DateTime khoaTaiKhoanDen, string idNhom)
        {
            this.idTaiKhoan = idTaiKhoan;
            this.idNhanVien = idNhanVien;
            this.tenDangNhap = tenDangNhap;
            this.matKhau = matKhau;
            this.khoaTaiKhoanDen = khoaTaiKhoanDen;
            this.idNhom = idNhom;
        }
    }
}