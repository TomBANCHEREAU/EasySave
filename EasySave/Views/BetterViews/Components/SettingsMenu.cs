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
    public partial class SettingsMenu : UserControl
    {
        public List<String> CryptExtensionsList;
        public List<String> PriorityExtensionsList;
        public List<String> BusinessSoftwareList;

        private IReadOnlyModel model;
        private IController controller;

        public SettingsMenu(IController controller, IReadOnlyModel model) : this()
        {
            this.controller = controller;
            this.model = model;
        }

        public SettingsMenu()
        {
            InitializeComponent();
        }

        private void SettingsMenu_Load(object sender, EventArgs e)
        {
            LoadCryptExtensions();
            LoadPriorityExtensions();
            LoadBusinessSoftware();
        }

        private void LoadCryptExtensions()
        {
            CryptExtensionsList = new List<string>(model.CryptedExtensions);
            CryptListView.Items.Clear();

            foreach (String item in CryptExtensionsList)
                CryptListView.Items.Add(item);
        }

        private void CryptAdd_Click(object sender, EventArgs e)
        {
            if (CryptInput.Text.Length > 0)
            {
                String ext = CryptInput.Text.ToCharArray()[0] != '.' ? '.' + CryptInput.Text : CryptInput.Text;
                
                if (!CryptExtensionsList.Contains(ext))
                    CryptExtensionsList.Add(ext);
                controller.SetCryptedExtensions(CryptExtensionsList.ToArray());
            }
            LoadCryptExtensions();
        }

        private void CryptRemove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in CryptListView.SelectedItems)
                CryptExtensionsList.Remove(item.Text);

            controller.SetCryptedExtensions(CryptExtensionsList.ToArray());
            LoadCryptExtensions();
        }

        private void LoadPriorityExtensions()
        {
            PriorityExtensionsList = new List<string>(model.HighPriorityExtensions);
            PriorityListView.Items.Clear();

            foreach (String item in PriorityExtensionsList)
                PriorityListView.Items.Add(item);
        }

        private void PriorityAdd_Click(object sender, EventArgs e)
        {
            if (PriorityInput.Text.Length > 0)
            {
                String ext = PriorityInput.Text.ToCharArray()[0] != '.' ? '.' + PriorityInput.Text : PriorityInput.Text;
                
                if (!PriorityExtensionsList.Contains(ext))
                    PriorityExtensionsList.Add(ext);

                controller.SetHighPriorityExtensions(PriorityExtensionsList.ToArray());
            }
            LoadPriorityExtensions();
        }

        private void PriorityRemove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in PriorityListView.SelectedItems)
                PriorityExtensionsList.Remove(item.Text);

            controller.SetHighPriorityExtensions(PriorityExtensionsList.ToArray());
            LoadPriorityExtensions();
        }

        private void LoadBusinessSoftware()
        {
            BusinessSoftwareList = new List<string>(model.BlockingProcesses);
            BusinessSoftwareListView.Items.Clear();

            foreach (String item in BusinessSoftwareList)
                BusinessSoftwareListView.Items.Add(item);
        }

        private void BusinessSoftwareAdd_Click(object sender, EventArgs e)
        {
            if (BusinessSoftwareInput.Text.Length > 0)
            {
                String proc = BusinessSoftwareInput.Text;

                if (!BusinessSoftwareList.Contains(proc))
                    BusinessSoftwareList.Add(proc);

                controller.SetBlockingProcesses(BusinessSoftwareList.ToArray());
            }
            LoadBusinessSoftware();
        }

        private void BusinessSoftwareRemove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in BusinessSoftwareListView.SelectedItems)
                BusinessSoftwareList.Remove(item.Text);

            controller.SetBlockingProcesses(BusinessSoftwareList.ToArray());
            LoadBusinessSoftware();
        }

        private void LimitSizeConfirm_Click(object sender, EventArgs e)
        {
            if (Ko100.Checked)
                controller.SetKoLimit(100);
            else if (Ko500.Checked)
                controller.SetKoLimit(500);
            else if (Ko1000.Checked)
                controller.SetKoLimit(1000);
            else if (Ko10000.Checked)
                controller.SetKoLimit(10000);
            else
                controller.SetKoLimit((long)KoInput.Value);
        }
    }
}
