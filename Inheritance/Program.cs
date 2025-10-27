using System;

namespace Inheritance
{
    class Program
    {
        static void Main()
        {
            Payroll payroll = new Payroll();

            SalariedEmployee se1 = new SalariedEmployee("Mister", "Awesome", "E001", 1200.00);
            HourlyEmployee he1 = new HourlyEmployee("Silly", "Guy", "E002", 20.00, 40);
            SalariedEmployee se2 = new SalariedEmployee("Charlie", "Brown", "E003", 1500.00);

            SalariedEmployee se3 = new SalariedEmployee
            {
                nameF = "Walter",
                nameL = "White",
                IDNumber = "E004",
                salFromImpracticalJokers = 1000.00
            };

            HourlyEmployee he2 = new HourlyEmployee
            {
                nameF = "Eli",
                nameL = "Bockus",
                IDNumber = "E005",
                HourlyRate = 25.00,
                HoursPerWeek = 35
            };

            HourlyEmployee he3 = new HourlyEmployee
            {
                nameF = "Fiona",
                nameL = "Shrekington",
                IDNumber = "E006",
                HourlyRate = 18.50,
                HoursPerWeek = 30
            };

            payroll.Add(se1);
            payroll.Add(he1);
            payroll.Add(se2);
            payroll.Add(se3);
            payroll.Add(he2);
            payroll.Add(he3);

            try
            {
                se1.PtoDaysTaken = 10;
                he1.PtoDaysTaken = 5;

                se2.PtoDaysTaken = 35;

                se3.PtoDaysTaken = 30;
                he2.PtoDaysTaken = 15;

                he3.PtoDaysTaken = 50;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return; 
            }

            payroll.PrintChecks();

            Console.WriteLine($"\nMaximum PTO allowed for any employee: {Employee.GetMaxPtoDays()} days");
        }
    }
}
