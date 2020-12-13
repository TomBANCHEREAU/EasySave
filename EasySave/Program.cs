using System;
using System.Threading;
using EasySave.Controllers;
using EasySave.Models;
using EasySave.Views;
using EasySave.Views.BetterViews;
using EasySave.Views.ConsoleViews;
using EasySave.Views.WindowsFormViews;

namespace EasySave
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            bool newInstance;
            Mutex mutex = new Mutex(false, "EasySave", out newInstance);

            if (!newInstance)
            {
                // EasySave is already running!
                return;
            }

            IModel model = new Model();
            // IView view = new ConsoleView();
            IView view = new BetterView();
            IController controller = new Controller(model, view);
            controller.Start();
        }
    }
}
