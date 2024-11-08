using TomFilesDesktop.Dto;
using TomFilesDesktop.Interfaces;

namespace TomFilesDesktop.UserControls
{
    public partial class UcFile : UserControl
    {
        private readonly IFileService _fileService;
        private int fileId = 0;

        public UcFile(IFileService fileService)
        {
            InitializeComponent();

            _fileService = fileService;
        }

        private async void UcFile_Load(object sender, EventArgs e)
        {
            await GetAllFilesAsync();
        }

        private async Task GetAllFilesAsync()
        {
            var dt = await _fileService.GetAllFiles();

            GridFiles.DataSource = dt;
            GridFiles.Columns[0].Visible = false;
        }

        private void GridFiles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            fileId = int.Parse(GridFiles.Rows[e.RowIndex].Cells[0].Value.ToString());
            TxtName.Text = GridFiles.Rows[e.RowIndex].Cells[1].Value.ToString();
            TxtPath.Text = GridFiles.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            await SaveAsync();
        }

        private async Task SaveAsync()
        {
            var filesCreateUpdateDto = new FilesCreateUpdateDto(fileId == 0 ? 0 : fileId,
                                                                TxtName.Text.Trim(),
                                                                TxtPath.Text.Trim());

            var result = false;

            if (fileId == 0) result = await _fileService.Create(filesCreateUpdateDto);
            else result = await _fileService.Update(filesCreateUpdateDto);

            if (result)
            {
                MessageBox.Show("Successfully saved!", "File", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFieldsFiles();

                await GetAllFilesAsync();
            }
        }

        private void ClearFieldsFiles()
        {
            fileId = 0;
            TxtName.Clear();
            TxtPath.Clear();
            TxtName.Focus();
        }

        private async void BtnClear_Click(object sender, EventArgs e)
        {
            ClearFieldsFiles();

            await GetAllFilesAsync();
        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete?", "File",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No) return;

            await DeleteAsync();
        }

        private async Task DeleteAsync()
        {
            if (await _fileService.Delete(fileId))
            {
                MessageBox.Show("Successfully deleted!", "File", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFieldsFiles();

                await GetAllFilesAsync();
            }
        }

        private void BtnPathFile_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fdFile = new FolderBrowserDialog())
            {
                if (fdFile.ShowDialog() == DialogResult.OK)
                    TxtPath.Text = fdFile.SelectedPath;
            }
        }
    }
}
