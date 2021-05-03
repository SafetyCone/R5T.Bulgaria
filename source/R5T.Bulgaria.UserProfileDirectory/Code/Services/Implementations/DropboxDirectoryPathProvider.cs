using System;
using System.Threading.Tasks;

using R5T.Lombardy;
using R5T.Visigothia;


namespace R5T.Bulgaria.UserProfileDirectory
{
    public class DropboxDirectoryPathProvider : IDropboxDirectoryPathProvider
    {
        private IDropboxDirectoryNameProvider DropboxDirectoryNameProvider { get; set; }
        private IStringlyTypedPathOperator StringlyTypedPathOperator { get; set; }
        private IUserProfileDirectoryPathProvider UserProfileDirectoryPathProvider { get; set; }


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
