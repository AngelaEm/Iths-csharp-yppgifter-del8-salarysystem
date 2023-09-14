using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Iths_csharp_yppgifter_del8_salarysystem
{
    internal class SalarySystem
    {
        private List<int> EmployeeIds;
        private List<double> EmployeeSalaries;
        private List<double> BonusAmounts;
        public int counter = 0;

        public SalarySystem()
        {
            EmployeeIds= new List<int>();
            EmployeeSalaries= new List<double>();
            BonusAmounts= new List<double>();
        }

        //Implement a method AddSalary(int employeeId, double salary) that adds an
        //employee's salary. Ensure the salary is not negative.

        public void AddSalary(int employeeId, double salary)
        {
            if(salary >= 0)
            {
                EmployeeIds.Add(employeeId);               
                EmployeeSalaries.Add(salary);
                counter++;
            }
            else
            {
                Console.WriteLine("Invalid salary. Try again!");
            }          
        }

        //Implement a method GetSalary(int employeeId) that retrieves an employee's salary
        //based on their ID.If the employee doesn't exist, return -1.

        public double GetSalary(int employeeId)
        {
            for (int i = 0; i < EmployeeIds.Count; i++)
            {
                if (EmployeeIds[i] == employeeId)
                {
                    return EmployeeSalaries[i];                   
                }          
            }
            return -1;
        }

        //Implement a method RemoveEmployee(int employeeId) that removes an employee's
        //details from all the lists.

        public void RemoveEmployees(int employerId)
        {       
            for (int i = 0; i < EmployeeIds.Count; i++)
            {
                if (EmployeeIds[i] == employerId)
                {
                    EmployeeIds.RemoveAt(i);
                    EmployeeSalaries.RemoveAt(i);
                    BonusAmounts.RemoveAt(i);
                    counter--;
                    Console.WriteLine("Employee removed!");
                }
                else
                {
                    Console.WriteLine("Invalid Id.");
                }
            }
        }

        //Implement a method AddBonus(int employeeId, double bonus) to award a bonus to
        //an employee.Ensure the bonus is not negative.

        public void AddBonus(int employeeId, double bonus)
        {
            if (bonus >= 0)
            {
                for (int i = 0; i < EmployeeIds.Count; i++)
                {
                    if (EmployeeIds[i] == employeeId)
                    {
                        BonusAmounts.Add(bonus); // Kan man välja vilken position i listan man vill lägga till? 
                    }
                }                             
            }
            else
            {
                Console.WriteLine("Invalid bonus. Try again!");
            }
        }

        //Implement a method GetTotalCompensation(int employeeId) that returns the sum of
        //an employee's salary and bonus.

        public double GetTotalCompensation(int employeeId)
        {
            double total = 0;

            for (int i = 0; i < EmployeeIds.Count; i++)
            {
                if (EmployeeIds[i] == employeeId)
                {
                    total = EmployeeSalaries[i] + BonusAmounts[i];
                    return total;
                }          
            }       
                return -1;        
        }

        //Implement a method GiveRaise(int employeeId, double percentage) to give an
        //employee a raise based on a percentage of their current salary

        public void GiveRaise(int employeeId, double percentage)
        {
            double newSalary;

            for (int i = 0; i < EmployeeIds.Count; i++)
            {
                if (EmployeeIds[i] == employeeId)
                {
                    newSalary = EmployeeSalaries[i] * (1 + (percentage / 100));
                    Console.WriteLine($"New salary after {percentage}% raise is: {Math.Round(newSalary,2)}." );
                }
            }
        }

        //Implement a method DeductTax(int employeeId, double taxPercentage) that deducts
        //a certain percentage from an employee's salary.

        public void DeductTax(int employeeId, double taxPercentage)
        {
            double newSalary;

            for (int i = 0; i < EmployeeIds.Count; i++)
            {
                if (EmployeeIds[i] == employeeId)
                {
                    newSalary = EmployeeSalaries[i] * (1 - (taxPercentage / 100));
                    Console.WriteLine($"New salary after {taxPercentage}% taxes is: {Math.Round(newSalary, 2)}.");
                }
            }
        }

        //Implement a method GetAverageSalary() that calculates the average salary of all
        //employees.

        public double GetAverageSalary()
        {
            double sum = 0;
            double averageSalary;

            foreach (double salary in EmployeeSalaries)
            {
                sum += salary;              
            }
            averageSalary = sum / EmployeeSalaries.Count;

            return Math.Round(averageSalary,2);
        }
        //Implement a method GetTopEarner() that returns the ID of the employee with the
        //highest salary.


        public double GetTopEarner()
        {
            double topEarner = 0;

            for (int i = 0; i < EmployeeSalaries.Count; i++)
            {              
                for (int j = 1; j < EmployeeSalaries.Count; j++)
                {
                    if (EmployeeSalaries[j] > topEarner)
                    {
                        topEarner = EmployeeSalaries[j];
                    }
                }            
            }
            for (int i = 0; i < EmployeeSalaries.Count; i++)
            {
                if (EmployeeSalaries[i] == topEarner)
                {
                    return EmployeeIds[i];
                }
            }
            return -1;                   
        }

        //Implement a method YearlyProjection(int employeeId) that multiplies the monthly
        //salary of an employee by 12 to give a yearly projection.

        public void YearlyProjection(int employeeId)
        {
            double yearlyProjection = 0;

            for (int i = 0; i < EmployeeIds.Count; i++)
            {
                if (EmployeeIds[i] == employeeId)
                {
                    yearlyProjection = EmployeeSalaries[i] * 12;
                    
                }
            }
            Console.WriteLine("Yearly Projection: " + yearlyProjection);
        }

        //Implement a method TotalBonusBudget() that returns the total amount set aside for
        //bonuses.

        public double TotalBonusBudget()
        {
            double totalBonusBudget = 0;
            foreach (double bonus in BonusAmounts)
            {
                totalBonusBudget += bonus;
            }
            return totalBonusBudget;
        }

        //Implement a method GetEmployeesBelowAverage() that finds and returns a list of
        //employee IDs earning below the average salary.

        public List<int> GetEmployeesBelowAverage()
        {
            double averageSalery = GetAverageSalary();
           
            List<int> belowAverage = new List<int>();

            for (int i = 0; i < EmployeeSalaries.Count; i++)
            {
                if (EmployeeSalaries[i] < averageSalery)
                {
                    belowAverage.Add(EmployeeIds[i]);                   
                }
            }
            return belowAverage;
        }

        //Implement a method IsEligibleForBonus(int employeeId, double minimumSalary)
        //that checks if an employee's salary exceeds a certain minimum.>

        public bool IsEligibleForBonus(int employeeId, double minimunSalary)
        {
            for (int i = 0; i < EmployeeIds.Count; i++)
            {
                if((EmployeeIds[i] == employeeId) && (minimunSalary < EmployeeSalaries[i]))
                {
                    return true;
                }
            }
            return false;
        }

        //Implement a method TotalPayrollCost() that calculates the total expenditure for all
        //employees' salaries and bonuses.

        public void TotalPayrollCost()
        {
            double payrollCost = 0;
            double totalasalary = 0;
            double totalbonus = 0;
            foreach (double salary in EmployeeSalaries)
            {
                totalasalary += salary;
            }
            foreach (double bonus in BonusAmounts)
            {
                totalbonus += bonus;
            }

            payrollCost = totalasalary + totalbonus;
            Console.WriteLine("Total cost all salaries and bonus: " + payrollCost);
        }

        //Implement a method TotalEmployees() that returns the total number of employees
        //in the system.

        public int TotalEmployees()
        {
            return counter;
        }
    }
}
