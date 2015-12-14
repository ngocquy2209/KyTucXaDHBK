using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    [Table("tblDANGKYGIAHAN")]
    public class DangKyGiaHan
    {
        [Key]
        public string idDangKyGiaHan { set; get; }
        public string idPhong { set; get; }
        public string idThuePhong { set; get; }
        public string idHocKy { set; get; }
        public DateTime thoiGianDangKy { set; get; }
        public DateTime thoiGianDuyet { set; get; }
        public string idPhongDuocDuyet { set; get; }
        public string idTrangThaiDangKy { set; get; }
        [ForeignKey("idPhong")]
        public virtual Phong Phong { set; get; }
        [ForeignKey("idThuePhong")]
        public virtual ThuePhong ThuePhong { set; get; }
        [ForeignKey("idHocKy")]
        public virtual HocKy HocKy { set; get; }
        [ForeignKey("idTrangThaiDangKy")]
        public virtual TrangThaiDangKyGiaHan TrangThaiDangKyGiaHan { set; get; }
        public DangKyGiaHan() { }
        public DangKyGiaHan(string idDangKyGiaHan, string idPhong, string idThuePhong, string idHocKy,
            DateTime thoiGianDangKy, DateTime thoiGianDuyet, string idPhongDuocDuyet, string idTrangThaiDangKy)
        {
            this.idDangKyGiaHan = idDangKyGiaHan;
            this.idPhong = idPhong;
            this.idThuePhong = idThuePhong;
            this.idHocKy = idHocKy;
            this.thoiGianDangKy = thoiGianDangKy;
            this.thoiGianDuyet = thoiGianDuyet;
            this.idPhongDuocDuyet = idPhongDuocDuyet;
            this.idTrangThaiDangKy = idTrangThaiDangKy;
        }
    }
}