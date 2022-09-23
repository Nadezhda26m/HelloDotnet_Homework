// < Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8 >
// Зададим искомое число случайно из множества целых чисел 
// на числовом отрезке [1,50]
// Само число N в выборку четных чисел включать не будем

Console.Clear();
int N = new Random().Next(1, 51);
Console.Write("Задумано число ");
Console.WriteLine(N);
if (N > 2)
{
    Console.Write("Список четных чисел от 1 до ");
    Console.WriteLine(N);
    int evenNum = 2;
    while (evenNum < N)
    {
        Console.Write(evenNum);
        Console.Write("  ");
        evenNum +=2;
    }
}
else
{
    Console.Write("От 1 до ");
    Console.Write(N);
    Console.WriteLine(" четных чисел нет");
}