namespace TomFilesDesktop.UserControls
{
    partial class UcFolder
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            TblFolderPrincipal = new TableLayoutPanel();
            grpTitleFolder = new GroupBox();
            TxtNameFolder = new TextBox();
            LblNameFolder = new Label();
            CbxFiles = new ComboBox();
            TblActionFolder = new TableLayoutPanel();
            BtnClearFolder = new Button();
            BtnDeleteFolder = new Button();
            BtnSave = new Button();
            GridFolder = new DataGridView();
            TblFolderPrincipal.SuspendLayout();
            grpTitleFolder.SuspendLayout();
            TblActionFolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridFolder).BeginInit();
            SuspendLayout();
            // 
            // TblFolderPrincipal
            // 
            TblFolderPrincipal.ColumnCount = 1;
            TblFolderPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TblFolderPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            TblFolderPrincipal.Controls.Add(grpTitleFolder, 0, 0);
            TblFolderPrincipal.Controls.Add(TblActionFolder, 0, 1);
            TblFolderPrincipal.Controls.Add(GridFolder, 0, 2);
            TblFolderPrincipal.Dock = DockStyle.Fill;
            TblFolderPrincipal.Location = new Point(0, 0);
            TblFolderPrincipal.Name = "TblFolderPrincipal";
            TblFolderPrincipal.RowCount = 3;
            TblFolderPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 14.8148146F));
            TblFolderPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 8.278867F));
            TblFolderPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 76.90632F));
            TblFolderPrincipal.Size = new Size(895, 465);
            TblFolderPrincipal.TabIndex = 1;
            // 
            // grpTitleFolder
            // 
            grpTitleFolder.Controls.Add(TxtNameFolder);
            grpTitleFolder.Controls.Add(LblNameFolder);
            grpTitleFolder.Controls.Add(CbxFiles);
            grpTitleFolder.Dock = DockStyle.Fill;
            grpTitleFolder.Location = new Point(3, 3);
            grpTitleFolder.Name = "grpTitleFolder";
            grpTitleFolder.Size = new Size(889, 62);
            grpTitleFolder.TabIndex = 0;
            grpTitleFolder.TabStop = false;
            // 
            // TxtNameFolder
            // 
            TxtNameFolder.Location = new Point(269, 22);
            TxtNameFolder.Name = "TxtNameFolder";
            TxtNameFolder.Size = new Size(233, 23);
            TxtNameFolder.TabIndex = 2;
            // 
            // LblNameFolder
            // 
            LblNameFolder.AutoSize = true;
            LblNameFolder.Location = new Point(187, 25);
            LblNameFolder.Name = "LblNameFolder";
            LblNameFolder.Size = new Size(76, 15);
            LblNameFolder.TabIndex = 1;
            LblNameFolder.Text = "Name folder:";
            // 
            // CbxFiles
            // 
            CbxFiles.DropDownStyle = ComboBoxStyle.DropDownList;
            CbxFiles.FormattingEnabled = true;
            CbxFiles.Location = new Point(6, 22);
            CbxFiles.Name = "CbxFiles";
            CbxFiles.Size = new Size(155, 23);
            CbxFiles.TabIndex = 0;
            CbxFiles.SelectedIndexChanged += CbxFiles_SelectedIndexChanged;
            // 
            // TblActionFolder
            // 
            TblActionFolder.ColumnCount = 4;
            TblActionFolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            TblActionFolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            TblActionFolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            TblActionFolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            TblActionFolder.Controls.Add(BtnClearFolder, 2, 0);
            TblActionFolder.Controls.Add(BtnDeleteFolder, 3, 0);
            TblActionFolder.Controls.Add(BtnSave, 1, 0);
            TblActionFolder.Dock = DockStyle.Fill;
            TblActionFolder.Location = new Point(3, 71);
            TblActionFolder.Name = "TblActionFolder";
            TblActionFolder.RowCount = 1;
            TblActionFolder.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TblActionFolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TblActionFolder.Size = new Size(889, 32);
            TblActionFolder.TabIndex = 1;
            // 
            // BtnClearFolder
            // 
            BtnClearFolder.Dock = DockStyle.Fill;
            BtnClearFolder.Location = new Point(713, 3);
            BtnClearFolder.Name = "BtnClearFolder";
            BtnClearFolder.Size = new Size(82, 26);
            BtnClearFolder.TabIndex = 1;
            BtnClearFolder.Text = "Clear";
            BtnClearFolder.UseVisualStyleBackColor = true;
            BtnClearFolder.Click += BtnClearFolder_Click;
            // 
            // BtnDeleteFolder
            // 
            BtnDeleteFolder.Dock = DockStyle.Fill;
            BtnDeleteFolder.Location = new Point(801, 3);
            BtnDeleteFolder.Name = "BtnDeleteFolder";
            BtnDeleteFolder.Size = new Size(85, 26);
            BtnDeleteFolder.TabIndex = 2;
            BtnDeleteFolder.Text = "Delete";
            BtnDeleteFolder.UseVisualStyleBackColor = true;
            BtnDeleteFolder.Click += BtnDeleteFolder_Click;
            // 
            // BtnSave
            // 
            BtnSave.Dock = DockStyle.Fill;
            BtnSave.Location = new Point(625, 3);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(82, 26);
            BtnSave.TabIndex = 3;
            BtnSave.Text = "Save";
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // GridFolder
            // 
            GridFolder.AllowUserToAddRows = false;
            GridFolder.AllowUserToDeleteRows = false;
            GridFolder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            GridFolder.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            GridFolder.BackgroundColor = Color.White;
            GridFolder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridFolder.Dock = DockStyle.Fill;
            GridFolder.Location = new Point(3, 109);
            GridFolder.MultiSelect = false;
            GridFolder.Name = "GridFolder";
            GridFolder.ReadOnly = true;
            GridFolder.SelectionMode = DataGridViewSelectionMode.CellSelect;
            GridFolder.Size = new Size(889, 353);
            GridFolder.TabIndex = 2;
            GridFolder.CellDoubleClick += GridFolder_CellDoubleClick;
            // 
            // UcFolder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TblFolderPrincipal);
            Name = "UcFolder";
            Size = new Size(895, 465);
            Load += UcFolder_Load;
            TblFolderPrincipal.ResumeLayout(false);
            grpTitleFolder.ResumeLayout(false);
            grpTitleFolder.PerformLayout();
            TblActionFolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GridFolder).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TblFolderPrincipal;
        private GroupBox grpTitleFolder;
        private TextBox TxtNameFolder;
        private Label LblNameFolder;
        private ComboBox CbxFiles;
        private TableLayoutPanel TblActionFolder;
        private Button BtnClearFolder;
        private Button BtnDeleteFolder;
        private DataGridView GridFolder;
        private Button BtnSave;
    }
}
