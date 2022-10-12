// Задача 47. Задайте двумерный массив размером m*n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Алгоритм
// 1. Задать количество строк и столбцов двумерного массива
// 2. Создать двумерный массив заданного размера
// 3. Заполнить массив вещественными числами
// 4. Распечатать массив

// Методы
// 1. Метод получения случайного целого числа
// 2. Метод создания двумерного массива
// 3. Метод заполнения матрицы вещественными числами
// 4. Метод печати матрицы с округлением чисел

#region Методы
// 1. Метод получения случайного целого числа
int GetIntValue(int min, int max)
{
    return new Random().Next(min, max + 1);
}

// 2. Метод создания двумерного массива
double[,] CreateMatrix(int row, int col)
{
    return new double[row, col];
}

// 3. Метод заполнения матрицы вещественными числами
void FillDoubleNumbers(double[,] matrix)
{
    int row = matrix.GetLength(0);
    int col = matrix.GetLength(1);
    int[] multiplier = { -100, -10, 10, 100 };
    int mulSize = multiplier.Length;
    for (int i = 0; i < row; i++)
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = new Random().NextDouble() *
            multiplier[new Random().Next(0, mulSize)];
        }
}

void Fill2DoubleNumbers(double[,] matrix)
{
    int row = matrix.GetLength(0);
    int col = matrix.GetLength(1);
    for (int i = 0; i < row; i++)
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = new Random().Next(-99, 100) / 10.0;
        }
}

// 4. Метод печати матрицы с округлением чисел
void Print(double[,] matr, int round)
{
    int row = matr.GetLength(0);
    int col = matr.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        Console.Write("{ ");
        for (int j = 0; j < col; j++)
        {
            if (j < col - 1)
                Console.Write(Math.Round(matr[i, j], round) + "; ");
            else Console.Write(Math.Round(matr[i, j], round));
        }
        Console.WriteLine(" }");
    }
}
#endregion

Console.Clear();
int row = GetIntValue(2, 7);
int col = GetIntValue(2, 10);
Console.WriteLine($"Задана двумерная матрица вещественных чисел");
Console.WriteLine($"Количество строк = {row}, "
                + $"количество столбцов = {col}");
double[,] matrix = CreateMatrix(row, col);
FillDoubleNumbers(matrix);
// Fill2DoubleNumbers(matrix);
Print(matrix, 1);
