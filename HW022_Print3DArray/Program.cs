// Задача 60. ...Сформируйте трёхмерный массив из 
// неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя 
// индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Алгоритм
// 1. Задать трехмерный массив
// 2. Заполнить массив неповторяющимеся двузначными числами
// 3. Распечатать массив построчно с указанием индексов

// Методы
// 1. Метод создания трехмерного массива
// 2. Метод получения чисел из отрезка в случайном порядке 
// без повтора
// 2.1 Метод получения нескольких чисел из отрезка 
// в случайном порядке без повтора
// 3. Метод заполнения трехмерного массива числами
// из одномерного массива
// 4. Метод печати трехмерного массива в консоль по рядам
// с указанием индексов каждого элемента

#region Методы
// 1. Метод создания трехмерного массива
int[,,] CreateCube(int layer, int row, int col)
{
    return new int[layer, row, col];
}

// 2. Метод получения чисел из отрезка в случайном порядке 
// без повтора
int[] GetAllDifferentIntNumbers(int min, int max)
{
    int size = Math.Abs(min - max) + 1;
    int[] differentNums = new int[size];
    int number = 0;
    for (int i = 0; i < size; i++)
    {
        number = new Random().Next(min, max + 1);
        for (int j = 0; j < i; j++)
        {
            if (differentNums[j] == number)
            {
                number = new Random().Next(min, max + 1);
                j = -1;
            }
        }
        differentNums[i] = number;
    }
    return differentNums;
}

// 2.1 Метод получения нескольких чисел из отрезка 
// в случайном порядке без повтора
int[] GetSomeDifferentIntNumbers(int count, int min, int max)
{
    int[] differentNums = new int[count];
    int number = 0;
    for (int i = 0; i < count; i++)
    {
        number = new Random().Next(min, max + 1);
        for (int j = 0; j < i; j++)
        {
            if (differentNums[j] == number)
            {
                number = new Random().Next(min, max + 1);
                j = -1;
            }
        }
        differentNums[i] = number;
    }
    return differentNums;
}

// 3. Метод заполнения трехмерного массива числами
// из одномерного массива
void Fill3DArrayFrom(int[] numbers, int[,,] array3D)
{
    int layer = array3D.GetLength(0);
    int row = array3D.GetLength(1);
    int col = array3D.GetLength(2);
    int count = numbers.Length;
    for (int i = 0; i < layer; i++)
    {
        for (int j = 0; j < row; j++)
        {
            for (int k = 0; k < col; k++)
            {
                array3D[i, j, k] = numbers[i * row * col + j * col + k];
            }
        }
    }
}

// 4. Метод печати трехмерного массива в консоль по рядам
// с указанием индексов каждого элемента
void Print3DArrayWithIndex(int[,,] array3D)
{
    int layer = array3D.GetLength(0);
    int row = array3D.GetLength(1);
    int col = array3D.GetLength(2);
    for (int i = 0; i < layer; i++)
    {
        for (int j = 0; j < row; j++)
        {
            for (int k = 0; k < col; k++)
            {
                Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
#endregion Методы

Console.Clear();
int[,,] cube = CreateCube(3, 4, 6);
int layer = cube.GetLength(0);
int row = cube.GetLength(1);
int col = cube.GetLength(2);
int countElements = layer * row * col;
int rangeStart = 10;
int rangeEnd = 99;
Console.WriteLine($"Задан трехмерный массив размером "
                + $"{layer} x {row} x {col}");
Console.WriteLine($"Данный массив нужно заполнить неповторяющимися "
                + $"числами из отрезка [{rangeStart},{rangeEnd}]");
if (countElements <= rangeEnd - rangeStart + 1)
{
    int[] num = GetSomeDifferentIntNumbers
                (countElements, rangeStart, rangeEnd);
    // Console.WriteLine(String.Join(",", num));
    // Console.WriteLine();
    Fill3DArrayFrom(num, cube);
    Console.WriteLine("Полученный массив (с указанием индексов "
                    + "каждого элемента):");
    Print3DArrayWithIndex(cube);
}
else 
{
    Console.WriteLine();
    Console.WriteLine("Чисел из выбранного диапазона недостаточно "
                    + "для заполнения заданного массива");
    Console.WriteLine("Измените размер массива или диапазон чисел");
}