using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    [Table("tblNAMHOC")]
    public class NamHoc
    {
        [Key]
        public string idNamHoc { set; get; }
        public string namHoc { set; get; }
        public virtual ICollection<HocKy> CacHocKy { set; get; }
        public NamHoc() { }
        public NamHoc(string idNamHoc, string namHoc)
        {
            this.idNamHoc = idNamHoc;
            this.namHoc = namHoc;
        }
    }
}