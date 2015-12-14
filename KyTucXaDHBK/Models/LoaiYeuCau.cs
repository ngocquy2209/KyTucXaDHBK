using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    [Table("tblLOAIYEUCAU")]
    public class LoaiYeuCau
    {
        [Key]
        public string idLoaiYeuCau { set; get; }
        public string loaiYeuCau { set; get; }
        public virtual ICollection<YeuCau> CacYeuCau { set; get; }
        public LoaiYeuCau() { }
        public LoaiYeuCau(string idLoaiYeuCau, string loaiYeuCau)
        {
            this.idLoaiYeuCau = idLoaiYeuCau;
            this.loaiYeuCau = loaiYeuCau;
        }
    }
}