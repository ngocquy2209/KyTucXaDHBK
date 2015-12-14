using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    [Table("tblTONGIAO")]
    public class TonGiao
    {
        [Key]
        public string idTonGiao { set; get; }
        public string tenTonGiao { set; get; }
        public virtual ICollection<SinhVien> CacSinhVien { set; get; }
        public TonGiao() { }
        public TonGiao(string idTonGia, string tenTonGiao)
        {
            this.idTonGiao = idTonGia;
            this.tenTonGiao = tenTonGiao;
        }
    }
}