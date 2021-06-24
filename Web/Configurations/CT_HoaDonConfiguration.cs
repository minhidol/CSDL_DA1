using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Entites;

namespace Web.Configurations
{
    public class CT_HoaDonConfiguration : IEntityTypeConfiguration<CT_HoaDon>
    {
        public void Configure(EntityTypeBuilder<CT_HoaDon> builder)
        {
            builder.ToTable("CT_HoaDon");
            builder.HasKey(t => new { t.MaSP, t.MaHD });

            builder.Property(x => x.GiaBan).HasColumnType("money");
            builder.Property(x => x.GiaGiam).HasColumnType("money");
            builder.Property(x => x.ThanhTien).HasColumnType("money");

            builder.HasOne(t => t.SanPham).WithMany(hd => hd.ct_hd)
                .HasForeignKey(hd => hd.MaSP);
            builder.HasOne(t => t.HoaDon).WithMany(hd => hd.ct_hd)
                .HasForeignKey(hd => hd.MaHD);

            
        }


    }
}
