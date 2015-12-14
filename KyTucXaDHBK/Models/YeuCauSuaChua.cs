using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    [Table("tblYEUCAUSUACHUA")]
    public class YeuCauSuaChua
    {
        [Key]
        public string idYeuCauSuaChua { set; get; }
        public string idYeuCau { set; get; }
        public string idTaiSanPhong { set; get; }
        public int soLuong { set; get; }
        public string ghiChu { set; get; }
        [ForeignKey("idYeuCau")]
        public virtual YeuCau YeuCau { set; get; }
        [ForeignKey("idTaiSanPhong")]
        public virtual TaiSanPhong TaiSanPhong { set; get; }
        public virtual ICollection<SuaChua> CacSuaChua { set; get; }
        public YeuCauSuaChua() { }
        public YeuCauSuaChua(string idYeuCauSuaChua, string idYeuCau, string idTaiSanPhong, int soLuong, string ghiChu)
        {
            this.idYeuCauSuaChua = idYeuCauSuaChua;
            this.idYeuCau = idYeuCau;
            this.idTaiSanPhong = idTaiSanPhong;
            this.soLuong = soLuong;
            this.ghiChu = ghiChu;
        }

    }
}