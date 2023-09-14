using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iths_csharp_yppgifter_del8_salarysystem
{
    internal class Employee
    {
        private int Id;
        private double Salary;
        private double Bonus;

        public Employee(int id, double salary, double bonus)
        {
            Id = id;
            Salary = salary;
            Bonus = bonus;
        }

        public int GetId()
        {
            return Id;
        }
        
        public double GetSalary()
        {
            return Salary;
        }

        public double GetBonus()
        {
            return Bonus;
        }

        
    }
}
