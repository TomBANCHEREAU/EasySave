using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EasySave.Controllers;
using EasySave.Models;

namespace EasySave.Views.BetterViews.Components
{
    public partial class EnvironmentList : UserControl
    {
        private IReadOnlyModel model;
        private IController controller;
        public EnvironmentList()
        {
            InitializeComponent();
        }

        private void EnvironmentList_Load(object sender, EventArgs e)
        {
            model = ((BetterViewForm)ParentForm).model;
            controller = ((BetterViewForm)ParentForm).controller;
            UpdateEnvironmentList();
            //model.OnEnvironmentListChange += (Object a, FileTransferEvent f) => { UpdateEnvironmentList(); };
        }

        private void UpdateEnvironmentList()
        {
            Debug.WriteLine("UpdateEnvironmentList");
            this.EnvList.Items.Clear();
            foreach (BackupEnvironment backupEnvironment in model.GetBackupEnvironments())
            {
                ListViewItem item = new ListViewItem(new String[1] { 
                    backupEnvironment.Name 
                });
                item.Tag = backupEnvironment;
                this.EnvList.Items.Add(item);
            }
            Debug.WriteLine("UpdateEnvironmentList END");
        }
    }
}
