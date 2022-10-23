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

// DateTime dtStart3 = DateTime.Now;
// int[,] matrix = CreateMatrix(4, 4);
// int num = 1;
// // int row = matrix.GetLength(0);
// // int col = matrix.GetLength(1);
// // вправо
// int rowNow = 0;
// for (int k = 0; k < 4; k++) // 4 операции
// {
//     matrix[rowNow, k] = num;
//     num++;
// }
// // вниз
// int colNow = 3;
// for (int t = 1; t < 4; t++) // 3 операции
// {
//     matrix[t, colNow] = num;
//     num++;
// }
// // влево
// rowNow = 3;
// for (int k = 2; k > -1; k--) // 3 операции
// {
//     matrix[rowNow, k] = num;
//     num++;
// }
// // вверх
// colNow = 0;
// for (int t = 2; t > 0; t--) // 2 операции
// {
//     matrix[t, colNow] = num;
//     num++;
// }
// // вправо
// rowNow = 1;
// for (int k = 1; k < 3; k++) // 2 операции
// {
//     matrix[rowNow, k] = num;
//     num++;
// }
// // вниз
// colNow = 2;
// for (int t = 2; t < 3; t++) // 1 операция
// {
//     matrix[t, colNow] = num;
//     num++;
// }
// // влево
// rowNow = 2;
// for (int k = 1; k > 0; k--) // 1 операция
// {
//     matrix[rowNow, k] = num;
//     num++;
// }

// PrintMatrix(matrix);
// Console.WriteLine();


#region Решение 3

int[,] matrix3 = CreateMatrix(4, 4);
int row = matrix3.GetLength(0);
int col = matrix3.GetLength(1);
int num3 = 1;
int i = 0;
int j = 0;
int count = 0;
// int rowN = 0;
// i = 0, j = 0
row = 4;
col = 4;
// вправо
while (count < row) // 4 операции
{
    matrix3[i, j] = num3;
    num3++;
    j++;
    count++;
}
// i = 0, j = 4
row = 3; 
col = 4;
count = 0;
// вниз
while (count < row) // 3 операции
{
    matrix3[i + 1, j - 1] = num3;
    num3++;
    i++;
    count++;
}
// i = 3, j = 4
row = 3;
col = 3;
count = 0;
// влево
while (count < row) // 3 операции
{
    matrix3[i, j - 2] = num3;
    num3++;
    j--;
    count++;
}
// i = 3, j = 1
row = 2;
col = 3;
count = 0;
// вверх
while (count < row) // 2 операции
{
    matrix3[i - 1, j - 1] = num3;
    num3++;
    i--;
    count++;
}
// i = 1, j = 1
row = 2;
col = 2;
count = 0;
// вправо
while (count < row) // 2 операции
{
    matrix3[i, j] = num3;
    num3++;
    j++;
    count++;
}
// i = 1, j = 3
row = 1;
col = 2;
count = 0;
// вниз
while (count < row) // 1 операция
{
    matrix3[i + 1, j - 1] = num3;
    num3++;
    i++;
    count++;
}
// i = 2, j = 3
row = 1;
col = 1;
count = 0;
// влево
while (count < row) // 1 операция
{
    matrix3[i, j - 2] = num3;
    num3++;
    j--;
    count++;
}
// i = 2, j = 2
row = 0;
col = 1;
count = 0;

PrintMatrix(matrix3);

#endregion Решение 3
