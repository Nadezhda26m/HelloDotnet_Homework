// Напишите метод, который принимает на вход 
// пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Алгоритм
// 1. Ввести натуральное пятизначное число
// 2. Сделать проверку на корректность введенных данных
// 3. Проверить равенство первого и последнего, 
// второго и четвертого элементов
// 4. Вывести результат, является ли число палиндромом

// Методы
// 1. Метод получения псевдослучайного числа от min до max
// 2. Метод ввода числа с консоли
// 3. Метод подсчета количества разрядов в числе
// 4. Метод проверки числа на принадлежность к натуральным и на количество разрядов
// 5. Метод проверки натурального пятизначного числа на палиндром

#region Методы
// Метод получения псевдослучайного числа от min до max
int GetIntValue(int min, int max)
{
    return new Random().Next(min, max);
}

// Метод ввода числа с консоли
int EnterIntNumberConsole()
{
    return int.Parse(Console.ReadLine());
}

// Метод подсчета количества разрядов в числе
int CountDigits(int number)
{
    int num = Math.Abs(number);
    int count = 0;
    while (num > 0)
    {
        num = num / 10;
        count += 1;
    }
    return count;
}

// Метод проверки числа на принадлежность к натуральным и на количество разрядов
bool CheckLengthPositiveInteger(int number, int desiredLength)
{
    bool flag = false;
    int size = CountDigits(number);
    if (number > 0 && size == desiredLength)
    {
        flag = true;
    }
    return flag;
}

// Метод проверки натурального пятизначного числа на палиндром
void CheckPalindromeFiveDigits(int number)
{
    int digit2 = (number / 1000) % 10;
    int digit4 = (number % 100) / 10;
    if (number / 10000 == number % 10 && digit2 == digit4)
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом");
    }
}
#endregion

Console.Clear();
Console.WriteLine("Введите натуральное пятизначное число и нажмите Enter: ");
int number = EnterIntNumberConsole();
// Console.WriteLine("Задумано натуральное пятизначное число: ");
// int number = GetIntValue(10000, 100000);
// Console.WriteLine(number);
if (CheckLengthPositiveInteger(number, 5))
{
    CheckPalindromeFiveDigits(number);
}
else
{
    Console.WriteLine("Вы ввели неверные данные");
}
