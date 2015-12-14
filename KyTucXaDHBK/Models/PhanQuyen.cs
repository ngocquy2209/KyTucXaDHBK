using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    [Table("tblPHANQUYEN")]
    public class PhanQuyen
    {
        [Key]
        public int idPhanQuyen { set; get; }
        public string idNhom { set; get; }
        public string idMenu { set; get; }
        public string idSubMenu { set; get; }
        public bool enable { set; get; }
        [ForeignKey("idNhom")]
        public virtual Nhom Nhom { set; get; }
        [ForeignKey("idMenu")]
        public virtual Menu Menu { set; get; }
        [ForeignKey("idSubMenu")]
        public virtual SubMenu SubMenu { set; get; }
        public PhanQuyen() { }
        public PhanQuyen(string idNhom, string idMenu, string idSubMenu, bool enable)
        {
            this.idNhom = idNhom;
            this.idMenu = idMenu;
            this.idSubMenu = idSubMenu;
            this.enable = enable;
        }
    }
}