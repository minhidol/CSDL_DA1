using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Entites;
using Web.Configurations;


namespace Web.Entity_Framework 
{
    public class EWebDBContext : DbContext
    {
        public EWebDBContext(DbContextOptions options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /// configure using Fluent API
            modelBuilder.ApplyConfiguration(new KhachHangConfiguration());
            modelBuilder.ApplyConfiguration(new HoaDonConfiguration());
            modelBuilder.ApplyConfiguration(new SanPhamConfiguration());
            modelBuilder.ApplyConfiguration(new CT_HoaDonConfiguration());

            // Data seeding
            //modelBuilder.seed();
            //    base.OnModelCreating(modelBuilder);
        }
        public DbSet<KhachHang> KhachHang { set; get; }
        public DbSet<SanPham> SanPham { set; get; }
        public DbSet<CT_HoaDon> CT_HoaDon { set; get; }
        public DbSet<HoaDon> HoaDon { set; get; }
    }
}
