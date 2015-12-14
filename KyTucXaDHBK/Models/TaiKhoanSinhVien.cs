using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    [Table("tblTAIKHOANSINHVIEN")]
    public class TaiKhoanSinhVien
    {
        [Key]
        public string idTaiKhoan { set; get; }
        public string idSinhVien { set; get; }
        public string matKhau { set; get; }
        public DateTime khoaTaiKhoanDen { set; get; }
        [ForeignKey("idSinhVien")]
        public virtual SinhVien SinhVien { set; get; }
        public virtual ICollection<ViPham> CacViPham { set; get; }
        public virtual ICollection<BaoVang> CacBaoVang { set; get; }
        public virtual ICollection<ThuePhong> CacThuePhong { set; get; }
        public virtual ICollection<DangKyThuePhong> CacDangKyThuePhong { set; get; }
        public virtual ICollection<PhiNoiTru> CacPhiNoiTru { set; get; }
        public virtual ICollection<ThongBao> CacThongBao { set; get; }
        public virtual ICollection<PhiDienNuoc> CacPhiDienNuoc { set; get; }
        public virtual ICollection<PhiDichVu> CacPhiDichVu { set; get; }
        public TaiKhoanSinhVien() { }
        public TaiKhoanSinhVien(string idTaiKhoan, string idSinhVien, string matKhau, DateTime khoaTaiKhoanDen)
        {
            this.idTaiKhoan = idTaiKhoan;
            this.idSinhVien = idSinhVien;
            this.matKhau = matKhau;
            this.khoaTaiKhoanDen = khoaTaiKhoanDen;
        }
    }
}