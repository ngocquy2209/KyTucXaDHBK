using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    [Table("tblBAOVANG")]
    public class BaoVang
    {
        [Key]
        public int idBaoVang { set; get; }
        public string idTaiKhoan { set; get; }
        public DateTime thoiGianBatDau { set; get; }
        public DateTime thoiGianKetThuc { set; get; }
        [ForeignKey("idTaiKhoan")]
        public virtual TaiKhoanSinhVien TaiKhoan { set; get; }
        public string lyDo { set; get; }
        public BaoVang() { }
        public BaoVang(string idTaiKhoan, DateTime thoiGianBatDau, DateTime thoiGianKetThuc, string lyDo)
        {
            this.idTaiKhoan = idTaiKhoan;
            this.thoiGianBatDau = thoiGianBatDau;
            this.thoiGianKetThuc = thoiGianKetThuc;
            this.lyDo = lyDo;
        }
    }
}