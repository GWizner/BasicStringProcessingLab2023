bool yesNo = true;
while (yesNo)
{
    Console.WriteLine("Enter a sentence: ");
    string userInput1 = Console.ReadLine();

    string[] splitResult = userInput1.Split(' ');
    for (int i = 0; i < splitResult.Length; i++)
    {
        Console.WriteLine(splitResult[i]);
        System.Threading.Thread.Sleep(800);
    }

    Console.Write("\nWould you like to continue? (y/n): ");
    string choice1 = Console.ReadLine().ToLower().Trim();
    choice1 = choice1.Trim();
    Console.WriteLine();
    if (choice1 == "y" || choice1 == "yes")
    {
        yesNo = true;
    }
    else if (choice1 == "n" || choice1 == "no")
    {
        Console.WriteLine("Goodbye!\n");
        yesNo = false;
    }
    else
    {
        Console.WriteLine("I do not understand your input. Please try again.");
        Console.WriteLine();
    }
}

System.Threading.Thread.Sleep(1500);
int count = 0;
yesNo = true;
string userInput2 = null;
List<string> userList = new List<string>();

while (yesNo)
{
    if (count == 0)
    {
        Console.WriteLine("Create a sentance one word at a time. Enter first word: ");
        userInput2 = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine(userInput2);
        Console.WriteLine();
        userList.Add(userInput2);
        count++;
        
    }
    else
    {
        Console.WriteLine("\nEnter next word: \n");
        string userInput3 = Console.ReadLine();
        Console.WriteLine();
        userList.Add(userInput3);

        for (int i = 0; i < userList.Count; i++)
        {
            Console.Write($"{userList[i]}" + " ");
            System.Threading.Thread.Sleep(800);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine("Would you like to continue? (y/n): \n");
    string choice2 = Console.ReadLine().ToLower().Trim();
    choice2 = choice2.Trim();
    
    if (choice2 == "y" || choice2 == "yes")
    {
        yesNo = true;
    }
    else if (choice2 == "n" || choice2 == "no")
    {
        Console.WriteLine("Goodbye!");
        yesNo = false;
    }
    else
    {
        Console.WriteLine("I do not understand your input. Please try again.");
        Console.WriteLine();
    }

}