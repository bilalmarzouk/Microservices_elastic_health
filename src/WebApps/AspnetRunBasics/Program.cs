using Common.Logging;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Sinks.Elasticsearch;
using System;
using System.Reflection;

namespace AspnetRunBasics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args).UseSerilog(SeriLogger.Configure)
            //((context,confiuration)=>

            //{
            //    confiuration.Enrich.FromLogContext()
            //    .Enrich.WithMachineName()
            //    .WriteTo.Console()
            //    .WriteTo.Elasticsearch(
            //        new ElasticsearchSinkOptions(new System.Uri(context.Configuration["ElasticConfiguration:Uri"]))
            //    {
            //        IndexFormat = $"applogs-{Assembly.GetExecutingAssembly().GetName().Name.ToLower().Replace(".", "-")}-{context.HostingEnvironment.EnvironmentName?.ToLower().Replace(".", "-")}-log-{DateTime.UtcNow:yyyy-MM}",
            //        AutoRegisterTemplate = true,
            //        NumberOfShards = 2,
            //        NumberOfReplicas = 1
            //    }).Enrich.WithProperty("Environment",context.HostingEnvironment.EnvironmentName).ReadFrom.Configuration(context.Configuration);
            //}
                //)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
