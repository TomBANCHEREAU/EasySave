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
using System.IO;

namespace EasySave.Views.WindowsFormViews.UserControls
{
    public partial class RestoreBackup : UserControl
    {
        internal BackupEnvironment selected;

        public RestoreBackup()
        {
            InitializeComponent();
        }

        public void changeLanguage()
        {
            returnMenuButton.Text = Resources.returnMenuButton;
            restore.Text = Resources.restoreBackup;
        }


        private void RestoreBackup_Load(object sender, EventArgs e)
        {
            UpdateBackupList();
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
                restore.Enabled = true;
            }
            else
            {
                restore.Enabled = false;
            }
        }

        private void returnMenuButton_Click(object sender, EventArgs e)
        {
            GraphicalView.MainView.setViewState(GraphicalView.MainView.Main);
        }

        private void restore_Click(object sender, EventArgs e)
        {
            if(restore.Enabled == true)
            {

            }
        }
    }
}
