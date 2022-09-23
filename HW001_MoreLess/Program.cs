// <Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3>
// Будем сравнивать целые числа, заданные рандомно 
// на числовом отрезке [-100, 100]

Console.Clear();
int numberA = new Random().Next(-100, 101);
int numberB = new Random().Next(-100, 101);
Console.Write("Задумано первое число ");
Console.WriteLine(numberA);
Console.Write("Задумано второе число ");
Console.WriteLine(numberB);
if (numberA > numberB)
{
    Console.Write("Число ");
    Console.Write(numberA);
    Console.WriteLine(" больше");
    Console.Write("Число ");
    Console.Write(numberB);
    Console.WriteLine(" меньше");
}
else
{
    if (numberA == numberB)
    {
        Console.WriteLine("Оба числа равны");
    }
    else
    {
        Console.Write("Число ");
        Console.Write(numberB);
        Console.WriteLine(" больше");
        Console.Write("Число ");
        Console.Write(numberA);
        Console.WriteLine(" меньше");
    }
}