using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    [Table("tblYEUCAUTRAPHONG")]
    public class YeuCauTraPhong
    {
        [Key]
        public string idYeuCauTraPhong { set; get; }
        public string idYeuCau { set; get; }
        public DateTime thoiGianTra { set; get; }
        [ForeignKey("idYeuCau")]
        public virtual YeuCau YeuCau { set; get; }
        public YeuCauTraPhong() { }
        public YeuCauTraPhong(string idYeuCauTraPhong, string idYeuCau, DateTime thoiGianTra)
        {
            this.idYeuCauTraPhong = idYeuCauTraPhong;
            this.idYeuCau = idYeuCau;
            this.thoiGianTra = thoiGianTra;
        }
    }
}