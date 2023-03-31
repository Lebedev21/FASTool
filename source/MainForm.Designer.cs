
namespace FAS_Tool
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowAbout = new System.Windows.Forms.Button();
            this.btnBackupManager = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.saveDisplay = new System.Windows.Forms.RichTextBox();
            this.cbEditMode = new System.Windows.Forms.CheckBox();
            this.saveSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.openSaveFile = new System.Windows.Forms.OpenFileDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShowAbout);
            this.groupBox1.Controls.Add(this.btnBackupManager);
            this.groupBox1.Controls.Add(this.btnEncrypt);
            this.groupBox1.Controls.Add(this.btnDecrypt);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tools";
            // 
            // btnShowAbout
            // 
            this.btnShowAbout.Location = new System.Drawing.Point(309, 32);
            this.btnShowAbout.Name = "btnShowAbout";
            this.btnShowAbout.Size = new System.Drawing.Size(80, 23);
            this.btnShowAbout.TabIndex = 4;
            this.btnShowAbout.Text = "About";
            this.btnShowAbout.UseVisualStyleBackColor = true;
            this.btnShowAbout.Click += new System.EventHandler(this.btnShowAbout_Click);
            // 
            // btnBackupManager
            // 
            this.btnBackupManager.Location = new System.Drawing.Point(184, 32);
            this.btnBackupManager.Name = "btnBackupManager";
            this.btnBackupManager.Size = new System.Drawing.Size(119, 23);
            this.btnBackupManager.TabIndex = 2;
            this.btnBackupManager.Text = "Backup Manager";
            this.btnBackupManager.UseVisualStyleBackColor = true;
            this.btnBackupManager.Click += new System.EventHandler(this.btnBackupManager_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(103, 32);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 1;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(22, 32);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 0;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(713, 415);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Browse...";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // saveDisplay
            // 
            this.saveDisplay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.saveDisplay.Cursor = System.Windows.Forms.Cursors.Default;
            this.saveDisplay.Location = new System.Drawing.Point(12, 98);
            this.saveDisplay.Name = "saveDisplay";
            this.saveDisplay.ReadOnly = true;
            this.saveDisplay.Size = new System.Drawing.Size(776, 311);
            this.saveDisplay.TabIndex = 1;
            this.saveDisplay.Text = "Save contents will be displayed here.";
            // 
            // cbEditMode
            // 
            this.cbEditMode.AutoSize = true;
            this.cbEditMode.Location = new System.Drawing.Point(12, 419);
            this.cbEditMode.Name = "cbEditMode";
            this.cbEditMode.Size = new System.Drawing.Size(99, 17);
            this.cbEditMode.TabIndex = 2;
            this.cbEditMode.Text = "Enable editing?";
            this.cbEditMode.UseVisualStyleBackColor = true;
            this.cbEditMode.CheckedChanged += new System.EventHandler(this.cbEditMode_CheckedChanged);
            // 
            // saveSaveFile
            // 
            this.saveSaveFile.DefaultExt = "dat";
            this.saveSaveFile.Filter = "DAT Files|*.dat|JSON Files|*.json|All Files|*.*";
            this.saveSaveFile.RestoreDirectory = true;
            this.saveSaveFile.Title = "Save a modified save file.";
            // 
            // openSaveFile
            // 
            this.openSaveFile.DefaultExt = "dat";
            this.openSaveFile.Filter = "DAT Files|*.dat|JSON Files|*.json|All Files|*.*";
            this.openSaveFile.RestoreDirectory = true;
            this.openSaveFile.Title = "Open a save file.";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(632, 415);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbEditMode);
            this.Controls.Add(this.saveDisplay);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FAS Multi-Tool (v 1.0)";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.RichTextBox saveDisplay;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnBackupManager;
        private System.Windows.Forms.CheckBox cbEditMode;
        private System.Windows.Forms.Button btnShowAbout;
        private System.Windows.Forms.SaveFileDialog saveSaveFile;
        private System.Windows.Forms.OpenFileDialog openSaveFile;
        private System.Windows.Forms.Button btnSave;
    }
}

