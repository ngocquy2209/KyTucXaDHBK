using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    public class DataContext:DbContext
    {
        public DbSet<BaoVang> BaoVangs { set; get; }
        public DbSet<ChucVu> ChucVus { set; get; }
        public DbSet<DanToc> DanTocs { set; get; }
        public DbSet<DangKyDichVu> DangKyDichVus { set; get; }
        public DbSet<DangKyGiaHan> DangKyGiaHans { set; get; }
        public DbSet<DangKyThuePhong> DangKyThuePhongs { set; get; }
        public DbSet<DichVu> DichVus { set; get; }
        public DbSet<DoiTuong> DoiTuongs { set; get; }
        public DbSet<DonGiaTienDien> DonGiaTienDiens { set; get; }
        public DbSet<DonGiaTienNuoc> DonGiaTienNuocs { set; get; }
        public DbSet<FileTaiLen> FileTaiLens { set; get; }
        public DbSet<GopY> GopYs { set; get; }
        public DbSet<HinhThucSuaChua> HinhThucSuaChuas { set; get; }
        public DbSet<HocKy> HocKys { set; get; }
        public DbSet<HocKyTrongNam> HocKyTrongNams { set; get; }
        public DbSet<Khoa> Khoas { set; get; }
        public DbSet<Khoas> Khoass { set; get; }
        public DbSet<KhuVuc> KhuVucs { set; get; }
        public DbSet<LichSuQuanLy> LichSuQuanLys { set; get; }
        public DbSet<LoaiYeuCau> LoaiYeuCaus { set; get; }
        public DbSet<Lop> Lops { set; get; }
        public DbSet<Menu> Menus { set; get; }
        public DbSet<NamHoc> NamHocs { set; get; }
        public DbSet<Nha> Nhas { set; get; }
        public DbSet<NhanVien> NhanViens { set; get; }
        public DbSet<Nhom> Nhoms { set; get; }
        public DbSet<PhanQuyen> PhanQuyens { set; get; }
        public DbSet<PhiDichVu> PhiDichVus { set; get; }
        public DbSet<PhiDienNuoc> PhiDienNuocs { set; get; }
        public DbSet<PhiNoiTru> PhiNoiTrus { set; get; }
        public DbSet<Phong> Phongs { set; get; }
        public DbSet<QuocGia> QuocGias { set; get; }
        public DbSet<SinhVien> SinhViens { set; get; }
        public DbSet<SuaChua> SuaChuas { set; get; }
        public DbSet<SubMenu> SubMenus { set; get; }
        public DbSet<TaiKhoanNhanVien> TaiKhoanNhanViens { set; get; }
        public DbSet<TaiKhoanSinhVien> TaiKhoanSinhViens { set; get; }
        public DbSet<TaiSan> TaiSans { set; get; }
        public DbSet<TaiSanPhong> TaiSanPhongs { set; get; }
        public DbSet<TinTucTrangChu> TinTucTrangChus { set; get; }
        public DbSet<Tinh> Tinhs { set; get; }
        public DbSet<TinhTrangDangKyDichVu> TinhTrangDangKyDichVus { set; get; }
        public DbSet<TinhTrangPhong> TinhTrangPhongs { set; get; }
        public DbSet<TonGiao> TonGiaos { set; get; }
        public DbSet<ThongBao> ThongBaos { set; get; }
        public DbSet<ThueDichVu> ThueDichVus { set; get; }
        public DbSet<ThuePhong> ThuePhongs { set; get; }
        public DbSet<TrangThaiDangKyGiaHan> TrangThaiDangKyGiaHans { set; get; }
        public DbSet<TrangThaiDangKyThuePhong> TrangThaiDangKyThuePhongs { set; get; }
        public DbSet<TrangThaiThue> TrangThaiThues { set; get; }
        public DbSet<TrangThaiYeuCau> TrangThaiYeuCaus { set; get; }
        public DbSet<ViPham> ViPhams { set; get; }
        public DbSet<YeuCau> YeuCaus { set; get; }
        public DbSet<YeuCauChuyenPhong> YeuCauChuyenPhongs { set; get; }
        public DbSet<YeuCauKhac> YeuCauKhacs { set; get; }
        public DbSet<YeuCauSuaChua> YeuCauSuaChuas { set; get; }
        public DbSet<YeuCauTraPhong> YeuCauTraPhongs { set; get; }
        public DataContext()
            : base("mydata")
        {
            Database.SetInitializer<DataContext>(new DataInitializer());
        }
        public class DataInitializer : CreateDatabaseIfNotExists<DataContext>
        {
            protected override void Seed(DataContext context)
            {
                context.TrangThaiDangKyGiaHans.Add(new TrangThaiDangKyGiaHan("abc", "abc"));
                context.TrangThaiDangKyGiaHans.Add(new TrangThaiDangKyGiaHan("abce", "abc"));
                context.SaveChanges();
            }
        }
    }    
}