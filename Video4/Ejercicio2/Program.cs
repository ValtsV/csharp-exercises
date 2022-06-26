List<int> numbers = new List<int>();
bool willAddNumber = true;
do
{ 
    Console.WriteLine("Enter a number: ");
try
{
    int input = Convert.ToInt32(Console.ReadLine());
        numbers.Add(input);
        Console.WriteLine("Press Y to add another number");
        if (Console.ReadLine() != "Y")
        {
            willAddNumber = false;
        } 
}
catch (Exception)
{
    throw;
}
} while (willAddNumber);

int positives = 0;
int negatives = 0;
int zeros = 0;

foreach (var item in numbers)
{
    if (item < 0) negatives++;
    if (item > 0) positives++;
    if (item == 0) zeros++;
}

Console.WriteLine($"Positives: {positives} Negatives: {negatives} Zeros: {zeros}");
