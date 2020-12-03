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
            // IView view = new ConsoleView();
            IView view = new GraphicalView();
            IController controller = new Controller(model,view);
            controller.Start();
        }
    }
}
