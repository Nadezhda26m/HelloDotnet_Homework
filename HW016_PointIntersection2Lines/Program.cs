// Задача 43: Напишите программу, которая найдёт 
// точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Точку пересечения укажем в виде координат (x, y)

// Алгоритм
// 1. Ввести с клавиатуры значения k1, b1, k2 и b2
// 2. Преобразовать уравнения прямых для поиска координат 
// точки пересечения
// 3. Найти координаты точки пересечения 

// Метод ввода вещественного числа с консоли
double InputDoubleValue()
{
    return double.Parse(Console.ReadLine());
}

Console.Clear();
Console.WriteLine("Данная программа находит координаты (x, y) "
                + "точки пересечения двух прямых, ");
Console.WriteLine("заданных уравнениями: ");
Console.WriteLine("y = k1 * x + b1, y = k2 * x + b2");
Console.WriteLine("Введите значения k1, b1, k2 и b2, после "
                + "ввода каждого значения нажмите Enter");

Console.Write($"Введите k1: ");
double k1 = InputDoubleValue();
Console.Write($"Введите b1: ");
double b1 = InputDoubleValue();
Console.Write($"Введите k2: ");
double k2 = InputDoubleValue();
Console.Write($"Введите b2: ");
double b2 = InputDoubleValue();

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
Console.WriteLine($"Точка пересечения: ({Math.Round(x, 2)};"
                                    + $"{Math.Round(y, 2)})");
