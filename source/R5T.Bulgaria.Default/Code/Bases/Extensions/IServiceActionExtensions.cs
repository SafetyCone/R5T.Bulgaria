using System;

using R5T.T0062;
using R5T.T0063;


namespace R5T.Bulgaria.Default
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="DropboxDirectoryNameProvider"/> implementation of <see cref="IDropboxDirectoryNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IDropboxDirectoryNameProvider> AddDropboxDirectoryNameProviderAction(this IServiceAction _)
        {
            var serviceAction = _.New<IDropboxDirectoryNameProvider>(services => services.AddDropboxDirectoryNameProvider());
            return serviceAction;
        }
    }
}
