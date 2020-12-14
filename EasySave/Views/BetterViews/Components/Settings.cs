using EasySave.Controllers;
using EasySave.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EasySave.Views.BetterViews.Components
{
    public partial class Settings : UserControl
    {
        private IReadOnlyModel model;
        private IController controller;

        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            this.model = ((BetterViewForm)ParentForm).model;
            this.controller = ((BetterViewForm)ParentForm).controller;
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
            ((BetterViewForm)ParentForm).SetViewState(new SettingstMenu(controller, model));
        }
    }
}
