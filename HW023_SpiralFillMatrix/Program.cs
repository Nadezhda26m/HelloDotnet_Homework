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

// Метод спирального заполнения двумерного массива размером 4 на 4
void Method(int[,] matr, int row, int col, int num, int i, int j, int flag)
{
    if (row > 0)
    {
        int count = 0;
        if (flag == 1)
        {
            count = 0;
            while (count < row) // вправо
            {
                matr[i, j] = num;
                num++;
                j++;
                count++;
            }
            Method(matr, row - 1, col, num, i + 1, j - 1, flag + 1);
        }
        if (flag == 2)
        {
            count = 0;
            while (count < row) // вниз
            {
                matr[i, j] = num;
                num++;
                i++;
                count++;
            }
            Method(matr, row, col - 1, num, i - 1, j - 1, flag + 1);
        }
        if (flag == 3)
        {
            count = 0;
            while (count < row) // влево
            {
                matr[i, j] = num;
                num++;
                j--;
                count++;
            }
            Method(matr, row - 1, col, num, i - 1, j + 1, flag + 1);
        }
        if (flag == 4)
        {
            count = 0;
            while (count < row) // вверх
            {
                matr[i, j] = num;
                num++;
                i--;
                count++;
            }
            Method(matr, row, col - 1, num, i + 1, j + 1, flag - 3);
        }
    }
}

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

int[,] matrix4 = CreateMatrix(4, 4);
int row4 = matrix4.GetLength(0);
int col4 = matrix4.GetLength(1);
int numberStart = 1;
Method(matrix4, row4, col4, numberStart, 0, 0, 1);
PrintMatrix(matrix4);
