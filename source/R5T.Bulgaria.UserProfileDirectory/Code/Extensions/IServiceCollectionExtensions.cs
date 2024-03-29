﻿using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Lombardy;
using R5T.Visigothia;

using R5T.T0063;


namespace R5T.Bulgaria.UserProfileDirectory
{
    public static partial class IServiceCollectionExtensions
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
                .Run(dropboxDirectoryNameProviderAction)
                .Run(stringlyTypedPathOperatorAction)
                .Run(userProfileDirectoryPathProviderAction)
                .AddSingleton<IDropboxDirectoryPathProvider, DropboxDirectoryPathProvider>();

            return services;
        }
    }
}
