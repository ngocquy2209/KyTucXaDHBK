using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    [Table("tblPHIDIENNUOC")]
    public class PhiDienNuoc
    {
        [Key]
        public int idPhiDienNuoc { set; get; }
        public string soBienLai { set; get; }
        public string idPhong { set; get; }
        public string idTaiKhoan { set; get; }
        public DateTime phiCuaThang { set; get; }
        public double soDienDau { set; get; }
        public double soDienCuoi { set; get; }
        public double tienDien { set; get; }
        public double soNuocDau { set; get; }
        public double soNuocCuoi { set; get; }
        public double tienNuoc { set; get; }
        public double tongPhi { set; get; }
        public DateTime? thoiGianNop { set; get; }
        [ForeignKey("idPhong")]
        public virtual Phong Phong { set; get; }
        [ForeignKey("idTaiKhoan")]
        public virtual TaiKhoanSinhVien TaiKhoan { set; get; }
        public bool daNop { set; get; }
        public PhiDienNuoc() { }
        public PhiDienNuoc(string soBienLai, string idPhong, string idTaiKhoan, DateTime phiCuaThang, double soDienDau, double soDienCuoi,
            double tienDien, double soNuocDau, double soNuocCuoi, double tienNuoc, double tongPhi, bool daNop)
        {
            this.soBienLai = soBienLai;
            this.idPhong = idPhong;
            this.idTaiKhoan = idTaiKhoan;
            this.phiCuaThang = phiCuaThang;
            this.soDienDau = soDienDau;
            this.soDienCuoi = soDienCuoi;
            this.tienDien = tienDien;
            this.soNuocDau = soNuocDau;
            this.soNuocCuoi = soNuocCuoi;
            this.tienNuoc = tienNuoc;
            this.tongPhi = tongPhi;
            this.daNop = daNop;
        }
    }
}