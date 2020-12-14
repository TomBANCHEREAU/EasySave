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
    public partial class EnvironmentMenu : UserControl
    {
        internal BackupEnvironment selected;

        private IReadOnlyModel model;
        private IController controller;

        public EnvironmentMenu()
        {
            InitializeComponent();
        }

        public EnvironmentMenu(IController controller, IReadOnlyModel model, BackupEnvironment backupEnvironment) : this()
        {
            this.controller = controller;
            this.model = model;
            selected = backupEnvironment;
        }

        private void EnvironmentMenu_Load(object sender, EventArgs e)
        {
            UpdateBackupList();

            if (selected.FullBackups.Count > 0)
            {
                DifferentialBackupButton.Enabled = true;
            }
            if (selected.Backups.Count == 1)
            {
                RestoreButton.Enabled = true;
            }
        }

        private void FullBackupButton_Click(object sender, EventArgs e)
        {

            try
            {
                controller.RunBackup(selected,BackupType.FULL);
                MessageBox.Show("The full backup has been done.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ((BetterViewForm)ParentForm).SetViewState(new DefaultView(controller,model));
            }
            catch
            {
                MessageBox.Show("A bussiness has been detected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DifferentialBackupButton_Click(object sender, EventArgs e)
        {
            try
            {
                controller.RunBackup(selected,BackupType.DIFFERENTIAL);
                MessageBox.Show("The differential backup has been done.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ((BetterViewForm)ParentForm).SetViewState(new DefaultView(controller, model));
            }
            catch
            {
                MessageBox.Show("A bussiness has been detected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RestoreButton_Click(object sender, EventArgs e)
        {
            Backup backupToRestore = (Backup)BackupList.SelectedItems[0].Tag;
            controller.RestoreBackup(backupToRestore);
            ((BetterViewForm)ParentForm).SetViewState(new DefaultView(controller, model));
            MessageBox.Show("The restoration has been done.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BackupList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BackupList.SelectedItems.Count == 1)
            {
                RestoreButton.Enabled = true;
            }
            else
            {
                RestoreButton.Enabled = false;
            }
        }

        internal void UpdateBackupList()
        {
            BackupList.Items.Clear();

            foreach (Backup backup in selected.Backups)
            {
                String type = "No backup";

                if (backup.Type == BackupType.FULL)
                    type = "Full";
                if (backup.Type == BackupType.DIFFERENTIAL)
                    type = "Differential";

                ListViewItem item = new ListViewItem(new String[2] {
                    backup.ExecutionDate.ToString(),
                    type
                });
                item.Tag = backup;
                BackupList.Items.Add(item);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            controller.DeleteBackupEnvironment((BackupEnvironment)selected);
            // Refresh
        }
    }
}
