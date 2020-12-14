using EasySave.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EasySave.Properties;
using System.Threading;
using System.Globalization;

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
                ListViewItem listViewItem = new ListViewItem(new string[2] { backupEnvironment.Name, "" });
                listViewItem.Tag = backupEnvironment;
                listEnvironments.Items.Add(listViewItem);
            }
        }

        public void changeLanguage()
        {
            Environments.Text = Resources.Environments;
            BackupType.Text = Resources.BackupType;            
            fullBackup.Text = Resources.fullBackup;
            differentialBackup.Text = Resources.differentialBackup;
            none.Text = Resources.none;
            runBackups.Text = Resources.runBackups;
            chooseBackupLabel.Text = Resources.chooseBackupLabel;
            returnMenuButton.Text = Resources.returnMenuButton;
        }

        private void returnMenuButton_Click(object sender, EventArgs e)
        {
            GraphicalView.MainView.setViewState(GraphicalView.MainView.Main);
        }

        private void listEnvironments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listEnvironments.SelectedItems.Count > 0)
            {
                selected = listEnvironments.SelectedItems[0];
                none.Checked = selected.SubItems[1].Text.Equals("None");
                fullBackup.Checked = selected.SubItems[1].Text.Equals("Full");
                differentialBackup.Checked = selected.SubItems[1].Text.Equals("Differential");
                differentialBackup.Enabled = ((BackupEnvironment)selected.Tag).FullBackups.Count > 0;
            }
            else
            {
                selected = null;
            }
        }

        private void none_CheckedChanged(object sender, EventArgs e)
        {
            if (selected != null && none.Checked)
            {
                if (Thread.CurrentThread.CurrentUICulture == CultureInfo.GetCultureInfo(""))
                {
                    selected.SubItems[1].Text = "None";
                }
                else
                {
                    selected.SubItems[1].Text = "Aucune";
                }
            }
        }

        private void fullBackup_CheckedChanged(object sender, EventArgs e)
        {
            if (selected != null && fullBackup.Checked)
            {
                if (Thread.CurrentThread.CurrentUICulture == CultureInfo.GetCultureInfo(""))
                {
                    selected.SubItems[1].Text = "Full";
                }
                else
                {
                    selected.SubItems[1].Text = "Complète";
                }
            }

        }

        private void differentialBackup_CheckedChanged(object sender, EventArgs e)
        {
            if (selected != null && differentialBackup.Checked)
            {
                if (Thread.CurrentThread.CurrentUICulture == CultureInfo.GetCultureInfo(""))
                {
                    selected.SubItems[1].Text = "Differential";
                }
                else
                {
                    selected.SubItems[1].Text = "Différentielle";
                }
            }
        }

        private void runBackups_Click(object sender, EventArgs e)
        {
            List<Backup> backups = new List<Backup>();
            foreach (ListViewItem item in listEnvironments.Items)
            {
                throw new Exception();
                /*String type = item.SubItems[1].Text;
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
                }*/
            }
            try
            {
                throw new Exception();
                //GraphicalView.Controller.RunMultipleBackup(backups);
                /*MessageBox.Show(Resources.mbRunMultipleBackup, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GraphicalView.MainView.setViewState(GraphicalView.MainView.Main);*/
            }
            catch
            {
                MessageBox.Show(Resources.mbBusinessSoftwware, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
