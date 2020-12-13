using EasySave.Controllers;
using EasySave.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EasySave.Views.BetterViews
{
    public partial class BetterViewForm : Form
    {
        internal IReadOnlyModel model;
        internal IController controller;

        public BetterViewForm(IController controller, IReadOnlyModel model)
        {
            this.model = model;
            this.controller = controller;
            InitializeComponent();
        }

        private void BetterViewForm_Load(object sender, EventArgs e)
        {

        }

        internal enum ViewState { DEFAULT_VIEW, CREATE_ENVIRONMENT, ENVIRONMENT_MENU }

        internal void SetViewState(ViewState viewState)
        {
            foreach (var item in DynamicPanel.Controls)
            {
                if (item is UserControl)
                {
                    ((UserControl)item).Hide();
                }
            }

            switch (viewState)
            {
                case ViewState.DEFAULT_VIEW:
                    DefaultView.Show();
                    break;
                case ViewState.CREATE_ENVIRONMENT:
                    CreateEnvironment.Show();
                    break;
                case ViewState.ENVIRONMENT_MENU:
                    EnvironmentMenu.Show();
                    break;
                default:
                    break;
            }
        }

        private void Title_Click(object sender, EventArgs e)
        {
            SetViewState(BetterViewForm.ViewState.DEFAULT_VIEW);
        }
    }
}
