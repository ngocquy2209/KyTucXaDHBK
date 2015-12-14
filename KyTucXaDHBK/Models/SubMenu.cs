using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    [Table("tblSUBMENU")]
    public class SubMenu
    {
        [Key]
        public string idSubMenu { set; get; }
        public string idMenu { set; get; }
        public string subMenu { set; get; }
        public string link { set; get; }
        [ForeignKey("idMenu")]
        public virtual Menu Menu { set; get; }
        public virtual ICollection<PhanQuyen> CacPhanQuyen { set; get; }
        public SubMenu() { }
        public SubMenu(string idSubMenu, string idMenu, string subMenu, string link)
        {
            this.idSubMenu = idSubMenu;
            this.idMenu = idMenu;
            this.subMenu = subMenu;
            this.link = link;
        }
    }
}