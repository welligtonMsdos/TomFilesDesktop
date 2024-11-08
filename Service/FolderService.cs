using System.Data;
using TomFilesDesktop.Interfaces;

namespace TomFilesDesktop.Service;

public class FolderService : IFolderService
{
    private readonly IFolderRepository _repository;

    public FolderService(IFolderRepository repository)
    {
        _repository = repository;
    }
    public async Task<DataTable> GetFoldersByFileId(int fileId)
    {
        return await _repository.GetFoldersByFileId(fileId);
    }
}
