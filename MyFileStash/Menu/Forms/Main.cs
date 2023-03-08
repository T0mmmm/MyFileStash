using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static MyFileStash.Files.def.Vars;

namespace MyFileStash.Menu.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKey.Text) || string.IsNullOrWhiteSpace(txtSalt.Text) || string.IsNullOrWhiteSpace(txtIV.Text))
            {
                MessageBox.Show("Enter your keys for encryption and decryption.", "MyFileStash", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            strKey = txtKey.Text;
            strSalt = txtSalt.Text;
            strIV = txtIV.Text;

            var MyControl = new MyFileStash.Menu.UserControls.MainControl();
            pMain.Controls.Clear();
            pMain.Controls.Add(MyControl);
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            const string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();

            txtKey.Text = new string(Enumerable.Repeat(characters, 25).Select(s => s[random.Next(s.Length)]).ToArray());

            txtSalt.Text = new string(Enumerable.Repeat(characters, 16).Select(s => s[random.Next(s.Length)]).ToArray());

            txtIV.Text = new string(Enumerable.Repeat(characters, 16).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
