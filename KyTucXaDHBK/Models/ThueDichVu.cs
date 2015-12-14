using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    [Table("tblTHUEDICHVU")]
    public class ThueDichVu
    {
        [Key]
        public string idThueDichVu { set; get; }
        public string idPhong { set; get; }
        public string idDichVu { set; get; }
        public string idHocKy { set; get; }
        public DateTime thoiGianHetHan { set; get; }
        [ForeignKey("idPhong")]
        public virtual Phong Phong { set; get; }
        [ForeignKey("idDichVu")]
        public virtual DichVu DichVu { set; get; }
        public ThueDichVu() { }
        public ThueDichVu(string idThueDichVu, string idPhong, string idDichVu, string idHocKy, DateTime thoiGianHetHan)
        {
            this.idDichVu = idDichVu;
            this.idPhong = idPhong;
            this.idDichVu = idDichVu;
            this.idHocKy = idHocKy;
            this.thoiGianHetHan = thoiGianHetHan;
        }
    }
}