using System;
namespace MethodsWithLoopsAndConditionals
{


    public class Methods
    {

        public static void Numbers1000ToNegative1000()

        {

                for (int i = 1000; i >= -1000; i--)
                {
                    Console.WriteLine(i);
                }

        }



        public static void ThreeThrough999By3()
        {
            for (int i = 3; i <= 999; i+=3)
            {
                Console.WriteLine(i);
            }
        }



        public static void CheckIfEqual(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine($"{num1} is equal to {num2}");

            }
            else
            {
                Console.WriteLine($"{num1} is not equal to {num2}");
            }
        }


        public static void OddOrEven()
        {
            Console.WriteLine("Please enter a number to check if it's odd or even");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput % 2 ==0)
            {
                Console.WriteLine($"{userInput} is even");
            }
            else
            {
                Console.WriteLine($"{userInput} is odd");
            }
        }



        public static void IsPositiveOrNegative(int num)
        {
            if (num >0)
            {
                Console.WriteLine($"{num} is positive");
            }
            else
            {
                Console.WriteLine($"{num} is negative");
            }
        }


        public static void VotingAge()
        {
            Console.WriteLine("What is your age?");
            var input = int.Parse(Console.ReadLine());
            if (input >= 18)
            {
                Console.WriteLine("You can vote");
            }
            else
            {
                Console.WriteLine("You cannot vote.");
            }
        }

        public static void InRange()
        {
            Console.WriteLine("Enter a number to check if it's in range");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput <= 10 && userInput >= -10)
            {

                Console.WriteLine("Your number is range!");
             
            }
            else
            {
                Console.WriteLine("Your number is not in range");
            }
        }


        public static void MultiplicationTable(int num)
        {
            for (int i = 1; i <=12; i++)
            {
                var answer = i * num;
                Console.WriteLine($" {i} x {num} = {answer}");
            }
        }



    }

}


