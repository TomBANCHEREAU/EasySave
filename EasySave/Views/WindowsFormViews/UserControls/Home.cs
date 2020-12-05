using EasySave.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using EasySave.Properties;

namespace EasySave.Views.WindowsFormViews.UserControls
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            UpdateBackupList();
        }

        public void changeLanguage()
        {
            searchBarLabel.Text = Resources.searchBarLabel;
            addBackupEnvironment.Text = Resources.addBackupEnvironment;
            deleteBackupEnvironment.Text = Resources.deleteBackupEnvironment;
            runBackup.Text = Resources.runBackup;
            settingsLabel.Text = Resources.settingsLabel;
            businessSoftwaresButton.Text = Resources.businessSoftwaresButton;
            filesToEncryptButton.Text = Resources.filesToEncryptButton;
            restoreBackup.Text = Resources.restoreBackup;
            runMultipleBackup.Text = Resources.runMultipleBackup;
            EnvironmentName.Text = Resources.EnvironmentName;
        }

        internal void UpdateBackupList()
        {
            IReadOnlyList<BackupEnvironment> backupEnvironments = GraphicalView.Model.GetBackupEnvironments();
            listBackupEnvironments.Items.Clear();

            foreach (var backupEnvironment in backupEnvironments)
            {
                ListViewItem item = new ListViewItem();
                item.Tag = backupEnvironment;
                item.Text = backupEnvironment.Name;
                listBackupEnvironments.Items.Add(item);
            }
        }

        private void listBackupEnvironments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBackupEnvironments.SelectedItems.Count == 1)
            {
                deleteBackupEnvironment.Enabled = true;
                runBackup.Enabled = true;
            }
            else
            {
                deleteBackupEnvironment.Enabled = false;
                runBackup.Enabled = false;
            }
        }

        private void seachBar_TextChanged(object sender, EventArgs e)
        {
            
            IReadOnlyList<BackupEnvironment> backupEnvironments = GraphicalView.Model.GetBackupEnvironments();
            listBackupEnvironments.Items.Clear();

            if (string.IsNullOrEmpty(seachBar.Text) == false)
            {
                foreach (var backupEnvironment in backupEnvironments)
                {
                    ListViewItem item = new ListViewItem();
                    item.Tag = backupEnvironment;
                    item.Text = backupEnvironment.Name;

                    if (item.Text.StartsWith(seachBar.Text, StringComparison.InvariantCultureIgnoreCase))
                    {
                        listBackupEnvironments.Items.Add(item);
                    }
                }
            }
            else if (seachBar.Text == "")
            {
                foreach (var backupEnvironment in backupEnvironments)
                {
                    ListViewItem item = new ListViewItem();
                    item.Tag = backupEnvironment;
                    item.Text = backupEnvironment.Name;
                    listBackupEnvironments.Items.Add(item);
                }
            }
            
        }

        private void addBackupEnvironment_Click(object sender, EventArgs e)
        {
            GraphicalView.MainView.setViewState(GraphicalView.MainView.backupEnvironmentForm);
        }

        private void deleteBackupEnvironment_Click(object sender, EventArgs e)
        {
            GraphicalView.Controller.DeleteBackupEnvironment((BackupEnvironment)listBackupEnvironments.SelectedItems[0].Tag);
            listBackupEnvironments.SelectedItems.Clear();
            UpdateBackupList();
        }

        private void runBackup_Click(object sender, EventArgs e)
        {
            GraphicalView.MainView.runBackup.selected = (BackupEnvironment)listBackupEnvironments.SelectedItems[0].Tag;
            GraphicalView.MainView.setViewState(GraphicalView.MainView.runBackup);

        }

        private void businessSoftwaresButton_Click(object sender, EventArgs e)
        {
            GraphicalView.MainView.setViewState(GraphicalView.MainView.businessSoftwaresSettings);
        }

        private void filesToEncryptButton_Click(object sender, EventArgs e)
        {
            GraphicalView.MainView.setViewState(GraphicalView.MainView.extensionsSettings);
        }

        private void runMultipleBackup_Click(object sender, EventArgs e)
        {
            GraphicalView.MainView.setViewState(GraphicalView.MainView.runMultipleBackup);
        }

        private void restoreBackup_Click(object sender, EventArgs e)
        {
            GraphicalView.MainView.setViewState(GraphicalView.MainView.restoreBackup);
        }
    }
}
