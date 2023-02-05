using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace Encryptor
{
    public partial class Form1 : Form
    {
        Encryptor encryptor;
        Button btnHide;
        bool onFileHover = false;
        bool isHideKey = false;

        bool OnFileHover
        {
            get
            {
                return onFileHover;
            }
            set
            {
                onFileHover = value;
                RefreshDragArea();
            }
        }
        bool IsHideKey
        {
            get
            {
                return isHideKey;
            }
            set
            {
                isHideKey = value;

                if (isHideKey)
                {
                    btnHide.Image = Properties.Resources.hide;
                    TextKey.PasswordChar = '*';
                }
                else
                {
                    btnHide.Image = Properties.Resources.show;
                    TextKey.PasswordChar = '\0';
                }
            }
        }
        public Form1()
        {
            InitializeComponent();

            encryptor = new Encryptor();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            Initialize();
        }

        void Initialize()
        {
            InitializeAddHideButton();
            IsHideKey = true;
            TextKey.Text = encryptor.Key;
            TextDirectory.Text = encryptor.Directory;

            LabelMessage("");
        }

        void InitializeAddHideButton()
        {
            var btn = new Button();
            btnHide = btn;

            btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn.Size = new Size(25, TextKey.ClientSize.Height + 2);
            btn.Location = new Point(TextKey.ClientSize.Width - btn.Width, -1);
            btn.Cursor = Cursors.Default;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = FlatStyle.Flat;
            btn.Image = Properties.Resources.hide;
            btn.Click += (sender, e) =>
            {
                IsHideKey = !IsHideKey;
            };
            TextKey.Controls.Add(btn);
        }

        void LabelMessage(string message, Color? color = null)
        {
            if (color is not null) LabelAlert.ForeColor = (Color)color;

            LabelAlert.Text = message;
        }

        void RefreshDragArea()
        {
            if (onFileHover) DropAreaPicture.Image = Properties.Resources.drag_and_drop_hover;
            else DropAreaPicture.Image = Properties.Resources.drag_and_drop;

            Refresh();
        }

        private void DropArea_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(new SolidBrush(this.BackColor), this.ClientRectangle);

            Color color;
            if (OnFileHover) color = Color.White;
            else color = Color.FromArgb(99, 103, 153);

            Panel panel = (Panel)sender;
            float width = (float)6.0;
            Pen pen = new(color, width)
            {
                DashStyle = DashStyle.Dot
            };
            e.Graphics.DrawLine(pen, 0, 0, 0, panel.Height - 0);
            e.Graphics.DrawLine(pen, 0, 0, panel.Width - 0, 0);
            e.Graphics.DrawLine(pen, panel.Width - 1, panel.Height - 1, 0, panel.Height - 1);
            e.Graphics.DrawLine(pen, panel.Width - 1, panel.Height - 1, panel.Width - 1, 0);
        }

        private void DropArea_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data!.GetData(DataFormats.FileDrop)!;

            onFileHover = false;
            
            foreach(var file in files)
            {
                ListViewItem item = new(file);
                FileListView.Items.Add(item);
            }

            OnFileHover = false;
        }

        private void DropArea_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;

            OnFileHover = true;
        }

        private void DropArea_DragLeave(object sender, EventArgs e)
        {
            OnFileHover = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            encryptor.SaveConfig();
        }

        private void TextKey_TextChanged(object sender, EventArgs e)
        {
            encryptor.Key = TextKey.Text;
        }

        private void TextDirectory_TextChanged(object sender, EventArgs e)
        {
            encryptor.Directory = TextDirectory.Text;
        }

        private void BtnImportKey_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new()
            {
                Filter = "Key (*.key)|*.key|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = dialog.FileName;
                encryptor.Key = File.ReadAllText(fileName);
                TextKey.Text = encryptor.Key;
            }
        }

        private void BtnExportKey_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new()
            {
                Filter = "Key (*.key)|*.key|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = dialog.FileName;
                File.WriteAllText(fileName, encryptor.Key);
            }
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            using FolderBrowserDialog dialog = new();
            dialog.SelectedPath = encryptor.Directory;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                encryptor.Directory = dialog.SelectedPath;
                TextDirectory.Text = dialog.SelectedPath;
            }
        }

        private void BtnEncrypt_Click(object sender, EventArgs e)
        {
            if (!InputValidation()) return;

            int total = 0;
            int fail = 0;
            var directory = encryptor.Directory;
            IterateFileNames((fullPath) => {
                var file = Path.GetFileName(fullPath);

                var encPath = $"{directory}\\{file}.enc";
                var success = encryptor.EncryptAndExport(fullPath, encPath);

                total++;
                if (!success) fail++;
            });

            FileListView.Items.Clear();
            LabelMessage($"Encrypt finished ({total} files, {fail} failed)", Color.Green);
        }

        private void BtnDecrypt_Click(object sender, EventArgs e)
        {
            if (!InputValidation()) return;

            int total = 0;
            int fail = 0;
            var directory = encryptor.Directory;
            IterateFileNames((fullPath) => {
                var file = Path.GetFileName(fullPath);

                var encPath = $"{directory}\\{TruncateExtEnc(file)}";
                var success = encryptor.DecryptAndExport(fullPath, encPath);

                total++;
                if (!success) fail++;
            });

            FileListView.Items.Clear();
            LabelMessage($"Decrypt finished ({total} files, {fail} failed)", Color.Green);
        }

        void IterateFileNames(Action<string> action)
        {
            foreach (var obj in FileListView.Items)
            {
                if (obj is not ListViewItem item) continue;

                action(item.Text);
            }
        }

        static string TruncateExtEnc(string filename)
        {
            if (filename.EndsWith(".enc"))
            {
                int length = filename.Length - 4;
                return filename[..length];
            }
            else
            {
                return filename;
            }
        }

        bool InputValidation()
        {
            var key = encryptor.Key;
            var directory = encryptor.Directory;
            if (key == "")
            {
                LabelMessage("Key is empty", Color.Red);
                return false;
            }
            else if (directory == "")
            {
                LabelMessage("Directory is empty", Color.Red);
                return false;
            }
            else if (!Directory.Exists(directory))
            {
                LabelMessage("Directory is not exists", Color.Red);
                return false;
            }
            else if (FileListView.Items.Count == 0)
            {
                LabelMessage("No files to process", Color.Red);
                return false;
            }


            if (directory.EndsWith(@"\"))
            {
                var length = directory.Length - 1;
                encryptor.Directory = directory[..length];
            }

            return true;
        }

        private void FileListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DropArea_Resize(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}