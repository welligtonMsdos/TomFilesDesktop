using System.Data;
using TomFilesDesktop.Dto;
using TomFilesDesktop.Interfaces;
using TomFilesDesktop.ValidationFluent;

namespace TomFilesDesktop.Service;

public class FileService : IFileService
{
    private readonly IFileRepository _repository;

    public FileService(IFileRepository repository)
    {
        _repository = repository;
    }

    public async Task<bool> Create(FilesCreateUpdateDto filesCreateUpdateDto)
    { 
        var validResult = new FileValidator().Validate(filesCreateUpdateDto);

        string[] erros = validResult.ToString("~").Split('~');

        if (!validResult.IsValid)
        {
            MessageBox.Show(erros[0], "File", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }

        return await _repository.Create(filesCreateUpdateDto);
    }   

    public async Task<DataTable> GetAllFiles()
    {
        return await _repository.GetAllFiles();
    }

    public async Task<bool> Update(FilesCreateUpdateDto filesCreateUpdateDto)
    {
        var validResult = new FileValidator().Validate(filesCreateUpdateDto);

        string[] erros = validResult.ToString("~").Split('~');

        if (!validResult.IsValid)
        {
            MessageBox.Show(erros[0], "File", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }

        return await _repository.Update(filesCreateUpdateDto);
    }

    public async Task<bool> Delete(int fileId)
    {
        return await _repository.Delete(fileId);
    }   
}
