using System;
using System.Threading.Tasks;


namespace R5T.Bulgaria.Default
{
    public class DropboxDirectoryNameProvider : IDropboxDirectoryNameProvider
    {
        public Task<string> GetDropboxDirectoryName()
        {
            return Task.FromResult(Constants.DefaultDropboxDirectoryName);
        }
    }
}
