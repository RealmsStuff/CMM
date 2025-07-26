namespace UnityModManager
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ListBox listBoxMods;
        private System.Windows.Forms.Button btnInstallMod;
        private System.Windows.Forms.Label labelGamePath;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnBrowse = new System.Windows.Forms.Button();
            listBoxMods = new System.Windows.Forms.ListBox();
            btnInstallMod = new System.Windows.Forms.Button();
            labelGamePath = new System.Windows.Forms.Label();
            textBoxDescription = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new System.Drawing.Point(12, 12);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new System.Drawing.Size(140, 23);
            btnBrowse.TabIndex = 0;
            btnBrowse.Text = "Browse Game Folder";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // listBoxMods
            // 
            listBoxMods.FormattingEnabled = true;
            listBoxMods.ItemHeight = 15;
            listBoxMods.Location = new System.Drawing.Point(12, 70);
            listBoxMods.Name = "listBoxMods";
            listBoxMods.Size = new System.Drawing.Size(360, 184);
            listBoxMods.TabIndex = 1;
            // 
            // btnInstallMod
            // 
            btnInstallMod.Location = new System.Drawing.Point(228, 12);
            btnInstallMod.Name = "btnInstallMod";
            btnInstallMod.Size = new System.Drawing.Size(144, 23);
            btnInstallMod.TabIndex = 2;
            btnInstallMod.Text = "Install Selected Mod";
            btnInstallMod.UseVisualStyleBackColor = true;
            btnInstallMod.Click += btnInstallMod_Click;
            // 
            // labelGamePath
            // 
            labelGamePath.AutoSize = true;
            labelGamePath.Location = new System.Drawing.Point(12, 44);
            labelGamePath.Name = "labelGamePath";
            labelGamePath.Size = new System.Drawing.Size(120, 15);
            labelGamePath.TabIndex = 3;
            labelGamePath.Text = "No game path set yet";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new System.Drawing.Point(378, 70);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.ReadOnly = true;
            textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            textBoxDescription.Size = new System.Drawing.Size(258, 184);
            textBoxDescription.TabIndex = 4;
            // 
            // Form1
            // 
            ClientSize = new System.Drawing.Size(648, 261);
            Controls.Add(textBoxDescription);
            Controls.Add(labelGamePath);
            Controls.Add(btnInstallMod);
            Controls.Add(listBoxMods);
            Controls.Add(btnBrowse);
            Name = "Form1";
            Text = "Captivity Mod Manager";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        private System.Windows.Forms.TextBox textBoxDescription;
    }
}
