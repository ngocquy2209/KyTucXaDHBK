using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    [Table("tblVIPHAM")]
    public class ViPham
    {
        [Key]
        public int idViPham { set; get; }
        public string idTaiKhoan { set; get; }
        public string noiDungViPham { set; get; }
        public string hinhThucXuLy { set; get; }
        public DateTime thoiGianViPham { set; get; }
        public string ghiChu { set; get; }
        [ForeignKey("idTaiKhoan")]
        public virtual TaiKhoanSinhVien TaiKhoan { set; get; }
        public ViPham() { }
        public ViPham(string idTaiKhoan, string noiDungViPham, string hinhThucXuLy,
            DateTime thoiGianViPham, string ghiChu)
        {
            this.idTaiKhoan = idTaiKhoan;
            this.noiDungViPham = noiDungViPham;
            this.hinhThucXuLy = hinhThucXuLy;
            this.thoiGianViPham = thoiGianViPham;
            this.ghiChu = ghiChu;
        }
    }
}