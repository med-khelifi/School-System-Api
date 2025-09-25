using Microsoft.Extensions.DependencyInjection;
using SS.Application.Interfaces;
using SS.Application.Mappings.StudentMappers;
using SS.Application.Services;
using SS.Core.Interfaces;
using System.Reflection;

namespace SS.Application
{
    public static class ApplicationDependencies
    {
        public static IServiceCollection AddApplicationDependencies(this IServiceCollection services)
        {
            services.AddAutoMapper((serviceProvider, mapperConfig) =>
            {
                // Add any custom config here, like constructor mapping, naming, etc.
                // mapperConfig.ShouldMapField = f => true;
            }, typeof(StudentMapperProfile).Assembly); // or Assembly.GetExecutingAssembly()


            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly());
            });


            services.AddScoped<IStudentService, StudentService>();
            return services;    
        }
    }
}
