namespace TomFilesDesktop.UserControls
{
    partial class UcFile
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
            TlpFilePrincipal = new TableLayoutPanel();
            GrpTitle = new GroupBox();
            BtnPathFile = new Button();
            TxtPath = new TextBox();
            LblPath = new Label();
            TxtName = new TextBox();
            LblName = new Label();
            TlpAction = new TableLayoutPanel();
            BtnSave = new Button();
            BtnClear = new Button();
            BtnDelete = new Button();
            GridFiles = new DataGridView();
            TlpFilePrincipal.SuspendLayout();
            GrpTitle.SuspendLayout();
            TlpAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridFiles).BeginInit();
            SuspendLayout();
            // 
            // TlpFilePrincipal
            // 
            TlpFilePrincipal.ColumnCount = 1;
            TlpFilePrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TlpFilePrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            TlpFilePrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            TlpFilePrincipal.Controls.Add(GrpTitle, 0, 0);
            TlpFilePrincipal.Controls.Add(TlpAction, 0, 1);
            TlpFilePrincipal.Controls.Add(GridFiles, 0, 2);
            TlpFilePrincipal.Dock = DockStyle.Fill;
            TlpFilePrincipal.Location = new Point(0, 0);
            TlpFilePrincipal.Name = "TlpFilePrincipal";
            TlpFilePrincipal.RowCount = 3;
            TlpFilePrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 15.46841F));
            TlpFilePrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 8.278867F));
            TlpFilePrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 76.25272F));
            TlpFilePrincipal.Size = new Size(895, 465);
            TlpFilePrincipal.TabIndex = 1;
            // 
            // GrpTitle
            // 
            GrpTitle.Controls.Add(BtnPathFile);
            GrpTitle.Controls.Add(TxtPath);
            GrpTitle.Controls.Add(LblPath);
            GrpTitle.Controls.Add(TxtName);
            GrpTitle.Controls.Add(LblName);
            GrpTitle.Dock = DockStyle.Fill;
            GrpTitle.Location = new Point(3, 3);
            GrpTitle.Name = "GrpTitle";
            GrpTitle.Size = new Size(889, 65);
            GrpTitle.TabIndex = 0;
            GrpTitle.TabStop = false;
            // 
            // BtnPathFile
            // 
            BtnPathFile.Location = new Point(839, 20);
            BtnPathFile.Name = "BtnPathFile";
            BtnPathFile.Size = new Size(38, 23);
            BtnPathFile.TabIndex = 4;
            BtnPathFile.UseVisualStyleBackColor = true;
            BtnPathFile.Click += BtnPathFile_Click;
            // 
            // TxtPath
            // 
            TxtPath.BackColor = Color.White;
            TxtPath.Location = new Point(223, 21);
            TxtPath.Name = "TxtPath";
            TxtPath.ReadOnly = true;
            TxtPath.Size = new Size(610, 23);
            TxtPath.TabIndex = 3;
            // 
            // LblPath
            // 
            LblPath.AutoSize = true;
            LblPath.Location = new Point(183, 24);
            LblPath.Name = "LblPath";
            LblPath.Size = new Size(34, 15);
            LblPath.TabIndex = 2;
            LblPath.Text = "Path:";
            // 
            // TxtName
            // 
            TxtName.BackColor = Color.White;
            TxtName.Location = new Point(54, 21);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(123, 23);
            TxtName.TabIndex = 1;
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(6, 24);
            LblName.Name = "LblName";
            LblName.Size = new Size(42, 15);
            LblName.TabIndex = 0;
            LblName.Text = "Name:";
            // 
            // TlpAction
            // 
            TlpAction.ColumnCount = 4;
            TlpAction.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            TlpAction.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            TlpAction.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            TlpAction.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            TlpAction.Controls.Add(BtnSave, 1, 0);
            TlpAction.Controls.Add(BtnClear, 2, 0);
            TlpAction.Controls.Add(BtnDelete, 3, 0);
            TlpAction.Dock = DockStyle.Fill;
            TlpAction.Location = new Point(3, 74);
            TlpAction.Name = "TlpAction";
            TlpAction.RowCount = 1;
            TlpAction.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpAction.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TlpAction.Size = new Size(889, 32);
            TlpAction.TabIndex = 1;
            // 
            // BtnSave
            // 
            BtnSave.Dock = DockStyle.Fill;
            BtnSave.Location = new Point(625, 3);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(82, 26);
            BtnSave.TabIndex = 2;
            BtnSave.Text = "Save";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // BtnClear
            // 
            BtnClear.Dock = DockStyle.Fill;
            BtnClear.Location = new Point(713, 3);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(82, 26);
            BtnClear.TabIndex = 2;
            BtnClear.Text = "Clear";
            BtnClear.UseVisualStyleBackColor = true;
            BtnClear.Click += BtnClear_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Dock = DockStyle.Fill;
            BtnDelete.Location = new Point(801, 3);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(85, 26);
            BtnDelete.TabIndex = 2;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // GridFiles
            // 
            GridFiles.AllowUserToAddRows = false;
            GridFiles.AllowUserToDeleteRows = false;
            GridFiles.AllowUserToResizeColumns = false;
            GridFiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            GridFiles.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            GridFiles.BackgroundColor = Color.White;
            GridFiles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridFiles.Dock = DockStyle.Fill;
            GridFiles.Location = new Point(3, 112);
            GridFiles.MultiSelect = false;
            GridFiles.Name = "GridFiles";
            GridFiles.ReadOnly = true;
            GridFiles.Size = new Size(889, 350);
            GridFiles.TabIndex = 2;
            GridFiles.CellDoubleClick += GridFiles_CellDoubleClick;
            // 
            // UcFile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TlpFilePrincipal);
            Name = "UcFile";
            Size = new Size(895, 465);
            Load += UcFile_Load;
            TlpFilePrincipal.ResumeLayout(false);
            GrpTitle.ResumeLayout(false);
            GrpTitle.PerformLayout();
            TlpAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GridFiles).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TlpFilePrincipal;
        private GroupBox GrpTitle;
        private Button BtnPathFile;
        private TextBox TxtPath;
        private Label LblPath;
        private TextBox TxtName;
        private Label LblName;
        private TableLayoutPanel TlpAction;
        private Button BtnSave;
        private Button BtnClear;
        private Button BtnDelete;
        private DataGridView GridFiles;
    }
}
