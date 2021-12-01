using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.Bulgaria.Default
{
    public static partial class IServiceCollectionExtensions
    {
        /// <summary>
        /// Add the <see cref="DropboxDirectoryNameProvider"/> implementation of <see cref="IDropboxDirectoryNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDropboxDirectoryNameProvider_Old(this IServiceCollection services)
        {
            services.AddSingleton<IDropboxDirectoryNameProvider, DropboxDirectoryNameProvider>();

            return services;
        }

        /// <summary>
        /// Add the <see cref="DropboxDirectoryNameProvider"/> implementation of <see cref="IDropboxDirectoryNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IDropboxDirectoryNameProvider> AddDropboxDirectoryNameProviderAction_Old(this IServiceCollection services)
        {
            var serviceAction = ServiceAction.New<IDropboxDirectoryNameProvider>(() => services.AddDropboxDirectoryNameProvider_Old());
            return serviceAction;
        }
    }
}
