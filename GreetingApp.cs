using System;

internal class GreetingApp
{
    private static void Main()
    {
        int choice;

        string? choiceAsString;

        while (true)
        {
            Console.WriteLine("How would you like to be greeted?");

            Console.WriteLine("1. Non Formal");
            Console.WriteLine("2. Formal");

            choiceAsString = Console.ReadLine();

            choice = int.Parse(choiceAsString);

            switch (choice)
            {
                case 1:
                    NonFormal();
                    break;

                case 2:
                    Formal();
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select either 1 or 2.");
                    break;
            }

            break;
        }
    }

    protected static void NonFormal()
    {
        string message = "Hey there! How's it going?";
        
        if (message == null)
        {
            Console.WriteLine("hello friend");
        }

        Console.WriteLine(message);
    }

    protected static void Formal()
    {
        Console.WriteLine("Good day to you. How do you do?");
    }
}