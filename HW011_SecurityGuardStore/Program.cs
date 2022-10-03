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
// учитывать не будем, т.к. весь этот час он внутри не будет 
// 3. Найдем максимальное значение в заполненном массиве
// 4. Найдем позиции пиковых значений в заполненном массиве
// 5. Выведем на экран промежуток(ки) времени, в который
// было больше всего посетителей

#region Methods unfit

// ------Метод ввода числа с консоли
int EnterIntNumber()
{
    return int.Parse(Console.ReadLine());
}

// ------3. Метод заполнения массива псевдослучайными числами
void Fill(int[] array, int min, int max)
{
    int size = array.Length;
    int i = 0;
    while (i < size)
    {
        array[i] = new Random().Next(min, max);
        i++;
    }
}

// -------метод ведения журнала гостей
int[] LogBuyer(int[] array, int count)
{
    int buyer = 0;
    while (buyer < count)
    {
        FillBuyer(array, GetIntValue(0, 24), GetIntValue(0, 24));
        buyer++;
    }
    return array;
}

#endregion

#region Methods

// 1. Метод получения псевдослучайного числа от min до max
int GetIntValue(int min, int max)
{
    return new Random().Next(min, max);
}

// 2. Метод создания массива с указанным кол-м элементов
int[] CreateArray(int size)
{
    return new int[size];
}

// 3. Метод добавления входа и выхода покупателя в течение суток (0-24)
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

// 4 Метод распечатывания массива
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

// 5. Метод поиска максимального элемента в массиве
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

// 6. Метод нахождения количества одинаковых элементов в массиве
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

// 7. Метод поиска позиций одинаковых элементов в массиве
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

// Метод вывода ответа



#endregion

Console.Clear();
int[] arrayDay = CreateArray(24);
// Print(arrayDay);
// int count = GetIntValue(1, 101);
Console.WriteLine("Введите количество покупателей");
int count = EnterIntNumber();
Console.WriteLine($"Количество покупателей за день: {count}");
int[] arr = { 10, 10, 20, 30, 40, 50, 60, 70, 80, 90, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 };
Print(arr); // для удобного ориентирования по часам
for (int buyer = 0; buyer < count; buyer++)
{
    FillBuyer(arrayDay, GetIntValue(0, 25), GetIntValue(0, 25)); // рандомный вход и выход
    // int minB = GetIntValue(0, 25); 
    // int maxB = GetIntValue(0, 25);
    // Console.WriteLine($"{minB} - {maxB}"); 
    // FillBuyer(arrayDay, minB, maxB); // покажет рандомные данные входа и выхода
    // FillBuyer(arrayDay, EnterIntNumber(), EnterIntNumber()); // ввести вход и выход с консоли
}
Print(arrayDay);
int max = FindMaximumValue(arrayDay);
Console.WriteLine($"Max = {max}");
int countMax = FindAmountSameItem(arrayDay, max);
Console.WriteLine($"Количество пиковых часов: {countMax}");
int[] maxHours = FindIndexSameItem(arrayDay, max, countMax);
Console.Write($"Максимальные часы: ");
Print(maxHours);
Console.WriteLine("Максимальное количество покупателей было в следующие промежутки: ");
int answer = maxHours.Length;
for (int j = 0; j < answer; j++)
{
    Console.WriteLine($"{maxHours[j]} - {maxHours[j] + 1} ч");
}
