using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num;
            // Input
            Console.WriteLine("Hello! What is your name?");
            string Name = Console.ReadLine();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Hello " + Name + ". Lets play a game!");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Enter in a number between 1 and 100 and i will tell you about it.");
          //  Num = int.Parse(Console.ReadLine());

            bool Exit = false;
            while (!int.TryParse(Console.ReadLine(), out Num) || Num < 1 ||  Num > 100)
            {
                Console.WriteLine();
                Console.WriteLine("Wrong!!!");
                System.Threading.Thread.Sleep(1000);
                Console.Write("Please enter a number between 1 and 100");

              //  Exit = true;
            }

            Console.WriteLine(Num);
            Console.WriteLine("That's an amzing number " + Name);
            System.Threading.Thread.Sleep(1000);
        }
    }
}
