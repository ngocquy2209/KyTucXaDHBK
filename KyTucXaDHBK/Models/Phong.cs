using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    [Table("tblPHONG")]
    public class Phong
    {
        [Key]
        public string idPhong { set; get; }
        public string idNha { set; get; }
        public int tang { set; get; }
        public string tenPhong { set; get; }
        public int soGiuong { set; get; }
        public int soLuongSV { set; get; }
        public double giaPhong { set; get; }
        public String gioiTinh { set; get; }
        public int soLuongDangKy { set; get; }
        public int soLuongGiaHan { set; get; }
        public int soLuongYeuCau { set; get; }
        public string idTinhTrangPhong { set; get; }
        [ForeignKey("idNha")]
        public virtual Nha Nha { set; get; }
        [ForeignKey("idTinhTrangPhong")]
        public virtual TinhTrangPhong TinhTrangPhong { set; get; }
        public virtual ICollection<ThuePhong> CacThuePhong { set; get; }
        public virtual ICollection<DangKyThuePhong> CacDangKyThuePhong { set; get; }
        public virtual ICollection<DangKyGiaHan> CacDangKyGiaHan { set; get; }
        public virtual ICollection<PhiDienNuoc> CacPhiDienNuoc { set; get; }
        public virtual ICollection<YeuCauChuyenPhong> CacYeuCauChuyenPhong { set; get; }
        public virtual ICollection<TaiSanPhong> CacTaiSanPhong { set; get; }
        public virtual ICollection<ThueDichVu> CacThueDichVu { set; get; }
        public virtual ICollection<PhiDichVu> CacPhiDichVu { set; get; }
        public Phong() { }
        public Phong(string idPhong, string idNha, int tang, string tenPhong, int soGiuong, int soLuongSV,
            double giaPhong,String gioiTinh, int soLuongDangKy, int soLuongGiaHan, int soLuongYeuCau, string idTinhTrangPhong)
        {
            this.idPhong = idPhong;
            this.idNha = idNha;
            this.tang = tang;
            this.tenPhong = tenPhong;
            this.soGiuong = soGiuong;
            this.soLuongSV = soLuongSV;
            this.giaPhong = giaPhong;
            this.gioiTinh = gioiTinh;
            this.soLuongDangKy = soLuongDangKy;
            this.soLuongGiaHan = soLuongGiaHan;
            this.soLuongYeuCau = soLuongYeuCau;
            this.idTinhTrangPhong = idTinhTrangPhong;
        }
    }
}