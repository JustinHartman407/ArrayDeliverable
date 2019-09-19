using System;
// Name: Justin Hartman
// Date: 9/18/2019
// Class: ISM 4300 
// Assignment: Array & Loop


namespace ArrayDeliverable9_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Below is an array that will auto populate from 1 - 25");
            // explaining the program and what is going to happen
           
            try
            // beginning of the try catch block
            {
                
                int[] numbers = new int[26];
                // declares that the array will hold 26 elements & will automatically update
                int pop_array = 0;
                
                for (int i = 1; i < numbers.Length; i++)
                    // Iterate through the array using a For Loop
                {
                    numbers[i] = pop_array;
                    Console.WriteLine("Element Value = " + i);
                    // displays the values 
                }
                Console.WriteLine("Press any key to leave the program");
                Console.ReadKey(true);

            }
            catch
            // this is the catch block and generates a message for the user
            {
                Console.WriteLine("Error was produced, please ask administrator for help");
                Console.WriteLine("Press any key to leave the program");
                Console.ReadKey(true);

            }

        }
    }
}
