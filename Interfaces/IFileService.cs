using System.Data;
using System.Threading.Tasks;

namespace TomFilesDesktop.Interfaces;

public interface IFileService
{
    Task<DataTable> GetAllFiles();
}
