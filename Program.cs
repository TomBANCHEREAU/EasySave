using System;
using System.Windows.Forms;
using EasySave.Controllers;
using EasySave.Models;
using EasySave.Views;
using EasySave.Views.ConsoleViews;
using EasySave.Views.WindowsFormViews;

namespace EasySave
{
    class Program
    {
        public static IReadOnlyModel Model;
        public static IController Controller;

        [STAThread]
        static void Main(string[] args)
        {
            IModel model = new Model();
            Model = model;
            // IView view = new ConsoleView();
            IView view = new GraphicalView();
            IController controller = new Controller(model,view);
            Controller = controller;
            controller.Start();
        }
    }
}
