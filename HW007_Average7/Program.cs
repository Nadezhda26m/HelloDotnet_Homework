// Напишите программу, которая принимает на вход семь чисел, 
// и находит их среднее арифметическое
// 1 2 3 4 5 6 7-> 4
// 10 20 30 40 50 60 70 -> 40
// Попросим пользователя последовательно ввести числа с клавиатуры

Console.Clear();
double sum = 0;
int amount = 0;
int amTotal = 7; // Сколько чисел вводить
Console.WriteLine($"Введите {amTotal} любых чисел. После ввода каждого числа нажмите Enter.");
Console.WriteLine("Примеры написания числа: 1; 34; -8; 27,5; -347,24");
Console.WriteLine("Введены числа: ");
while (amount < amTotal)
{
    double number = double.Parse(Console.ReadLine());
    sum = sum + number;
    amount++;
}
Console.WriteLine($"Среднее арифметическое этих чисел: {sum / amTotal}");
