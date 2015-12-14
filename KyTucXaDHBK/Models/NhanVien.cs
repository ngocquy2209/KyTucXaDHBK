using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    [Table("tblNHANVIEN")]
    public class NhanVien
    {
        [Key]
        public string idNhanVien { set; get; }
        public string ho { set; get; }
        public string ten { set; get; }
        public string gioiTinh { set; get; }
        public DateTime ngaySinh { set; get; }
        public string diaChi{ set; get; }
        [StringLength(12)]
        public string SDT { set; get; }
        [StringLength(12)]
        public string CMND { set; get; }
        public string idChucVu { set; get; }
        public string ghiChu { set; get; }
        [ForeignKey("idChucVu")]
        public virtual ChucVu ChucVu { set; get; }
        public virtual ICollection<TaiKhoanNhanVien> TaiKhoan { set; get; }
        public NhanVien() { }
        public NhanVien(string idNhanVien, string ho, string ten, string gioiTinh, DateTime ngaySinh,
            string diaChi, string SDT, string CMND, string idChucVu, string ghiChu)
        {
            this.idNhanVien = idNhanVien;
            this.ho = ho;
            this.ten = ten;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.diaChi = diaChi;
            this.SDT = SDT;
            this.CMND = CMND;
            this.idChucVu = idChucVu;
            this.ghiChu = ghiChu;
        }
    }
}