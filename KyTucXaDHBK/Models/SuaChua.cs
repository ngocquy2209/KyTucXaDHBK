using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    [Table("tblSUACHUA")]
    public class SuaChua
    {
        [Key]
        public int idSuaChua { set; get; }
        public string idYeuCauSuaChua { set; get; }
        public string hinhThucSuaChua { set; get; }
        public string idTaiKhoan { set; get; }
        public double giaSuaChua { set; get; }
        public DateTime? ngaySuaChua { set; get; }
        public bool daSuaChua { set; get; }
        public string ghiChu { set; get; }
        [ForeignKey("idYeuCauSuaChua")]
        public virtual YeuCauSuaChua YeuCauSuaChua { set; get; }
        [ForeignKey("hinhThucSuaChua")]
        public virtual HinhThucSuaChua HinhThucSuaChua { set; get; }
        [ForeignKey("idTaiKhoan")]
        public virtual TaiKhoanNhanVien TaiKhaon { set; get; }
        public SuaChua() { }
        public SuaChua(string idYeuCauSuaChua, string hinhThucSuaChua, string idTaiKhoan, double giaSuaChua,
            DateTime ngaySuaChua, bool daSuaChua, string ghiChu)
        {
            this.idYeuCauSuaChua = idYeuCauSuaChua;
            this.hinhThucSuaChua = hinhThucSuaChua;
            this.idTaiKhoan = idTaiKhoan;
            this.giaSuaChua = giaSuaChua;
            this.ngaySuaChua = ngaySuaChua;
            this.daSuaChua = daSuaChua;
            this.ghiChu = ghiChu;
        }
    }
}