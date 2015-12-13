using System;
namespace Capitalism.Models.Interfaces
{
    public interface IEmployee: IPaidPerson
    {
        Department Department { get; }

        //double SalaryFactor { get; }
    }
}
