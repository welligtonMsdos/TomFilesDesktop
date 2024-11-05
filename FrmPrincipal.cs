using TomFilesDesktop.Interfaces;


namespace TomFilesDesktop
{
    public partial class FrmPrincipal : Form
    {
        private readonly IFileService _fileService;

        public FrmPrincipal(IFileService fileService)
        {
            InitializeComponent();

            _fileService = fileService;
        }

        private async Task LoadAndBindDataAsync()
        {
            var dt = await _fileService.GetAllFiles();

            gridFiles.DataSource = dt;
            gridFiles.Columns[0].Visible = false;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            LoadAndBindDataAsync();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPath.Clear();
            txtName.Focus();
            LoadAndBindDataAsync();
        }

        private void btnPathFile_Click(object sender, EventArgs e)
        {
            using(FolderBrowserDialog fdFile = new FolderBrowserDialog())
            {
                if(fdFile.ShowDialog() == DialogResult.OK)
                    txtPath.Text = fdFile.SelectedPath;
            }
        }
    }
}
