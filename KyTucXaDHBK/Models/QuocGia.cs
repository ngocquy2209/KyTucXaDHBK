using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    [Table("tblQUOCGIA")]
    public class QuocGia
    {
        [Key]
        public string idQuocGia { set; get; }
        public string tenQuocGia { set; get; }
        public virtual ICollection<Tinh> CacTinh { set; get; }
        public virtual ICollection<DanToc> CacDanToc { set; get; }
        public QuocGia() { }
        public QuocGia(string idQuocGia, string tenQuocGia)
        {
            this.idQuocGia = idQuocGia;
            this.tenQuocGia = tenQuocGia;
        }
    }
}