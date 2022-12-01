// Вывести все квадраты от 1 до N

void stepN(int num)
{
    int count = 1;
    while (count <= num)
    {
        if (count == 1) Console.Write(Math.Pow(count, 2));
        else
        {
            Console.Write(",");
            Console.Write(Math.Pow(count, 2));
        }
        count++;
    }
    Console.WriteLine();
    Console.WriteLine("---------------------------------------");
    Console.WriteLine("THE END! PRESS ENTER!");
    Console.ReadLine();
}


Console.Clear();
Console.WriteLine("Enter the N: ");
int number = int.Parse(Console.ReadLine());

stepN(number);