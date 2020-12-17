using EasySave.Models;
using EasySave.Views.BetterViews;
using EasySave.Views.BetterViews.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoteEasySave
{
    public partial class RemoteEasySave : Form
    {
        Client client;

        public object EnvList { get; private set; }

        public RemoteEasySave()
        {
            InitializeComponent();
        }
        public RemoteEasySave(Client client) : this()
        {
            this.client = client;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.client.OnStateChange += Client_OnStateChange;
            this.client.Start(); ;
        }

        private void Client_OnStateChange(object sender, List<BackupEnvironment.BackupEnvironmentState> e)
        {
            this.Invoke(new MethodInvoker(()=> {
                foreach (BackupEnvironment.BackupEnvironmentState item in e)
                {
                    ListViewItem listViewItem = null;
                    foreach (ListViewItem viewItem in listView1.Items)
                    {
                        if (viewItem.SubItems[0].Text == item.Name)
                        {
                            listViewItem = viewItem;
                        }
                    }
                    if (listViewItem==null)
                    {
                        listViewItem = new ListViewItem(new String[3] {
                                item.Name,
                                "-",
                                "-"
                            });
                        listViewItem.UseItemStyleForSubItems = false;
                        listView1.Items.Add(listViewItem);
                    }
                    listViewItem.Tag = item;
                    if (item.Running && item.Status != null)
                    {
                        switch (item.Status.status)
                        {
                            case Backup.BackupStatus.IDLE:
                                listViewItem.SubItems[1].ForeColor = Color.Black;
                                listViewItem.SubItems[1].Text = "-";
                                break;
                            case Backup.BackupStatus.RUNNING:
                                listViewItem.SubItems[1].ForeColor = Color.Green;
                                listViewItem.SubItems[1].Text = Resources.StatusRunning;
                                break;
                            case Backup.BackupStatus.PAUSED:
                                listViewItem.SubItems[1].ForeColor = Color.Orange;
                                listViewItem.SubItems[1].Text = Resources.StatusPaused;
                                break;
                            case Backup.BackupStatus.BLOCKED:
                                listViewItem.SubItems[1].ForeColor = Color.Orange;
                                listViewItem.SubItems[1].Text = Resources.StatusBlocked;
                                break;
                            default:
                                break;
                        }
                        listViewItem.SubItems[1].Tag = item.Status.status;
                        listViewItem.SubItems[2].Text = (int)item.Status.Progression + "%";
                    }
                    else
                    {
                        listViewItem.SubItems[1].Tag = null;
                        listViewItem.SubItems[1].ForeColor = Color.Black;
                        listViewItem.SubItems[1].Text = "-";
                        listViewItem.SubItems[2].Text = "-";
                    }
                }
                UpdateSelected();
            }));
        }

        private void UpdateSelected()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                BackupEnvironment.BackupEnvironmentState environmentState = (BackupEnvironment.BackupEnvironmentState)listView1.SelectedItems[0].Tag;
                this.pauseButton.Enabled = environmentState.Running && environmentState.Status != null && environmentState.Status.status != Backup.BackupStatus.PAUSED;
                this.resumeButton.Enabled = environmentState.Running && environmentState.Status != null && environmentState.Status.status == Backup.BackupStatus.PAUSED;
                this.cancelButton.Enabled = environmentState.Running;
                this.RunDiffButton.Enabled = !environmentState.Running;
                this.RunFullButton.Enabled = !environmentState.Running;
                this.progressBar1.Value = environmentState.Running && environmentState.Status != null ? (int)environmentState.Status.Progression : 0;
            }
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                client.PauseBackup(listView1.SelectedItems[0].SubItems[0].Text);
            }
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSelected();
        }

        private void resumeButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                client.ResumeBackup(listView1.SelectedItems[0].SubItems[0].Text);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                client.CancelBackup(listView1.SelectedItems[0].SubItems[0].Text);
            }
        }

        private void RunFullButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                client.RunFullBackup(listView1.SelectedItems[0].SubItems[0].Text);
            }
        }

        private void RunDiffButton_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {
                client.RunDiffBackup(listView1.SelectedItems[0].SubItems[0].Text);
            }
        }

        private void UKButton_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("");
            UpdateLanguage();
        }

        private void FRButton_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("fr-FR");
            UpdateLanguage();
        }

        public void UpdateLanguage()
        {
            EnvName.Text = Resources.EnvName;
            EnvStatus.Text = Resources.EnvSatus;
            EnvProgress.Text = Resources.EnvProgress;
            pauseButton.Text = Resources.pauseButton;
            resumeButton.Text = Resources.resumeButton;
            cancelButton.Text = Resources.cancelButton;
            RunFullButton.Text = Resources.RunFullButton;
            RunDiffButton.Text = Resources.RunDiffButton;
            UKButton.Text = Resources.UKButton;
            FRButton.Text = Resources.FRButton;
        }
    }
}
