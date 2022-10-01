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

// 3. Метод добавления входа и выхода покупателя
void FillBuyer(int[] array, int min, int max)
{
    if (min > max)
    {
        int help = min;
        min = max;
        max = help;
    }
    int i = min;
    while (i <= max)
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
int MaximumValue(int[] arr)
{
    int leng = arr.Length;
    int max = arr[0];
    for (int i = 0; i < leng; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}

// 6. Метод поиска позиций одинаковых элементов в массиве




#endregion

Console.Clear();
int[] arr = { 10, 10, 20, 30, 40, 50, 60, 70, 80, 90, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 };
Print(arr);
int[] arrayDay = CreateArray(24);
// Print(arrayDay);
// int count = GetIntValue(1, 101);
int count = EnterIntNumber();
Console.WriteLine($"Количество покупателей за день: {count}");
for (int buyer = 0; buyer < count; buyer++)
{
    FillBuyer(arrayDay, GetIntValue(0, 24), GetIntValue(0, 24));
    // FillBuyer(arrayDay, EnterIntNumber(), EnterIntNumber());
}
Print(arrayDay);
int max = MaximumValue(arrayDay);
Console.WriteLine(max);


// Log(arrayDay, 100);
// Print(arrayDay);


