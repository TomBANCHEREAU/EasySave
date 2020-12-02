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
        [STAThread]
        static void Main(string[] args)
        {
            IModel model = new Model();
            IView view = new ConsoleView();
            IController controller = new Controller(model,view);
            controller.Start();
            /*Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainView());*/
        }
    }
}
