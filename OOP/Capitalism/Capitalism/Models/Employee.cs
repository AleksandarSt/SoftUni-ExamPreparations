﻿using Capitalism.Models.Interfaces;
namespace Capitalism.Models
{
    public class Employee:PaidPerson,IEmployee
    {
        public Department Department { get; set; }

        protected virtual double SalaryFactor 
        { 
            get 
            {
                return 1;
            }
        }
    }
}
