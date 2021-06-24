using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Entites;

namespace Web.Configurations
{
    public class SanPhamConfiguration : IEntityTypeConfiguration<SanPham>
    {
       

        public void Configure(EntityTypeBuilder<SanPham> builder)
        {
            builder.ToTable("SanPham");
            builder.HasKey(x => x.MaSP);
            builder.Property(x => x.TenSP).IsUnicode(true).HasMaxLength(255);
            builder.Property(x => x.Mota).IsUnicode(true).HasMaxLength(255);

           
            //builder.Property(x => x.DienThoai).IsRequired();
        }
    }
}
