using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    [Table("tblTRANGTHAIDANGKYTHUEPHONG")]
    public class TrangThaiDangKyThuePhong
    {
        [Key]
        public string idTrangThaiDangKy { set; get; }
        public string trangThaiDangKy { set; get; }
        public virtual ICollection<DangKyThuePhong> CacDangKyThuePhong { set; get; }
        public TrangThaiDangKyThuePhong() { }
        public TrangThaiDangKyThuePhong(string idTrangThaiDangKy, string trangThaiDangKy)
        {
            this.idTrangThaiDangKy = idTrangThaiDangKy;
            this.trangThaiDangKy = trangThaiDangKy;
        }
    }
}