using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIGateway
{
    public class Program
    {
        public static void Main(string[] args)
        {
             CreateHostBuilder(args).Build().Run();
        }


        //iniciate the re route jason file here
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration(
                          ic => ic.AddJsonFile("ocelot.json"))
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });


        //public static IHostBuilder CreateHostBuilder(string[] args)
        //{
        //    var result = Host.CreateDefaultBuilder(args);
        //    try
        //    {
        //        result.ConfigureAppConfiguration(
        //                      ic => ic.AddJsonFile("ocelot.json"));
        //    }
        //    catch(Exception e)
        //    {

        //    }

        //    result.ConfigureWebHostDefaults(webBuilder =>
        //    {
        //        webBuilder.UseStartup<Startup>();
        //    });


        //    return result;
        //}
    }
}
