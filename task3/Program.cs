// найти длинну отрезка по координатам в 2Д
Console.Clear();
int pointCoordinates(string str)
{
    Console.WriteLine(str);
    int coordinate = int.Parse(Console.ReadLine());
    return coordinate;
}

void calculateLength(int x1, int y1, int x2, int y2)
{
    int coordX;
    int coordY;
    if (x2 > x1) coordX = x2 - x1;
    else coordX = x1 - x2;
    if (y2 > y1) coordY = y2 - y1;
    else coordY = y1 - y2;
    double length = Math.Pow(coordY, 2) + Math.Pow(coordX, 2);
    length = Math.Sqrt(length);

    Console.WriteLine($"Длинна отрезка составляет: {Math.Round(length, 3)}");
    Console.ReadLine();
}

int x1 = pointCoordinates("Введите координату Х первой точки: ");
int y1 = pointCoordinates("Введите координату Y первой точки: ");
int x2 = pointCoordinates("Введите координату Х второй точки: ");
int y2 = pointCoordinates("Введите координату Y второй точки: ");

Console.WriteLine($"Координаты отрезка: ({x1},{y1}) || ({x2},{y2})");

calculateLength(x1, y1, x2, y2);