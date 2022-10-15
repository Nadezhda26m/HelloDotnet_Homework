// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Алгоритм
// 1-3. Задать, заполнить и распечатать двумерный массив
// 4. Найти сумму элементов каждой строки
// 5. Найти минимальное значение из полученных сумм
// 6. Показать строку/строки с наименьшей суммой элементов

// Методы
// 1. Метод создания двумерного массива
// 2. Метод получения случайного целого числа
// 3. Метод заполнения двумерного массива случайными целыми числами
// 4. Метод линейной записи двумерного массива для вывода
// 5. Метод построчной печати матрицы с фигурными скобками 
// из строкового формата 
// 6. Метод получения суммы элементов двумерного массива по строкам
// 7. Метод нахождения минимального значения в массиве

#region Методы
// 1. Метод создания двумерного массива
int[,] CreateMatrix(int row, int col)
{
    return new int[row, col];
}

// 2. Метод получения случайного целого числа
int GetIntValue(int min, int max)
{
    return new Random().Next(min, max + 1);
}

// 3. Метод заполнения двумерного массива случайными целыми числами
void Fill(int[,] matrix, int min, int max)
{
    int row = matrix.GetLength(0);
    int col = matrix.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
}

// 4. Метод линейной записи двумерного массива для вывода
string ShowLinear(int[,] matrix, string separator)
{
    int row = matrix.GetLength(0);
    int col = matrix.GetLength(1);
    string result = String.Empty;
    for (int i = 0; i < row; i++)
    {
        result += "{ ";
        for (int j = 0; j < col; j++)
        {
            if (j < col - 1)
            {
                result += matrix[i, j] + separator;
            }
            else result += matrix[i, j] + " }";
        }
    }
    return result;
}

// 5. Метод построчной печати матрицы с фигурными скобками 
// из строкового формата 
void PrintMatrix(string matrix)
{
    Console.Write(matrix[0]);
    for (int i = 1; i < matrix.Length; i++)
    {
        if (matrix[i].ToString() == "{")
        {
            Console.Write("\n{");
        }
        else Console.Write(matrix[i]);
    }
    Console.WriteLine();
}

// 6. Метод получения суммы элементов двумерного массива по строкам
int[] CalculateSumRowByRow(int[,] matrix)
{
    int row = matrix.GetLength(0);
    int col = matrix.GetLength(1);
    int[] sumRows = new int[row];
    int sum = 0;
    for (int i = 0; i < row; i++)
    {
        sum = 0;
        for (int j = 0; j < col; j++)
        {
            sum += matrix[i, j];
        }
        sumRows[i] = sum;
    }
    return sumRows;
}

// 7. Метод нахождения минимального значения в массиве
int FindMinValue(int[] array)
{
    int size = array.Length;
    int min = array[0];
    for (int i = 0; i < size; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}
#endregion Методы

Console.Clear();
int row = GetIntValue(4, 9);
int col = GetIntValue(2, 7);
int[,] matrix = CreateMatrix(row, col);
Fill(matrix, 0, 9);
Console.WriteLine("Задан массив:");
PrintMatrix(ShowLinear(matrix, ", "));
int[] sumRows = CalculateSumRowByRow(matrix);
Console.WriteLine($"// Суммы по строкам: / {String.Join(", ", sumRows)} /");
// int minSum = sumRows.Min();
int minSum = FindMinValue(sumRows);
Console.WriteLine($"Минимальная сумма элементов ({minSum}) в: ");
int countSum = sumRows.Length;
for (int i = 0; i < countSum; i++)
{
    if (sumRows[i] == minSum)
    {
        Console.WriteLine($"{i + 1} строке");
    }
}
