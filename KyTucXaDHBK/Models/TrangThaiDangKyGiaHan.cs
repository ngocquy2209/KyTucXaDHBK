using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    [Table("tblTRANGTHAIDANGKYGIAHAN")]
    public class TrangThaiDangKyGiaHan
    {
        [Key]
        public string idTrangThaiDangKy { set; get; }
        public string trangThaiDangKy { set; get; }
        public virtual ICollection<DangKyGiaHan> CacDangKyGiaHan { set; get; }
        public TrangThaiDangKyGiaHan() { }
        public TrangThaiDangKyGiaHan(string idTrangThaiDangKy, string trangThaiDangKy)
        {
            this.idTrangThaiDangKy = idTrangThaiDangKy;
            this.trangThaiDangKy = trangThaiDangKy;
        }
    }
}