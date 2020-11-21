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
            set => model = value;
        }
        public void SetModel(IReadOnlyModel model)
        {
            Model = model;
        }

        public void Start()
        {
            IViewState viewState = new MainMenu();
            while (viewState!=null)
                viewState = viewState.Execute(this);
        }
    }
}
