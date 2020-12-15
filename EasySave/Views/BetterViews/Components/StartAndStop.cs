using EasySave.Controllers;
using EasySave.Models;
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
        }

        private void StartAndStop_Load(object sender, EventArgs e)
        {
            this.Enabled = false;
            if (backupEnvironment == null)
                throw new ArgumentNullException();
            backupEnvironment.OnStateChange += Backup_OnStateChange;

        }


        private void Backup_OnStateChange(object sender, BackupEnvironment.BackupEnvironmentState e)
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
                if (last.Status.status == Backup.BackupStatus.PAUSED)
                    this.controller.ResumeBackup(backupEnvironment.runningBackup);
                else
                    this.controller.PauseBackup(backupEnvironment.runningBackup);
            }
        }
    }
}
