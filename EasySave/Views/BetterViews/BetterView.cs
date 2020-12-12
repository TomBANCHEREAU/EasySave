using EasySave.Controllers;
using EasySave.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace EasySave.Views.BetterViews
{
    class BetterView : IView
    {
        public void Start(IReadOnlyModel model, IController controller)
        {
            /*if (Model != null)
                throw new InvalidOperationException();
            Model = model;
            Controller = controller;*/
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BetterViewForm(controller,model));
        }
    }
}
