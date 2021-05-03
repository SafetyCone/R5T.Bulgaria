using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;
using R5T.Lombardy;
using R5T.Visigothia;

using R5T.Bulgaria.Default;


namespace R5T.Bulgaria.Standard
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="IDropboxDirectoryNameProvider"/> service.
        /// </summary>
        public static IServiceAction<IDropboxDirectoryNameProvider> AddDropboxDirectoryNameProviderAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction.New<IDropboxDirectoryNameProvider>(() => services.AddDropboxDirectoryNameProvider());
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="IDropboxDirectoryPathProvider"/> service.
        /// </summary>
        /// <param name="addStringlyTypedPathOperator">See R5T.Lombardy.</param>
        /// <param name="addUserProfileDirectoryPathProvider">See R5T.Visigothia.</param>
        /// <returns></returns>
        public static
            (
            IServiceAction<IDropboxDirectoryPathProvider> _,
            IServiceAction<IDropboxDirectoryNameProvider> DropboxDirectoryNameProviderAction
            )
        AddDropboxDirectoryPathProviderAction(this IServiceCollection services,
            IServiceAction<IStringlyTypedPathOperator> addStringlyTypedPathOperator,
            IServiceAction<IUserProfileDirectoryPathProvider> addUserProfileDirectoryPathProvider)
        {
            var dropboxDirectoryNameProviderAction = services.AddDropboxDirectoryNameProviderAction();

            var dropboxDirectoryPathProviderAction = UserProfileDirectory.IServiceCollectionExtensions.AddDropboxDirectoryPathProviderAction(services,
                dropboxDirectoryNameProviderAction,
                addStringlyTypedPathOperator,
                addUserProfileDirectoryPathProvider);

            return
                (
                dropboxDirectoryPathProviderAction,
                dropboxDirectoryNameProviderAction
                );
        }
    }
}
