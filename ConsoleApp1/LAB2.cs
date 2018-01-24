using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                int Num;
                // Input
                Console.WriteLine("Hello! What is your name?");
                string Name = Console.ReadLine();
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Hello " + Name + ". Lets play a game!");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Enter in a number between 1 and 100 and I will tell you about it.");
                //  Num = int.Parse(Console.ReadLine());

                //Validating
              
                while (!int.TryParse(Console.ReadLine(), out Num) || Num < 1 || Num > 100)
                {
                    Console.WriteLine();
                    Console.WriteLine("Wrong!!!");
                    System.Threading.Thread.Sleep(1000);
                    Console.Write("Please enter a number between 1 and 100");

                    //  Exit 
                }

                Console.WriteLine(Num);
                Console.WriteLine("That's an amzing number " + Name);
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Hold on one moment please while I analyze your number");
                System.Threading.Thread.Sleep(1500);

                if (Num % 2 == 1)
                {
                    Console.WriteLine("Odd");
                }
                else if (Num % 2 == 0 && Num >= 2 && Num <= 25)
                {
                    Console.WriteLine("Even and less than 25");
                }
                else if (Num % 2 == 0 && Num >= 26 && Num <= 60)
                {
                    Console.WriteLine("Even");
                }
                else if (Num % 2 == 0 && Num > 60)
                {
                    Console.WriteLine("Even: " + Num);
                }
                else if (Num % 2 == 1 && Num > 60)
                {
                    Console.WriteLine("Odd: " + Num);
                }
                else
                {

                }

                Console.WriteLine("Would you like me to tell you more about another number? (Yes/No)");
                if (Console.ReadLine().ToLower() != "yes")
                    break;

            }
        }
    }
}
