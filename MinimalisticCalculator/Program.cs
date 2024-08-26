using System;
using System.Text;
using System.Threading.Tasks;

namespace MinimalisticCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            do
            {
                int res;
                Console.Write("Enter first number:"); //announcement display 
                int num1 = Convert.ToInt32(Console.ReadLine()); // value input 
                Console.Write("Enter second number:");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter symbol(/,+,-,*):");
                string symbol = Console.ReadLine();

                switch (symbol) // symbol selection mechanism
                {
                    case "+":
                        res = num1 + num2;
                        Console.WriteLine("Result:" + res);
                        break;
                    case "-":
                        res = num1 - num2;
                        Console.WriteLine("Result:" + res);
                        break;
                    case "*":
                        res = num1 * num2;
                        Console.WriteLine("Result:" + res);
                        break;
                    case "/":
                        res = num1 / num2;
                        Console.WriteLine("Result:" + res);
                        break;
                    default:
                        Console.WriteLine("Result input");
                        break;
                }
                Console.ReadLine();
                Console.Write("Do you want to continue(y/n):"); //app exit
                value = Console.ReadLine();
            }
            while (value == "y" || value == "Y");
        }
    }

}
