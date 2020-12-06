using EasySave.Controllers;
using EasySave.Languages;
using EasySave.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasySave.Views.ConsoleViews.ViewStates
{
    class RunMultipleBackup : IViewState
    {
        public IViewState Execute(IReadOnlyModel model, IController controller)
        {
            IReadOnlyList<BackupEnvironment> backupEnvironments = model.GetBackupEnvironments();
            List<Backup> toExecute = new List<Backup>();

            if (backupEnvironments.Count == 0)
            {
                Console.Clear();
                Console.WriteLine(Language.GetText("RunMultipleBackup-NoBackupEnvrionmentAvailable"));
                Console.WriteLine("");
                return new MainMenu();
            }

            foreach (BackupEnvironment backupEnvironment in backupEnvironments)
            {
                Console.Clear();
                while (true)
                {
                    Console.WriteLine(Language.GetText("RunMultipleBackup-Question") + backupEnvironment.Name);
                    Console.WriteLine(Language.GetText("RunMultipleBackup-NotRuneBackup"));
                    Console.WriteLine(Language.GetText("RunMultipleBackup-FullBackup"));
                    Console.WriteLine(Language.GetText("RunMultipleBackup-DifferentialBackup"));
                    Console.WriteLine("");
                    int choice;
                    String strchoice = Console.ReadLine();
                    Console.Clear();
                    if (int.TryParse(strchoice, out choice) && choice >=0 && choice <=2)
                    {
                        if (choice == 1)
                        {
                            toExecute.Add(new Backup(backupEnvironment, new FullBackupStrategy())); 
                            break;
                        }
                        else if (choice == 2)
                        {
                            if (backupEnvironment.FullBackups.Count > 0)
                            {
                                toExecute.Add(new Backup(backupEnvironment, new DifferentialBackupStrategy(backupEnvironment.FullBackups[backupEnvironment.FullBackups.Count-1])));
                                break;
                            }
                            else
                                Console.WriteLine(Language.GetText("RunMultipleBackup-Error-DifferentialBackup"));
                        } 
                        else
                        {
                            break;
                        }
                    }
                }
            }
            foreach (Backup backup in toExecute)
            {
                controller.RunBackup(backup);
            }
            return new MainMenu();
        }
    }
}
