﻿using EasySave.Controllers;
using EasySave.Models;
using EasySave.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace EasySave.Views.BetterViews.Components
{
    public partial class SettingsMenu : UserControl
    {
        public List<String> CryptExtensionsList;
        public List<String> PriorityExtensionsList;
        public List<String> BusinessSoftwareList;
        public long KoSaved;

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
            UpdateLanguage();
        }

        private void SettingsMenu_Load(object sender, EventArgs e)
        {
            LoadCryptExtensions();
            LoadPriorityExtensions();
            LoadBusinessSoftware();
            LoadKoSaved();
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

        private void LoadKoSaved()
        {
            KoSaved = model.KoLimit;

            if (KoSaved == 100)
                Ko100.Checked = true;
            else if (KoSaved == 500)
                Ko500.Checked = true;
            else if (KoSaved == 1000)
                Ko1000.Checked = true;
            else if (KoSaved == 10000)
                Ko10000.Checked = true;
            else
            {
                KoMax.Checked = true;
                KoInput.Value = KoSaved;
            }
        }

        private void Ko100_CheckedChanged(object sender, EventArgs e)
        {
            controller.SetKoLimit(100);
        }

        private void Ko500_CheckedChanged(object sender, EventArgs e)
        {
            controller.SetKoLimit(500);
        }

        private void Ko1000_CheckedChanged(object sender, EventArgs e)
        {
            controller.SetKoLimit(1000);
        }

        private void Ko10000_CheckedChanged(object sender, EventArgs e)
        {
            controller.SetKoLimit(10000);
        }

        private void KoMax_CheckedChanged(object sender, EventArgs e)
        {
            KoInput.Enabled = true;
        }

        private void KoInput_ValueChanged(object sender, EventArgs e)
        {
           controller.SetKoLimit((long)KoInput.Value); 
        }

        private void UKButton_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("");
            ((BetterViewForm)ParentForm).UpdateLanguage();
            UpdateLanguage();
        }

        private void FRButton_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("fr-FR");
            ((BetterViewForm)ParentForm).UpdateLanguage();
            UpdateLanguage();
        }

        public void UpdateLanguage()
        {
            CryptLabel.Text = Resources.CryptLabel;
            CryptAdd.Text = Resources.CryptAdd;
            CryptRemove.Text = Resources.CryptRemove;
            PriorityLabel.Text = Resources.PriorityLabel;
            PriorityAdd.Text = Resources.PriorityAdd;
            PriorityRemove.Text = Resources.PriorityRemove;
            BusinessSoftwareLabel.Text = Resources.BusinessSoftwareLabel;
            BusinessSoftwareAdd.Text = Resources.BusinessSoftwareAdd;
            BusinessSoftwareRemove.Text = Resources.BusinessSoftwareRemove;
            LimitSizeLabel.Text = Resources.LimitSizeLabel;
            Ko100.Text = Resources.Ko100;
            Ko500.Text = Resources.Ko500;
            Ko1000.Text = Resources.Ko1000;
            Ko10000.Text = Resources.Ko10000;
            KoMax.Text = Resources.KoMax;
            UKButton.Text = Resources.UKButton;
            FRButton.Text = Resources.FRButton;
        }
    }
}
