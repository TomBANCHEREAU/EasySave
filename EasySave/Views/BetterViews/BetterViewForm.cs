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
        public BetterViewForm(IController controller,IReadOnlyModel model)
        {
            this.model = model;
            this.controller = controller;
            InitializeComponent();
        }

        private void BetterViewForm_Load(object sender, EventArgs e)
        {

        }
    }
}
