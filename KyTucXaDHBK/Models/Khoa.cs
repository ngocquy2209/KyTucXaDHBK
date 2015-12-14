using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    [Table("tblKHOA")]
    public class Khoa
    {
        [Key]
        public string idKhoa { set; get; }
        public string tenKhoa { set; get; }
        public virtual ICollection<Lop> CacLop { set; get; }
        public Khoa() { }
        public Khoa(string idKhoa, string tenKhoa)
        {
            this.idKhoa = idKhoa;
            this.tenKhoa = tenKhoa;
        }
    }
}