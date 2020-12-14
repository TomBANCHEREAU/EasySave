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

        private void EnvironmentMenu_Load(object sender, EventArgs e)
        {
            // model = ((BetterViewForm)ParentForm).model;
            // controller = ((BetterViewForm)ParentForm).controller;

            UpdateBackupsList();

            if (selected.FullBackups.Count > 0)
            {
                DifferentialBackupButton.Enabled = true;
            }
            if (selected.Backups.Count == 0)
            {
                RestoreButton.Enabled = true;
            }
        }

        private void FullBackupButton_Click(object sender, EventArgs e)
        {
            Backup fullbackup = new Backup(selected, new FullBackupStrategy());

            try
            {
                controller.RunBackup(fullbackup);
                MessageBox.Show("The full backup has been done.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ((BetterViewForm)ParentForm).SetViewState(BetterViewForm.ViewState.DEFAULT_VIEW);
            }
            catch
            {
                MessageBox.Show("A bussiness has been detected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DifferentialBackupButton_Click(object sender, EventArgs e)
        {
            Backup fullbackup = selected.FullBackups[selected.FullBackups.Count - 1];
            BackupStrategy strategy = new DifferentialBackupStrategy(fullbackup);
            Backup differentialbackup = new Backup(selected, strategy);

            try
            {
                controller.RunBackup(differentialbackup);
                MessageBox.Show("The differential backup has been done.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ((BetterViewForm)ParentForm).SetViewState(BetterViewForm.ViewState.DEFAULT_VIEW);
            }
            catch
            {
                MessageBox.Show("A bussiness has been detected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RestoreButton_Click(object sender, EventArgs e)
        {
            Backup backupToRestore = (Backup)BackupsList.SelectedItems[0].Tag;
            controller.RestoreBackup(backupToRestore);
            ((BetterViewForm)ParentForm).SetViewState(BetterViewForm.ViewState.DEFAULT_VIEW);
            MessageBox.Show("The restoration has been done.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BackupsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BackupsList.SelectedItems.Count == 1)
            {
                RestoreButton.Enabled = true;
            }
            else
            {
                RestoreButton.Enabled = false;
            }
        }

        internal void UpdateBackupsList()
        {
            IReadOnlyList<Backup> backupList = selected.Backups;
            BackupsList.Items.Clear();

            if (BackupsList.Items.Count == 0)
            {
                BackupsList.Enabled = false;
            }
            else
            {
                BackupsList.Enabled = true;

                for (int i = 1; backupList.Count >= i; i++)
                {
                    ListViewItem item = new ListViewItem();
                    item.Tag = backupList[i - 1];
                    item.Text = i + ":" + backupList[i - 1].ExecutionDate;
                    BackupsList.Items.Add(item);
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            controller.DeleteBackupEnvironment((BackupEnvironment)selected);
            // EnvironmentList.EnvList.SelectedItems.Clear();
            // Refresh
        }
    }
}
