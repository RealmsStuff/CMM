using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace UnityModManager
{
    public partial class Form1 : Form
    {
        string modsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Mods");
        string gamePathFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GamePath.txt");

        public Form1()
        {
            InitializeComponent();
            Directory.CreateDirectory(modsPath);
            LoadModList();
            LoadGamePath();
        }

        void LoadModList()
        {
            listBoxMods.Items.Clear();
            var modDirs = Directory.GetDirectories(modsPath).Select(Path.GetFileName);
            foreach (var mod in modDirs)
                listBoxMods.Items.Add(mod);
        }

        void LoadGamePath()
        {
            if (File.Exists(gamePathFile))
                labelGamePath.Text = File.ReadAllText(gamePathFile);
            else
                labelGamePath.Text = "No game path selected.";
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using var dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(gamePathFile, dialog.SelectedPath);
                labelGamePath.Text = dialog.SelectedPath;
            }
        }

        private void btnInstallMod_Click(object sender, EventArgs e)
        {
            if (listBoxMods.SelectedItem == null)
            {
                MessageBox.Show("Select a mod first.");
                return;
            }

            if (!File.Exists(gamePathFile))
            {
                MessageBox.Show("Set the game path first.");
                return;
            }

            string selectedMod = listBoxMods.SelectedItem.ToString();
            string gamePath = File.ReadAllText(gamePathFile);
            string modDir = Path.Combine(modsPath, selectedMod);

            foreach (var file in Directory.GetFiles(modDir, "*", SearchOption.AllDirectories))
            {
                string relativePath = Path.GetRelativePath(modDir, file); // keeps subfolders
                string destFile = Path.Combine(gamePath, relativePath);

                Directory.CreateDirectory(Path.GetDirectoryName(destFile)!);
                File.Copy(file, destFile, true);
            }


            MessageBox.Show($"Installed mod: {selectedMod}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
