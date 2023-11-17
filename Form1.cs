using System.Data;
using System.Security.Cryptography;

namespace FileHasher
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            // Display the openFile dialog.
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtFolder.Text = folderBrowserDialog1.SelectedPath;

                List<FileInfoObj> fileInfoObjs = ListFiles().Select(f => new FileInfoObj(f)).ToList();

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter streamWriter = new StreamWriter(saveFileDialog1.FileName))
                    {
                        streamWriter.WriteLine(String.Format("FileName, Path, Hash"));
                        foreach (FileInfoObj fileInfoObj in fileInfoObjs)
                        {
                            streamWriter.WriteLine(fileInfoObj);
                        }
                    };

                    lblInfoDetails.Text = String.Format("Produced {0}", saveFileDialog1.FileName);
                }
            }
        }

        private string[] ListFiles()
        {
            return Directory.GetFiles(folderBrowserDialog1.SelectedPath, txtFilter.Text, SearchOption.AllDirectories);
        }

        /// <summary>
        /// Fine Information Object
        /// </summary>
        public class FileInfoObj
        {
            public string Path { get; private set; }
            public string FileName { get; private set; }
            public string FileHash { get; private set; }

            public FileInfoObj(string path)
            {
                Path = path;
                FileName = System.IO.Path.GetFileName(Path);
                FileHash = string.Empty;

                SHA256 Sha256 = SHA256.Create();

                using (FileStream stream = File.OpenRead(Path))
                {
                    byte[] hash = Sha256.ComputeHash(stream);
                    foreach (byte b in hash) FileHash += b.ToString("x2");
                }
            }
            /// <summary>
            /// To String Method
            /// </summary>
            /// <returns></returns>
            public override string ToString()
            {
                return String.Format("{0},{1},{2}", FileName, this.Path, FileHash);
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
