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
            // model.OnEnvironmentListChange += (Object a, FileTransferEvent f) => { UpdateEnvironmentList(); };
        }

        internal void UpdateEnvironmentList()
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
    }
}
