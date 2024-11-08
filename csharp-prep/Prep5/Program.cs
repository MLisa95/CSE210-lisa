using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();

        string userName = PromptUserName();
        
        int userNum = PromptUserNumber(5);

        int square = SquareNumber(userNum);
        
        DisplayResult(userName, square);
        
    }
    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }
        
    static string PromptUserName ()
    {
        Console.Write("Please enter your username: ");
        string userName = Console.ReadLine();
        return userName; //usually use return when there is an input from user
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