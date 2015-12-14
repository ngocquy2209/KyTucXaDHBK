using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    [Table("tblNHOM")]
    public class Nhom
    {
        [Key]
        public string idNhom { set; get; }
        public string tenNhom { set; get; }
        public string moTa { set; get; }
        public virtual ICollection<TaiKhoanNhanVien> CacTaiKhoan { set; get; }
        public virtual ICollection<PhanQuyen> CacPhanQuyen { set; get; }
        public Nhom() { }
        public Nhom(string idNhom, string tenNhom, string moTa)
        {
            this.idNhom = idNhom;
            this.tenNhom = tenNhom;
            this.moTa = moTa;
        }
    }
}