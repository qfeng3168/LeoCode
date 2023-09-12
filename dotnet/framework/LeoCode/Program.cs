using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace FurionStart
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder
                    .Inject()   // 添加这一行
                    .UseStartup<Startup>();
                });
    }
}