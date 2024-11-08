using System.Data;

namespace TomFilesDesktop.Interfaces;

public interface IFolderService
{
    Task<DataTable> GetFoldersByFileId(int fileId);
}
