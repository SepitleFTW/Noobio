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
            Greeting();
            Gender();
            Console.ReadLine();
        }

        static void Greeting()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name} Welcome to The Council");
        }

        static void Gender()
        {
            Console.Write("What is your prefered gender (Male/Female): ");
            string gender = Console.ReadLine();

            if (gender == "Male" || gender == "male")
            {
                Console.WriteLine("You are a Male!");
            }
            else if (gender == "Female" || gender == "female")
            {
                Console.WriteLine("You are a Female!");
            }
            else
            {
                Console.WriteLine("We are not sure what you are!\n Please try again!");
            }
        }
 
    }
}
 