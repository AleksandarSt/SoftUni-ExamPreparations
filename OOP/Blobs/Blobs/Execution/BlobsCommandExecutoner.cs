using Blobs.Interfaces;
using Blobs.Models;
using System;

namespace Blobs.Execution
{
    public class BlobsCommandExecutoner:ICommandExecutor
    {
        private IDatabase database;

        public BlobsCommandExecutoner()
        {
            this.database = new BlobsDatabase();
        }

        public string ExecuteCommand(ICommand command)
        {

            string commandResult = null;
            switch (command.Name)
            {
                case "create":
                    commandResult = ExecuteCreateBlobCommand(command);
                    break;
                case "attack":
                    commandResult = ExecuteAttackCommand(command);
                    break;
                case "pass":
                    commandResult = ExecutePassCommand(command);
                    break;
                case "status":
                    commandResult = ExecuteStatusCommand(command);
                    break;
                case "report-events":
                    commandResult = ExecuteReportEventsCommand(command);
                    break;
                case "drop":
                    break;
                default:
                    throw new InvalidOperationException("The command is invalid.");
            }

            return commandResult;
        }

        private string ExecuteReportEventsCommand(ICommand command)
        {
            throw new NotImplementedException();
        }

        private string ExecuteStatusCommand(ICommand command)
        {
            throw new NotImplementedException();
        }

        private string ExecutePassCommand(ICommand command)
        {
            throw new NotImplementedException();
        }

        private string ExecuteAttackCommand(ICommand command)
        {
            throw new NotImplementedException();
        }

        private string ExecuteCreateBlobCommand(ICommand command)
        {
            var behavior = new Behavior(command.Parameters[3]);
            var attack = new Attack(command.Parameters[4]);
            var blob = new Blob(command.Parameters[0], int.Parse(command.Parameters[1]), int.Parse(command.Parameters[2]),behavior,attack);

            this.database.Blobs.Add(blob);

            return null;
        }
    }
}
