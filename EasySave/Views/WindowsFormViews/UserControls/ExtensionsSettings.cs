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
        public List<String> extensions;
        public ExtensionsSettings()
        {
            InitializeComponent();
        }

        private void ExtensionsSettings_Load(object sender, EventArgs e)
        {
            loadExtensions();
        }

        private void loadExtensions()
        {
            extensions = new List<string>(GraphicalView.Model.CryptedExtensions);
            extensionsList.Items.Clear();
            foreach (String item in extensions)
            {
                extensionsList.Items.Add(item);
            }
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

        private void add_Click(object sender, EventArgs e)
        {
            if (input.Text.Length>0)
            {
                String ext = input.Text.ToCharArray()[0] != '.' ? '.' + input.Text : input.Text;
                if (!extensions.Contains(ext))
                    extensions.Add(ext);
                GraphicalView.Controller.SetCryptedExtensions(extensions.ToArray());
            }
            loadExtensions();
        }

        private void remove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in extensionsList.SelectedItems)
            {
                extensions.Remove(item.Text);
            }
            GraphicalView.Controller.SetCryptedExtensions(extensions.ToArray());
            loadExtensions();
        }
    }
}
