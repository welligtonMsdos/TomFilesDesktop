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
            TcPrincipal = new TabControl();
            TabFiles = new TabPage();
            TabFolders = new TabPage();
            tlpPrincipal.SuspendLayout();
            TcPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // tlpPrincipal
            // 
            tlpPrincipal.ColumnCount = 1;
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpPrincipal.Controls.Add(TcPrincipal, 0, 0);
            tlpPrincipal.Dock = DockStyle.Fill;
            tlpPrincipal.Location = new Point(0, 0);
            tlpPrincipal.Name = "tlpPrincipal";
            tlpPrincipal.RowCount = 1;
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpPrincipal.Size = new Size(909, 499);
            tlpPrincipal.TabIndex = 0;
            // 
            // TcPrincipal
            // 
            TcPrincipal.Controls.Add(TabFiles);
            TcPrincipal.Controls.Add(TabFolders);
            TcPrincipal.Dock = DockStyle.Fill;
            TcPrincipal.Location = new Point(3, 3);
            TcPrincipal.Name = "TcPrincipal";
            TcPrincipal.SelectedIndex = 0;
            TcPrincipal.Size = new Size(903, 493);
            TcPrincipal.TabIndex = 0;
            TcPrincipal.MouseClick += TcPrincipal_MouseClick;
            // 
            // TabFiles
            // 
            TabFiles.Location = new Point(4, 24);
            TabFiles.Name = "TabFiles";
            TabFiles.Padding = new Padding(3);
            TabFiles.Size = new Size(895, 465);
            TabFiles.TabIndex = 0;
            TabFiles.Text = "Files";
            TabFiles.UseVisualStyleBackColor = true;
            // 
            // TabFolders
            // 
            TabFolders.Location = new Point(4, 24);
            TabFolders.Name = "TabFolders";
            TabFolders.Padding = new Padding(3);
            TabFolders.Size = new Size(895, 465);
            TabFolders.TabIndex = 1;
            TabFolders.Text = "Folders";
            TabFolders.UseVisualStyleBackColor = true;
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
            TcPrincipal.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpPrincipal;
        private TabControl TcPrincipal;
        private TabPage TabFiles;
        private TabPage TabFolders;
    }
}
