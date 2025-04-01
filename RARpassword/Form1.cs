using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SharpCompress.Archives;
using SharpCompress.Archives.Rar;
using SharpCompress.Common;

namespace RARpassword
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool stopTocken = false;

        public string charactersselect() {
            string chara = "";
            if (simpleLetterCheck.Checked)
            {
                chara += "abcdefghijklmnopqrstuvwxyz";
            }
            if (capitalLetterCheck.Checked)
            {
                chara += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            }
            if (numberCheck.Checked)
            {
                chara += "0123456789";
            }
            if (spacialCharCheck.Checked)
            {
                chara += "!@#$%^&*()_+-=,./";
            }
            return chara;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void start_Click(object sender, EventArgs e)
        {
            stopTocken = false;

            await Task.Run(() =>
            {
                string rarFilePath = fileTxt.Text; // Replace with your RAR file path
                string extractionPath = extractTxt.Text; // Replace with your extraction path
                string characters = charactersselect(); // Characters to try
                int maxPasswordLength = int.Parse(maxLengthText.Text); // Maximum password length to try
                int minPasswordLength = int.Parse(minLengthText.Text); // Minimum password length to try

                for (int length = minPasswordLength; length <= maxPasswordLength; length++)
                {
                    if (stopTocken)
                    {
                        break;
                    }
                    GeneratePasswords(characters, length, "", rarFilePath,extractionPath);
                }
            });

        }
        public void GeneratePasswords(string characters, int length, string currentPassword, string rarFilePath ,string extractionPath)
        {
            if (length == 0)
            {
                TryPassword(currentPassword, rarFilePath, extractionPath);
                return;
            }

            for (int i = 0; i < characters.Length; i++)
            {
                if (stopTocken)
                {
                    break;
                }
                GeneratePasswords(characters, length - 1, currentPassword + characters[i], rarFilePath, extractionPath);
            }
        }

        public void TryPassword(string password, string rarFilePath, string extractionPath)
        {
            if (stopTocken)
            {
                return;
            }
            try
            {
                this.Invoke(new Action(() => { tryPass.Text = password; }));
                using (var archive = RarArchive.Open(rarFilePath, new SharpCompress.Readers.ReaderOptions() { Password = password }))
                {
                    foreach (var entry in archive.Entries.Where(entry => !entry.IsDirectory))
                    {
                        entry.WriteToDirectory(extractionPath, new ExtractionOptions()
                        {
                            ExtractFullPath = true,
                            Overwrite = true
                        });
                    }
                }
                this.Invoke(new Action(() =>
                {
                    DialogResult result = MessageBox.Show($"Password found: {password}", "Password Found", MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                }));
            }
            catch (SharpCompress.Common.CryptographicException)
            {
                // Incorrect password
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private void fileDestination_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "RAR files (*.rar)|*.rar";
                openFileDialog.Title = "Select a RAR file";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileTxt.Text = openFileDialog.FileName;
                }
            }
        }
        private void extractDestination_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Select a folder to extract the RAR file";

                DialogResult result = folderBrowserDialog.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    extractTxt.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void stopbtn_Click(object sender, EventArgs e)
        {
            stopTocken = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }

}