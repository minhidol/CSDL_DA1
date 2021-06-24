using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Entites;

namespace Web.Configurations
{
    public class KhachHangConfiguration : IEntityTypeConfiguration<KhachHang>
    {
        public void Configure(EntityTypeBuilder<KhachHang> builder)
        {
            builder.ToTable("KhachHang");
            builder.HasKey(x => x.MaKH);
            builder.Property(x => x.SoNha).HasMaxLength(20);
            builder.Property(x => x.DienThoai).IsRequired().HasMaxLength(12);
            builder.Property(x => x.Ho).IsUnicode(true).HasMaxLength(20);
            builder.Property(x => x.Ten).IsUnicode(true).HasMaxLength(100);
            builder.Property(x => x.Duong).IsUnicode(true).HasMaxLength(100);
            builder.Property(x => x.Quan).IsUnicode(true).HasMaxLength(50);
            builder.Property(x => x.Phuong).IsUnicode(true).HasMaxLength(100);
            builder.Property(x => x.Tpho).HasMaxLength(50);

        }
    }
}
