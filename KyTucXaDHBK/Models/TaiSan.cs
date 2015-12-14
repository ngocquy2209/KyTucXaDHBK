using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    [Table("tblTAISAN")]
    public class TaiSan
    {
        [Key]
        public string idTaiSan { set; get; }
        public string tenTaiSan { set; get; }
        public string donViTinh { set; get; }
        public string donGia { set; get; }
        public int soLuong { set; get; }
        public virtual ICollection<TaiSanPhong> CacTaiSanPhong { set; get; }
        public TaiSan() { }
        public TaiSan(string idTaiSan, string tenTaiSan, string donViTinh, string donGia, int soLuong)
        {
            this.idTaiSan = idTaiSan;
            this.tenTaiSan = tenTaiSan;
            this.donViTinh = donViTinh;
            this.donGia = donGia;
            this.soLuong = soLuong;
        }
    }
}