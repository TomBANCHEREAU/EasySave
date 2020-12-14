using EasySave.Controllers;
using EasySave.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EasySave.Views.BetterViews.Components
{
    public partial class CreateEnvironment : UserControl
    {
        private IReadOnlyModel model;
        private IController controller;

        public CreateEnvironment()
        {
            InitializeComponent();
        }

        private void CreateEnvironment_Load(object sender, EventArgs e)
        {
            // model = ((BetterViewForm)ParentForm).model;
            // controller = ((BetterViewForm)ParentForm).controller;
        }

        private void SourceDirectoryExplorer_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog sd = new FolderBrowserDialog();
            if (sd.ShowDialog() == DialogResult.OK)
            {
                String sourceDirectory = sd.SelectedPath;
                SourceDirectoryTextBox.Text = sourceDirectory;
            }
        }

        private void DestinationDirectoryExplorer_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dd = new FolderBrowserDialog();
            if (dd.ShowDialog() == DialogResult.OK)
            {
                String destinationDirectory = dd.SelectedPath;
                DestinationDirectoryTextBox.Text = destinationDirectory;
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text.Length >= 3 && NameTextBox.Text.Length <= 30)
            {
                if (!String.IsNullOrEmpty(SourceDirectoryTextBox.Text) && !String.IsNullOrEmpty(DestinationDirectoryTextBox.Text))
                {
                    BackupEnvironment backupEnvironment = new BackupEnvironment(NameTextBox.Text, SourceDirectoryTextBox.Text, DestinationDirectoryTextBox.Text);
                    controller.AddBackupEnvironment(backupEnvironment);
                    MessageBox.Show("The " + NameTextBox.Text + "envrionment has been created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ((BetterViewForm)ParentForm).SetViewState(BetterViewForm.ViewState.DEFAULT_VIEW);
                    // Refresh
                }
                else
                {
                    MessageBox.Show("Wrong Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Wrong Format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
