using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    [Table("tblDONGIATIENDIEN")]
    public class DonGiaTienDien
    {
        [Key]
        public int idDonGia { set; get; }
        public int tuSo { set; get; }
        public int denSo { set; get; }
        public int soHo { set; get; }
        public double donGia { set; get; }
        public DonGiaTienDien() { }
        public DonGiaTienDien(int tuSo, int denSo, int soHo, double donGia)
        {
            this.tuSo = tuSo;
            this.denSo = denSo;
            this.soHo = soHo;
            this.donGia = donGia;
        }
    }
}