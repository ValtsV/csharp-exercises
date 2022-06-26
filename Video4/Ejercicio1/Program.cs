Console.WriteLine("Enter a number:");

try
{
    int input = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i < 11; i++)
    {
        Console.WriteLine($"{input} x {i} = {input * i}");
    }
} catch (Exception e)
{
    Console.WriteLine("Enter a number next time pls");
    Console.WriteLine(e.ToString());
}

