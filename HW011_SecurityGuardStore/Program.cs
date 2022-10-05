// Есть магазин "Еда"
// В магазине есть охранник
// Охранник ведёт запись всех, кто заходит в магазин
// Охранник ведёт запись всех, кто выходит из магазина
// Зайти и выйти можно в целый час.
// Выяснить, в какой промежуток времени было больше всего
// посетителей
// Данные вводятся парами: приход-уход
// Максимум 100 покупателей
// Входные данные
// 10-12
// 11-13
// 9-12
// Ответ
// 11-12

// Алгоритм
// 1. Зададим массив, в который будем добавлять часы нахождения 
// в магазине покупателей. Рассматриваем целые сутки от 0 до 24
// 2. Заполним массив, передав в него данные входа 
// и выхода покупателей. Час, в который покупатель выходит, 
// учитывать не будем, т.к. весь этот час он внутри не находится 
// 3. Найдем максимальное значение в заполненном массиве
// 4. Выведем на экран промежуток(ки) времени, в который
// было больше всего посетителей (если пик был в 12 ч, то промежуток 12-13 ч)

// Методы
// 1. Метод получения псевдослучайного числа от min до max
// 2. Метод ввода числа с консоли
// 3. Метод создания массива с указанным кол-м элементов
// 4. Метод добавления входа и выхода покупателя в течение суток (0-24)
// 5. Метод распечатывания массива
// 6. Метод поиска максимального элемента в массиве с минимум 1 элементом

#region 1. Methods unfit
// ------Метод ведения журнала гостей
void LogBuyer(int[] array, int count)
{
    int buyer = 0;
    while (buyer < count)
    {
        FillBuyer(array, GetIntValue(0, 24), GetIntValue(0, 24));
        buyer++;
    }
}

// ------Метод нахождения количества одинаковых элементов в массиве
int FindAmountSameItem(int[] array, int item)
{
    int length = array.Length;
    int amount = 0;
    for (int index = 0; index < length; index++)
    {
        if (array[index] == item) amount = amount + 1;
    }
    return amount;
}

// ------Метод поиска позиций одинаковых элементов в массиве
int[] FindIndexSameItem(int[] array, int item, int countItem)
{
    int[] arrayIndex = new int[countItem];
    int size = array.Length;
    int pos = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] == item)
        {
            arrayIndex[pos] = i;
            pos++;
        }
    }
    return arrayIndex;
}
#endregion

#region 2. Methods
// 1. Метод получения псевдослучайного числа от min до max
int GetIntValue(int min, int max)
{
    return new Random().Next(min, max);
}

// 2. Метод ввода числа с консоли
int EnterIntNumber()
{
    return int.Parse(Console.ReadLine());
}

// 3. Метод создания массива с указанным кол-м элементов
int[] CreateArray(int size)
{
    return new int[size];
}

// 4. Метод добавления входа и выхода покупателя в течение суток (0-24)
void FillBuyer(int[] array, int min, int max)
{
    if (min > max) // на случай задания min и max рандомом или в обратном порядке
    {
        int help = min;
        min = max;
        max = help;
    }
    int i = min;
    while (i < max)
    {
        array[i] = array[i] + 1;
        i++;
    }
}

// 5. Метод распечатывания массива
void Print(int[] array)
{
    int i = 0;
    int size = array.Length;
    while (i < size)
    {
        Console.Write(array[i] + " ");
        i++;
    }
    Console.WriteLine();
}

// 6. Метод поиска максимального элемента в массиве с минимум 1 элементом
int FindMaximumValue(int[] arr)
{
    int leng = arr.Length;
    int max = arr[0];
    for (int i = 0; i < leng; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}
#endregion

#region 3. Основное решение 
Console.Clear();
int[] arrayDay = CreateArray(24);
Console.Write("Введите количество покупателей за день: ");
int count = EnterIntNumber();
for (int buyer = 0; buyer < count; buyer++)
{
    FillBuyer(arrayDay, GetIntValue(0, 25), GetIntValue(0, 25)); // рандомный вход и выход
}
Console.WriteLine("Количество покупателей в каждом часу (от 0 до 24 ч): ");
Print(arrayDay);
int max = FindMaximumValue(arrayDay);
if (max > 0)
{
    Console.WriteLine($"Максимальное количество покупателей ({max}) было в следующие промежутки: ");
    int size = arrayDay.Length;
    for (int m = 0; m < size - 1; m++)
    {
        if (arrayDay[m] == max)
        {
            for (int k = m + 1; k < size; k++)
            {
                if (arrayDay[m] != arrayDay[k])
                {
                    Console.WriteLine($"{m} - {k} ч");
                    m = k;
                    k = size - 1;
                }
                else if (k == size - 1)
                {
                    Console.WriteLine($"{m} - {k + 1} ч");
                    m = k + 1;
                }
            }
        }
    }
}
else Console.WriteLine("Покупателей в течение дня не было");
#endregion

#region 4. Программа с различными способами ввода данных и выводом промежуточных данных

// Console.Clear();
// int[] arrayDay = CreateArray(24);
// // Print(arrayDay);
// Console.Write("Введите количество покупателей за день: ");
// int count = EnterIntNumber(); // ввод количества покупателей с консоли
// // int count = GetIntValue(1, 101); // рандомное количество покупателей
// // Console.WriteLine($"Количество покупателей за день: {count}");
// for (int buyer = 0; buyer < count; buyer++)
// {
//     FillBuyer(arrayDay, GetIntValue(0, 25), GetIntValue(0, 25)); // рандомный вход и выход
//     // int minB = GetIntValue(0, 25);
//     // int maxB = GetIntValue(0, 25);
//     // Console.WriteLine($"{minB} - {maxB}");
//     // FillBuyer(arrayDay, minB, maxB); // покажет рандомные данные входа и выхода
//     // FillBuyer(arrayDay, EnterIntNumber(), EnterIntNumber()); // ввести вход и выход с консоли
// }
// int[] arr = { 10, 10, 20, 30, 40, 50, 60, 70, 80, 90, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 };
// // int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1, 2, 3 };
// // Print(arr); // для удобного ориентирования по часам
// Print(arrayDay);
// int max = FindMaximumValue(arrayDay);
// if (max > 0)
// {
//     Console.WriteLine($"Max = {max}");
//     int countMax = FindAmountSameItem(arrayDay, max);
//     Console.WriteLine($"Количество пиковых часов: {countMax}");
//     int[] maxHours = FindIndexSameItem(arrayDay, max, countMax);
//     Console.Write($"Максимальные часы: ");
//     Print(maxHours);
//     Console.WriteLine($"Максимальное количество покупателей ({max}) было в следующие промежутки: ");
//     int size = arrayDay.Length;
//     for (int m = 0; m < size - 1; m++)
//     {
//         if (arrayDay[m] == max)
//         {
//             for (int k = m + 1; k < size; k++)
//             {
//                 if (arrayDay[m] != arrayDay[k])
//                 {
//                     Console.WriteLine($"{m} - {k} ч");
//                     m = k;
//                     k = size - 1;
//                 }
//                 else if (k == size - 1)
//                 {
//                     Console.WriteLine($"{m} - {k + 1} ч");
//                     m = k + 1;
//                 }
//             }
//         }
//     }
// }
// else Console.WriteLine("Покупателей в течение дня не было");
#endregion