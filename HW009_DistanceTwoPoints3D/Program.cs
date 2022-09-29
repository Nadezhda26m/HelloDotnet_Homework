// Напишите метод, который принимает на вход 
// координаты двух точек и находит расстояние 
// между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Алгоритм
// 1. Ввести координаты первой точки
// 2. Ввести координаты второй точки
// 3. Найти расстояние между точками

// Методы
// 1. Метод ввода числа с консоли
// 2. Метод ввода с консоли координат точки в 3D пространстве
// 3. Метод нахождения расстояния между точками в 3D пространстве

#region Methods
    
// Метод ввода числа с консоли
double EnterIntNumberConsole()
{
    return double.Parse(Console.ReadLine());
}

// Метод ввода координат точки в 3D пространстве
double[] GetCoordinatesPoint3D()
{
    double[] point = new double[3];
    Console.Write("По оси Ox: ");
    point[0] = EnterIntNumberConsole();
    Console.Write("По оси Oy: ");
    point[1] = EnterIntNumberConsole();
    Console.Write("По оси Oz: ");
    point[2] = EnterIntNumberConsole();
    return point;
}

// Метод нахождения расстояния между точками в 3D
double Distance(double[] pointA, double[] pointB)
{
    double squareDist = 0;
    int index = 0;
    while (index < 3)
    {
        squareDist = squareDist + Math.Pow((pointA[index] - pointB[index]), 2);
        index++;
    }
    double distance = Math.Sqrt(squareDist);
    return distance;
}
#endregion

Console.Clear();
Console.WriteLine("Введите координаты точки A в 3D пространстве: ");
double[] pointD = GetCoordinatesPoint3D();
Console.WriteLine("Введите координаты точки B в 3D пространстве: ");
double[] pointF = GetCoordinatesPoint3D();
Console.WriteLine($"Расстояние между точками = {Distance(pointD, pointF)}");
