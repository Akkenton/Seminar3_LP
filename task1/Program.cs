// Программа принимает на вход Х У и определяет номер плоскости

link1: Console.Clear();
Console.WriteLine("Enter X: ");
int X = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Y: ");
int Y = int.Parse(Console.ReadLine());

if (X == 0 || Y == 0)
{
    Console.WriteLine("Координаты не должны быть равны нулю! Если понятно - нажмите ENTER");
    Console.ReadLine();
    goto link1;
}

if (X < 0)
{
    if (Y > 0) Console.WriteLine("Плоскость 2");
    else Console.WriteLine("Плоскость 3");
}
else
{
    if (Y > 0) Console.WriteLine("Плоскость 1");
    else Console.WriteLine("Плоскость 4");
}