using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14GradeswithSwitch
{
    class Program
    {
        static void Main(string[] args)
        {

            do
            {
                DisplayMenu();
                int selection = GetSelection();

                if (selection == 6)
                {
                    Console.WriteLine("Good bye..");
                    break;
                }

                Console.WriteLine();

            } while (true);
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("Calculator Menu");
            Console.WriteLine($"1.  Add");
            Console.WriteLine($"2.  Subtract");
            Console.WriteLine($"3.  Multiply");
            Console.WriteLine($"4.  Divide");
            Console.WriteLine($"5.  Modulus");
            Console.WriteLine($"6.  Quit");
            Console.WriteLine("----------------------------");
        }

        private static int GetSelection()
        {
            Console.Write("Please enter a selection: ");
            int selection = int.Parse(Console.ReadLine());

            if (selection == 6)
            {
                return selection;
            }

            Console.Write("Enter first number: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int number2 = int.Parse(Console.ReadLine());

            DoArithmetic(selection, number1, number2);
            return selection;
        }

        private static void DoArithmetic(int selection, int number1, int number2)
        {
            switch (selection)
            {
                case 1:
                    Console.WriteLine($"{number1} + {number2} = {Add(number1, number2)}");
                    break;
                case 2:
                    Console.WriteLine($"{number1} - {number2} = {Subtract(number1, number2)}");
                    break;
                case 3:
                    Console.WriteLine($"{number1} * {number2} = {Multiply(number1, number2)}");
                    break;
                case 4:
                    Console.WriteLine($"{number1} / {number2} = {Divide(number1, number2)}");
                    break;
                case 5:
                    Console.WriteLine($"{number1} + {number2} = {Modulus(number1, number2)}");
                    break;
                default:
                    break;
            }
        }

        private static int Modulus(int number1, int number2)
        {
            return number1 % number2;
        }

        private static int Divide(int number1, int number2)
        {
            return number1 / number2;
        }

        private static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        private static int Subtract(int number1, int number2)
        {
            return number1 - number2;
        }

        private static int Add(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}
