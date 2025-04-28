using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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

        static bool Gender()
        {
            bool isGender = true;
            if (isGender)
            {
                Console.Write("What is your gender? ");
                string gender = Console.ReadLine();
                Console.WriteLine("You are a Male");
            } else
            {
                Console.WriteLine("You are a Female!");
            }
            return isGender;
        }
 
    }
}
 