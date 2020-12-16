using EasySave.Controllers;
using EasySave.Models;
using EasySave.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EasySave.Views.BetterViews.Components
{
    public partial class StartAndStop : UserControl
    {

        internal IReadOnlyModel model;
        internal IController controller;
        internal BackupEnvironment backupEnvironment;
        internal BackupEnvironment.BackupEnvironmentState last;

        public StartAndStop()
        {
            InitializeComponent();
            UpdateLanguage();
            this.Enabled = false;
        }

        private void StartAndStop_Load(object sender, EventArgs e)
        {

        }

        public void Backup_OnStateChange(object sender, BackupEnvironment.BackupEnvironmentState e)
        {
            try
            {
                Invoke(new MethodInvoker(() => {
                    this.last = e;
                    this.Enabled = e.Running;
                    if (e.Running)
                    {
                        if (e.Status != null)
                        {
                            this.ProgressBar.Value = (int)e.Status.Progression;
                            this.PauseButton.Enabled = e.Status.status != Backup.BackupStatus.PAUSED;
                            this.ResumeButton.Enabled = e.Status.status == Backup.BackupStatus.PAUSED;

                        }
                    }
                    else
                    {
                        this.ProgressBar.Value = 0;
                    }
                }));
            }
            catch { }

        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            if (last != null && last.Running && last.Status!=null)
            {
                if (last.Status.status != Backup.BackupStatus.PAUSED)
                    this.controller.PauseBackup(backupEnvironment.runningBackup);
            }
        }

        private void ResumeButton_Click(object sender, EventArgs e)
        {
            if (last != null && last.Running && last.Status != null)
            {
                if (last.Status.status == Backup.BackupStatus.PAUSED)
                    this.controller.ResumeBackup(backupEnvironment.runningBackup);
            }
        }

        public void UpdateLanguage()
        {
            groupBox.Text = Resources.groupBox2;
            PauseButton.Text = Resources.PauseButton;
            ResumeButton.Text = Resources.ResumeButton;
            CancelButton.Text = Resources.CancelButton;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (last != null && last.Running && last.Status != null)
            {
                if (last.Status.status != Backup.BackupStatus.IDLE)
                    this.controller.CancelBackup(backupEnvironment.runningBackup);
            }
        }
    }
}
