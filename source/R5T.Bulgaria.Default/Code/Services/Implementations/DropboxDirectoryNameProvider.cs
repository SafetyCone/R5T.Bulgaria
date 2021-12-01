using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.Bulgaria.Default
{
    [ServiceImplementationMarker]
    public class DropboxDirectoryNameProvider : IDropboxDirectoryNameProvider, IServiceImplementation
    {
        public Task<string> GetDropboxDirectoryName()
        {
            return Task.FromResult(Constants.DefaultDropboxDirectoryName);
        }
    }
}
