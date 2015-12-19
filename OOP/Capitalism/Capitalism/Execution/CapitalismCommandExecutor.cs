using Capitalism.Interfaces;
using Capitalism.Models;
using System;
namespace Capitalism.Execution
{
    public class CapitalismCommandExecutor:ICommandExecutor
    {
        private IDatabase database;
        //private IUserInterface userInterface;

        public CapitalismCommandExecutor()
        {
            this.database = new CapitalismDatabase();
        }

        public string ExecuteCommand(ICommand command)
        {
            switch (command.Name)
            {
                case "create-company":
                    //TO DO: Refractor to use proper constructors
                    //var ceo=new CEO()
                    //{
                    //    FirstName=command.Parameters[1],
                    //    LastName=command.Parameters[2],
                    //    Salary=decimal.Parse(command.Parameters[3])
                    //};
                    string companyName = command.Parameters[0];
                    this.database.Companies.Add(new Company(companyName, ceo));
                    break;
                case "create-department":
                    break;
                case "create-employee":
                    break;
                case "pay-salaries":
                    break;
                case "show-employees":
                    //TODO: Implement properly
                    return "Employees go here";
                case "end":
                    break;
                default:
                    throw new InvalidOperationException("The command is invalid.");
            }
            return null;
        }
    }
}
