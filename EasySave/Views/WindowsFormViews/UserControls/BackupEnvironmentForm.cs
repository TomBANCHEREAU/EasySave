using EasySave.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using EasySave.Properties;
using System.Threading;
using System.Globalization;

namespace EasySave.Views.WindowsFormViews.UserControls
{
    public partial class BackupEnvironmentForm : UserControl
    {
        public BackupEnvironmentForm()
        {
            InitializeComponent();

            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("fr-FR");
            nameLabel.Text = Resources.nameLabel;
            sourceDirectoryLabel.Text = Resources.sourceDirectoryLabel;
            destinationDirectoryLabel.Text = Resources.destinationDirectoryLabel;
            decriptionLabel.Text = Resources.decriptionLabel;
            confirmButton.Text = Resources.confirmButton;
            returnMenuButton.Text = Resources.returnMenuButton;
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
            if (nameTextBox.Text.Length >= 3 && nameTextBox.Text.Length <= 30)
            {
                if (!String.IsNullOrEmpty(sourceDirectoryTextbox.Text) && !String.IsNullOrEmpty(destinationDirectoryTextbox.Text))
                {
                    BackupEnvironment backupEnvironment = new BackupEnvironment(nameTextBox.Text, sourceDirectoryTextbox.Text, destinationDirectoryTextbox.Text);
                    GraphicalView.Controller.AddBackupEnvironment(backupEnvironment);
                    MessageBox.Show("The " + nameTextBox.Text + " environment has been created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GraphicalView.MainView.setViewState(GraphicalView.MainView.Main);
                    GraphicalView.MainView.Main.UpdateBackupList();
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

        private void returnMenuButton_Click_1(object sender, EventArgs e)
        {
            GraphicalView.MainView.setViewState(GraphicalView.MainView.Main);
        }
    }
}
