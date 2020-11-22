using EasySave.Controllers;
using EasySave.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasySave.Views.ConsoleViews.ViewStates
{
    class MainMenu : IViewState
    {
        public IViewState Execute(IReadOnlyModel model, IController controller)
        { 
            while (true)
            {
                Console.WriteLine("0. Exit EasySave");
                Console.WriteLine("1. Create a backup environment");
                Console.WriteLine("2. Delete a backup environment");
                Console.WriteLine("");
                String strChoice = Console.ReadLine();
                int choice;
                if(int.TryParse(strChoice, out choice))
                {
                    switch (choice)
                    {
                        case 0: return null;
                        case 1: return new AddBackupEnvironment(); // new CreateBackupEnvironment();
                        default:
                            break;
                    }
                }
                Console.Clear();
            } 
        }
    }
}
