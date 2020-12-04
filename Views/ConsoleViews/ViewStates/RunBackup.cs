using EasySave.Controllers;
using EasySave.Languages;
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
                Console.WriteLine(Language.GetText("RunBackup-NoBackupEnvrionmentAvailable"));
                Console.WriteLine("");
                return new MainMenu();
            }

            while (true)
            {
                // Listing all backup environments
                Console.Clear();
                Console.WriteLine(Language.GetText("RunBackup-WishBackupEnvironment"));
                Console.WriteLine(Language.GetText("RunBackup-ReturnMenu"));
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
                            Console.WriteLine(Language.GetText("RunBackup-WishBackup"));
                            Console.WriteLine(Language.GetText("RunBackup-ReturnMenu"));
                            Console.WriteLine(Language.GetText("RunBackup-RunFull"));
                            Console.WriteLine(Language.GetText("RunBackup-RunDifferential"));

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
                                        controller.RunBackup(new Backup(environment, new FullBackupStrategy()));
                                    
                                        Console.Clear();
                                        Console.WriteLine(Language.GetText("RunBackup-RunFullDone"));
                                        Console.WriteLine("");
                                        return new MainMenu();

                                    // Run a differential backup
                                    case 2:
                                        if (environment.FullBackups.Count > 0)
                                        {
                                            Backup backup = new Backup(environment, new DifferentialBackupStrategy(environment.FullBackups[environment.FullBackups.Count - 1]));
                                            controller.RunBackup(backup);
                                        
                                            Console.Clear();
                                            Console.WriteLine(Language.GetText("RunBackup-RunDifferentialDone"));
                                            Console.WriteLine("");
                                            return new MainMenu();
                                        }
                                        Console.Clear();
                                        Console.WriteLine(Language.GetText("RunBackup-NoFullBackup"));
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
