using Newtonsoft.Json;
using System.Data;
using System.Text;
using TomFilesDesktop.Dto;
using TomFilesDesktop.Interfaces;
using TomFilesDesktop.Utils;

namespace TomFilesDesktop.Repositories;

public class FileRepository : IFileRepository
{
    private readonly string pathApi = "https://localhost:7048/api/v1/File";

    public async Task<bool> Create(FilesCreateUpdateDto filesCreateUpdateDto)
    {
        try
        {
            using (var httpClient = new HttpClient())
            {
                var jsonContent = JsonConvert.SerializeObject(filesCreateUpdateDto);

                var contentString = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync(pathApi, contentString);

                var jsonResponse = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

                if (response.StatusCode != System.Net.HttpStatusCode.OK) return false;
            }

            return true;
        }
        catch (Exception ex)
        {
            Util.MsgError(ex.Message);
            return false;
        }
    }

    public async Task<DataTable> GetAllFiles()
    {
        var dt = new DataTable();

        try
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(pathApi);

                var jsonResponse = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

                ApiFilesResponse apiResponse = JsonConvert.DeserializeObject<ApiFilesResponse>(jsonResponse);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    dt.Columns.Add("Id", typeof(int));
                    dt.Columns.Add("Name", typeof(string));
                    dt.Columns.Add("Path", typeof(string));

                    foreach (var item in apiResponse.Data)
                    {
                        dt.Rows.Add(item.Id, item.Name, item.Path);
                    }
                }

            }
        }
        catch (Exception ex)
        {
            Util.MsgError(ex.Message);
        }

        return dt;
    }

    public async Task<bool> Update(FilesCreateUpdateDto filesCreateUpdateDto)
    {
        try
        {
            using (var httpClient = new HttpClient())
            {
                var jsonContent = JsonConvert.SerializeObject(filesCreateUpdateDto);

                var contentString = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                var response = await httpClient.PutAsync(pathApi, contentString);

                var jsonResponse = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

                if (response.StatusCode != System.Net.HttpStatusCode.OK) return false;
            }

            return true;
        }
        catch (Exception ex)
        {
            Util.MsgError(ex.Message);
            return false;
        }
    }

    public async Task<bool> Delete(int fileId)
    {
        try
        {
            using (var httClient = new HttpClient())
            {
                using (var httpClient = new HttpClient())
                {
                    var response = await httpClient.DeleteAsync(pathApi + "/" + fileId);

                    var jsonResponse = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

                    if (response.StatusCode != System.Net.HttpStatusCode.OK) return false;
                }
            }

            return true;
        }
        catch (Exception ex)
        {
            Util.MsgError(ex.Message);

            return false;
        }
    }    
}
