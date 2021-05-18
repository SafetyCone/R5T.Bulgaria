using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;
using R5T.Lombardy;
using R5T.Visigothia;


namespace R5T.Bulgaria.UserProfileDirectory
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="DropboxDirectoryPathProvider"/> implementation of <see cref="IDropboxDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDropboxDirectoryPathProvider(this IServiceCollection services,
            IServiceAction<IDropboxDirectoryNameProvider> dropboxDirectoryNameProviderAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction,
            IServiceAction<IUserProfileDirectoryPathProvider> userProfileDirectoryPathProviderAction)
        {
            services
                .AddSingleton<IDropboxDirectoryPathProvider, DropboxDirectoryPathProvider>()
                .Run(dropboxDirectoryNameProviderAction)
                .Run(stringlyTypedPathOperatorAction)
                .Run(userProfileDirectoryPathProviderAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="DropboxDirectoryPathProvider"/> implementation of <see cref="IDropboxDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IDropboxDirectoryPathProvider> AddDropboxDirectoryPathProviderAction(this IServiceCollection services,
            IServiceAction<IDropboxDirectoryNameProvider> dropboxDirectoryNameProviderAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction,
            IServiceAction<IUserProfileDirectoryPathProvider> userProfileDirectoryPathProviderAction)
        {
            var serviceAction = ServiceAction.New<IDropboxDirectoryPathProvider>(() => services.AddDropboxDirectoryPathProvider(
                dropboxDirectoryNameProviderAction,
                stringlyTypedPathOperatorAction,
                userProfileDirectoryPathProviderAction));

            return serviceAction;
        }
    }
}
