using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    [Table("tblTRANGTHAIYEUCAU")]
    public class TrangThaiYeuCau
    {
        [Key]
        public string idTrangThaiYeuCau { set; get; }
        public string trangThaiYeuCau { set; get; }
        public virtual ICollection<YeuCau> CacYeuCau { set; get; }
        public TrangThaiYeuCau() { }
        public TrangThaiYeuCau(string idTrangThaiYeuCau, string trangThaiYeuCau)
        {
            this.idTrangThaiYeuCau = idTrangThaiYeuCau;
            this.trangThaiYeuCau = trangThaiYeuCau;
        }
    }
}