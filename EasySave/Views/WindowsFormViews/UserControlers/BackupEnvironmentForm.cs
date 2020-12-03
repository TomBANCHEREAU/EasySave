using EasySave.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EasySave.Views.WindowsFormViews.UserControlers
{
    public partial class BackupEnvironmentForm : UserControl
    {
        public BackupEnvironmentForm()
        {
            InitializeComponent();
        }

        private void BackupEnvironmentForm_Load(object sender, EventArgs e)
        {

        }

        private void sourceDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog sd = new FolderBrowserDialog();
            if (sd.ShowDialog() == DialogResult.OK)
            {
                String sourceDirectory = sd.SelectedPath;
                sourceDirectoryTextbox.Text = sourceDirectory;
            }
        }

        private void destinationDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dd = new FolderBrowserDialog();
            if (dd.ShowDialog() == DialogResult.OK)
            {
                String destinationDirectory = dd.SelectedPath;
                destinationDirectoryTextbox.Text = destinationDirectory;
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            Regex rx = new Regex("^[a-zA-Z.]{2,30}$");
            if (rx.IsMatch(nameTextBox.Text))
            {
                if (!String.IsNullOrEmpty(sourceDirectoryTextbox.Text) && !String.IsNullOrEmpty(destinationDirectoryTextbox.Text))
                {
                    BackupEnvironment backupEnvironment = new BackupEnvironment(nameTextBox.Text, sourceDirectoryTextbox.Text, destinationDirectoryTextbox.Text);
                    GraphicalView.Controller.AddBackupEnvironment(backupEnvironment);
                    MessageBox.Show("The " + nameTextBox.Text + " environment has been created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GraphicalView.MainView.setViewState(GraphicalView.MainView.Main);
                }
                else
                {
                    MessageBox.Show("Information incorrect !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("The name format is incorrect !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void returnMenuButton_Click(object sender, EventArgs e)
        {
            GraphicalView.MainView.setViewState(GraphicalView.MainView.Main);
        }
    }
}
