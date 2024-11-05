using Newtonsoft.Json;
using System.Data;
using TomFilesDesktop.Dto;
using TomFilesDesktop.Interfaces;

namespace TomFilesDesktop.Service;

public class FileService : IFileService
{
    public async Task<DataTable> GetAllFiles()
    {
        var dt = new DataTable();

        try
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync("https://localhost:7048/api/v1/File");

                var jsonResponse = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

                ApiResponse apiResponse = JsonConvert.DeserializeObject<ApiResponse>(jsonResponse);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    dt.Columns.Add("Id", typeof(int));
                    dt.Columns.Add("Name", typeof(string));
                    dt.Columns.Add("Path", typeof(string)); 

                    foreach(var item in apiResponse.Data)
                    {
                        dt.Rows.Add(item.Id,item.Name,item.Path);
                    }                   
                }
                    
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "File", MessageBoxButtons.OK,  MessageBoxIcon.Error);
        }       

        return dt;
    }
  
}
