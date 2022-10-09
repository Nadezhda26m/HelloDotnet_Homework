// Задача 34: Задайте массив, заполненный случайными 
// положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Алгоритм
// 1. Создать массив
// 2. Заполнить массив случайными положительными трёхзначными числами
// 3. Распечатать массив
// 4. Посчитать количество четных чисел в созданном массиве 

// Методы
// 1. Метод получения случайного числа
// 2. Метод создания массива
// 3. Метод заполнения массива случайными числами от min до max
// 4. Метод вывода массива на печать
// 5. Метод, считающий количество четных чисел в массиве 

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

// 5. Метод, считающий количество четных чисел в массиве 
int CountEvenNumbers(int[] array)
{
    int count = 0;
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}
#endregion

Console.Clear();
int[] numbers = CreateArray(GetIntValue(10, 15));
Fill(numbers, 100, 999);
Console.WriteLine("Задан массив из случайных положительных трёхзначных чисел: ");
Console.WriteLine(Print(numbers));
Console.WriteLine($"Количество четных чисел в массиве: "
                + $"{CountEvenNumbers(numbers)}");
