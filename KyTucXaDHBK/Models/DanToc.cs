using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    [Table("tblDANTOC")]
    public class DanToc
    {
        [Key]
        public string idDanToc { set; get; }
        public string idQuocGia { set; get; }
        public string tenDanDoc { set; get; }
        [ForeignKey("idQuocGia")]
        public virtual QuocGia QuocGia { set; get; }
        public virtual ICollection<SinhVien> CacSinhVien { set; get; }
        public DanToc() { }
        public DanToc(string idDanToc, string idQuocGia, string tenDanToc)
        {
            this.idDanToc = idDanToc;
            this.idQuocGia = idQuocGia;
            this.tenDanDoc = tenDanToc;
        }
    }
}