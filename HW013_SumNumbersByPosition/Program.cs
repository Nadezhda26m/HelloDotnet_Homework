// Задача 36: Задайте одномерный массив, заполненный 
// случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Алгоритм
// 1. Создать массив
// 2. Заполнить массив случайными числами
// 3. Распечатать массив
// 4. Посчитать сумму элементов массива на нечетных позициях 

// Методы
// 1. Метод получения случайного числа
// 2. Метод создания массива
// 3. Метод заполнения массива случайными числами от min до max
// 4. Метод вывода массива на печать
// 5. Метод, считающий сумму элементов массива на нечетных позициях  

#region Методы    
// 1. Метод получения случайного числа
int GetIntValue(int min, int max)
{
    return new Random().Next(min, max + 1);
}

// 2. Метод создания массива
int[] CreateArray(int size)
{
    return new int[size];
}

// 3. Метод заполнения массива случайными числами от min до max
void Fill(int[] array, int min, int max)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
}

// 4. Метод вывода массива на печать
string Print(int[] array)
{
    return "{" + String.Join(", ", array) + "}";
}

// 5. Метод, считающий сумму элементов массива на нечетных позициях  
int SumNumbersByUnevenPosition(int[] array)
{
    int sum = 0;
    int size = array.Length;
    for (int i = 1; i < size; i += 2)
    {
        sum = sum + array[i];
    }
    return sum;
}
#endregion

Console.Clear();
int[] arr = CreateArray(GetIntValue(5, 20));
Fill(arr, -99, 99);
Console.WriteLine($"Задан массив: {Print(arr)}");
Console.WriteLine($"Сумма элементов массива на нечетных позициях = "
                + $"{SumNumbersByUnevenPosition(arr)}");
