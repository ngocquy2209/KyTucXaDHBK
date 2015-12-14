using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    [Table("tblKHOAS")]
    public class Khoas
    {
        [Key]
        public string idKhoas { set; get; }
        public string tenKhoas { set; get; }
        public virtual ICollection<Lop> CacLop { set; get; }
        public Khoas() { }
        public Khoas(string idKhoas, string tenKhoas)
        {
            this.idKhoas = idKhoas;
            this.tenKhoas = tenKhoas;
        }
    }
}