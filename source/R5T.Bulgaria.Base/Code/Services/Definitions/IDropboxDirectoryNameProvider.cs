using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.Bulgaria
{
    [ServiceDefinitionMarker]
    public interface IDropboxDirectoryNameProvider : IServiceDefinition
    {
        Task<string> GetDropboxDirectoryName();
    }
}
