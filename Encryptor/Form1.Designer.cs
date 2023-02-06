namespace Encryptor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DropArea = new System.Windows.Forms.Panel();
            this.DropAreaPicture = new System.Windows.Forms.PictureBox();
            this.FileListView = new System.Windows.Forms.ListView();
            this.TextKey = new System.Windows.Forms.TextBox();
            this.LabelKey = new System.Windows.Forms.Label();
            this.LabelSaveAs = new System.Windows.Forms.Label();
            this.TextDirectory = new System.Windows.Forms.TextBox();
            this.BtnImportKey = new System.Windows.Forms.Button();
            this.BtnExportKey = new System.Windows.Forms.Button();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.BtnDecrypt = new System.Windows.Forms.Button();
            this.LabelAlert = new System.Windows.Forms.Label();
            this.BtnEncrypt = new System.Windows.Forms.Button();
            this.DropArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DropAreaPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // DropArea
            // 
            this.DropArea.AllowDrop = true;
            this.DropArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DropArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.DropArea.Controls.Add(this.DropAreaPicture);
            this.DropArea.Location = new System.Drawing.Point(33, 295);
            this.DropArea.Margin = new System.Windows.Forms.Padding(30);
            this.DropArea.Name = "DropArea";
            this.DropArea.Padding = new System.Windows.Forms.Padding(30);
            this.DropArea.Size = new System.Drawing.Size(487, 141);
            this.DropArea.TabIndex = 0;
            this.DropArea.DragDrop += new System.Windows.Forms.DragEventHandler(this.DropArea_DragDrop);
            this.DropArea.DragEnter += new System.Windows.Forms.DragEventHandler(this.DropArea_DragEnter);
            this.DropArea.DragLeave += new System.EventHandler(this.DropArea_DragLeave);
            this.DropArea.Paint += new System.Windows.Forms.PaintEventHandler(this.DropArea_Paint);
            this.DropArea.Resize += new System.EventHandler(this.DropArea_Resize);
            // 
            // DropAreaPicture
            // 
            this.DropAreaPicture.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DropAreaPicture.Image = global::Encryptor.Properties.Resources.drag_and_drop;
            this.DropAreaPicture.Location = new System.Drawing.Point(51, 33);
            this.DropAreaPicture.Name = "DropAreaPicture";
            this.DropAreaPicture.Size = new System.Drawing.Size(381, 75);
            this.DropAreaPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DropAreaPicture.TabIndex = 2;
            this.DropAreaPicture.TabStop = false;
            // 
            // FileListView
            // 
            this.FileListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(25)))));
            this.FileListView.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FileListView.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FileListView.Location = new System.Drawing.Point(33, 42);
            this.FileListView.Name = "FileListView";
            this.FileListView.Size = new System.Drawing.Size(487, 220);
            this.FileListView.TabIndex = 1;
            this.FileListView.UseCompatibleStateImageBehavior = false;
            this.FileListView.View = System.Windows.Forms.View.List;
            this.FileListView.SelectedIndexChanged += new System.EventHandler(this.FileListView_SelectedIndexChanged);
            // 
            // TextKey
            // 
            this.TextKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextKey.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextKey.Location = new System.Drawing.Point(33, 511);
            this.TextKey.Name = "TextKey";
            this.TextKey.Size = new System.Drawing.Size(487, 32);
            this.TextKey.TabIndex = 2;
            this.TextKey.TextChanged += new System.EventHandler(this.TextKey_TextChanged);
            // 
            // LabelKey
            // 
            this.LabelKey.AutoSize = true;
            this.LabelKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelKey.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelKey.ForeColor = System.Drawing.Color.Snow;
            this.LabelKey.Location = new System.Drawing.Point(33, 475);
            this.LabelKey.Name = "LabelKey";
            this.LabelKey.Size = new System.Drawing.Size(47, 28);
            this.LabelKey.TabIndex = 3;
            this.LabelKey.Text = "Key";
            // 
            // LabelSaveAs
            // 
            this.LabelSaveAs.AutoSize = true;
            this.LabelSaveAs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelSaveAs.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelSaveAs.ForeColor = System.Drawing.Color.Snow;
            this.LabelSaveAs.Location = new System.Drawing.Point(33, 617);
            this.LabelSaveAs.Name = "LabelSaveAs";
            this.LabelSaveAs.Size = new System.Drawing.Size(86, 28);
            this.LabelSaveAs.TabIndex = 4;
            this.LabelSaveAs.Text = "Save As";
            // 
            // TextDirectory
            // 
            this.TextDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextDirectory.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextDirectory.Location = new System.Drawing.Point(33, 653);
            this.TextDirectory.Name = "TextDirectory";
            this.TextDirectory.Size = new System.Drawing.Size(487, 32);
            this.TextDirectory.TabIndex = 5;
            this.TextDirectory.TextChanged += new System.EventHandler(this.TextDirectory_TextChanged);
            // 
            // BtnImportKey
            // 
            this.BtnImportKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnImportKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(77)))), ((int)(((byte)(115)))));
            this.BtnImportKey.FlatAppearance.BorderSize = 0;
            this.BtnImportKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImportKey.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnImportKey.ForeColor = System.Drawing.Color.Snow;
            this.BtnImportKey.Location = new System.Drawing.Point(284, 558);
            this.BtnImportKey.Name = "BtnImportKey";
            this.BtnImportKey.Size = new System.Drawing.Size(113, 39);
            this.BtnImportKey.TabIndex = 6;
            this.BtnImportKey.Text = "Import";
            this.BtnImportKey.UseVisualStyleBackColor = false;
            this.BtnImportKey.Click += new System.EventHandler(this.BtnImportKey_Click);
            // 
            // BtnExportKey
            // 
            this.BtnExportKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExportKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(77)))), ((int)(((byte)(115)))));
            this.BtnExportKey.FlatAppearance.BorderSize = 0;
            this.BtnExportKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExportKey.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnExportKey.ForeColor = System.Drawing.Color.Snow;
            this.BtnExportKey.Location = new System.Drawing.Point(407, 559);
            this.BtnExportKey.Name = "BtnExportKey";
            this.BtnExportKey.Size = new System.Drawing.Size(113, 39);
            this.BtnExportKey.TabIndex = 7;
            this.BtnExportKey.Text = "Export";
            this.BtnExportKey.UseVisualStyleBackColor = false;
            this.BtnExportKey.Click += new System.EventHandler(this.BtnExportKey_Click);
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(77)))), ((int)(((byte)(115)))));
            this.BtnBrowse.FlatAppearance.BorderSize = 0;
            this.BtnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBrowse.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnBrowse.ForeColor = System.Drawing.Color.Snow;
            this.BtnBrowse.Location = new System.Drawing.Point(407, 701);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(113, 39);
            this.BtnBrowse.TabIndex = 8;
            this.BtnBrowse.Text = "Browse";
            this.BtnBrowse.UseVisualStyleBackColor = false;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // BtnDecrypt
            // 
            this.BtnDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDecrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(77)))), ((int)(((byte)(115)))));
            this.BtnDecrypt.FlatAppearance.BorderSize = 0;
            this.BtnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDecrypt.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDecrypt.ForeColor = System.Drawing.Color.Snow;
            this.BtnDecrypt.Location = new System.Drawing.Point(297, 852);
            this.BtnDecrypt.Name = "BtnDecrypt";
            this.BtnDecrypt.Size = new System.Drawing.Size(223, 71);
            this.BtnDecrypt.TabIndex = 10;
            this.BtnDecrypt.Text = "Decrypt";
            this.BtnDecrypt.UseVisualStyleBackColor = false;
            this.BtnDecrypt.Click += new System.EventHandler(this.BtnDecrypt_Click);
            // 
            // LabelAlert
            // 
            this.LabelAlert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelAlert.AutoSize = true;
            this.LabelAlert.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelAlert.ForeColor = System.Drawing.Color.Snow;
            this.LabelAlert.Location = new System.Drawing.Point(4, 951);
            this.LabelAlert.Name = "LabelAlert";
            this.LabelAlert.Size = new System.Drawing.Size(134, 25);
            this.LabelAlert.TabIndex = 12;
            this.LabelAlert.Text = "Label Message";
            // 
            // BtnEncrypt
            // 
            this.BtnEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEncrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(77)))), ((int)(((byte)(115)))));
            this.BtnEncrypt.FlatAppearance.BorderSize = 0;
            this.BtnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEncrypt.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnEncrypt.ForeColor = System.Drawing.Color.Snow;
            this.BtnEncrypt.Location = new System.Drawing.Point(56, 852);
            this.BtnEncrypt.Name = "BtnEncrypt";
            this.BtnEncrypt.Size = new System.Drawing.Size(223, 71);
            this.BtnEncrypt.TabIndex = 13;
            this.BtnEncrypt.Text = "Encrypt";
            this.BtnEncrypt.UseVisualStyleBackColor = false;
            this.BtnEncrypt.Click += new System.EventHandler(this.BtnEncrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(551, 980);
            this.Controls.Add(this.BtnEncrypt);
            this.Controls.Add(this.LabelAlert);
            this.Controls.Add(this.BtnDecrypt);
            this.Controls.Add(this.BtnBrowse);
            this.Controls.Add(this.BtnExportKey);
            this.Controls.Add(this.BtnImportKey);
            this.Controls.Add(this.TextDirectory);
            this.Controls.Add(this.LabelSaveAs);
            this.Controls.Add(this.LabelKey);
            this.Controls.Add(this.TextKey);
            this.Controls.Add(this.FileListView);
            this.Controls.Add(this.DropArea);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.Text = "Encryptor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.OnLoad);
            this.DropArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DropAreaPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel DropArea;
        private PictureBox DropAreaPicture;
        private ListView FileListView;
        private TextBox TextKey;
        private Label LabelKey;
        private Label LabelSaveAs;
        private TextBox TextDirectory;
        private Button BtnImportKey;
        private Button BtnExportKey;
        private Button BtnBrowse;
        private Button BtnDecrypt;
        private Label LabelAlert;
        private Button BtnEncrypt;
    }
}