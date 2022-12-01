// по заданому номеру четверти выдать диапазон возможных координат

int numberOfQuadrant(string str)
{
link1: Console.Clear();
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    if (number < 1 || number > 4)
    {
        Console.WriteLine("Неверная четверть! Введите значение от 1 до 4 включительно. Если понятно - нажмите ENTER");
        Console.ReadLine();
        goto link1;
    }
    else return number;
}

void periodOfCoordinates(int quadrant)
{
    switch (quadrant)
    {
        case 1:
            Console.WriteLine("Все числа по координатам X и Y больше нуля!");
            break;
        case 2:
            Console.WriteLine("Все числа по координатам X меньше 0, а Y больше нуля!");
            break;
        case 3:
            Console.WriteLine("Все числа по координатам X и Y меньше нуля!");
            break;
        case 4:
            Console.WriteLine("Все числа по координатам X больше 0, а Y меньше нуля!");
            break;
    }
}


int number = numberOfQuadrant("Введите номер четверти: ");
periodOfCoordinates(number);
Console.WriteLine("Press ENTER for Exit");
Console.ReadLine();
Console.Clear();