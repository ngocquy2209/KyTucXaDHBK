using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    [Table("tblTHUEPHONG")]
    public class ThuePhong
    {
        [Key]
        public string idThuePhong { set; get; }
        public string idTaiKhoan { set; get; }
        public string idPhong { set; get; }
        public string idHocKy { set; get; }
        public string idTrangThaiThue { set; get; }
        [ForeignKey("idTaiKhoan")]
        public virtual TaiKhoanSinhVien TaiKhoan { set; get; }
        [ForeignKey("idPhong")]
        public virtual Phong Phong { set; get; }
        [ForeignKey("idTrangThaiThue")]
        public virtual TrangThaiThue TrangThaiThue { set; get; }
        [ForeignKey("idHocKy")]
        public virtual HocKy HocKy { set; get; }
        public virtual ICollection<DangKyGiaHan> CacDangKyGiaHan { set; get; }
        public virtual ICollection<YeuCau> CacYeuCau { set; get; }
        public virtual ICollection<DangKyDichVu> CacDangKyDichVu { set; get; }
        public ThuePhong() { }
        public ThuePhong(string idThuePhong, string idTaiKhoan, string idPhong,
            string idHocKy, string idTrangThaiThue)
        {
            this.idThuePhong = idThuePhong;
            this.idTaiKhoan = idTaiKhoan;
            this.idPhong = idPhong;
            this.idHocKy = idHocKy;
            this.idTrangThaiThue = idTrangThaiThue;
        }
    }
}