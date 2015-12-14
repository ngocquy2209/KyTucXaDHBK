using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    [Table("tblLICHSUQUANLY")]
    public class LichSuQuanLy
    {
        [Key]
        public int idLichSuQuanLy { set; get; }
        public string idTaiKhoan { set; get; }
        public string hanhDong { set; get; }
        public DateTime thoiGian { set; get; }
        [ForeignKey("idTaiKhoan")]
        public virtual TaiKhoanNhanVien TaiKhoan { set; get; }
        public LichSuQuanLy() { }
        public LichSuQuanLy(string idTaiKhoan, string hanhDong, DateTime thoiGian)
        {
            this.idTaiKhoan = idTaiKhoan;
            this.hanhDong = hanhDong;
            this.thoiGian = thoiGian;
        }
    }
}