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
    public partial class ExtensionsSettings : UserControl
    {
        public ExtensionsSettings()
        {
            InitializeComponent();
        }

        private void ExtensionsSettings_Load(object sender, EventArgs e)
        {

        }

        public void changeLanguage()
        {
            titleExtensions.Text = Resources.titleExtentions;
            subtitleExtentions.Text = Resources.subtitleExtentions;
            returnMenuButton.Text = Resources.returnMenuButton;
        }

        private void returnMenuButton_Click(object sender, EventArgs e)
        {
            GraphicalView.MainView.setViewState(GraphicalView.MainView.Main);
        }
    }
}
