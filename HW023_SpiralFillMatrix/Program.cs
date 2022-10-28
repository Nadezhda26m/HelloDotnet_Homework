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
// 1. Метод создания двумерного массива
// 2.1. Метод спирального заполнения двумерного массива по часовой 
// стрелке от элемента на позиции [0, 0] с начальным флагом 1
// 2.2. без флага
// 3. Метод для печати матрицы

#region Методы
// 1. Метод создания двумерного массива
int[,] CreateMatrix(int row, int col)
{
    return new int[row, col];
}

// 2.1. Метод спирального заполнения двумерного массива по часовой 
// стрелке от элемента на позиции [0, 0] с начальным флагом 1
void FillSpiral2(int[,] matr, int rowAll, int colAll,
                    int num, int i, int j, int flag)
{
    if (rowAll != 0 && colAll != 0)
    {
        int countSteps = 0;
        if (flag == 5) flag = 1;
        if (flag % 2 == 0)
        {
            while (countSteps < rowAll)
            {
                matr[i, j] = num;
                num++;
                countSteps++;
                if (flag == 2) i++; // вниз
                else i--; // вверх
            }
        }
        else while (countSteps < colAll)
            {
                matr[i, j] = num;
                num++;
                countSteps++;
                if (flag == 1) j++; // вправо
                else j--; // влево
            }
        if (flag == 1)
            FillSpiral2(matr, rowAll - 1, colAll, num, i + 1, j - 1, flag + 1);
        else if (flag == 2)
            FillSpiral2(matr, rowAll, colAll - 1, num, i - 1, j - 1, flag + 1);
        else if (flag == 3)
            FillSpiral2(matr, rowAll - 1, colAll, num, i - 1, j + 1, flag + 1);
        else
            FillSpiral2(matr, rowAll, colAll - 1, num, i + 1, j + 1, flag + 1);
    }
}

// 2.2. Метод спирального заполнения двумерного массива 
// по часовой стрелке от элемента на позиции [0, 0] 
// // с начальным флагом 1
void FillSpiral(int[,] matr, int row, int col, int num, int i, int j)
{
    if (row != 0 && col != 0)
    {
        int count = 0;
        if (i == 0 && j == 0)
        {
            matr[i, j] = num;
            count = 1;
            num++;
        }
        if (j + 1 < matr.GetLength(1))
        {
            if (matr[i, j + 1] == 0)
            {
                while (count < col)
                {
                    j++; // вправо
                    matr[i, j] = num;
                    num++;
                    count++;
                }
                FillSpiral(matr, row - 1, col, num, i, j);
            }
        }
        if (i + 1 < matr.GetLength(0))
        {
            if (matr[i + 1, j] == 0)
            {
                while (count < row)
                {
                    i++; // вниз
                    matr[i, j] = num;
                    num++;
                    count++;
                }
                FillSpiral(matr, row, col - 1, num, i, j);
            }
        }
        if (j - 1 >= 0)
        {
            if (matr[i, j - 1] == 0)
            {
                while (count < col)
                {
                    j--; // влево
                    matr[i, j] = num;
                    num++;
                    count++;
                }
                FillSpiral(matr, row - 1, col, num, i, j);
            }
        }
        if (i - 1 >= 0)
        {
            if (matr[i - 1, j] == 0)
            {
                while (count < row)
                {
                    i--; // вверх
                    matr[i, j] = num;
                    num++;
                    count++;
                }
                FillSpiral(matr, row, col - 1, num, i, j);
            }
        }
    }
}

// 3. Метод для печати матрицы
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
#endregion Методы

Console.Clear();
int[,] matrix5 = CreateMatrix(4, 7);
int row5 = matrix5.GetLength(0);
int col5 = matrix5.GetLength(1);
int numberStart = 11;
FillSpiral2(matrix5, row5, col5, numberStart, 0, 0, 1);
Console.WriteLine($"Пример спирального заполнения матрицы {row5} x {col5}:");
PrintMatrix(matrix5);
Console.WriteLine();

// Решение без флага
int[,] matrix6 = CreateMatrix(4, 7);
int row6 = matrix6.GetLength(0);
int col6 = matrix6.GetLength(1);
FillSpiral(matrix6, row6, col6, numberStart, 0, 0);
PrintMatrix(matrix6);
