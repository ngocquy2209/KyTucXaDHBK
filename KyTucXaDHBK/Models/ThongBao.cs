using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    [Table("tblTHONGBAO")]
    public class ThongBao
    {
        [Key]
        public int idThongBao { set; get; }
        public string idTaiKhoan { set; get; }
        public string tieuDe { set; get; }
        public string noiDung { set; get; }
        public DateTime thoiGianViet { set; get; }
        public bool daDoc { set; get; }
        [ForeignKey("idTaiKhoan")]
        public virtual TaiKhoanSinhVien TaiKhoan { set; get; }
        public ThongBao() { }
        public ThongBao(string idTaiKhoan, string tieuDe, string noiDung, DateTime thoiGianViet, bool daDoc)
        {
            this.idTaiKhoan = idTaiKhoan;
            this.tieuDe = tieuDe;
            this.noiDung = noiDung;
            this.thoiGianViet = thoiGianViet;
            this.daDoc = daDoc;
        }
    }
}