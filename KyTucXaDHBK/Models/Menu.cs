using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    [Table("tblMENU")]
    public class Menu
    {
        [Key]
        public string idMenu { set; get; }
        public string menu { set; get; }
        public string link { set; get; }
        public virtual ICollection<SubMenu> CacSubMenu { set; get; }
        public virtual ICollection<PhanQuyen> CacPhanQuyen { set; get; }
        public Menu() { }
        public Menu(string idMenu, string menu, string link)
        {
            this.idMenu = idMenu;
            this.menu = menu;
            this.link = link;
        }
    }
}