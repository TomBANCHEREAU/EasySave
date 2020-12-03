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
        private static IReadOnlyModel model;

        public static IReadOnlyModel Model
        {
            get { return model; }
            private set { model = value; }
        }
        private static IController controller;

        public static IController Controller
        {
            get { return controller; }
            private set { controller = value; }
        }
        private static MainView view;

        public static MainView MainView
        {
            get { return view; }
            private set { view = value; }
        }

        public void Start(IReadOnlyModel model, IController controller)
        {
            if(Model!=null)
                throw new InvalidOperationException();
            Model = model;
            Controller = controller;
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainView = new MainView();
            Application.Run(MainView);
        }
    }
}
