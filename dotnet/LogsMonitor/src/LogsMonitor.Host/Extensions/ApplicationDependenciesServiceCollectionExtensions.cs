using Microsoft.Extensions.DependencyInjection;

using LogsMonitor.Service;
using LogsMonitor.Core.Abstractions;

namespace LogsMonitor.Host.Extensions
{
    internal static class ApplicationDependenciesServiceCollectionExtensions
    {
        internal static void AddApplicationDependencies(this IServiceCollection services)
        {
            services.AddSingleton<IActivityLogsRepository, ActivityLogsRepository>();
            services.AddSingleton<IActivityLogsService, ActivityLogsService>();
        }
    }
}