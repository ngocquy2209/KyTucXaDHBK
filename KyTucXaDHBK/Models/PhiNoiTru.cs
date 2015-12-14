using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    [Table("tblPHINOITRU")]
    public class PhiNoiTru
    {
        [Key]
        public string idPhiNoiTru { set; get; }
        public string soBienLai { set; get; }
        public string idTaiKhoan { set; get; }
        public string idHocKy { set; get; }
        public double soTien { set; get; }
        public DateTime? thoiGianNop { set; get; }
        public string ghiChu { set; get; }
        [ForeignKey("idTaiKhoan")]
        public virtual TaiKhoanSinhVien TaiKhoan { set; get; }
        [ForeignKey("idHocKy")]
        public virtual HocKy HocKy { set; get; }
        public PhiNoiTru() { }
        public PhiNoiTru(string idPhiNoiTru, string soBienLai, string idTaiKhoan, string idHocKy,
            double soTien, DateTime thoiGianNop, string ghiChu)
        {
            this.idPhiNoiTru = idPhiNoiTru;
            this.soBienLai = soBienLai;
            this.idTaiKhoan = idTaiKhoan;
            this.idHocKy = idHocKy;
            this.soTien = soTien;
            this.thoiGianNop = thoiGianNop;
            this.ghiChu = ghiChu;
        }
    }
}