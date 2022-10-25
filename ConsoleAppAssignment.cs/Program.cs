using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess my age?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 28;

            do
            {
                switch (number)
                {
                    case 40:
                        Console.WriteLine("I'm not that old! Try again");
                        Console.WriteLine("Guess my age?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 20:
                        Console.WriteLine("I'm not that young! Try again");
                        Console.WriteLine("Guess my age?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 30:
                        Console.WriteLine("You are close! Try again");
                        Console.WriteLine("Guess my age?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 28:
                        Console.WriteLine("Yes! I am 28 years old.");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
                                        
            }

            while (!isGuessed);
            Console.Read();

        }
    }
}
