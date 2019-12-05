using System;
using CleanArchitecture.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CleanArchitecture.Data.Context
{
    public partial class WebEnglishDBContext : DbContext
    {
        public WebEnglishDBContext()
        {
        }

        public WebEnglishDBContext(DbContextOptions<WebEnglishDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BaiHoc> BaiHoc { get; set; }
        public virtual DbSet<BaiKiemTra> BaiKiemTra { get; set; }
        public virtual DbSet<CauHoi> CauHoi { get; set; }
        public virtual DbSet<ChiTietBaiHoc> ChiTietBaiHoc { get; set; }
        public virtual DbSet<ChuDe> ChuDe { get; set; }
        public virtual DbSet<Hoc> Hoc { get; set; }
        public virtual DbSet<NguoiDung> NguoiDung { get; set; }
        public virtual DbSet<ThamGiaChuDe> ThamGiaChuDe { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=WebDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BaiHoc>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BaiSo).HasDefaultValueSql("((1))");

                entity.Property(e => e.IdchuDe).HasColumnName("IDChuDe");

                entity.Property(e => e.NgayTao)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TenBaiHoc).HasMaxLength(100);

                entity.HasOne(d => d.IdchuDeNavigation)
                    .WithMany(p => p.BaiHoc)
                    .HasForeignKey(d => d.IdchuDe)
                    .HasConstraintName("FK__BaiHoc__IDChuDe__3D2915A8");
            });

            modelBuilder.Entity<BaiKiemTra>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdbaiHoc).HasColumnName("IDBaiHoc");

                entity.Property(e => e.NgayTao)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.IdbaiHocNavigation)
                    .WithMany(p => p.BaiKiemTra)
                    .HasForeignKey(d => d.IdbaiHoc)
                    .HasConstraintName("FK__BaiKiemTr__IDBai__498EEC8D");
            });

            modelBuilder.Entity<CauHoi>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CauHoi1)
                    .HasColumnName("CauHoi")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DapAnA)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DapAnB)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DapAnC)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DapAnD)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DapAnDung)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.GoiY).HasColumnType("ntext");

                entity.Property(e => e.IdbaiKiemTra).HasColumnName("IDBaiKiemTra");

                entity.HasOne(d => d.IdbaiKiemTraNavigation)
                    .WithMany(p => p.CauHoi)
                    .HasForeignKey(d => d.IdbaiKiemTra)
                    .HasConstraintName("FK__CauHoi__IDBaiKie__756D6ECB");
            });

            modelBuilder.Entity<ChiTietBaiHoc>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdbaiHoc).HasColumnName("IDBaiHoc");

                entity.Property(e => e.LinkMp3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NoiDung).HasColumnType("text");

                entity.HasOne(d => d.IdbaiHocNavigation)
                    .WithMany(p => p.ChiTietBaiHoc)
                    .HasForeignKey(d => d.IdbaiHoc)
                    .HasConstraintName("FK__ChiTietBa__IDBai__625A9A57");
            });

            modelBuilder.Entity<ChuDe>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.NgayTao)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TenChuDe).HasMaxLength(100);

                entity.Property(e => e.ThongTin).HasMaxLength(1000);
            });

            modelBuilder.Entity<Hoc>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Diem).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdbaiHoc).HasColumnName("IDBaiHoc");

                entity.Property(e => e.IdthamGiaChuDe).HasColumnName("IDThamGiaChuDe");

                entity.HasOne(d => d.IdbaiHocNavigation)
                    .WithMany(p => p.Hoc)
                    .HasForeignKey(d => d.IdbaiHoc)
                    .HasConstraintName("FK__Hoc__IDBaiHoc__45BE5BA9");

                entity.HasOne(d => d.IdthamGiaChuDeNavigation)
                    .WithMany(p => p.Hoc)
                    .HasForeignKey(d => d.IdthamGiaChuDe)
                    .HasConstraintName("FK__Hoc__IDThamGiaCh__44CA3770");
            });

            modelBuilder.Entity<NguoiDung>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Gmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MatKhau)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NgayTao)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SoDienThoai)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TaiKhoan)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TenNguoiDung).HasMaxLength(100);

                entity.Property(e => e.VaiTro).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ThamGiaChuDe>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdchuDe).HasColumnName("IDChuDe");

                entity.Property(e => e.IdnguoiDung).HasColumnName("IDNguoiDung");

                entity.HasOne(d => d.IdchuDeNavigation)
                    .WithMany(p => p.ThamGiaChuDe)
                    .HasForeignKey(d => d.IdchuDe)
                    .HasConstraintName("FK__ThamGiaCh__IDChu__3A4CA8FD");

                entity.HasOne(d => d.IdnguoiDungNavigation)
                    .WithMany(p => p.ThamGiaChuDe)
                    .HasForeignKey(d => d.IdnguoiDung)
                    .HasConstraintName("FK__ThamGiaCh__IDNgu__395884C4");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
