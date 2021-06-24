using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Entity_Framework
{
    public class EWebDBContextFactory : IDesignTimeDbContextFactory<EWebDBContext>
    {
        public EWebDBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            
            var connectionString = configuration.GetConnectionString("DA1Database");

            var optionsBuilder = new DbContextOptionsBuilder<EWebDBContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new EWebDBContext(optionsBuilder.Options);
        }
    }
}
