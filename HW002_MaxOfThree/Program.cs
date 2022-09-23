// Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
// Будем сравнивать целые числа, заданные рандомно 
// на числовом отрезке [-100, 100]

Console.Clear();
int num1 = new Random().Next(-100, 101);
int num2 = new Random().Next(-100, 101);
int num3 = new Random().Next(-100, 101);
Console.Write("Задумано три числа: ");
Console.Write(num1);
Console.Write(", ");
Console.Write(num2);
Console.Write(", ");
Console.WriteLine(num3);

int max = num1;
if (num2 > max)
{
    max = num2;
}
if (num3 > max)
{
    max = num3;
}
Console.Write("Максимальным является число ");
Console.WriteLine(max);