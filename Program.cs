using System;
using EasySave.Controllers;
using EasySave.Models;
using EasySave.Views;
using EasySave.Views.ConsoleViews;

namespace EasySave
{
    class Program
    {
        static void Main(string[] args)
        {
            IModel model = new Model();
            IView view = new ConsoleView();
            IController controller = new Controller(model,view);
            controller.Start();
        }
    }
}
