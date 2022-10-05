// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// Будем задавать случайное целое число 

Console.Clear();

int number = new Random().Next(-999_999_999, 1_000_000_000);
Console.WriteLine($"Задумали целое число {number}");
int count = 0; // количество разрядов
int num = number;
while (num != 0) // ищем количество разрядов в числе
{
    num = num / 10;
    count++;
}
if (count < 3) // проверяем, есть ли третья цифра
{
    Console.WriteLine("В этом числе третьей цифры нет");
}
else // ищем третью цифру
{
    num = number;
    int divisor = count - 2;
    int third = 0;
    if (num < 0) num = -num; // избавляемся от минуса
    for (int amount = 0; amount < divisor; amount++) // сколько раз делить на 10
    {
        third = num % 10;
        num = num / 10;
    }
    Console.WriteLine($"Третья цифра числа: {third}");
}

// Решение с семинара
// int a = new Random().Next(-999_999_999, 1_000_000_000);
// Console.WriteLine($"Задумали целое число {a}");
// if (a < 0) a = -a;
// if (a >= 100)
// {
//     while (a > 999)
//     {
//         a = a / 10;
//     }
//     Console.WriteLine(a % 10);
// }