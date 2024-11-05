using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();

        string userName = PromptUserName();;
        int userNum = PromptUserNumber();

        int square = SquareNumber();
        DisplayResult();
        
    }
    static void DisplayMessage(string message)
    {
        Console.Write("Welcome to the program!");
    }
        
    static string PromptUserName ()
    {
        Console.Write("Please enter your username: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber(int userNum)
    {
        Console.Write("Please enter your lucky number: ");
        userNum = int.Parse(Console.ReadLine());
        return userNum;
    }

    static int SquareNumber (float userNum)
    {
        int square = (int)(userNum * userNum);
        return square;
    }

    static void DisplayResult (string userName, int square)
    {
        Console.WriteLine($"{userName}, your squared number is {square}.");
    }
}