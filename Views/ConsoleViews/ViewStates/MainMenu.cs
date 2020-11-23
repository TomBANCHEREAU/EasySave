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
                Console.WriteLine("2. Display backup environment list");
                Console.WriteLine("3. Delete a backup environment");
                Console.WriteLine("4. Run a backup");
                Console.WriteLine("5. Restore a backup");
                Console.WriteLine("6. Run multiple backups");
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
