using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EasySave.Models;
using EasySave.Properties;

namespace EasySave.Views.WindowsFormViews.UserControls
{
    public partial class RestoreBackup : UserControl
    {
        internal BackupEnvironment selected;

        public RestoreBackup()
        {
            InitializeComponent();
        }

        private void RestoreBackup_Load(object sender, EventArgs e)
        {
            UpdateBackupList();
        }

        public void changeLanguage()
        {
            returnMenuButton.Text = Resources.returnMenuButton;
            restoreButton.Text = Resources.restoreButton;
        }

        internal void UpdateBackupList()
        {
            IReadOnlyList<BackupEnvironment> backupEnvironments = GraphicalView.Model.GetBackupEnvironments();
            listBackups.Items.Clear();

            foreach (var backup in selected.Backups)
            {
                ListViewItem item = new ListViewItem();
                item.Tag = backup;
                listBackups.Items.Add(item);
            }
        }
        private void listBackups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBackups.SelectedItems.Count == 1)
            {
                restoreButton.Enabled = true;
            }
            else
            {
                restoreButton.Enabled = false;
            }
        }

        private void returnMenuButton_Click(object sender, EventArgs e)
        {
            GraphicalView.MainView.setViewState(GraphicalView.MainView.Main);
        }

        private void restore_Click(object sender, EventArgs e)
        {
            if (restoreButton.Enabled == true)
            {

            }
        }
    }
}
