using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Scripting;

namespace Lombiq.HelpfulLibraries.Libraries.MethodProviders
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddHelpfulMethodProviders(this IServiceCollection services) =>
            services.AddSingleton<IGlobalMethodProvider, UserMethodProvider>();
    }
}
