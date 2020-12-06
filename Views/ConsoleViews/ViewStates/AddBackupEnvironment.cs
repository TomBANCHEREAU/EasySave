using EasySave.Controllers;
using EasySave.Languages;
using EasySave.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasySave.Views.ConsoleViews.ViewStates
{
    class AddBackupEnvironment : IViewState
    {
        public IViewState Execute(IReadOnlyModel model, IController controller)
        {
            Console.Clear();
            
            if (model.GetBackupEnvironments().Count >= 5)
            {
                
                Console.WriteLine(Language.GetText("AddBackupEnvironment-Error-5Backups"));
                Console.WriteLine("");
                return new MainMenu();
            }

            BackupEnvironment backupEnvironment = new BackupEnvironment();

            while (true) // Name
            {
                try
                {
                    Console.Write(Language.GetText("AddBackupEnvironment-Name"));
                    backupEnvironment.Name = Console.ReadLine();
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(Language.GetText("AddBackupEnvironment-Name-Error"));
                }
            }
            while (true) // Source Directory
            {
                try
                {
                    Console.Write(Language.GetText("AddBackupEnvironment-SrcDirectory"));
                    backupEnvironment.SourceDirectory = Console.ReadLine();
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(Language.GetText("AddBackupEnvironment-SrcDirectory-Error"));
                }
            }
            while (true) // Destination Directory
            {
                try
                {
                    Console.Write(Language.GetText("AddBackupEnvironment-DstDirectory"));
                    backupEnvironment.DestinationDirectory = Console.ReadLine();
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(Language.GetText("AddBackupEnvironment-DstDirectory-Error"));
                }
            }


            try
            {
                controller.AddBackupEnvironment(backupEnvironment);
                Console.Clear();
                Console.WriteLine(Language.GetText("AddBackupEnvironment-NewBackup"));
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine(Language.GetText("AddBackupEnvironment-Error-5Backups"));
            }

            Console.WriteLine("");
            return new MainMenu();
        }
    }
}

