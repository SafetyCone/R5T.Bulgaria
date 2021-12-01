using System;

using R5T.Lombardy;
using R5T.Visigothia;

using R5T.T0062;
using R5T.T0063;


namespace R5T.Bulgaria.UserProfileDirectory
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="DropboxDirectoryPathProvider"/> implementation of <see cref="IDropboxDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IDropboxDirectoryPathProvider> AddDropboxDirectoryPathProviderAction(this IServiceAction _,
            IServiceAction<IDropboxDirectoryNameProvider> dropboxDirectoryNameProviderAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction,
            IServiceAction<IUserProfileDirectoryPathProvider> userProfileDirectoryPathProviderAction)
        {
            var serviceAction = _.New<IDropboxDirectoryPathProvider>(services => services.AddDropboxDirectoryPathProvider(
                dropboxDirectoryNameProviderAction,
                stringlyTypedPathOperatorAction,
                userProfileDirectoryPathProviderAction));

            return serviceAction;
        }
    }
}
