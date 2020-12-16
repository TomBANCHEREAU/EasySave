using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using EasySave.Controllers;
using EasySave.Models;
using EasySave.Properties;

namespace EasySave.Views.BetterViews.Components
{
    public partial class EnvironmentList : UserControl
    {

        internal IReadOnlyModel model;
        internal IController controller;

        public EnvironmentList()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("");
            UpdateLanguage();
        }

        private void EnvironmentList_Load(object sender, EventArgs e)
        {
            UpdateEnvironmentList(null);
            model.OnEnvironmentStateChange += (Object a, IReadOnlyList<BackupEnvironment.BackupEnvironmentState> f) => {
                try
                {
                        this.Invoke(new MethodInvoker(()=>UpdateEnvironmentList(f)));
                }
                catch {}
            };
        }

        internal void UpdateEnvironmentList(IReadOnlyList<BackupEnvironment.BackupEnvironmentState> f)
        {
            if (f==null || f.Count != EnvList.Items.Count)
            {
                EnvList.Items.Clear();
                foreach (BackupEnvironment backupEnvironment in model.GetBackupEnvironments())
                {
                    ListViewItem item = new ListViewItem(new String[3] {
                        backupEnvironment.Name,"-","-"
                    });
                    item.Tag = backupEnvironment;
                    item.UseItemStyleForSubItems = false;
                    EnvList.Items.Add(item);

                }
            }
            foreach (ListViewItem item in EnvList.Items)
            {
                BackupEnvironment backupEnvironment = (BackupEnvironment)item.Tag;
                if (backupEnvironment.IsRunning)
                {
                    switch (backupEnvironment.runningBackup.currentState.status)
                    {
                        case Backup.BackupStatus.IDLE:
                            item.SubItems[1].ForeColor = Color.Black;
                            item.SubItems[1].Text = "-";
                            break;
                        case Backup.BackupStatus.RUNNING:
                            item.SubItems[1].ForeColor = Color.Green;
                            item.SubItems[1].Text = "Running";
                            break;
                        case Backup.BackupStatus.PAUSED:
                            item.SubItems[1].ForeColor = Color.Orange;
                            item.SubItems[1].Text = "Paused";
                            break;
                        case Backup.BackupStatus.BLOCKED:
                            item.SubItems[1].ForeColor = Color.Orange;
                            item.SubItems[1].Text = "Blocked";
                            break;
                        default:
                            break;
                    }
                    item.SubItems[2].Text = backupEnvironment.runningBackup.currentState.Progression+"%";
                }
                else
                {
                    item.SubItems[1].Text = "-";
                    item.SubItems[2].Text = "-";
                }
                //item.SubItems[1] = 
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ((BetterViewForm)ParentForm).SetViewState(new CreateEnvironment(controller,model));
        }

        private void EnvList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EnvList.SelectedItems.Count == 1)
            {
                ((BetterViewForm)ParentForm).SetViewState(new EnvironmentMenu(controller, model, (BackupEnvironment)EnvList.SelectedItems[0].Tag));
            }
            else
            {
                ((BetterViewForm)ParentForm).SetViewState(new DefaultView(controller, model));
            }
        }

        private void SearchInput_TextChanged(object sender, EventArgs e)
        {
            IReadOnlyList<BackupEnvironment> backupEnvironments = model.GetBackupEnvironments();
            EnvList.Items.Clear();

            if (string.IsNullOrEmpty(SearchInput.Text) == false)
            {
                foreach (var backupEnvironment in backupEnvironments)
                {
                    ListViewItem item = new ListViewItem();
                    item.Tag = backupEnvironment;
                    item.Text = backupEnvironment.Name;

                    if (item.Text.StartsWith(SearchInput.Text, StringComparison.InvariantCultureIgnoreCase))
                    {
                        EnvList.Items.Add(item);
                    }
                }
            }
            else if (SearchInput.Text == "")
            {
                foreach (var backupEnvironment in backupEnvironments)
                {
                    ListViewItem item = new ListViewItem();
                    item.Tag = backupEnvironment;
                    item.Text = backupEnvironment.Name;
                    EnvList.Items.Add(item);
                }
            }
        }

        public void UpdateLanguage()
        {
            SearchLabel.Text = Resources.SearchLabel;
            AddButton.Text = Resources.AddButton;
            EnvName.Text = Resources.EnvName;
            statusCol.Text = Resources.statusCol;
            progressCol.Text = Resources.progressCol;
        }
    }
}
