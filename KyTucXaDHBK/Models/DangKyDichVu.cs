using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    [Table("tblDANGKYDICHVU")]
    public class DangKyDichVu
    {
        [Key]
        public string idDangKyDichVu { set; get; }
        public string idThuePhong { set; get; }
        public string idDichVu { set; get; }
        public DateTime thoiGianDangKy { set; get; }
        public DateTime? thoiGianDuyet { set; get; }
        public string idTinhTrangDangKy { set; get; }
        [ForeignKey("idThuePhong")]
        public virtual ThuePhong ThuePhong { set; get; }
        [ForeignKey("idDichVu")]
        public virtual DichVu DichVu { set; get; }
        [ForeignKey("idTinhTrangDangKy")]
        public virtual TinhTrangDangKyDichVu TinhTrangDangKyDichVu { set; get; }
        public DangKyDichVu() { }
        public DangKyDichVu(string idDangKyDichVu, string idThuePhong,string idDichVu, DateTime thoiGianDangKy,
            DateTime thoiGianDuyet, string idTinhTrangDangKy)
        {
            this.idDangKyDichVu = idDangKyDichVu;
            this.idThuePhong = idThuePhong;
            this.idDichVu = idDichVu;
            this.thoiGianDangKy = thoiGianDangKy;
            this.thoiGianDuyet = thoiGianDuyet;
            this.idTinhTrangDangKy = idTinhTrangDangKy;
        }
    }
}