using System;
using System.IO;
using System.Windows.Forms;

namespace FAS_Tool
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        #region Edit Mode
        private void cbEditMode_CheckedChanged(object sender, EventArgs e)
        {
            if(cbEditMode.Checked)
            {
                saveDisplay.ReadOnly = false;
            } else
            {
                saveDisplay.ReadOnly = true;
            }
        }
        #endregion

        #region Encrypt & Decrypt
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            saveDisplay.Text = Crypto.Decrypt(saveDisplay.Text);
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {    
            saveDisplay.Text = Crypto.Encrypt(saveDisplay.Text);
        }
        #endregion

        #region Open & Save
        private void btnOpen_Click(object sender, EventArgs e)
        {
            openSaveFile.ShowDialog();
            string save = openSaveFile.FileName;
            string savecontents = File.ReadAllText(save);
            saveDisplay.Text = savecontents;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveSaveFile.ShowDialog();
            string save = saveSaveFile.FileName;
            File.WriteAllText(save, saveDisplay.Text);
        }
        #endregion

        #region Open Forms
        private void btnBackupManager_Click(object sender, EventArgs e)
        {
            BackupForm backups = new BackupForm();
            backups.Show();
        }

        private void btnShowAbout_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.Show();
        }
        #endregion

    }
}
