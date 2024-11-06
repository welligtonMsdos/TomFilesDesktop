using TomFilesDesktop.Dto;
using TomFilesDesktop.Interfaces;


namespace TomFilesDesktop
{
    public partial class FrmPrincipal : Form
    {
        private readonly IFileService _fileService;
        private int fileId = 0;

        public FrmPrincipal(IFileService fileService)
        {
            InitializeComponent();

            _fileService = fileService;
        }       

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            GetAllAsync();
        }

        private async Task SaveAsync()
        {
            var filesCreateUpdateDto = new FilesCreateUpdateDto(fileId == 0 ? 0 : fileId, 
                                                                txtName.Text.Trim(), 
                                                                txtPath.Text.Trim());

            var result = false;

            if(fileId == 0) result = await _fileService.Create(filesCreateUpdateDto);
            else result = await _fileService.Update(filesCreateUpdateDto);            

            if (result)
            {
                MessageBox.Show("Successfully saved!", "File", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();

                GetAllAsync();
            }
        }

        private async Task GetAllAsync()
        {
            var dt = await _fileService.GetAllFiles();

            gridFiles.DataSource = dt;
            gridFiles.Columns[0].Visible = false;
        }

        private async Task DeleteAsync()
        {
            if (await _fileService.Delete(fileId))
            {
                MessageBox.Show("Successfully deleted!", "File", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();

                GetAllAsync();
            }
        }

        private void btnPathFile_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fdFile = new FolderBrowserDialog())
            {
                if (fdFile.ShowDialog() == DialogResult.OK)
                    txtPath.Text = fdFile.SelectedPath;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveAsync();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();

            GetAllAsync();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete?", "File",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No) return;

            DeleteAsync();
        }

        private void gridFiles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            fileId = int.Parse(gridFiles.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtName.Text = gridFiles.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPath.Text = gridFiles.Rows[e.RowIndex].Cells[2].Value.ToString();
        }       

        private void ClearFields()
        {
            fileId = 0;
            txtName.Clear();
            txtPath.Clear();
            txtName.Focus();
        }
    }
}
