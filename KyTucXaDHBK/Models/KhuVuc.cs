using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    [Table("tblKHUVUC")]
    public class KhuVuc
    {
        [Key]
        public string idKhuVuc { set; get; }
        public string tenKhuVuc { set; get; }
        public virtual ICollection<SinhVien> CacSinhVien { set; get; }
        public KhuVuc() { }
        public KhuVuc(string idKhuVuc, string tenKhuVuc)
        {
            this.idKhuVuc = idKhuVuc;
            this.tenKhuVuc = tenKhuVuc;
        }
    }
}