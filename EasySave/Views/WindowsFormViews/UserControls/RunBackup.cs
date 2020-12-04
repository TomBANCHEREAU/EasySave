﻿using EasySave.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EasySave.Views.WindowsFormViews.UserControls
{
    public partial class RunBackup : UserControl
    {
        internal BackupEnvironment selected;

        public RunBackup()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GraphicalView.MainView.setViewState(GraphicalView.MainView.Main);
        }

        private void executeBackup_Click(object sender, EventArgs e)
        {
            if (selected != null)
            {
                if (radioButton1.Checked)
                {
                    Backup fullbackup = new Backup(selected, new FullBackupStrategy());
                    selected.AddBackup(fullbackup);
                    GraphicalView.Controller.RunBackup(fullbackup);
                    GraphicalView.MainView.setViewState(GraphicalView.MainView.Main);
                    MessageBox.Show("The full backup has been done", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (radioButton2.Checked)
                {
                    Backup fullbackup = selected.FullBackups[selected.FullBackups.Count-1];
                    BackupStrategy strategy = new DifferentialBackupStrategy(fullbackup);
                    Backup differentialbackup = new Backup(selected, strategy);
                    selected.AddBackup(differentialbackup);
                    GraphicalView.Controller.RunBackup(differentialbackup);
                    GraphicalView.MainView.setViewState(GraphicalView.MainView.Main);
                    MessageBox.Show("The differential backup has been done", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                executeBackup.Enabled = false;
            }
        }

        private void runBackup_Load(object sender, EventArgs e)
        {

        }
    }
}