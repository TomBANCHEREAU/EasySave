using EasySave.Controllers;
using EasySave.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasySave.Views.ConsoleViews.ViewStates
{
    class RunBackup : IViewState
    {
        public IViewState Execute(IReadOnlyModel model, IController controller)
        {
            Console.Clear();
            IReadOnlyList<BackupEnvironment> backupEnvironmentList = model.GetBackupEnvironments();

            // There is no backup environment available
            if (backupEnvironmentList.Count == 0)
            {
                Console.WriteLine("There is no backup environment available");
                Console.WriteLine("");
                return new MainMenu();
            }

            while (true)
            {
                // Listing all backup environments
                Console.Clear();
                Console.WriteLine("Select the backup environment you wish to use:");
                Console.WriteLine("0. Return to menu");
                for (int i = 1; backupEnvironmentList.Count >= i; i++)
                {
                    Console.WriteLine(i + ". " + backupEnvironmentList[i - 1].Name);
                }

                // User chooses an environment
                Console.WriteLine("");
                int choice;

                // Verification
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    // Display all backup's types
                    if (choice > 0 && choice <= backupEnvironmentList.Count)
                    {
                        BackupEnvironment environment = backupEnvironmentList[choice - 1];
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("Which type of backup would you like to run:");
                            Console.WriteLine("0. Return to menu");
                            Console.WriteLine("1. Run a full backup");
                            Console.WriteLine("2. Run a differential backup");

                            // User chooses a backup's type
                            Console.WriteLine("");

                            // Verification
                            if (int.TryParse(Console.ReadLine(), out choice))
                            {
                                switch (choice)
                                {
                                    // Exit
                                    case 0:
                                        Console.Clear();
                                        return new MainMenu();

                                    // Run a full backup
                                    case 1: 
                                        controller.RunBackup(environment,BackupType.FULL);
                                    
                                        Console.Clear();
                                        Console.WriteLine("The full backup has been done");
                                        Console.WriteLine("");
                                        return new MainMenu();

                                    // Run a differential backup
                                    case 2:
                                        if (environment.FullBackups.Count > 0)
                                        {
                                            controller.RunBackup(environment, BackupType.DIFFERENTIAL);
                                        
                                            Console.Clear();
                                            Console.WriteLine("The differential backup has been done");
                                            Console.WriteLine("");
                                            return new MainMenu();
                                        }
                                        Console.Clear();
                                        Console.WriteLine("No full backup has been done");
                                        Console.WriteLine("");
                                        return new MainMenu();
                                }
                            }
                        }
                    }
                }
                // Exit
                if (choice == 0)
                {
                    Console.Clear();
                    return new MainMenu();
                }
            }
        }
    }
}
