Console.WriteLine("Enter number");

bool number = Convert.ToInt32(Console.ReadLine()) >= 18;

Console.WriteLine("Enter a char");

bool character = Convert.ToChar(Console.ReadLine()) == 'a';

bool bothTrue = number && character;

bool isOneTrueAndOtherFalse = (number && !character) || (!number && character);