﻿using EasySave.Controllers;
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
            UpdateLanguage();
        }

        private void RunMultipleBackups_Load(object sender, EventArgs e)
        {
            IReadOnlyList<BackupEnvironment> backupEnvironments = model.GetBackupEnvironments();

            foreach (BackupEnvironment backupEnvironment in backupEnvironments)
            {
                ListViewItem listViewItem = new ListViewItem(new string[2] { 
                    backupEnvironment.Name, 
                    "-"
                });
                listViewItem.Tag = backupEnvironment;

                if (backupEnvironment.IsRunning)
                {
                    listViewItem.SubItems[1].Tag = 1;
                    listViewItem.SubItems[1].Text = Resources.TypeAlreadyRunning;
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
                    if (selected.SubItems[1].Tag is null)
                    {
                        NoBackupRadio.Checked = selected.SubItems[1].Tag == null;
                        NoBackupRadio.Checked = selected.SubItems[1].Text == Resources.TypeNoBackup;
                        NoBackupRadio.Checked = true;
                    }
                    else if (selected.SubItems[1].Text == Resources.TypeAlreadyRunning)
                    {
                        FullBackupRadio.Enabled = false;
                        FullBackupRadio.Checked = false;
                        DifferentialBackupRadio.Enabled = false;
                        DifferentialBackupRadio.Checked = false;
                        NoBackupRadio.Enabled = false;
                        NoBackupRadio.Checked = false;
                    }
                    else
                    {
                        FullBackupRadio.Checked = BackupType.FULL.CompareTo(selected.SubItems[1].Tag) == 0;
                        DifferentialBackupRadio.Checked = BackupType.DIFFERENTIAL.CompareTo(selected.SubItems[1].Tag) == 0;
                        NoBackupRadio.Enabled = true;
                        FullBackupRadio.Enabled = true;
                        DifferentialBackupRadio.Enabled = ((BackupEnvironment)selected.Tag).FullBackups.Count > 0;
                    }
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
            if (selected != null && NoBackupRadio.Checked && NoBackupRadio.Enabled)
            {
                selected.SubItems[1].Tag = null;
                selected.SubItems[1].Text = Resources.TypeNoBackup;
            }
        }

        private void FullBackupRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (selected != null && FullBackupRadio.Checked)
            {
                selected.SubItems[1].Tag = BackupType.FULL;
                selected.SubItems[1].Text = Resources.TypeFull;
            }
        }

        private void DifferentialBackupRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (selected != null && DifferentialBackupRadio.Checked)
            {
                selected.SubItems[1].Tag = BackupType.DIFFERENTIAL;
                selected.SubItems[1].Text = Resources.TypeDifferential;
            }
        }

        private void RunMultipleBackupsButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in EnvironmentList.Items)
                try
                {
                    if (item.SubItems[1].Tag != null && !((int)item.SubItems[1].Tag == 1))
                        controller.RunBackup((BackupEnvironment)item.Tag, (BackupType)item.SubItems[1].Tag);
                } 
                catch
                {
                    MessageBox.Show(Resources.mbRunMultipleBackups, Resources.mbTypeError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void UpdateLanguage()
        {
            RunMultipleBackupsLabel.Text = Resources.RunMultipleBackupsLabel;
            EnvironmentColumn.Text = Resources.EnvironmentColumn;
            TypeColumn.Text = Resources.TypeColumn;
            NoBackupRadio.Text = Resources.NoBackupRadio;
            FullBackupRadio.Text = Resources.FullBackupRadio;
            DifferentialBackupRadio.Text = Resources.DifferentialBackupRadio;
            RunMultipleBackupsButton.Text = Resources.RunMultipleBackupsButton;
        }
    }
}
