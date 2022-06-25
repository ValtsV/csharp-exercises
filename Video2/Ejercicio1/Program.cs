Console.WriteLine("Escribe tu nombre: ");
string name = Console.ReadLine();
Console.WriteLine("Escribe tu edad: ");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Eres guay? Di Y si lo eres: ");
bool isGuay = Console.ReadLine() == "y" || Console.ReadLine() == "Y" ? true : false;

Console.WriteLine($"{name} {age} {isGuay}");