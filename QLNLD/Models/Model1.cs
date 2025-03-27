using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLNLD.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<DiemDanhNgayLaoDong> DiemDanhNgayLaoDongs { get; set; }
        public virtual DbSet<Khoa> Khoas { get; set; }
        public virtual DbSet<Lop> Lops { get; set; }
        public virtual DbSet<PhieuDangKy> PhieuDangKies { get; set; }
        public virtual DbSet<PhieuDuyet> PhieuDuyets { get; set; }
        public virtual DbSet<PhieuXacNhanHoanThanh> PhieuXacNhanHoanThanhs { get; set; }
        public virtual DbSet<QuanLy> QuanLies { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }
        public virtual DbSet<SoNgayLaoDong> SoNgayLaoDongs { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<TaoDotNgayLaoDong> TaoDotNgayLaoDongs { get; set; }
        public virtual DbSet<VaiTro> VaiTroes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PhieuDangKy>()
                .HasMany(e => e.PhieuDuyets)
                .WithOptional(e => e.PhieuDangKy1)
                .HasForeignKey(e => e.PhieuDangKy);

            modelBuilder.Entity<PhieuDuyet>()
                .HasMany(e => e.PhieuXacNhanHoanThanhs)
                .WithOptional(e => e.PhieuDuyet1)
                .HasForeignKey(e => e.Phieuduyet);

            modelBuilder.Entity<PhieuXacNhanHoanThanh>()
                .HasMany(e => e.SoNgayLaoDongs)
                .WithOptional(e => e.PhieuXacNhanHoanThanh)
                .HasForeignKey(e => e.Ma_phieu_xac_nhan);

            modelBuilder.Entity<QuanLy>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<QuanLy>()
                .HasMany(e => e.DiemDanhNgayLaoDongs)
                .WithOptional(e => e.QuanLy)
                .HasForeignKey(e => e.NguoiTao);

            modelBuilder.Entity<QuanLy>()
                .HasMany(e => e.PhieuDuyets)
                .WithOptional(e => e.QuanLy)
                .HasForeignKey(e => e.Nguoiduyet);

            modelBuilder.Entity<QuanLy>()
                .HasMany(e => e.PhieuXacNhanHoanThanhs)
                .WithOptional(e => e.QuanLy)
                .HasForeignKey(e => e.NguoiXacNhan);

            modelBuilder.Entity<QuanLy>()
                .HasMany(e => e.TaoDotNgayLaoDongs)
                .WithOptional(e => e.QuanLy)
                .HasForeignKey(e => e.NguoiTao);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .HasMany(e => e.QuanLies)
                .WithOptional(e => e.TaiKhoan1)
                .HasForeignKey(e => e.taikhoan);

            modelBuilder.Entity<TaiKhoan>()
                .HasMany(e => e.SinhViens)
                .WithOptional(e => e.TaiKhoan1)
                .HasForeignKey(e => e.taikhoan);

            modelBuilder.Entity<VaiTro>()
                .HasMany(e => e.TaiKhoans)
                .WithOptional(e => e.VaiTro)
                .HasForeignKey(e => e.role_id);
        }
    }
}
