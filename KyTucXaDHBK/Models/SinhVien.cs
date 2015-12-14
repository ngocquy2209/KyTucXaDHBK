using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    [Table("tblSINHVIEN")]
    public class SinhVien
    {
        [Key]
        public string idSinhVien { set; get; }
        public string MSSV { set; get; }
        public string ho { set; get; }
        public string ten { set; get; }
        public string idLop { set; get; }
        public string gioiTinh { set; get; }
        public DateTime ngaySinh { set; get; }
        [StringLength(12)]
        public string SDT { set; get; }
        [StringLength(12)]
        public string CMND { set; get; }
        public string hoKhauThuongTru { set; get; }
        public string xa { set; get; }
        public string huyen { set; get; }
        public string idTinh { set; get; }
        public string noiOHienTai { set; get; }
        public string idDanToc { set; get; }
        public string idTonGiao { set; get; }
        public string idKhuVuc { set; get; }
        public string idDoiTuong { set; get; }
        public string hoTenChaMe { set; get; }
        public string sdtChaMe { set; get; }
        public string noiTru { set; get; }
        public string ngoaiTru { set; get; }
        public string sdtNgoaiTru { set; get; }
        [ForeignKey("idLop")]
        public virtual Lop Lop { set; get; }
        [ForeignKey("idTinh")]
        public virtual Tinh Tinh { set; get; }
        [ForeignKey("idDanToc")]
        public virtual DanToc DanToc { set; get; }
        [ForeignKey("idTonGiao")]
        public virtual TonGiao TonGiao { set; get; }
        [ForeignKey("idKhuVuc")]
        public virtual KhuVuc KhuVuc { set; get; }
        [ForeignKey("idDoiTuong")]
        public virtual DoiTuong DoiTuong { set; get; }
        public virtual ICollection<TaiKhoanSinhVien> TaiKhoan { set; get; }
        public SinhVien(){}
        public SinhVien(string idSinhVien, string MSSV, string ho, string ten, string idLop, string gioiTinh,
            DateTime ngaySinh, string SDT, string CMND, string hoKhauThuongTru, string xa, string huyen,
            string idTinh, string noiOHienTai, string idDanToc, string idTonGiao, string idKhuVuc, string idDoiTuong,
            string hoTenChaMe, string sdtChaMe, string noiTru, string ngoaiTru, string sdtNgoaiTru)
        { 
            this.idSinhVien = idSinhVien;
            this.MSSV = MSSV;
            this.ho = ho;
            this.ten = ten;
            this.idLop = idLop;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.SDT = SDT;
            this.CMND = CMND;
            this.hoKhauThuongTru = hoKhauThuongTru;
            this.xa = xa;
            this.huyen = huyen;
            this.idTinh = idTinh;
            this.noiOHienTai = noiOHienTai;
            this.idDanToc = idDanToc;
            this.idTonGiao = idTonGiao;
            this.idKhuVuc = idKhuVuc;
            this.idDoiTuong = idDoiTuong;
            this.hoTenChaMe = hoTenChaMe;
            this.sdtChaMe = sdtChaMe;
            this.noiTru = noiTru;
            this.ngoaiTru = ngoaiTru;
            this.sdtNgoaiTru = sdtNgoaiTru;
        }
    }
}