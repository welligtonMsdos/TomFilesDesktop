using TomFilesDesktop.Enum;
using TomFilesDesktop.Interfaces;
using TomFilesDesktop.Utils;

namespace TomFilesDesktop.UserControls
{
    public partial class UcFolder : UserControl
    {
        private readonly IFolderService _folderService;
        private readonly IFileService _fileService;
        private int folderId = 0;

        public UcFolder(IFileService fileService, IFolderService folderService)
        {
            InitializeComponent();
            _fileService = fileService;
            _folderService = folderService;
        }

        private async void UcFolder_Load(object sender, EventArgs e)
        {
            await SetComboFilesAsync();
        }

        private async Task SetComboFilesAsync()
        {
            var dt = await _fileService.GetAllFiles();

            CbxFiles.DataSource = dt;
            CbxFiles.DisplayMember = "Name";
            CbxFiles.ValueMember = "Id";
        }

        private async Task GetFoldersByFileIdAsync()
        {
            if (int.TryParse(CbxFiles.SelectedValue?.ToString(), result: out int result))
            {
                var dt = await _folderService.GetFoldersByFileId(result);

                GridFolder.DataSource = dt;
                GridFolder.Columns[0].Visible = false;
            }
        }

        private void GridFolder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            folderId = int.Parse(GridFolder.Rows[e.RowIndex].Cells[0].Value.ToString());
            TxtNameFolder.Text = GridFolder.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private async void CbxFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            await GetFoldersByFileIdAsync();
        }

        private async void BtnClearFolder_Click(object sender, EventArgs e)
        {
            Util.ClearFields(this, ref folderId);

            await GetFoldersByFileIdAsync();
        }

        private async void BtnDeleteFolder_Click(object sender, EventArgs e)
        {
            if (!Util.MsgQuestion(EMsg.QUESTION_DELETE)) return;

            await DeleteAsync();
        }

        private async Task DeleteAsync()
        {
            if (await _folderService.Delete(folderId))
            {
                Util.MsgInformation(EMsg.DELETED);

                Util.ClearFields(this, ref folderId);

                await GetFoldersByFileIdAsync();
            }
        }
    }
}
