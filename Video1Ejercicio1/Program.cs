double num1 = 0;
while (true)
{
    Console.WriteLine("Enter your name: ");
    string userInput = Console.ReadLine();


    if (double.TryParse(userInput, out num1)) {
        // if the parse was successful, we can break out of the loop
        Console.WriteLine("Can't have a number for a name!!! This is not year 2098!");
    }
    else
    {
        // if the parse was unsuccessful, display an error message and try again
        Console.WriteLine("Your name is: " + userInput);
        break;
    }
}

