using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            char choice;

            // Keep The Loop Running Until The Choice Is y/Y
            do
            {

                // Input Patient Name
                Console.Write("Enter Patient Name: ");
                string patientName = Console.ReadLine();

                // Input Number Of Medicine
                Console.Write("Enter Number Of Medicine (1-125): ");
                int numMedicine = Int32.Parse(Console.ReadLine());

                // Keep Re-Entering Number Of Medicine
                // If Until User Enters Invalid Value
                while (numMedicine < 1 || numMedicine > 125)
                {
                    Console.WriteLine("Value Must Be Between 1 And 125!");
                    Console.Write("Re-Enter Number Of Medicine (1-125): ");
                    numMedicine = Int32.Parse(Console.ReadLine());
                }

                // Input If The Customer Is A Reseller
                Console.Write("Is Patient A Homeless? (y/Y For Yes): ");
                choice = Console.ReadLine().ToLower()[0];
                bool isHomeless = false;
                if (choice == 'y')
                {
                    isHomeless = true;
                }


                // Compute Bill

                // Compute medicine Cost
                double totalCost = 0.0;
                if (numMedicine < 6)
                {
                    totalCost += numMedicine * 45;
                }
                else if (numMedicine < 5)
                {
                    totalCost += numMedicine * 39.5;
                }
                else
                {
                    totalCost += numMedicine * 34.6;
                }

                // Compute Discount
                double discount = 0.0;

                if (isHomeless)
                {
                    discount = totalCost * 0.20;
                }

                // Print Bill
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("------------------- RECEIPT -------------------");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Patient Name: {0}", patientName);
                Console.WriteLine("Number Of Medicine: {0}", numMedicine);
                Console.WriteLine("Total Cost Of medicine: {0:C}", totalCost);
                Console.WriteLine("Discount: {0:C}", discount);
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Amount Payable: {0:C}", totalCost - discount);
                Console.WriteLine("--------------------------------------------");



                // Input User Choice
                Console.Write("Input Y/y To Continue Or Any Other Key To Exit: ");

                // Get First Letter Of Choice
                choice = Console.ReadLine().ToLower()[0];
                Console.WriteLine();
            } while (choice == 'y');
        }
    }
