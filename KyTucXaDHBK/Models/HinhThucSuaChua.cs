using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    [Table("tblHINHTHUCSUACHUA")]
    public class HinhThucSuaChua
    {
        [Key]
        public string idHinhThucSuaChua { set; get; }
        public string hinhThucSuaChua { set; get; }
        public virtual ICollection<SuaChua> SuaChua { set; get; }
        public HinhThucSuaChua() { }
        public HinhThucSuaChua(string idHinhThucSuaChua, string hinhThucSuaChua)
        {
            this.idHinhThucSuaChua = idHinhThucSuaChua;
            this.hinhThucSuaChua = hinhThucSuaChua;
        }
    }
}