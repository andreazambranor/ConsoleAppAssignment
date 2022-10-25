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

            ////INITIAL QUESTION START BOOL
            //Console.WriteLine("Guess my age?");
            //int number = Convert.ToInt32(Console.ReadLine());
            //bool isGuessed = number == 29;

            //// DO WHILE STATEMENT
            //do
            //{
            //    switch (number)
            //    {
            //        //CASE 1 FALSE
            //        case 40:
            //            Console.WriteLine("I'm not that old! Try again");
            //            Console.WriteLine("Guess my age?");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        //CASE 2 FALSE
            //        case 20:
            //            Console.WriteLine("I'm not that young! Try again");
            //            Console.WriteLine("Guess my age?");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        //CASE 3 FALSE
            //        case 30:
            //            Console.WriteLine("You are close! Try again");
            //            Console.WriteLine("Guess my age?");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        //CASE 4 TRUE
            //        case 29:
            //            Console.WriteLine("Yes! I am 29 years old.");
            //            isGuessed = true;
            //            break;
            //        //DEFAULT FALSE
            //        default:
            //            Console.WriteLine("You are wrong");
            //            Console.WriteLine("Guess my age?");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //    }
                                        
            //}

            //while (!isGuessed);
            //Console.Read();

            Console.WriteLine("Write a random number from 1 to 20");
            int Num = Convert.ToInt32(Console.ReadLine());
            while (Num < 20)
            {
                Console.WriteLine(Num);
                Num++;
            }
            Console.ReadLine();

        }

    }
}
