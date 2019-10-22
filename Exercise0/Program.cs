using System;

namespace Exercise0
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepAlive = true; 
            while (keepAlive)
            {
                try
                {
                    Console.Write("Enter assignement number (or -1 to exit):");
                    int assignementChoice = int.Parse(Console.ReadLine() ?? "");
                    Console.ForegroundColor = ConsoleColor.Green;
                    switch (assignementChoice)
                    {
                        case 1:
                            RunExerciseOne();
                            break;
                        case 2:
                            RunExerciseTwo();
                            break;
                        case 3:
                            // Call your next assigment method here!
                            break;
                        case -1:
                            keepAlive = false;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("That is not a valid option");
                            break;
                    }
                    Console.ResetColor();
                    Console.WriteLine("Hit any key to continue");
                    Console.ReadKey();
                    Console.Clear();

                
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not a valid option");
                    Console.ResetColor();
                }
            }
        }
        private static void RunExerciseOne()
        {
            Console.WriteLine("First Name:");
            String firstName = Console.ReadLine();
            Console.WriteLine("Surname:");
            String surname = Console.ReadLine();
            Console.WriteLine("Hello " + firstName + " " + surname + "! you have passed this exercise");
        }
        private static void RunExerciseTwo()
        {
            DateTime timenow = DateTime.Now;
            Console.WriteLine("Todays date is " + timenow);
        }
    }
}
 