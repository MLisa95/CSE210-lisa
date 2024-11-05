using System;

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();

        int userNum = 0;

        do
        {
            
            Console.Write("Please enter a number: ");
            userNum = int.Parse(Console.ReadLine());

            if (userNum != 0)
            {
                numbers.Add(userNum);
            }
        }
        while (userNum != 0);

        Console.WriteLine(numbers.Count);

        int sum = numbers.Sum();
        double average = numbers.Average();
        int max = numbers.Max();
        int min = numbers.Min();

        Console.WriteLine($"The sum of your list is {sum}");
        Console.WriteLine($"The average of your list is {average}.");
        Console.WriteLine($"The maximum number in your list is {max}");
        Console.WriteLine($"The minimum number in your list is {min}");
    }
}