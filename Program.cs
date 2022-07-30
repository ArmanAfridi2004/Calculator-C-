using System;
namespace Calculator
{
    class Calculator
    {
        static double num1;
        static double num2;
        static string userInput;
        static string numString1;
        static string numString2;
        static void Main (string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            DataEntry();
            Calculation();
            Console.ResetColor();
            Console.Read();
                

        }

        public static void Calculation()
        {
            if (userInput == "a" && numString1 != "a" && numString1 != "")
            {
                Console.WriteLine("The sum of {0} and {1} is: {2}", num1, num2, Add(num1, num2));
            }
            else if (userInput == "b" && numString1 != "b" && numString1 != "")
            {
                Console.WriteLine("The difference of {0} and {1} is: {2}", num1, num2, Subtraction(num1, num2));
            }
            else if (userInput == "c" && numString1 != "c" && numString1 != "")
            {
                Console.WriteLine("The product of {0} and {1} is: {2}", num1, num2, Multiplication(num1, num2));
            }
            else if (userInput == "d" && numString1 != "d" && numString1 != "")
            {
                Console.WriteLine("The quotient of {0} and {1} is: {2}", num1, num2, Division(num1, num2));
            }
        }
        public static void DataEntry()
        {
            
            Console.Write("What operation do you want to do? \na)Addition\nb)Substraction\nc)Multiplication\nd)Division\n-->");
            userInput = Console.ReadLine().ToLower();
            if (userInput == "a" || userInput == "b" || userInput == "c" || userInput == "d")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("\nEnter your first number: ");
                numString1 = Console.ReadLine();
                Console.Write("Enter your second number: ");
                numString2 = Console.ReadLine();

                try
                {
                    num1 = Double.Parse(numString1);
                    num2 = Double.Parse(numString2);
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("PLESE ENTER A VALID NUMBER!");
                    
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("PLEASE ENTER 'a'/'b'/'c'/'d' NEXT TIME.");
            }

        }
        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        public static double Subtraction(double num1, double num2)
        {
            return num1 - num2;
        }
        public static double Multiplication(double num1, double num2)
        {
            return num1 * num2;
        }
        public static double Division(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
