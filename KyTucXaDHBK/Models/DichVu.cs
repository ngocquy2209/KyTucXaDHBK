using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    [Table("tblDICHVU")]
    public class DichVu
    {
        [Key]
        public string idDichVu { set; get; }
        public string tenDichVu { set; get; }
        public float soThangPhaiTra { set; get; }
        public double donGia { set; get; }
        public virtual ICollection<ThueDichVu> CacThueDichVu { set; get; }
        public virtual ICollection<DangKyDichVu> CacDangKyDichVu { set; get; }
        public DichVu() { }
        public DichVu(string idDichVu, string tenDichVu, float soThangPhaiTra, double donGia)
        {
            this.idDichVu = idDichVu;
            this.tenDichVu = tenDichVu;
            this.soThangPhaiTra = soThangPhaiTra;
            this.donGia = donGia;
        }
    }
}