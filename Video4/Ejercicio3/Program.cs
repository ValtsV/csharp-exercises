Console.WriteLine("Enter height");
int height = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter width");
int width = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Press 1 to fill, 0 to leave empty");
bool fill = Convert.ToInt32(Console.ReadLine()) == 1 ? true : false;

if (fill)
{
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            Console.Write("O");
        }
        Console.WriteLine();
    }
}

if (!fill)
{
    for (int i = 0; i < height; i++)
    {
        Console.Write("O");
        for (int j = 1; j < width-1; j++)
        {
            if (i == 0 || i == height - 1)
            {
                Console.Write("O");
            } else
            {
                Console.Write(" ");

            }
        }
        Console.Write("O");
        Console.WriteLine();
    }
}
