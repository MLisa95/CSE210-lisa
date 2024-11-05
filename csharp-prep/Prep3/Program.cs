using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,10);

        int guess = 0;

        do 
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess > number)
            {
                Console.Write("Guess lower. ");
            }
            else if (guess < number)
            {
                Console.WriteLine("Guess higher. ");
            }
            else
            {
                Console.WriteLine("Congratulations! You guess correct!");
            }
        }
        while (guess != number);
    }
}