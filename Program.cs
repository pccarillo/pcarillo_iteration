using System;

namespace pcarillo_iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Display a message showing inputs that program accepts
                Console.Write("Enter number between 1 and 100: ");

                // Collect number from user
                int number = Convert.ToInt32(Console.ReadLine());

                // Evaluate if number is between 1 and 100
                if(number >= 1 && number <= 100)
                {
                    // Display user input and iterate 100 times
                    for (int i = 1; i <= number ; i++)
                    {
                        // print user input and a message displaying current iteration
                        Console.WriteLine("You have entered " + number + ". This is the current integer value in the loop: " + i);
                    }
                }
                else
                {
                    // Display a warning message
                    Console.WriteLine("Please, enter a value between 1 and 100");
                }
            }
            catch
            {
                // Display a warning message
                Console.WriteLine("You didn't enter an integer. Please, enter an integer.");
            }
        }   
    }
}