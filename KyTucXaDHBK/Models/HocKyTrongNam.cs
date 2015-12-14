using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    [Table("tblHOCKYTRONGNAM")]
    public class HocKyTrongNam
    {
        [Key]
        public string idHocKyTrongNam { set; get; }
        public string hocKy { set; get; }
        public virtual ICollection<HocKy> CacHocKy { set; get; }
        public HocKyTrongNam() { }
        public HocKyTrongNam(string idHocKyTrongNam, string hocky)
        {
            this.idHocKyTrongNam = idHocKyTrongNam;
            this.hocKy = hocky;
        }
    }
}