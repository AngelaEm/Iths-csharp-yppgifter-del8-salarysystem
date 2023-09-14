namespace Iths_csharp_yppgifter_del8_salarysystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor= ConsoleColor.Cyan;
            Console.Clear();
            Console.ForegroundColor= ConsoleColor.Magenta;
            PrintStars();

            SalarySystem salarySystem = new SalarySystem();

            // Add Salary and Id
            salarySystem.AddSalary(1, 120000);
            salarySystem.AddSalary(2, 30000);
            salarySystem.AddSalary(3, 40000);
            salarySystem.AddSalary(4, 50000);
            salarySystem.AddSalary(5, 160000);
            salarySystem.AddSalary(6, 30000);
            salarySystem.AddSalary(7, 80000);

            // Add Bonus
            salarySystem.AddBonus(1, 3000);
            salarySystem.AddBonus(2, 1000);
            salarySystem.AddBonus(3, 4000);
            salarySystem.AddBonus(4, 1000);
            salarySystem.AddBonus(5, 300);
            salarySystem.AddBonus(6, 50);
            salarySystem.AddBonus(7, 30);

            // Get Salary from id: 3
            Console.WriteLine($"The salary of this user is: {salarySystem.GetSalary(3)}.");

            PrintStars();

            // Get total compensation from id: 5
            Console.WriteLine($"Total compensation of this user is: {salarySystem.GetTotalCompensation(5)}.");

            PrintStars();

            // New salary to id 1 after a 7% raise
            salarySystem.GiveRaise(1, 7);

            PrintStars();

            // New salary to id 7 after 32% taxes
            salarySystem.DeductTax(7, 32);

            PrintStars();

            // Average salary
            Console.WriteLine("Average salary: " + salarySystem.GetAverageSalary());

            PrintStars();

            //Top earner id
            Console.WriteLine("Top earner id: " + salarySystem.GetTopEarner());
            
            PrintStars();
            
            // Yearly projection id 2
            salarySystem.YearlyProjection(2);

            PrintStars();

            //Total budget for bonus
            Console.WriteLine("Total budget for bonus: " + salarySystem.TotalBonusBudget()); 

            PrintStars();

            // A list with employees with salary below average
            Console.WriteLine("These employees have a salary below awarage:");
            foreach (var id in salarySystem.GetEmployeesBelowAverage())
            {
                Console.WriteLine("id: " + id);
            }

            PrintStars();

            // Tells if Id 6 gets a bonus when limit is 40000
            if (salarySystem.IsEligibleForBonus(6, 40000))
            {
                Console.WriteLine("Du får bonus!");
            }
            else
            {
                Console.WriteLine("Du får ingen bonus.");
            }

            PrintStars();

            // Total cost salary and bonus
            salarySystem.TotalPayrollCost();

            PrintStars();

            // Print total number of employees in system
            Console.WriteLine("Total employees: " + salarySystem.TotalEmployees()); 

            PrintStars();

            Console.ReadKey();
        }

        static void PrintStars()
        {
            Console.WriteLine("****************************************\n");
        }
    }
}