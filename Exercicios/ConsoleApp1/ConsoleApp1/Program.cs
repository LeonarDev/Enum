using System;
using System.Globalization;
using ConsoleApp1.Entities;
using ConsoleApp1.Entities.Enums;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.Write("");

            Console.Write("Enter department's name: ");
            string departmentInput = Console.ReadLine();
            Department department = new Department(departmentInput);

            Console.WriteLine("Enter worker data:");

            Console.Write("Name: ");
            string nameInput = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Worker worker = new Worker(nameInput, level, baseSalary, department);

            Console.Write("How many contracts to this worker? ");
            int contracts = int.Parse(Console.ReadLine());

            if (contracts > 0)
            {
                for (int i = 1; i <= contracts; i++)
                {
                    Console.WriteLine($"Enter #{i} contract data:");

                    Console.Write("Date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());

                    Console.Write("Value per hour: ");
                    double valuePerHour = double.Parse(Console.ReadLine());

                    Console.Write("Duration (hours): ");
                    int hours = int.Parse(Console.ReadLine());

                    HourContract contract = new HourContract(date, valuePerHour, hours);

                    worker.AddContract(contract);
                }
            }

            Console.WriteLine();

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Department: {worker.Department.Name}");
            Console.WriteLine($"Income for {monthAndYear}: {worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
