﻿using EasySave.Controllers;
using EasySave.Models;
using EasySave.Properties;
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

        public CreateEnvironment(IController controller, IReadOnlyModel model) : this()
        {
            this.controller = controller;
            this.model = model;
        }

        public CreateEnvironment()
        {
            InitializeComponent();
            UpdateLanguage();
        }

        private void CreateEnvironment_Load(object sender, EventArgs e)
        {
            
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
                    MessageBox.Show(Resources.mbCreatedEnvironment1 + NameTextBox.Text + Resources.mbCreatedEnvironment2, Resources.mbTypeSuccess, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ((BetterViewForm)ParentForm).SetViewState(new EnvironmentMenu(controller,model, backupEnvironment));
                }
                else
                {
                    MessageBox.Show(Resources.mbWrongInformation, Resources.mbTypeError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(Resources.mbWrongFormat, Resources.mbTypeError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateLanguage()
        {
            CreateEnvironmentLabel.Text = Resources.CreateEnvironmentLabel;
            NameLabel.Text = Resources.NameLabel;
            SourceDirectoryLabel.Text = Resources.SourceDirectoryLabel;
            DestinationDirectoryLabel.Text = Resources.DestinationDirectoryLabel;
            CreateButton.Text = Resources.CreateButton;
        }
    }
}
