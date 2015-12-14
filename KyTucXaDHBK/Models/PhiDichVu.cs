using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    [Table("tblPHIDICHVU")]
    public class PhiDichVu
    {
        [Key]
        public string idPhiDichVu { set; get; }
        public string soBienLai { set; get; }
        public string idPhong { set; get; }
        public string idTaiKhoan { set; get; }
        public double soTien { set; get; }
        public DateTime thoiGianNop { set; get; }
        public string ghiChu { set; get; }
        [ForeignKey("idPhong")]
        public virtual Phong Phong { set; get; }
        [ForeignKey("idTaiKhoan")]
        public virtual TaiKhoanSinhVien TaiKhoan { set; get; }
        public PhiDichVu() { }
        public PhiDichVu(string idPhiDichVu, string soBienLai, string idPhong, string idTaiKhoan, double soTien,
            DateTime thoiGianNop, string ghiChu)
        {
            this.idPhiDichVu = idPhiDichVu;
            this.soBienLai = soBienLai;
            this.idPhong = idPhong;
            this.idTaiKhoan = idTaiKhoan;
            this.soTien = soTien;
            this.thoiGianNop = thoiGianNop;
            this.ghiChu = ghiChu;
        }
    }
}