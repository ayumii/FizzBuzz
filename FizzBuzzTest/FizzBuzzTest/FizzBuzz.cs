using System;

namespace FizzBuzzTest
{
    public class FizzBuzz
    {

        public static void Main()
        {
            Console.WriteLine("Please input a number from 1 to 100.");
            int input = int.Parse(Console.ReadLine());

            try
            {
                if (input >= 1 && input <= 100)
                {
                    String output = GetOutput(input);
                    Console.WriteLine(output);
                }
                else
                {
                    throw new Exception("Invalid input!");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public static string GetOutput(int input)
        {
            if (input % 3 == 0 && input % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (input % 3 == 0)
            {
                return "Fizz";
            }
            else if (input % 5 == 0)
            {
                return "Buzz";
            }

            return input.ToString();
        }




    }
}
