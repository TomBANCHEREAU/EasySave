using EasySave.Controllers;
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
    public partial class EnvironmentMenu : UserControl
    {
        internal BackupEnvironment selected;

        private IReadOnlyModel model;
        private IController controller;

        public EnvironmentMenu()
        {
            InitializeComponent();
            UpdateLanguage();
        }

        public EnvironmentMenu(IController controller, IReadOnlyModel model, BackupEnvironment backupEnvironment) : this()
        {
            this.controller = controller;
            this.model = model;
            selected = backupEnvironment;
            this.EnvNameLabel.Text += backupEnvironment.Name;
            this.SourceLabel.Text += backupEnvironment.SourceDirectory;
            this.DestinationLabel.Text += backupEnvironment.DestinationDirectory;

            if (this.startAndStop1==null)
                throw new Exception();
            this.startAndStop1.model = model;
            this.startAndStop1.controller = controller;
            this.startAndStop1.backupEnvironment = backupEnvironment;
            backupEnvironment.OnStateChange += this.startAndStop1.Backup_OnStateChange;
            backupEnvironment.OnStateChange += BackupEnvironment_OnStateChange; ;
        }

        private void BackupEnvironment_OnStateChange(object sender, BackupEnvironment.BackupEnvironmentState e)
        {
            Invoke(new MethodInvoker(() =>
            {
                FullBackupButton.Enabled = !e.Running;
                DifferentialBackupButton.Enabled = !e.Running;
            }));
        }

        private void EnvironmentMenu_Load(object sender, EventArgs e)
        {
            this.startAndStop1.Backup_OnStateChange(this, selected.currentState);
            RestoreButton.Enabled = false;
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
            controller.RunBackup(selected,BackupType.FULL);
            MessageBox.Show(Resources.mbFullBackup, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DifferentialBackupButton_Click(object sender, EventArgs e)
        {
            controller.RunBackup(selected,BackupType.DIFFERENTIAL);
            MessageBox.Show(Resources.mbDifferentialBackup, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RestoreButton_Click(object sender, EventArgs e)
        {
            Backup backupToRestore = (Backup)BackupList.SelectedItems[0].Tag;
            controller.RestoreBackup(backupToRestore);
            ((BetterViewForm)ParentForm).SetViewState(new DefaultView(controller, model));
            MessageBox.Show(Resources.mbRestore, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                String type = Resources.TypeNoBackup;

                if (backup.Type == BackupType.FULL)
                    type = Resources.TypeFull;
                if (backup.Type == BackupType.DIFFERENTIAL)
                    type = Resources.TypeDifferential;

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
            MessageBox.Show(Resources.mbDelete, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ((BetterViewForm)ParentForm).SetViewState(new DefaultView());
        }

        public void UpdateLanguage()
        {
            groupBox1.Text = Resources.groupBox1;
            EnvNameLabel.Text = Resources.NameLabel;
            SourceLabel.Text = Resources.SourceDirectoryLabel;
            DestinationLabel.Text = Resources.DestinationDirectoryLabel;
            FullBackupButton.Text = Resources.FullBackupButton;
            DifferentialBackupButton.Text = Resources.DifferentialBackupButton;
            DeleteButton.Text = Resources.DeleteButton;
            BackupColumn.Text = Resources.BackupColumn;
            TypeColumn.Text = Resources.TypeColumn;
            RestoreButton.Text = Resources.RestoreButton;
        }
    }
}
