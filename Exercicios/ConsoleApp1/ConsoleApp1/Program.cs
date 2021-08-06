using ConsoleApp1.Entities;
using ConsoleApp1.Entities.Enums;
using System;

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
            string levelInput = Console.ReadLine();
            WorkerLevel level = new WorkerLevel

            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine());


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
                }
            }

            // VINCULAR AS VARIAVEIS DESTE ESCOPO COM AS VARIAVES DAS CLASSES:

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            DateTime income = DateTime.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {nameInput}");
            Console.WriteLine($"Department: {department}");
            Console.WriteLine($"Income for {income}: {HourContract.TotalValue()}");

            Console.Write("");

            Console.Write("");

            Console.Write("");

            Console.Write("");

            Console.Write("");
        }
    }
}
