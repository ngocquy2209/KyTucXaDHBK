using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    [Table("tblYEUCAUCHUYENPHONG")]
    public class YeuCauChuyenPhong
    {
        [Key]
        public string idYeuCauChuyenPhong { set; get; }
        public string idYeuCau { set; get; }
        public string idPhong { set; get; }
        public DateTime thoiGianChuyen { set; get; }
        [ForeignKey("idYeuCau")]
        public virtual YeuCau YeuCau { set; get; }
        [ForeignKey("idPhong")]
        public virtual Phong Phong { set; get; }
        public YeuCauChuyenPhong() { }
        public YeuCauChuyenPhong(string idYeuCauChuyenPhong, string idYeuCau, string idPhong, DateTime thoiGianChuyen)
        {
            this.idYeuCauChuyenPhong = idYeuCauChuyenPhong;
            this.idYeuCau = idYeuCau;
            this.idPhong = idPhong;
            this.thoiGianChuyen = thoiGianChuyen;
        }
    }
}