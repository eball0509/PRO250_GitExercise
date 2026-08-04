// How would you like to be greeted

int choice;

string choiceAsString;

Console.WriteLine("How would you like to be greeted?");

Console.WriteLine("1. Non Formal");
Console.WriteLine("2. Formal");

choiceAsString = Console.ReadLine();

choice = int.Parse(choiceAsString);

switch (choice)
{
    case 1:
        Console.WriteLine("Hey there! How's it going?");
        break;

    case 2:
        Console.WriteLine("Good day to you! How do you do?");
        break;

    default:
        Console.WriteLine("Invalid choice. Please select either 1 or 2.");
        break;
}