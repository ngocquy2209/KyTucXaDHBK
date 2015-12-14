using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    [Table("tblNHA")]
    public class Nha
    {
        [Key]
        public string idNha { set; get; }
        public string tenNha { set; get; }
        public int soTang { set; get; }
        public double giaPhong { set; get; }
        public virtual ICollection<Phong> CacPhong { set; get; }
        public Nha() { }
        public Nha(string idNha, string tenNha, int soTang, double giaPhong)
        {
            this.idNha = idNha;
            this.tenNha = tenNha;
            this.soTang = soTang;
            this.giaPhong = giaPhong;
        }
    }
}