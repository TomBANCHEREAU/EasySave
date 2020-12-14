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
                EnvironmentList.Items.Add(listViewItem);
            }
        }

        private void EnvironmentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EnvironmentList.SelectedItems.Count > 0)
            {
                selected = EnvironmentList.SelectedItems[0];
                NoBackupRadio.Checked = selected.SubItems[1].Tag == null;
                FullBackupRadio.Checked = ((BackupType)selected.SubItems[1].Tag) == BackupType.FULL;
                DifferentialBackupRadio.Checked = ((BackupType)selected.SubItems[1].Tag) == BackupType.DIFFERENTIAL;
                DifferentialBackupRadio.Enabled = ((BackupEnvironment)selected.Tag).FullBackups.Count > 0;
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
                selected.SubItems[1].Tag = null;
                selected.SubItems[1].Text = "Full";
            }
        }

        private void DifferentialBackupRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (selected != null && DifferentialBackupRadio.Checked)
            {
                selected.SubItems[1].Tag = null;
                selected.SubItems[1].Text = "Differential";
            }
        }

        private void RunMultipleBackupsButton_Click(object sender, EventArgs e)
        {
            List<Backup> backups = new List<Backup>();

            foreach (ListViewItem item in EnvironmentList.Items)
            {
                throw new Exception();
                /*
                String type = item.SubItems[1].Text;

                if (type == "Full" || type == "Complète")
                {
                    Backup full = new Backup((BackupEnvironment)item.Tag, new FullBackup());
                    ((BackupEnvironment)item.Tag).AddBackup(full);
                    backups.Add(full);
                }
                else if (type == "Differential" || type == "Différentielle")
                {
                    BackupStrategy backupStrategy = new DifferentialBackupStrategy(((BackupEnvironment)item.Tag).FullBackups[((BackupEnvironment)item.Tag).FullBackups.Count - 1]);
                    Backup differential = new Backup((BackupEnvironment)item.Tag, backupStrategy);
                    ((BackupEnvironment)item.Tag).AddBackup(differential);
                    backups.Add(differential);
                }
                */
            }
            try
            {
                throw new Exception();
                /*
                GraphicalView.Controller.RunMultipleBackup(backups);
                MessageBox.Show(Resources.mbRunMultipleBackup, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GraphicalView.MainView.setViewState(GraphicalView.MainView.Main);
                */
            }
            catch
            {
                MessageBox.Show("A business software has been detected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
