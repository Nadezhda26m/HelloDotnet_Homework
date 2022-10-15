// Seminars
// Example012_MatrixProduct

// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Алгоритм
// 1. Создать две матрицы 
// 2. Заполнить матрицы случайными числами
// 3. Распечатать обе матрицы
// 4. Проверить возможность перемножения двух заданных матриц, число 
// столбцов в первой матрице должно быть равно числу строк во второй;
// 5. Создать новую матрицу и заполнить ее числами, полученными 
// в результате перемножения соответствующих элементов первых двух матриц
// 6. Распечатать итоговую матрицу

// Методы
// 1. Метод получения случайного целого числа
// 2. Метод для создания двумерного массива
// 3. Метод для заполнения матрицы
// 4. Метод для печати матрицы
// 5. Метод для проверки возможности умножения двух матриц
// 6. Метод для умножения двух матриц

#region Методы    
// 1. Метод получения случайного целого числа
int GetIntValue(int min, int max)
{
    return new Random().Next(min, max + 1);
}

// 2. Метод для создания двумерного массива
int[,] CreateMatrix(int row, int col)
{
    return new int[row, col];
}

// 3. Метод для заполнения матрицы
void FillMatrix(int[,] matr, int min, int max)
{
    for (int i = 0; i < matr.GetLength(0); i++)
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max + 1);
        }
}

// 4. Метод для печати матрицы
void PrintMatrix(int[,] matr)
{
    int row = matr.GetLength(0);
    int col = matr.GetLength(1);
    if (row != 0)           // ??? 
        for (int i = 0; i < row; i++)
        {
            Console.Write("{ ");
            for (int j = 0; j < col; j++)
                Console.Write(matr[i, j] + " ");
            Console.WriteLine("}");
        }
    else Console.WriteLine("{ }");          // ??? 
}

// 5. Метод для проверки возможности умножения двух матриц
bool CheckPossibilityProduct(int[,] matrA, int[,] matrB)
{
    bool product = false;
    if (matrA.GetLength(1) == matrB.GetLength(0))
        product = true;
    return product;
}

// 6. Метод для умножения двух матриц
int[,] Multiply(int[,] matrA, int[,] matrB)
{
    int rowAB = matrA.GetLength(0);
    int colAB = matrB.GetLength(1);
    int commonSide = matrA.GetLength(1);
    int[,] matrAB = new int[rowAB, colAB];
    for (int i = 0; i < rowAB; i++)
        for (int j = 0; j < colAB; j++)
            for (int k = 0; k < commonSide; k++)
                matrAB[i, j] = matrAB[i, j] + matrA[i, k] * matrB[k, j];
    return matrAB;
}
#endregion // Методы

Console.Clear();
#region Задание исходных матриц, способ 1
// int rowProduct = GetIntValue(2, 3);
// int colProduct = GetIntValue(2, 3);
// int commonSide = GetIntValue(2, 3);
// int[,] matrix1 = CreateMatrix(rowProduct, commonSide);
// FillMatrix(matrix1, 2, 6);
// Console.WriteLine("Матрица A");
// PrintMatrix(matrix1);
// Console.WriteLine();
// int[,] matrix2 = CreateMatrix(commonSide, colProduct);
// FillMatrix(matrix2, 1, 5);
// Console.WriteLine("Матрица B");
// PrintMatrix(matrix2);
#endregion

#region Задание исходных матриц, способ 2
int[,] matrix1 = CreateMatrix(GetIntValue(2, 4), GetIntValue(2, 4));
FillMatrix(matrix1, 2, 6);
Console.WriteLine("Матрица A");
PrintMatrix(matrix1);
Console.WriteLine();
int[,] matrix2 = CreateMatrix(GetIntValue(2, 4), GetIntValue(2, 4));
FillMatrix(matrix2, 1, 5);
Console.WriteLine("Матрица B");
PrintMatrix(matrix2);
#endregion

bool chance = CheckPossibilityProduct(matrix1, matrix2);
if (chance)
{
    int[,] matrix12 = Multiply(matrix1, matrix2);
    Console.WriteLine("\nПроизведение матриц A * B");
    PrintMatrix(matrix12);
}
else Console.WriteLine("\nУмножение матриц невозможно");
