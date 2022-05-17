using System;
using Inpulse.WebApi.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace Inpulse.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            // services.AddResponseCompression(options =>
            // {
            //     options.Providers.Add<GzipCompressionProvider>();
            //     options.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(new[] { "application/json" });
            // });
            services.AddControllers();
            services.AddMvc();

            var host = Configuration["DBHOST"] ?? Configuration.GetConnectionString("DBHOST") ?? "127.0.0.1";
            var port = Configuration["DBPORT"] ?? Configuration.GetConnectionString("DBPORT") ?? "3306";
            var password = Configuration["PASSWORD"] ?? Configuration.GetConnectionString("PASSWORD");
            var userid = Configuration["USER"] ?? Configuration.GetConnectionString("USER") ?? "root";
            var productsdb = Configuration["DATABASE"] ?? Configuration.GetConnectionString("DATABASE") ?? "crm_sgr";

            var mySqlConnStr = $"server={host}; userid={userid};pwd={password};port={port};database={productsdb};AllowZeroDateTime=True;ConvertZeroDateTime=True";       
            
            Console.WriteLine(mySqlConnStr);
            
            services.AddDbContextPool<DataContext>(options =>
                options.UseMySql(mySqlConnStr, ServerVersion.AutoDetect(mySqlConnStr)));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Inpulse.WebApi", Version = "v1" });
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Inpulse.WebApi v1"));
            
            app.UseHttpsRedirection();
            app.UseRouting();
            
            app.UseCors(x => x
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
            
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
