namespace TomFilesDesktop
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tlpPrincipal = new TableLayoutPanel();
            tcPrincipal = new TabControl();
            tabFiles = new TabPage();
            tlpFilePrincipal = new TableLayoutPanel();
            grpTitle = new GroupBox();
            btnPathFile = new Button();
            txtPath = new TextBox();
            lblPath = new Label();
            txtName = new TextBox();
            lblName = new Label();
            tlpAction = new TableLayoutPanel();
            btnSave = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            gridFiles = new DataGridView();
            tabFolders = new TabPage();
            tlpPrincipal.SuspendLayout();
            tcPrincipal.SuspendLayout();
            tabFiles.SuspendLayout();
            tlpFilePrincipal.SuspendLayout();
            grpTitle.SuspendLayout();
            tlpAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridFiles).BeginInit();
            SuspendLayout();
            // 
            // tlpPrincipal
            // 
            tlpPrincipal.ColumnCount = 1;
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpPrincipal.Controls.Add(tcPrincipal, 0, 0);
            tlpPrincipal.Dock = DockStyle.Fill;
            tlpPrincipal.Location = new Point(0, 0);
            tlpPrincipal.Name = "tlpPrincipal";
            tlpPrincipal.RowCount = 1;
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpPrincipal.Size = new Size(909, 499);
            tlpPrincipal.TabIndex = 0;
            // 
            // tcPrincipal
            // 
            tcPrincipal.Controls.Add(tabFiles);
            tcPrincipal.Controls.Add(tabFolders);
            tcPrincipal.Dock = DockStyle.Fill;
            tcPrincipal.Location = new Point(3, 3);
            tcPrincipal.Name = "tcPrincipal";
            tcPrincipal.SelectedIndex = 0;
            tcPrincipal.Size = new Size(903, 493);
            tcPrincipal.TabIndex = 0;
            // 
            // tabFiles
            // 
            tabFiles.Controls.Add(tlpFilePrincipal);
            tabFiles.Location = new Point(4, 24);
            tabFiles.Name = "tabFiles";
            tabFiles.Padding = new Padding(3);
            tabFiles.Size = new Size(895, 465);
            tabFiles.TabIndex = 0;
            tabFiles.Text = "Files";
            tabFiles.UseVisualStyleBackColor = true;
            // 
            // tlpFilePrincipal
            // 
            tlpFilePrincipal.ColumnCount = 1;
            tlpFilePrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpFilePrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpFilePrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpFilePrincipal.Controls.Add(grpTitle, 0, 0);
            tlpFilePrincipal.Controls.Add(tlpAction, 0, 1);
            tlpFilePrincipal.Controls.Add(gridFiles, 0, 2);
            tlpFilePrincipal.Dock = DockStyle.Fill;
            tlpFilePrincipal.Location = new Point(3, 3);
            tlpFilePrincipal.Name = "tlpFilePrincipal";
            tlpFilePrincipal.RowCount = 3;
            tlpFilePrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 15.46841F));
            tlpFilePrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 7.18954229F));
            tlpFilePrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 77.34205F));
            tlpFilePrincipal.Size = new Size(889, 459);
            tlpFilePrincipal.TabIndex = 0;
            // 
            // grpTitle
            // 
            grpTitle.Controls.Add(btnPathFile);
            grpTitle.Controls.Add(txtPath);
            grpTitle.Controls.Add(lblPath);
            grpTitle.Controls.Add(txtName);
            grpTitle.Controls.Add(lblName);
            grpTitle.Dock = DockStyle.Fill;
            grpTitle.Location = new Point(3, 3);
            grpTitle.Name = "grpTitle";
            grpTitle.Size = new Size(883, 65);
            grpTitle.TabIndex = 0;
            grpTitle.TabStop = false;
            // 
            // btnPathFile
            // 
            btnPathFile.Location = new Point(839, 20);
            btnPathFile.Name = "btnPathFile";
            btnPathFile.Size = new Size(38, 23);
            btnPathFile.TabIndex = 4;
            btnPathFile.UseVisualStyleBackColor = true;
            btnPathFile.Click += btnPathFile_Click;
            // 
            // txtPath
            // 
            txtPath.BackColor = Color.White;
            txtPath.Location = new Point(223, 21);
            txtPath.Name = "txtPath";
            txtPath.ReadOnly = true;
            txtPath.Size = new Size(610, 23);
            txtPath.TabIndex = 3;
            // 
            // lblPath
            // 
            lblPath.AutoSize = true;
            lblPath.Location = new Point(183, 24);
            lblPath.Name = "lblPath";
            lblPath.Size = new Size(34, 15);
            lblPath.TabIndex = 2;
            lblPath.Text = "Path:";
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.Location = new Point(54, 21);
            txtName.Name = "txtName";
            txtName.Size = new Size(123, 23);
            txtName.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(6, 24);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // tlpAction
            // 
            tlpAction.ColumnCount = 4;
            tlpAction.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tlpAction.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlpAction.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlpAction.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlpAction.Controls.Add(btnSave, 1, 0);
            tlpAction.Controls.Add(btnClear, 2, 0);
            tlpAction.Controls.Add(btnDelete, 3, 0);
            tlpAction.Dock = DockStyle.Fill;
            tlpAction.Location = new Point(3, 74);
            tlpAction.Name = "tlpAction";
            tlpAction.RowCount = 1;
            tlpAction.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpAction.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpAction.Size = new Size(883, 27);
            tlpAction.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Fill;
            btnSave.Location = new Point(621, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 21);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Dock = DockStyle.Fill;
            btnClear.Location = new Point(709, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(82, 21);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Location = new Point(797, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(83, 21);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // gridFiles
            // 
            gridFiles.AllowUserToAddRows = false;
            gridFiles.AllowUserToDeleteRows = false;
            gridFiles.AllowUserToResizeColumns = false;
            gridFiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridFiles.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gridFiles.BackgroundColor = Color.White;
            gridFiles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridFiles.Dock = DockStyle.Fill;
            gridFiles.Location = new Point(3, 107);
            gridFiles.MultiSelect = false;
            gridFiles.Name = "gridFiles";
            gridFiles.ReadOnly = true;
            gridFiles.Size = new Size(883, 349);
            gridFiles.TabIndex = 2;
            gridFiles.CellDoubleClick += gridFiles_CellDoubleClick;
            // 
            // tabFolders
            // 
            tabFolders.Location = new Point(4, 24);
            tabFolders.Name = "tabFolders";
            tabFolders.Padding = new Padding(3);
            tabFolders.Size = new Size(895, 465);
            tabFolders.TabIndex = 1;
            tabFolders.Text = "Folders";
            tabFolders.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 499);
            Controls.Add(tlpPrincipal);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Files";
            Load += FrmPrincipal_Load;
            tlpPrincipal.ResumeLayout(false);
            tcPrincipal.ResumeLayout(false);
            tabFiles.ResumeLayout(false);
            tlpFilePrincipal.ResumeLayout(false);
            grpTitle.ResumeLayout(false);
            grpTitle.PerformLayout();
            tlpAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridFiles).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpPrincipal;
        private TabControl tcPrincipal;
        private TabPage tabFiles;
        private TabPage tabFolders;
        private TableLayoutPanel tlpFilePrincipal;
        private GroupBox grpTitle;
        private TextBox txtName;
        private Label lblName;
        private Button btnPathFile;
        private TextBox txtPath;
        private Label lblPath;
        private TableLayoutPanel tlpAction;
        private Button btnSave;
        private Button btnClear;
        private Button btnDelete;
        private DataGridView gridFiles;
    }
}
