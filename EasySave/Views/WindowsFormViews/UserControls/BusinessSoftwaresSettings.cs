using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EasySave.Properties;

namespace EasySave.Views.WindowsFormViews.UserControls
{
    public partial class BusinessSoftwaresSettings : UserControl
    {
        public List<String> processes;

        public BusinessSoftwaresSettings()
        {
            InitializeComponent();
        }

        private void BusinessSoftwaresSettings_Load(object sender, EventArgs e)
        {
            loadProcesses();

        }

        private void loadProcesses()
        {
            processes = new List<string>(GraphicalView.Model.BlockingProcesses);
            processesList.Items.Clear();
            foreach (String item in processes)
            {
                processesList.Items.Add(item);
            }
        }

        public void changeLanguage()
        {
            titleBusinessSoftwares.Text = Resources.titleBusinessSoftwares;
            subtitleBusinessSoftwares1.Text = Resources.subtitleBusinessSoftwares1;
            subtitleBusinessSoftwares2.Text = Resources.subtitleBusinessSoftwares2;
            returnMenuButton.Text = Resources.returnMenuButton;
            add.Text = Resources.add;
            remove.Text = Resources.remove;
        }

        private void returnMenuButton_Click(object sender, EventArgs e)
        {
            GraphicalView.MainView.setViewState(GraphicalView.MainView.Main);
        }

        private void remove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in processesList.SelectedItems)
            {
                processes.Remove(item.Text);
            }
            GraphicalView.Controller.SetBlockingProcesses(processes.ToArray());
            loadProcesses();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (input.Text.Length > 0)
            {
                String proc = input.Text;
                if (!processes.Contains(proc))
                    processes.Add(proc);
                GraphicalView.Controller.SetBlockingProcesses(processes.ToArray());
            }
            loadProcesses();


        }
    }
}
