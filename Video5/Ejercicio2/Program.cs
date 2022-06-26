List<string> list = new List<string> { "JS", "C#", "Java", "C", "Python" };
foreach (var item in list)
{
    Console.WriteLine(item);
}

Console.WriteLine("Choose language from 1 to 5");

int number = Convert.ToInt32(Console.ReadLine());

switch (number)
{
    case 1:
        Console.WriteLine(list[0]);
        break;
    case 2:
        Console.WriteLine(list[1]);
    break;
    case 3:
        Console.WriteLine(list[2]);
    break;
    case 4:
        Console.WriteLine(list[3]);
    break;
    case 5:
        Console.WriteLine(list[4]);
    break;

    default:
        break;
}
