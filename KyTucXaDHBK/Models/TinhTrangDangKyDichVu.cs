using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    [Table("tblTINHTRANGDANGKYDICHVU")]
    public class TinhTrangDangKyDichVu
    {
        [Key]
        public string idTinhTrangDangKy { set; get; }
        public string tinhTrangDangKy { set; get; }
        public virtual ICollection<DangKyDichVu> CacDangKyDichVu { set; get; }
        public TinhTrangDangKyDichVu() { }
        public TinhTrangDangKyDichVu(string idTinhTrangDangKy, string tinhTrangDangKy)
        {
            this.idTinhTrangDangKy = idTinhTrangDangKy;
            this.tinhTrangDangKy = tinhTrangDangKy;
        }
    }
}