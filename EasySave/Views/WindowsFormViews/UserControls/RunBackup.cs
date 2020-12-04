using EasySave.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using EasySave.Properties;

namespace EasySave.Views.WindowsFormViews.UserControls
{
    public partial class RunBackup : UserControl
    {
        internal BackupEnvironment selected;

        public RunBackup()
        {
            InitializeComponent();
        }

        private void runBackup_Load(object sender, EventArgs e)
        {
            
        }

        public void changeLanguage()
        {
            chooseBackupLabel.Text = Resources.chooseBackupLabel;
            radioButton1.Text = Resources.radioButton1;
            radioButton2.Text = Resources.radioButton2;
            executeBackup.Text = Resources.executeBackup;
            button1.Text = Resources.button1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GraphicalView.MainView.setViewState(GraphicalView.MainView.Main);
        }

        private void executeBackup_Click(object sender, EventArgs e)
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
                if (selected.FullBackups.Count > 0)
                {
                    Backup fullbackup = selected.FullBackups[selected.FullBackups.Count - 1];
                    BackupStrategy strategy = new DifferentialBackupStrategy(fullbackup);
                    Backup differentialbackup = new Backup(selected, strategy);
                    selected.AddBackup(differentialbackup);
                    GraphicalView.Controller.RunBackup(differentialbackup);
                    GraphicalView.MainView.setViewState(GraphicalView.MainView.Main);
                    MessageBox.Show("The differential backup has been done", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("You first need to run a full backup !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            executeBackup.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            executeBackup.Enabled = true;
        }
    }
}
