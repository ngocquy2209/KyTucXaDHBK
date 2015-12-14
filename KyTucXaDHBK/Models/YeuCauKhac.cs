using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    [Table("tblYEUCAUKHAC")]
    public class YeuCauKhac
    {
        [Key]
        public string idYeuCauKhac { set; get; }
        public string idYeuCau { set; get; }
        public string noiDung { set; get; }
        [ForeignKey("idYeuCau")]
        public virtual YeuCau YeuCau { set; get; }
        public YeuCauKhac() { }
        public YeuCauKhac(string idYeuCauKhac, string idYeuCau, string noiDung)
        {
            this.idYeuCauKhac = idYeuCauKhac;
            this.idYeuCau = idYeuCau;
            this.noiDung = noiDung;
        }
    }
}