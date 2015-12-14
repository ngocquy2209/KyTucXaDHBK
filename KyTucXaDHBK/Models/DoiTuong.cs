using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    [Table("tblDOITUONG")]
    public class DoiTuong
    {
        [Key]
        public string idDoiTuong { set; get; }
        public string tenDoiTuong { set; get; }
        public int doUuTien { set; get; }
        public virtual ICollection<SinhVien> CacSinhVien { set; get; }
        public DoiTuong() { }
        public DoiTuong(string idDoiTuong, string tenDoiTuong, int doUuTien)
        {
            this.idDoiTuong = idDoiTuong;
            this.tenDoiTuong = tenDoiTuong;
            this.doUuTien = doUuTien;
        }
    }
}