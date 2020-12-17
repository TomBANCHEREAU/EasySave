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
        internal CultureInfo cultureInfo;

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
            Thread.CurrentThread.CurrentUICulture = this.cultureInfo;
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
                            item.SubItems[1].Text = Resources.StatusRunning;
                            break;
                        case Backup.BackupStatus.PAUSED:
                            item.SubItems[1].ForeColor = Color.Orange;
                            item.SubItems[1].Text = Resources.StatusPaused;
                            break;
                        case Backup.BackupStatus.BLOCKED:
                            item.SubItems[1].ForeColor = Color.Orange;
                            item.SubItems[1].Text = Resources.StatusBlocked;
                            break;
                        default:
                            break;
                    }
                    item.SubItems[2].Text = (int)backupEnvironment.runningBackup.currentState.Progression+"%";
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

        public void UpdateEnvironmentList()
        {
            EnvList.SelectedItems.Clear();
        }

        public void UpdateLanguage()
        {
            this.cultureInfo = Thread.CurrentThread.CurrentUICulture;
            AddButton.Text = Resources.AddButton;
            EnvName.Text = Resources.EnvName;
            statusCol.Text = Resources.statusCol;
            progressCol.Text = Resources.progressCol;
        }
    }
}
