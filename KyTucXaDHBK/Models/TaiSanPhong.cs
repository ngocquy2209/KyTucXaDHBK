using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    [Table("tblTAISANPHONG")]
    public class TaiSanPhong
    {
        [Key]
        public string idTaiSanPhong { set; get; }
        public string idPhong { set; get; }
        public string idTaiSan { set; get; }
        public int soLuong { set; get; }
        public int soLuongHong { set; get; }
        [ForeignKey("idPhong")]
        public virtual Phong Phong { set; get; }
        [ForeignKey("idTaiSan")]
        public virtual TaiSan TaiSan { set; get; }
        public virtual ICollection<YeuCauSuaChua> CacYeuCauSuaChua { set; get; }
        public TaiSanPhong() { }
        public TaiSanPhong(string idTaiSanPhong, string idPhong, string idTaiSan, int soLuong, int soLuongHong)
        {
            this.idTaiSanPhong = idTaiSanPhong;
            this.idPhong = idPhong;
            this.idTaiSan = idTaiSan;
            this.soLuong = soLuong;
            this.soLuongHong = soLuongHong;
        }
    }
}