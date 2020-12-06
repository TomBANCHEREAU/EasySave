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
            IReadOnlyList<Backup> backupList = selected.Backups;
            listBackups.Items.Clear();
         
            if (backupList.Count == 0)
            {
                GraphicalView.MainView.setViewState(GraphicalView.MainView.Main);
            }
            else
            {
                for (int i = 1; backupList.Count >= i; i++)
                 {
                     ListViewItem item = new ListViewItem();
                     item.Tag = backupList[i-1];
                     item.Text = i + ":" + backupList[i-1].ExecutionDate;
                     listBackups.Items.Add(item);
                 }
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

        private void restoreButton_Click(object sender, EventArgs e)
        {
            Backup backupToRestore = (Backup)listBackups.SelectedItems[0].Tag;
            GraphicalView.Controller.RestoreBackup(backupToRestore);
            GraphicalView.MainView.setViewState(GraphicalView.MainView.Main);
            MessageBox.Show("The restore of the backup has been done", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }

        private void returnMenuButton_Click_1(object sender, EventArgs e)
        {
            GraphicalView.MainView.setViewState(GraphicalView.MainView.Main);
        }
    }
}
