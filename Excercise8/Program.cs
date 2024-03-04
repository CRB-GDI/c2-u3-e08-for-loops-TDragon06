// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter Max Number: ");
int number = Int32.Parse(Console.ReadLine());

for (int i = 0; i < number; i++)
{

    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }

}

Console.WriteLine("enter a number");
int aster = Int32.Parse(Console.ReadLine());

for (int i = 0; i <= aster; i++)
{
    Console.Write("*");
}