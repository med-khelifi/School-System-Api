using Microsoft.Extensions.DependencyInjection;
using SS.Application.Interfaces;
using SS.Application.Services;
using SS.Core.Interfaces;
using System.Reflection;

namespace SS.Application
{
    public static class ApplicationDependencies
    {
        public static IServiceCollection AddApplicationDependencies(this IServiceCollection services)
        {
            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly());
            });


            services.AddScoped<IStudentService, StudentService>();
            return services;    
        }
    }
}
