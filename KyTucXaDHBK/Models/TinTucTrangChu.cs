using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    [Table("tblTINTUCTRANGCHU")]
    public class TinTucTrangChu
    {
        [Key]
        public int tinTucTrangChu { set; get; }
        public string tieuDe { set; get; }
        public string noiDung { set; get; }
        public string idTaiKhoan { set; get; }
        public DateTime thoiGianViet { set; get; }
        public int theLoai { set; get; }
        [ForeignKey("idTaiKhoan")]
        public virtual TaiKhoanNhanVien TaiKhoan { set; get; }
        public TinTucTrangChu() { }
        public TinTucTrangChu(string tieuDe, string noiDung, string idTaiKhoan, DateTime thoiGianViet, int theLoai)
        {
            this.tieuDe = tieuDe;
            this.noiDung = noiDung;
            this.idTaiKhoan = idTaiKhoan;
            this.thoiGianViet = thoiGianViet;
            this.theLoai = theLoai;
        }
    }
}