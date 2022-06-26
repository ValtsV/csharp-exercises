double price = 24.99;

Console.WriteLine("Enter name: ");
string name = Console.ReadLine();
Console.WriteLine("Enter email: ");
string email = Console.ReadLine();
Console.WriteLine("Enter cupon code: ");
string cuponCode = Console.ReadLine();

double reduction = Convert.ToInt32(cuponCode.Substring(cuponCode.Length - 2));

double newPrice = price - (reduction / 100 * price);

Console.WriteLine($"{name} {email} {price} {Math.Round(newPrice, 2)}");
