using EasySave.Controllers;
using EasySave.Languages;
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
                Console.WriteLine(Language.GetText("MainMenu-Choice-0"));
                Console.WriteLine(Language.GetText("MainMenu-Choice-1"));
                Console.WriteLine(Language.GetText("MainMenu-Choice-2"));
                Console.WriteLine(Language.GetText("MainMenu-Choice-3"));
                Console.WriteLine(Language.GetText("MainMenu-Choice-4"));
                Console.WriteLine(Language.GetText("MainMenu-Choice-5"));
                Console.WriteLine(Language.GetText("MainMenu-Choice-6"));
                Console.WriteLine("");
                String strChoice = Console.ReadLine();
                int choice;
                if(int.TryParse(strChoice, out choice))
                {
                    switch (choice)
                    {
                        case 0: return null;
                        case 1: return new AddBackupEnvironment();
                        case 2: return new DisplayBackupEnvironments();
                        case 3: return new DeleteBackupEnvironment();
                        case 4: return new RunBackup();
                        case 5: return new RestoreBackup();
                        case 6: return new RunMultipleBackup();
                        default:
                            break;
                    }
                }
                Console.Clear();
            } 
        }
    }
}
