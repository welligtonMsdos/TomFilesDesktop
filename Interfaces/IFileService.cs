﻿using System.Data;
using TomFilesDesktop.Dto;

namespace TomFilesDesktop.Interfaces;

public interface IFileService
{
    Task<DataTable> GetAllFiles();
    Task<bool> Create(FilesCreateUpdateDto filesCreateUpdateDto);
    Task<bool> Update(FilesCreateUpdateDto filesCreateUpdateDto);
    Task<bool> Delete(int fileId);
}
