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
    public partial class RunMultipleBackups : UserControl
    {
        private ListViewItem selected;

        private IController controller;
        private IReadOnlyModel model;

        public RunMultipleBackups(IController controller, IReadOnlyModel model) : this()
        {
            this.controller = controller;
            this.model = model;
        }

        public RunMultipleBackups()
        {
            InitializeComponent();
        }

        private void RunMultipleBackups_Load(object sender, EventArgs e)
        {
            IReadOnlyList<BackupEnvironment> backupEnvironments = model.GetBackupEnvironments();

            foreach (BackupEnvironment backupEnvironment in backupEnvironments)
            {
                ListViewItem listViewItem = new ListViewItem(new string[2] { 
                    backupEnvironment.Name, 
                    ""
                });
                listViewItem.Tag = backupEnvironment;

                if (backupEnvironment.IsRunning)
                {
                    listViewItem.SubItems[1].Tag = backupEnvironment;
                    listViewItem.SubItems[1].Text = "Already running";
                }

                EnvironmentList.Items.Add(listViewItem);
            }
        }

        private void EnvironmentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EnvironmentList.SelectedItems.Count > 0)
            {
                selected = EnvironmentList.SelectedItems[0];

                if (!(selected.SubItems[1].Tag is BackupEnvironment))
                {
                    NoBackupRadio.Checked = selected.SubItems[1].Tag == null;
                    FullBackupRadio.Checked = BackupType.FULL.CompareTo(selected.SubItems[1].Tag) == 0;
                    DifferentialBackupRadio.Checked = BackupType.DIFFERENTIAL.CompareTo(selected.SubItems[1].Tag) == 0;
                    NoBackupRadio.Enabled = true;
                    FullBackupRadio.Enabled = true;
                    DifferentialBackupRadio.Enabled = ((BackupEnvironment)selected.Tag).FullBackups.Count > 0;
                } 
                else
                {
                    FullBackupRadio.Enabled = false;
                    FullBackupRadio.Checked = false;
                    DifferentialBackupRadio.Enabled = false;
                    DifferentialBackupRadio.Checked = false;
                    NoBackupRadio.Enabled = false;
                    NoBackupRadio.Checked = true;
                }
            }
            else
            {
                selected = null;
            }
        }

        private void NoBackupRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (selected != null && NoBackupRadio.Checked)
            {
                selected.SubItems[1].Tag = null;
                selected.SubItems[1].Text = "No backup";
            }
        }

        private void FullBackupRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (selected != null && FullBackupRadio.Checked)
            {
                selected.SubItems[1].Tag = BackupType.FULL;
                selected.SubItems[1].Text = "Full";
            }
        }

        private void DifferentialBackupRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (selected != null && DifferentialBackupRadio.Checked)
            {
                selected.SubItems[1].Tag = BackupType.DIFFERENTIAL;
                selected.SubItems[1].Text = "Differential";
            }
        }

        private void RunMultipleBackupsButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in EnvironmentList.Items)
                try
                {
                    if (item.SubItems[1].Tag != null)
                        controller.RunBackup((BackupEnvironment)item.Tag, (BackupType)selected.SubItems[1].Tag);
                } 
                catch
                {
                    MessageBox.Show("A backup is already running on one of the environment you have selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
    }
}
