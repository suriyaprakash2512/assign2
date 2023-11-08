using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee Name:");
            string employeeName = Console.ReadLine();

            Console.WriteLine("Enter Employee ID:");
            int employeeID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employee Gender:");
            char employeeGender = Convert.ToChar(Console.ReadLine().ToUpper()[0]);

            Console.WriteLine("Enter Employee Salary:");
            double employeeSalary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Employee Date of Joining (DOJ):");
            DateTime dateOfJoining = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("\nEmployee Details:\n");
            Console.WriteLine("Employee Name: " + employeeName);
            Console.WriteLine("ID: " + employeeID);
            Console.WriteLine("Employee Gender: " + employeeGender);
            Console.WriteLine("Employee Salary: " + employeeSalary);
            Console.WriteLine("DOJ: " + dateOfJoining.ToShortDateString());

            if (employeeSalary > 90000)
            {
                double tax = employeeSalary * 0.3; // 30% tax
                Console.WriteLine("\nYou have to pay 30% tax: " + tax);
            }
            else
            {
                double tax = employeeSalary * 0.15; // 15% tax
                Console.WriteLine("\nTax to be paid: 15%: " + tax);
            }
            Console.ReadKey();

        }
    }
}
