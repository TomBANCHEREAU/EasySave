using EasySave.Controllers;
using EasySave.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EasySave.Views.BetterViews.Components
{
    public partial class SettingstMenu : UserControl
    {
        public List<String> extensions;
        public List<String> extensionsprio;
        public List<String> processes;
        private IReadOnlyModel model;
        private IController controller;

        public SettingstMenu(IController controller, IReadOnlyModel model) : this()
        {
            this.controller = controller;
            this.model = model;
        }

        public SettingstMenu()
        {
            InitializeComponent();
        }

        private void SettingstMenu_Load(object sender, EventArgs e)
        {
            loadExtensions();
            loadExtensionsPrio();
            loadProcesses();
        }

        private void input_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void loadExtensions()
        {
            extensions = new List<string>(model.CryptedExtensions);
            extensionsList.Items.Clear();
            foreach (String item in extensions)
            {
                extensionsList.Items.Add(item);
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (input.Text.Length > 0)
            {
                String ext = input.Text.ToCharArray()[0] != '.' ? '.' + input.Text : input.Text;
                if (!extensions.Contains(ext))
                    extensions.Add(ext);
               controller.SetCryptedExtensions(extensions.ToArray());
            }
            loadExtensions();
        }

        private void remove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in extensionsList.SelectedItems)
            {
                extensions.Remove(item.Text);
            }
           controller.SetCryptedExtensions(extensions.ToArray());
            loadExtensions();
        }

        private void inputPrio_TextChanged(object sender, EventArgs e)
        {

        }

        private void loadExtensionsPrio()
        {
            extensionsprio = new List<string>(model.HighPriorityExtensions);
            extensionsListPrio.Items.Clear();
            foreach (String item in extensionsprio)
            {
                extensionsListPrio.Items.Add(item);
            }
        }

        private void addPrio_Click(object sender, EventArgs e)
        {
            if (inputPrio.Text.Length > 0)
            {
                String ext = inputPrio.Text.ToCharArray()[0] != '.' ? '.' + inputPrio.Text : inputPrio.Text;
                if (!extensionsprio.Contains(ext))
                    extensionsprio.Add(ext);
                controller.SetHighPriorityExtensions(extensionsprio.ToArray());
            }
            loadExtensionsPrio();
        }

        private void removePrio_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in extensionsListPrio.SelectedItems)
            {
                extensionsprio.Remove(item.Text);
            }
            controller.SetHighPriorityExtensions(extensionsprio.ToArray());
            loadExtensionsPrio();
        }

        private void loadProcesses()
        {
            processes = new List<string>(model.BlockingProcesses);
            processesList.Items.Clear();
            foreach (String item in processes)
            {
                processesList.Items.Add(item);
            }
        }

        private void addBusiness_Click(object sender, EventArgs e)
        {
            if (inputbusiness.Text.Length > 0)
            {  
                String proc = inputbusiness.Text;
                if (!processes.Contains(proc))
                    processes.Add(proc);
                controller.SetBlockingProcesses(processes.ToArray());
            }
            loadProcesses();
        }

        private void removebusiness_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in processesList.SelectedItems)
            {
                processes.Remove(item.Text);
            }
            controller.SetBlockingProcesses(processes.ToArray());
            loadProcesses();
        }
       

        private void ko100_CheckedChanged(object sender, EventArgs e)
        {
            validateko.Enabled = true;
        }

        private void ko500_CheckedChanged(object sender, EventArgs e)
        {
            validateko.Enabled = true;
        }

        private void ko1000_CheckedChanged(object sender, EventArgs e)
        {
            validateko.Enabled = true;
        }

        private void ko10000_CheckedChanged(object sender, EventArgs e)
        {
            validateko.Enabled = true;
        }

        private void kochoose_CheckedChanged(object sender, EventArgs e)
        {
            inputko.Enabled = true;
        }

        

        private void inputko_ValueChanged(object sender, EventArgs e)
        {
            inputko.Minimum= 0;
        }

        private void validateko_Click(object sender, EventArgs e)
        {
            if (ko100.Checked)
            {
                controller.SetKoLimit(100);
            }
            else if (ko500.Checked)
            {
                controller.SetKoLimit(500);
            }
            else if (ko1000.Checked)
            {
                controller.SetKoLimit(1000);
            }
            else if (ko10000.Checked)
            {
                controller.SetKoLimit(10000);
            }
            else
            {
                controller.SetKoLimit((long)inputko.Value);
            }
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void businessSoftware_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void extensionsListPrio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void extensionsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelextensionsprio_Click(object sender, EventArgs e)
        {

        }
    
    }
}
