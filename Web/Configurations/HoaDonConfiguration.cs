using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Entites;

namespace Web.Configurations
{
    public class HoaDonConfiguration: IEntityTypeConfiguration<HoaDon>
    {
        public void Configure(EntityTypeBuilder<HoaDon> builder)
        {
            builder.ToTable("HoaDon");
            builder.HasKey(x => x.MaHD);
            builder.Property(x => x.MaKH).IsRequired();
            builder.Property(x => x.TongTien).IsRequired().HasColumnType("money");
                
            builder.HasOne(t => t.khachHang).WithMany(hd => hd.listHD).HasForeignKey(x => x.MaKH);
        }

       
    }
}
