using TomFilesDesktop.Interfaces;

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

        private void UcFolder_Load(object sender, EventArgs e)
        {
            SetComboFilesAsync();
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
            if (int.TryParse(CbxFiles.SelectedValue.ToString(), out int result))
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

        private void CbxFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetFoldersByFileIdAsync();
        }
    }
}
