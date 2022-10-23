// Задача 62. Напишите программу, которая заполнит 
// спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
//  1  2  3  4
// 12 13 14  5
// 11 16 15  6
// 10  9  8  7

// Алгоритм
// 1. Задать двумерный массив размером 4 на 4
// 2. Заполнить массив числами по спирали (по часовой стрелке)
// 3. Распечатать полученный массив

// Методы

// Метод создания двумерного массива
int[,] CreateMatrix(int row, int col)
{
    return new int[row, col];
}

// Метод спирального заполнения двумерного массива


// Метод для печати матрицы
void PrintMatrix(int[,] matr)
{
    int row = matr.GetLength(0);
    int col = matr.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        Console.Write("{ ");
        for (int j = 0; j < col; j++)
            Console.Write(matr[i, j] + " ");
        Console.WriteLine("}");
    }
}

Console.Clear();
int[,] matrix = CreateMatrix(4, 4);
int num = 1;
int row = matrix.GetLength(0);
int col = matrix.GetLength(1);
for (int i = 0; i < 1; i++) // вправо
{
    for (int j = 0; j < col; j++)
    {
        matrix[i, j] = num;
        num++;
    }
}
for (int i = 1; i < row; i++) // вниз
{
    for (int j = col - 1; j < col; j++)
    {
        matrix[i, j] = num;
        num++;
    }
}
for (int i = row - 1; i < row; i++) // влево
{
    for (int j = col - 2; j > -1; j--)
    {
        matrix[i, j] = num;
        num++;
    }
}
for (int i = row - 2; i > 0; i--) // вверх
{
    for (int j = 0; j < 1; j++)
    {
        matrix[i, j] = num;
        num++;
    }
}
for (int i = 1; i < 2; i++) // вправо
{
    for (int j = 1; j < col - 1; j++)
    {
        matrix[i, j] = num;
        num++;
    }
}
for (int i = 2; i < row - 1; i++) // вниз
{
    for (int j = col - 2; j < col - 1; j++)
    {
        matrix[i, j] = num;
        num++;
    }
}
for (int i = row - 2; i < row - 1; i++) // влево
{
    for (int j = col - 3; j > 0; j--)
    {
        matrix[i, j] = num;
        num++;
    }
}

PrintMatrix(matrix);
