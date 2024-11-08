using Newtonsoft.Json;
using System.Data;
using TomFilesDesktop.Dto;
using TomFilesDesktop.Interfaces;

namespace TomFilesDesktop.Repositories;

public class FolderRepository : IFolderRepository
{
    private readonly string pathApi = "https://localhost:7048/api/v1/Folder";

    public async Task<DataTable> GetFoldersByFileId(int fileId)
    {
        var dt = new DataTable();

        try
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(pathApi + "/" + fileId);

                var jsonResponse = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

                ApiFolderResponse apiResponse = JsonConvert.DeserializeObject<ApiFolderResponse>(jsonResponse);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    dt.Columns.Add("Id", typeof(int));
                    dt.Columns.Add("Name", typeof(string));
                    dt.Columns.Add("Path", typeof(string));
                    dt.Columns.Add("FolderName", typeof(string));

                    foreach (var item in apiResponse.Data)
                    {
                        dt.Rows.Add(item.Id, item.Name, item.Path, item.FolderName);
                    }
                }

            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Folder", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        return dt;
    }
}
