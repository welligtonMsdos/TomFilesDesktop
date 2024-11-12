using System.Data;

namespace TomFilesDesktop.Interfaces;

public interface IFolderService
{
    Task<DataTable> GetFoldersByFileId(int fileId);
    Task<bool> Delete(int folderId);
}
