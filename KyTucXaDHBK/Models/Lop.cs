using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    [Table("tblLOP")]
    public class Lop
    {
        [Key]
        public string idLop { set; get; }
        public string idKhoa { set; get; }
        public string idKhoas { set; get; }
        public string tenLop { set; get; }
        [ForeignKey("idKhoa")]
        public virtual Khoa Khoa { set; get; }
        [ForeignKey("idKhoas")]
        public virtual Khoas Khoas { set; get; }
        public virtual ICollection<SinhVien> CacSinhVien { set; get; }
        public Lop() { }
        public Lop(string idLop, string idKhoa, string idKhoas, string tenLop)
        {
            this.idLop = idLop;
            this.idKhoa = idKhoa;
            this.idKhoas = idKhoas;
            this.tenLop = tenLop;
        }
    }
}