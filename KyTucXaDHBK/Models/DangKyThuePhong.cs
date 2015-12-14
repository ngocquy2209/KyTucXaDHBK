using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    [Table("tblDANGKYTHUEPHONG")]
    public class DangKyThuePhong
    {
        [Key]
        public string idDangKyThuePhong { set; get; }
        public string idTaiKhoan { set; get; }
        public string idPhong { set; get; }
        public string idHocKy { set; get; }
        public DateTime thoiGianDangKy { set; get; }
        public DateTime? thoiGianDuyet { set; get; }
        public string idPhongDuocDuyet { set; get; }
        public string idTrangThaiDangKy { set; get; }
        [ForeignKey("idTaiKhoan")]
        public virtual TaiKhoanSinhVien TaiKhoan { set; get; }
        [ForeignKey("idPhong")]
        public virtual Phong Phong { set; get; }
        [ForeignKey("idHocKy")]
        public virtual HocKy HocKy { set; get; }
        [ForeignKey("idTrangThaiDangKy")]
        public virtual TrangThaiDangKyThuePhong TrangThaiDangKyThue { set; get; }
        public DangKyThuePhong() { }
        public DangKyThuePhong(string idDangKyThuePhong, string idTaiKhoan, string idPhong, string idHocKy,
            DateTime thoiGianDangKy, DateTime thoiGianDuyet, string idPhongDuocDuyet, string idTrangThaiDangKy)
        {
            this.idDangKyThuePhong = idDangKyThuePhong;
            this.idTaiKhoan = idTaiKhoan;
            this.idPhong = idPhong;
            this.idHocKy = idHocKy;
            this.thoiGianDangKy = thoiGianDangKy;
            this.thoiGianDuyet = thoiGianDuyet;
            this.idPhongDuocDuyet = idPhongDuocDuyet;
            this.idTrangThaiDangKy = idTrangThaiDangKy;
        }
    }
}