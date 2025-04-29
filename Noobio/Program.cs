using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noobio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter an operator: ");
            string op = Convert.ToString(Console.ReadLine());

            Console.Write("Enter a number again: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.WriteLine(number1 + number2);
            }
            else if (op == "-")
            {
                Console.WriteLine(number1 - number2);
            }
            else if (op == "/")
            {
                Console.WriteLine(number1 / number2);
            }
            else if (op == "*")
            {
                Console.WriteLine(number1 * number2);
            }

            Console.ReadLine();
        }

        
 
    }
}
