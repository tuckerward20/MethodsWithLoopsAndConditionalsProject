using System;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            //AllThousand();
            //ThreePiece();
            //AreEqual();
            //EvenOrOdd();
            //PosOrNeg();
            //CanYouVote();
            TenToTen();
        }
        //LukeWarm Section
        /*
        //Write a method that will print to the console all numbers 1000 through -1000.
        static void AllThousand()
        {
            for (int i = -1000; i <= 1000; i++)
            {
                Console.WriteLine(i);
            }
        }
        
        //Write a method that will print to the console numbers 3 through 999 by 3 each time.
        static void ThreePiece()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }
        
        //Write a method to accept two integers as parameters and check whether they are equal or not.
        static void AreEqual()
        {
            
            Console.WriteLine("Enter the first number: ");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            var b = Convert.ToInt32(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine($"{a} is equal to {b}");
            }
            else
            {
                Console.WriteLine($"{a} is not equal to {b}");
            }
        }
        
        //Write a method to check whether a given number is even or odd.
        static void EvenOrOdd()
        {
            Console.WriteLine("Enter any number: ");
            var a = Convert.ToInt32(Console.ReadLine());
            
            if (a == 0)
            {
                Console.WriteLine($"Nice try, but 0 is actually even");
            }
            else if (a % 2 == 0)
            {
                Console.WriteLine($"{a} is even");
            }
            else if (a % 2 == 1)
            {
                Console.WriteLine($"{a} is odd");
            }
            else
            {
                Console.WriteLine("Invalid input, try again:");
                a = Convert.ToInt32(Console.ReadLine());
            }
        }
        
        //Write a method to check whether a given number is positive or negative.
        static void PosOrNeg()
        {
            for (int i = 1; i < 2;)
            {
                Console.WriteLine("Enter any number: ");
                var a = Console.ReadLine();
                int intA;
                bool success = Int32.TryParse(a, out intA);
                if (success)
                {
                    if (intA > 0)
                    {
                        Console.WriteLine($"{intA} is positive");
                        i++;
                    }
                    else if (intA < 0)
                    {
                        Console.WriteLine($"{intA} is negative");
                        i++;
                    }
                    else
                    {
                        Console.WriteLine($"{intA} is neither positive or negative");
                        i++;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, try again");
                }
                
            }
            
        }
        
        //Write a method to read the age of a candidate and determine whether they can vote. Hint: use Parse()... or the safer TryParse() for an extra challenge!!
        static void CanYouVote()
        
        {
            for (int i = 1; i < 2;)
            {
                Console.WriteLine("Do you know if you are old enough to vote? I can help you find out.");
                Console.WriteLine("What is your age?: ");
                var a = Console.ReadLine();
                int intA;
                bool success = Int32.TryParse(a, out intA);
                if (success)
                {
                    if (intA >= 18)
                    {
                        Console.WriteLine($"You are old enough to vote");
                        i++;
                    }
                    else
                    {
                        Console.WriteLine($"You are not old enough to vote");
                        i++;
                    }
                    
                }
                else
                {
                    Console.WriteLine("Invalid input, try again");
                }
                
            }
            
        }
        
        */
        //Heatin Up Section

        //Write a method to check if an integer(from the user) is in the range -10 to 10.
        static void TenToTen()

        {
            for (int i = 1; i < 2;)
            {
                Console.WriteLine("Input an integer from -10 to 10: ");
                
                var a = Console.ReadLine();
                int intA;
                bool success = Int32.TryParse(a, out intA);
                if (success)
                {
                    if (intA >= -10 && intA <= 10)
                    {
                        Console.WriteLine($"You did it!");
                        i++;
                    }
                    else
                    {
                        Console.WriteLine($"Please try again");
                        
                    }


                }
                else
                {
                    Console.WriteLine("Invalid input, try again");
                }

            }

        }
        //Write a method to display the multiplication table(from 1 to 12) of a given integer.
        ($"{multArray}")
    }
}
