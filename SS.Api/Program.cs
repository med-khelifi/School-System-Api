
using Microsoft.EntityFrameworkCore;
using SS.Application;
using SS.Application.Mappings.StudentMappers;
using SS.Infrastructure;
using SS.Infrastructure.appDbContext;
using System.Reflection;

namespace SS.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            
            // Add services to the container.
            builder.Services.AddDbContext<SchoolDbContext>(
                option =>
            {
                string cs = builder.Configuration.GetConnectionString("dbcontext")!;
                option.UseLazyLoadingProxies().UseSqlServer(cs);
            });

            builder.Services
                .AddInfrastructureDependencies()
                .AddApplicationDependencies();
            
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
