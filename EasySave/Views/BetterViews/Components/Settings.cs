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
    public partial class Settings : UserControl
    {
        private IReadOnlyModel model;
        private IController controller;

        public Settings()
        {
            InitializeComponent();
        }

        public Settings(IController controller, IReadOnlyModel model) : this()
        {
            this.controller = controller;
            this.model = model;
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void RunMutipleBackupsButton_Click(object sender, EventArgs e)
        {
            ((BetterViewForm)ParentForm).SetViewState(new RunMultipleBackups(controller, model));
        }
    }
}
