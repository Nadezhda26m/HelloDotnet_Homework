// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет 

// Алгоритм
// 1. Создать массив
// 2. Заполнить массив 
// 3. Распечатать массив
// 4. Ввести позиции элемента для поиска
// 5. Показать значение элемента или указать на его отсутствие

// Методы
// 1. Метод получения случайного целого числа
// 2. Метод создания двумерного массива
// 3. Метод заполнения матрицы случайными целыми числами
// 4. Метод печати матрицы в консоль с разделителем
// 5. Метод, проверяющий наличие элемента с 
// указанным индексом в матрице

#region Методы
// 1. Метод получения случайного целого числа
int GetIntValue(int min, int max)
{
    return new Random().Next(min, max + 1);
}

// 2. Метод создания двумерного массива
int[,] CreateMatrix(int row, int col)
{
    return new int[row, col];
}

// 3. Метод заполнения матрицы случайными целыми числами
void Fill(int[,] matrix, int min, int max)
{
    int row = matrix.GetLength(0);
    int col = matrix.GetLength(1);
    for (int i = 0; i < row; i++)
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
}

// 4. Метод печати матрицы в консоль с разделителем
void Print(int[,] matrix, string separator)
{
    int row = matrix.GetLength(0);
    int col = matrix.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        Console.Write("{ ");
        for (int j = 0; j < col; j++)
            if (j < col - 1) Console.Write(matrix[i, j] + separator);
            else Console.Write(matrix[i, j]);
        Console.WriteLine(" }");
    }
}

// 5. Метод, проверяющий наличие элемента с 
// указанным индексом в матрице
bool FindElement(int[,] matrix, int row, int col)
{
    bool element = false;
    if (row >= 0 && row < matrix.GetLength(0))
        if (col >= 0 && col < matrix.GetLength(1))
            element = true;
    return element;
}
#endregion Методы

Console.Clear();
int row = GetIntValue(2, 6);
int col = GetIntValue(2, 8);
int[,] matrix = CreateMatrix(row, col);
Fill(matrix, -9, 9);
Console.WriteLine("Задан массив: ");
Print(matrix, " <> ");

#region Пользовательский ввод
// Console.WriteLine("Введите позиции элемента массива для поиска");
// Console.WriteLine("Для ввода используйте натуральные числа от 1");
// // пользователь не комп, считает с 1)
// Console.Write("Строка: ");
// int positionRow = int.Parse(Console.ReadLine());
// Console.Write("Столбик: ");
// int positionCol = int.Parse(Console.ReadLine());
#endregion Пользовательский ввод

#region Ввод автоматический (случайный)
Console.WriteLine("Позиции элемента массива для поиска "
                + "(счет ведется с 1): ");
int positionRow = GetIntValue(1, row + 3); // чтобы не сильно вылететь за размер
Console.WriteLine($"Строка: {positionRow}");
int positionCol = GetIntValue(1, col + 3);
Console.WriteLine($"Столбик: {positionCol}");
#endregion Ввод автоматический (случайный)

bool presence = FindElement(matrix, positionRow - 1, positionCol - 1);
if (presence)
{
    Console.WriteLine($"Элемент [{positionRow}, {positionCol}] = "
                    + $"{matrix[positionRow - 1, positionCol - 1]}");
}
else Console.WriteLine($"Элемента [{positionRow}, {positionCol}] "
                    + $"в массиве нет");
