using EasySave.Controllers;
using EasySave.Models;
using EasySave.Views.ConsoleViews.ViewStates;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace EasySave.Views.ConsoleViews
{
    class ConsoleView : IView
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
            Console.WriteLine(File.ReadAllText("./start-message.txt"));
            IViewState viewState = new MainMenu();
            while (viewState!=null)
                viewState = viewState.Execute(model, controller);
            Console.Clear();
            Console.WriteLine(File.ReadAllText("./end-message.txt"));
            Thread.Sleep(5000);
        }
    }
}
