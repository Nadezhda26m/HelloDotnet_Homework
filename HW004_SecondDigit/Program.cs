// Напишите программу, которая принимает 
// на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
// P.S.: пользователь умный и вводит только целые числа) 

Console.Clear();
Console.WriteLine("Введите любое целое число от 100 до 999");
int n = int.Parse(Console.ReadLine());
bool test = true;
if (n < 100)
{
    test = false;
}
else if (n > 999)
{
    test = false;
}
if (!test)
{
    Console.WriteLine("Вы ввели неверное значение");
}
else 
{
    int first = n / 10;
    int second = first % 10;
    Console.WriteLine($"Вторая цифра числа: {second}");
}

