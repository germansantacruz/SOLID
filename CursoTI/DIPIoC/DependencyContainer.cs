using ConsoleLoggerLibrary;
using DIPAbstractions;
using Microsoft.Extensions.DependencyInjection;

namespace DIPIoC
{
    public static class DependencyContainer
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<ILogger, ConsoleLogger>();
        }
    }
}
