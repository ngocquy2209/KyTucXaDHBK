using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    [Table("tblTINH")]
    public class Tinh
    {
        [Key]
        public string idTinh { set; get; }
        public string idQuocGia { set; get; }
        public string tenTinh { set; get; }
        [ForeignKey("idQuocGia")]
        public virtual QuocGia QuocGia { set; get; }
        public virtual ICollection<SinhVien> CacSinhVien { set; get; }
        public Tinh() { }
        public Tinh(string idTinh, string idQuocGia, string tenTinh)
        {
            this.idTinh = idTinh;
            this.idQuocGia = idQuocGia;
            this.tenTinh = tenTinh;
        }
    }
}