using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // phuong thuc tao host nhan vao args, tra ve doi tuong IHostBuilder
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            // tao mot server,tra ve web host builder, su dung startup de khoi chay nhung file cau hinh
            // sau khi chay xong thi dung build de tao app, run 
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
