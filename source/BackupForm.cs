using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace FAS_Tool
{
    public partial class BackupForm : Form
    {
        public BackupForm()
        {
            InitializeComponent();
        }

        private void BackupForm_Load(object sender, EventArgs e)
        {
            string defaultPath = @"C:\Users\" + Environment.UserName + @"\AppData\LocalLow\Please Be Patient\Finnish Army Simulator";
            try
            {
                ListDirectory(treeView1, defaultPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private static void ListDirectory(TreeView treeView, string path)
        {
            treeView.Nodes.Clear();

            var stack = new Stack<TreeNode>();
            var rootDirectory = new DirectoryInfo(path);
            var node = new TreeNode(rootDirectory.Name) { Tag = rootDirectory };
            stack.Push(node);

            while (stack.Count > 0)
            {
                var currentNode = stack.Pop();
                var directoryInfo = (DirectoryInfo)currentNode.Tag;
                foreach (var directory in directoryInfo.GetDirectories())
                {
                    var childDirectoryNode = new TreeNode(directory.Name) { Tag = directory };
                    currentNode.Nodes.Add(childDirectoryNode);
                    stack.Push(childDirectoryNode);
                }
                foreach (var file in directoryInfo.GetFiles())
                    currentNode.Nodes.Add(new TreeNode(file.Name));
            }

            treeView.Nodes.Add(node);
        }

        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            string defaultPath = @"C:\Users\" + Environment.UserName + @"\AppData\LocalLow\Please Be Patient\Finnish Army Simulator";
            try
            {
                ListDirectory(treeView1, defaultPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedFile = @"C:\Users\" + Environment.UserName + @"\AppData\LocalLow\Please Be Patient\Finnish Army Simulator\" + treeView1.SelectedNode.Text;
                File.Delete(selectedFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreateBackup_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedFile = @"C:\Users\" + Environment.UserName + @"\AppData\LocalLow\Please Be Patient\Finnish Army Simulator\" + treeView1.SelectedNode.Text;
                Random rnd = new Random();
                int randomNumber = rnd.Next();
                string fileName = "save.dat_backup_" + randomNumber;
                string backup = @"C:\Users\" + Environment.UserName + @"\AppData\LocalLow\Please Be Patient\Finnish Army Simulator\" + fileName;
                File.Copy(selectedFile, backup);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
