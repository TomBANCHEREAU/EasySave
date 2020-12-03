using EasySave.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EasySave.Views.WindowsFormViews.UserControlers
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void UpdateBackupList()
        {
            IReadOnlyList<BackupEnvironment> backupEnvironments = Program.Model.GetBackupEnvironments();
            listBackupEnvironments.Items.Clear();

            foreach (var backupEnvironment in backupEnvironments)
            {
                ListViewItem item = new ListViewItem();
                item.Tag = backupEnvironment;
                item.Text = backupEnvironment.Name;
                listBackupEnvironments.Items.Add(item);
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            UpdateBackupList();
        }

        private void listBackupEnvironments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBackupEnvironments.SelectedItems.Count == 1)
            {
                deleteBackupEnvironment.Enabled = true;
            } 
            else
            {
                deleteBackupEnvironment.Enabled = false;
            }
        }

        private void seachBar_TextChanged(object sender, EventArgs e)
        {

        }

        private void addBackupEnvironment_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void deleteBackupEnvironment_Click(object sender, EventArgs e)
        {
            Program.Controller.DeleteBackupEnvironment((BackupEnvironment)listBackupEnvironments.SelectedItems[0].Tag);
            UpdateBackupList();
        }
    }
}
