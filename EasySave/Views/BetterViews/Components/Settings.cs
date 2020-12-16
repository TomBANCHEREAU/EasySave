using EasySave.Controllers;
using EasySave.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using EasySave.Properties;

namespace EasySave.Views.BetterViews.Components
{
    public partial class Settings : UserControl
    {
        internal IReadOnlyModel model;
        internal IController controller;

        public Settings()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("");
            UpdateLanguage();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            
        }

        private void RunMutipleBackupsButton_Click(object sender, EventArgs e)
        {
            ((BetterViewForm)ParentForm).SetViewState(new RunMultipleBackups(controller, model));
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            ProcessStartInfo UserDoc = new ProcessStartInfo();
            UserDoc.FileName = "User Doc.pdf";
            UserDoc.Verb = "OPEN";
            UserDoc.UseShellExecute = true;
            Process.Start(UserDoc);
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            ((BetterViewForm)ParentForm).SetViewState(new SettingsMenu(controller, model));
        }

        public void UpdateLanguage()
        {
            RunMutipleBackupsButton.Text = Resources.RunMutipleBackupsButton;
            SettingsButton.Text = Resources.SettingsButton;
            HelpButton.Text = Resources.HelpButton;
        }
    }
}
