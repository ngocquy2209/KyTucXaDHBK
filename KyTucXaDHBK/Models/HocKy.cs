using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    [Table("tblHOCKY")]
    public class HocKy
    {
        [Key]
        public string idHocKy { set; get; }
        public string idHocKyTrongNam { set; get; }
        public string idNamHoc { set; get; }
        public DateTime thoiGianBatDau { set; get; }
        public DateTime thoiGianKetThuc { set; get; }
        [ForeignKey("idNamHoc")]
        public virtual NamHoc NamHoc { set; get; }
        [ForeignKey("idHocKyTrongNam")]
        public virtual HocKyTrongNam HocKyTrongNam { set; get; }
        public virtual ICollection<ThuePhong> CacThuePhong { set; get; }
        public virtual ICollection<DangKyThuePhong> CacDangKyThuePhong { set; get; }
        public virtual ICollection<DangKyGiaHan> CacDangKyGiaHan { set; get; }
        public virtual ICollection<PhiNoiTru> CacPhiNoiTru { set; get; }
        public HocKy() { }
        public HocKy(string idHocKy, string idHocKyTrongNam, string idNamHoc,
            DateTime thoiGianBatDau, DateTime thoiGianKetThuc)
        {
            this.idHocKy = idHocKy;
            this.idHocKyTrongNam = idHocKyTrongNam;
            this.idNamHoc = idNamHoc;
            this.thoiGianBatDau = thoiGianBatDau;
            this.thoiGianKetThuc = thoiGianKetThuc;
        }
    }
}