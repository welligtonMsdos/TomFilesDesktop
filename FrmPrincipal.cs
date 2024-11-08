using System.Windows.Forms;
using TomFilesDesktop.Interfaces;
using TomFilesDesktop.UserControls;


namespace TomFilesDesktop
{
    public partial class FrmPrincipal : Form
    {
        private readonly IFolderService _folderService;
        private readonly IFileService _fileService;

        public FrmPrincipal(IFileService fileService, IFolderService folderService)
        {
            InitializeComponent();

            _fileService = fileService;
            _folderService = folderService;
        }

        private void TcPrincipal_MouseClick(object sender, MouseEventArgs e)
        {
            TabControl? tabControl = sender as TabControl;
            if (tabControl != null)
            {
                if (tabControl.SelectedIndex == 0)
                {
                    TabFiles.Controls.Clear();
                    var ucFile = new UcFile(_fileService);
                    TabFiles.Controls.Add(ucFile);
                }
                else if (tabControl.SelectedIndex == 1)
                {
                    TabFolders.Controls.Clear();
                    var ucFolder = new UcFolder(_fileService, _folderService);
                    TabFolders.Controls.Add(ucFolder);
                }
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            
        }
    }
}
