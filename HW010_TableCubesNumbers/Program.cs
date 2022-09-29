// Напишите метод, который принимает на вход 
// число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Алгоритм
// 1. Ввести натуральное число number с консоли
// 2. Возвести каждое число от 1 до number в 3 степень 
// 3. Распечатать результат

// Методы
// 1. Метод ввода числа с консоли
// 2. Метод возведения числа в степень
// 3. Метод получения списка чисел (от 1 до max), возведенных в степень

#region Methods
// Метод ввода числа с консоли
int EnterIntNumberConsole()
{
    return int.Parse(Console.ReadLine());
}

// Метод возведения числа в степень
int GetPower(int number, int power)
{
    int index = 1;
    int result = number;
    while (index < power)
    {
        result = result * number;
        index++;
    }
    return result;
}

// Метод получения списка чисел (от 1 до max), возведенных в степень
void TableDegrees(int number, int power)
{
    int currentNum = 1;
    int numberExpon = 1;
    while (currentNum <= number)
    {
        numberExpon = GetPower(currentNum, power);
        Console.Write(numberExpon + "  ");
        currentNum++;
    }
}
#endregion

Console.Clear();
Console.WriteLine("Данная программа выдает список кубов чисел от 1 до N включительно, ");
Console.WriteLine("где N - натуральное число");
Console.Write("Введите N: ");
int num = EnterIntNumberConsole();
if (num > 0)
{
    Console.WriteLine($"Числа от 1 до {num} в кубе: ");
    TableDegrees(num, 3);
}
else
{
    Console.WriteLine("Вы ввели неверное значение");
}
