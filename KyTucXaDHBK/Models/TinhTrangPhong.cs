using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    [Table("tblTINHTRANGPHONG")]
    public class TinhTrangPhong
    {
        [Key]
        public string idTinhTrangPhong { set; get; }
        public string tinhTrangPhong { set; get; }
        public virtual ICollection<Phong> CacPhong { set; get; }
        public TinhTrangPhong() { }
        public TinhTrangPhong(string idTinhTrangPhong, string tinhTrangPhong)
        {
            this.idTinhTrangPhong = idTinhTrangPhong;
            this.tinhTrangPhong = tinhTrangPhong;
        }
    }
}