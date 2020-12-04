﻿using EasySave.Controllers;
using EasySave.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EasySave.Views.WindowsFormViews
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
            setViewState(Main);
        }

        internal void setViewState(UserControl state)
        {
            foreach (Control control in Controls)
            {
                if (control is UserControl)
                {
                    if (state != control)
                        control.Hide();
                    else
                        control.Show();
                }
            }
        }

        private void MainView_Load(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}