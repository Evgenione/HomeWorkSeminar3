int x1 = coordinate("x", "A");
int y1 = coordinate("y", "A");
int z1 = coordinate("z", "A");
int x2 = coordinate("x", "B");
int y2 = coordinate("y", "B");
int z2 = coordinate("z", "B");
int coordinate(string coorName, string pointName)
{
    Console.WriteLine($"Введите координату {coorName} точки {pointName}^ ");
    return Convert.ToInt16(Console.ReadLine());
} 

double Decision (double x1, double x2,
                 double y1, double y2,
                 double z1, double z2)
{
    return Math.Sqrt(Math.Pow((x2-x1), 2)+
                     Math.Pow((y2-y1), 2)+
                     Math.Pow((z2-z1), 2));
}

double segmentLenght = Math.Round (Decision (x1, x2, y1, y2, z1, z2), 2);
Console.WriteLine($"Длина отрезка {segmentLenght}");