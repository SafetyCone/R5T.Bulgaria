using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.T0062;
using R5T.T0063;


namespace R5T.Bulgaria.Default
{
    public static partial class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="DropboxDirectoryNameProvider"/> implementation of <see cref="IDropboxDirectoryNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDropboxDirectoryNameProvider(this IServiceCollection services)
        {
            services.AddSingleton<IDropboxDirectoryNameProvider, DropboxDirectoryNameProvider>();

            return services;
        }
    }
}
