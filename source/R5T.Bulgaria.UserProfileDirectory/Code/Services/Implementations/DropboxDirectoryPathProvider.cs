using System;
using System.Threading.Tasks;

using R5T.Lombardy;
using R5T.Visigothia;

using R5T.T0064;


namespace R5T.Bulgaria.UserProfileDirectory
{
    [ServiceImplementationMarker]
    public class DropboxDirectoryPathProvider : IDropboxDirectoryPathProvider, IServiceImplementation
    {
        private IDropboxDirectoryNameProvider DropboxDirectoryNameProvider { get; set; }
        private IStringlyTypedPathOperator StringlyTypedPathOperator { get; set; }
        private IUserProfileDirectoryPathProvider UserProfileDirectoryPathProvider { get; set; }


        public DropboxDirectoryPathProvider(
            IDropboxDirectoryNameProvider dropboxDirectoryNameProvider,
            IStringlyTypedPathOperator stringlyTypedPathOperator,
            IUserProfileDirectoryPathProvider userProfileDirectoryPathProvider)
        {
            this.DropboxDirectoryNameProvider = dropboxDirectoryNameProvider;
            this.StringlyTypedPathOperator = stringlyTypedPathOperator;
            this.UserProfileDirectoryPathProvider = userProfileDirectoryPathProvider;
        }


        public async Task<string> GetDropboxDirectoryPath()
        {
            var gettingUserProfileDirectoryPath = this.UserProfileDirectoryPathProvider.GetUserProfileDirectoryPath();
            var gettingDropboxDirectoryName = this.DropboxDirectoryNameProvider.GetDropboxDirectoryName();

            var userProfileDirectoryPath = await gettingUserProfileDirectoryPath;
            var dropboxDirectoryName = await gettingDropboxDirectoryName;

            var dropboxDirectoryPath = this.StringlyTypedPathOperator.GetDirectoryPath(userProfileDirectoryPath, dropboxDirectoryName);
            return dropboxDirectoryPath;
        }
    }
}
