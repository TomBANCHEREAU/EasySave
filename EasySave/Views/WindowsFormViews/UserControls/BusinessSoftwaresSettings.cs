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
    public partial class BusinessSoftwaresSettings : UserControl
    {
        public BusinessSoftwaresSettings()
        {
            InitializeComponent();
        }

        private void BusinessSoftwaresSettings_Load(object sender, EventArgs e)
        {

        }

        public void changeLanguage()
        {
            titleBusinessSoftwares.Text = Resources.titleBusinessSoftwares;
            subtitleBusinessSoftwares1.Text = Resources.subtitleBusinessSoftwares1;
            subtitleBusinessSoftwares2.Text = Resources.subtitleBusinessSoftwares2;
            returnMenuButton.Text = Resources.returnMenuButton;
        }

        private void returnMenuButton_Click(object sender, EventArgs e)
        {
            GraphicalView.MainView.setViewState(GraphicalView.MainView.Main);
        }
    }
}
