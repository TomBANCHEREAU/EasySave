using EasySave.Controllers;
using EasySave.Models;
using EasySave.Views.BetterViews.Components;
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
            this.EnvironmentList.model = model;
            this.EnvironmentList.controller = controller;
            this.Settings.model = model;
            this.Settings.controller = controller;
            MainLayout.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
        }

        private void BetterViewForm_Load(object sender, EventArgs e)
        {

        }

        internal void SetViewState(UserControl viewState)
        {
            this.MainLayout.Controls.Remove(this.DynamicPanel);
            this.DynamicPanel = viewState;

            this.DynamicPanel.SuspendLayout();
            this.SuspendLayout();
            this.MainLayout.Controls.Add(this.DynamicPanel, 1, 1);
            this.DynamicPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DynamicPanel.Location = new System.Drawing.Point(361, 136);
            this.DynamicPanel.Margin = new System.Windows.Forms.Padding(0);
            this.DynamicPanel.Name = "DynamicPanel";
            this.DynamicPanel.TabIndex = 1;
            this.DynamicPanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private void Title_Click(object sender, EventArgs e)
        {
            SetViewState(new DefaultView(controller,model));
        }
    }
}
