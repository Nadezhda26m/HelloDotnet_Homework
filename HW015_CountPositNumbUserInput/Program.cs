// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

// Алгоритм
// 1. Задать количество чисел, вводимых пользователем
// 2. Ввести числа с клавиатуры
// 3. Посчитать количество введенных > 0 чисел
// 4. Напечатать результат

// Методы
// 1. Метод ввода целого числа с консоли
// 2. Метод ввода вещественного числа с консоли

// 1. Метод ввода целого числа с консоли
int InputIntValue()
{
        return int.Parse(Console.ReadLine());
}

// 2. Метод ввода вещественного числа с консоли
double InputDoubleValue()
{
    return double.Parse(Console.ReadLine());
}

Console.Clear();
//// Ввод количества чисел с консоли
// Console.WriteLine("Введите количество чисел (в виде целого числа), "
//                 + "которые будут введены ");
// Console.WriteLine("далее в программу, и нажмите Enter");
// int countNumb = InputIntValue();
int countNumb = 5;
int counPositive = 0;
Console.WriteLine("Введите целые или вещественные числа. "
                + "После ввода каждого числа нажмите Enter.");
Console.WriteLine("Пример ввода числа: -123; -15,43; 35");
Console.WriteLine($"Количество чисел для ввода: {countNumb}");
for (int i = 0; i < countNumb; i++)
{
    double number = InputDoubleValue();
    if (number > 0) counPositive++;
}
Console.WriteLine($"Введенных чисел больше ноля: {counPositive}");
