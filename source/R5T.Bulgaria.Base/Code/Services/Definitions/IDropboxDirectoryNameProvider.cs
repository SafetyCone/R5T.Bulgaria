using System;
using System.Threading.Tasks;


namespace R5T.Bulgaria
{
    public interface IDropboxDirectoryNameProvider
    {
        Task<string> GetDropboxDirectoryName();
    }
}
