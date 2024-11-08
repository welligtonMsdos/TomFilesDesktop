using System.Data;

namespace TomFilesDesktop.Interfaces;

public interface IFolderRepository
{
    Task<DataTable> GetFoldersByFileId(int fileId);
}
