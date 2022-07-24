using System;
using Microsoft.Extensions.DependencyInjection;

namespace Default_Backend.Common.Extensions
{
    public static class ServiceProviderExtension
    {
        public static IServiceScope CreateScope(this IServiceProvider provider)
        {
            return provider.GetRequiredService<IServiceScopeFactory>().CreateScope();
        }
    }
}
