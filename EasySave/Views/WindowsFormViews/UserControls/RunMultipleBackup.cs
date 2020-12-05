using EasySave.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EasySave.Views.WindowsFormViews.UserControls
{
    public partial class RunMultipleBackup : UserControl
    {
        private ListViewItem selected;
        public RunMultipleBackup()
        {
            InitializeComponent();
        }

        private void RunMultipleBackup_Load(object sender, EventArgs e)
        {
            IReadOnlyList<BackupEnvironment> backupEnvironments = GraphicalView.Model.GetBackupEnvironments();
            foreach (BackupEnvironment backupEnvironment in backupEnvironments)
            {
                ListViewItem listViewItem = new ListViewItem(new string[2] { backupEnvironment.Name, "none" });
                listViewItem.Tag = backupEnvironment;
                listEnvironments.Items.Add(listViewItem);
            }
        }

        private void returnMenuButton_Click(object sender, EventArgs e)
        {
            GraphicalView.MainView.setViewState(GraphicalView.MainView.Main);
        }

        private void listEnvironments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listEnvironments.SelectedItems.Count>0)
            {
                selected = listEnvironments.SelectedItems[0];
                none.Checked = selected.SubItems[1].Text.Equals("none");
                fullBackup.Checked = selected.SubItems[1].Text.Equals("full");
                differentialBackup.Checked = selected.SubItems[1].Text.Equals("differential");
                differentialBackup.Enabled = ((BackupEnvironment)selected.Tag).FullBackups.Count > 0;
            }
            else
            {
                selected = null;
            }
        }

        private void none_CheckedChanged(object sender, EventArgs e)
        {
            if (selected!=null && none.Checked)
            {
                selected.SubItems[1].Text = "none";
            }
        }

        private void fullBackup_CheckedChanged(object sender, EventArgs e)
        {
            if (selected != null && fullBackup.Checked)
            {
                selected.SubItems[1].Text = "full";
            }

        }

        private void differentialBackup_CheckedChanged(object sender, EventArgs e)
        {
            if (selected != null && differentialBackup.Checked)
            {
                selected.SubItems[1].Text = "differential";
            }

        }

        private void runBackups_Click(object sender, EventArgs e)
        {
            List<Backup> backups = new List<Backup>();
            foreach (ListViewItem item in listEnvironments.Items)
            {
                String type = item.SubItems[1].Text;
                if (type == "full")
                {
                    Backup full = new Backup((BackupEnvironment)item.Tag,new FullBackupStrategy());
                    ((BackupEnvironment)item.Tag).AddBackup(full);
                    backups.Add(full);
                }
                else if (type == "differential")
                {
                    BackupStrategy backupStrategy = new DifferentialBackupStrategy(((BackupEnvironment)item.Tag).FullBackups[((BackupEnvironment)item.Tag).FullBackups.Count - 1]);
                    Backup differential = new Backup((BackupEnvironment)item.Tag, backupStrategy);
                    ((BackupEnvironment)item.Tag).AddBackup(differential);
                    backups.Add(differential);
                }
            }
            GraphicalView.Controller.RunMultipleBackup(backups);
            GraphicalView.MainView.setViewState(GraphicalView.MainView.Main);
        }
    }
}
