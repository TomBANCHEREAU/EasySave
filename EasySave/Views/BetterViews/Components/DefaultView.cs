using EasySave.Controllers;
using EasySave.Models;
using EasySave.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EasySave.Views.BetterViews.Components
{
    public partial class DefaultView : UserControl
    {
        private IController controller;
        private IReadOnlyModel model;

        public DefaultView(IController controller, IReadOnlyModel model) : this()
        {
            this.controller = controller;
            this.model = model;
        }

        public DefaultView()
        {
            InitializeComponent();
            UpdateLanguage();
        }


        private void DefaultView_Load(object sender, EventArgs e)
        {

        }

        public void UpdateLanguage()
        {
            WelcomeLabel.Text = Resources.WelcomeLabel;
            DefaultViewLabel.Text = Resources.DefaultViewLabel;
        }
    }
}
