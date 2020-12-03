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
            Console.WriteLine(@"
              ___                        _  _                                         
     o O O   | __|    __ _      ___     | || |                                        
    o        | _|    / _` |    (_-<      \_, |                                        
   TS__[O]   |___|   \__,_|    /__/_    _|__/                                         
  {======| _|'''''| _|'''''| _|'''''| _|'''''|                                        
 ./o--000' '`-0-0-' '`-0-0-' '`-0-0-' '`-0-0-'                                        
                                                     ___                              
                                            o O O   / __|    __ _     __ __     ___   
                                           o        \__ \   / _` |    \ V /    / -_)  
                                          TS__[O]   |___/   \__,_|    _\_/_    \___|  
                                         {======| _|'''''| _|'''''| _|'''''| _|'''''| 
                                        ./o--000' '`-0-0-' '`-0-0-' '`-0-0-' '`-0-0-' ");
            IViewState viewState = new MainMenu();
            while (viewState!=null)
                viewState = viewState.Execute(model, controller);
            Console.Clear();
            Console.WriteLine(@"             ___      _  _                               
    o O O   | _ )    | || |    ___                       
   o        | _ \     \_, |   / -_)                      
  TS__[O]   |___/    _|__/    \___|                      
 {======| _|'''''| _|'''''| _|'''''|                     
./o--000' '`-0-0-' '`-0-0-' '`-0-0-'                     
                                 ___      _  _           
    o O O     o O O     o O O   | _ )    | || |    ___   
   o         o         o        | _ \     \_, |   / -_)  
  TS__[O]   TS__[O]   TS__[O]   |___/    _|__/    \___|  
 {======|  {======|  {======| _|'''''| _|'''''| _|'''''| 
./o--000' ./o--000' ./o--000' '`-0-0-' '`-0-0-' '`-0-0-' ");
            Thread.Sleep(2000);
        }
    }
}
