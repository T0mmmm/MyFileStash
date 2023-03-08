using System;
using System.Windows.Forms;
using static MyFileStash.Files.def.CryptoGraphy;
using static MyFileStash.Files.def.Vars;

namespace MyFileStash.Menu.UserControls
{
    public partial class MainControl : UserControl
    {
        public MainControl()
        {
            InitializeComponent();
            cbOptions.SelectedIndex = 0;
        }

        private void cbOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbOptions.SelectedIndex)
            {
                case 0:
                    btnRun.Text = "Encrypt";
                    Encrypt = true;
                    break;
                case 1:
                    btnRun.Text = "Decrypt";
                    Encrypt = false;
                    break;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Add files
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                ofd.Title = "Select the file that you want to encrypt or decrypt.";
                ofd.Multiselect = true;

                DialogResult result = ofd.ShowDialog();

                if (result == DialogResult.OK)
                {
                    MyFiles = ofd.FileNames;

                    foreach (string filename in ofd.SafeFileNames)
                    {
                        rtbOutPut.AppendText(filename + Environment.NewLine);
                    }
                }
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (Encrypt == true)
            {
                foreach (string path in MyFiles)
                {
                    EncryptFile(path);
                }
            }
            else
            {
                foreach (string path in MyFiles)
                {
                    DecryptFile(path);
                }
            }

        }
    }
}
