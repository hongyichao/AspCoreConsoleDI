using System;
using Serilog;
using ClassLibrary1;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();


            var serviceProvider = new ServiceCollection()     
            .AddSingleton<IClass1, Class1>()
            .AddSingleton<Interface1, Class2>()
            .BuildServiceProvider();



            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(configuration)            
            .CreateLogger();

            Log.Information("Hello again, Serilog!");

            var c1 = serviceProvider.GetService<IClass1>();
            
            

            c1.WriteSomething();

            Log.CloseAndFlush();
            Console.ReadKey();
        }
    }
}
