using EasySave.Controllers;
using EasySave.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace EasySave.Views.WindowsFormViews
{
    class GraphicalView : IView
    {
        private IReadOnlyModel model;
        public IReadOnlyModel Model
        {
            get => model;
        }
        public void SetModel(IReadOnlyModel model)
        {
            this.model = model;
        }

        public void Start(IReadOnlyModel model, IController controller)
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainView());
        }
    }
}
