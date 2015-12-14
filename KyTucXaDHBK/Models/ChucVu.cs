using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    [Table("tblCHUCVU")]
    public class ChucVu
    {
        [Key]
        public string idChucVu { set; get; }
        public string tenChucVu { set; get; }
        public string moTaCongViec { set; get; }
        public virtual ICollection<NhanVien> CacNhanVien { set; get; }
        public ChucVu() { }
        public ChucVu(string idChucVu, string tenChucVu, string moTaCongViec)
        {
            this.idChucVu = idChucVu;
            this.tenChucVu = tenChucVu;
            this.moTaCongViec = moTaCongViec;
        }
    }
}