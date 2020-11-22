using EasySave.Controllers;
using EasySave.Models;
using EasySave.Views.ConsoleViews.ViewStates;
using System;
using System.Collections.Generic;
using System.Text;

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
            IViewState viewState = new MainMenu();
            while (viewState!=null)
                viewState = viewState.Execute(model, controller);
        }
    }
}
