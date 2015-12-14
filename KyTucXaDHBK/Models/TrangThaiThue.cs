using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    [Table("tblTRANGTHAITHUE")]
    public class TrangThaiThue
    {
        [Key]
        public string idTrangThaiThue { set; get; }
        public string trangThaiThue { set; get; }
        public virtual ICollection<ThuePhong> CacThuePhong { set; get; }
        public TrangThaiThue() { }
        public TrangThaiThue(string idTrangThaiThue, string trangThaiThue)
        {
            this.idTrangThaiThue = idTrangThaiThue;
            this.trangThaiThue = trangThaiThue;
        }
    }
}