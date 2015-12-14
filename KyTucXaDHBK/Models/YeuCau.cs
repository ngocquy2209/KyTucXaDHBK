using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    [Table("tblYEUCAU")]
    public class YeuCau
    {
        [Key]
        public string idYeuCau { set; get; }
        public string idThuePhong { set; get; }
        public string idLoaiYeuCau { set; get; }
        public DateTime thoiGianGui { set; get; }
        public string idTrangThaiYeuCau { set; get; }
        [ForeignKey("idThuePhong")]
        public virtual ThuePhong ThuePhong { set; get; }
        [ForeignKey ("idTrangThaiYeuCau")]
        public virtual TrangThaiYeuCau TrangThaiYeuCau { set; get; }
        [ForeignKey("idLoaiYeuCau")]
        public virtual LoaiYeuCau LoaiYeuCau { set; get; }
        public virtual ICollection<YeuCauChuyenPhong> CacYeuCauChuyenPhong { set; get; }
        public virtual ICollection<YeuCauTraPhong> CacYeuCauTraPhong { set; get; }
        public virtual ICollection<YeuCauSuaChua> CacYeuCauSuaChua { set; get; }
        public virtual ICollection<YeuCauKhac> CacYeuCauKhac { set; get; }
        public YeuCau() { }
        public YeuCau(string idYeuCau, string idThuePhong, string idLoaiYeuCau,
            DateTime thoiGianGui, string idTrangThaiYeuCau)
        {
            this.idYeuCau = idYeuCau;
            this.idThuePhong = idThuePhong;
            this.idLoaiYeuCau = idLoaiYeuCau;
            this.thoiGianGui = thoiGianGui;
            this.idTrangThaiYeuCau = idTrangThaiYeuCau;
        }

    }
}