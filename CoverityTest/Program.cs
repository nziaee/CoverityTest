using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using TestLibrary;

namespace CoverityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new Class1();
            user.Name = "Test";
            Console.WriteLine("Hello "+user.Name+"!");
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args);
    }
}
