// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 
// 4,6; 5,6; 3,6; 3

// Алгоритм
// 1-3. Создать, заполнить и распечатать двумерный массив
// 4. Найти среднее арифметическое элементов в столбце
// 5. Найти и распечатать значение из п.4 для каждого столбца

// Методы
// 1. Метод получения случайного целого числа
// 2. Метод создания двумерного массива
// 3. Метод заполнения матрицы случайными целыми числами
// 4. Метод печати матрицы в консоль с разделителем
// 5. Метод нахождения среднего арифметического 
// элементов в каждом столбце
// 6. Метод вывода массива на печать с округлением чисел 
// и выбором разделителя элементов

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
    if (row != 0 && col != 0)
    {
        for (int i = 0; i < row; i++)
        {
            Console.Write("{ ");
            for (int j = 0; j < col; j++)
                if (j < col - 1) Console.Write(matrix[i, j] + separator);
                else Console.Write(matrix[i, j]);
            Console.WriteLine(" }");
        }
    }
    else Console.WriteLine("{ }");
}

// 5. Метод нахождения среднего арифметического 
// элементов в каждом столбце
double[] FindAverageArithmColumns(int[,] matrix)
{
    int row = matrix.GetLength(0);
    int col = matrix.GetLength(1);
    double[] averageAr = new double[col];
    double sum = 0;
    for (int i = 0; i < col; i++)
    {
        sum = 0;
        for (int j = 0; j < row; j++)
        {
            sum = sum + matrix[j, i];
        }
        averageAr[i] = sum / row;
    }
    return averageAr;
}

// 6. Метод вывода массива на печать с округлением чисел 
// и выбором разделителя элементов
string PrintDouble(double[] array, int round, string separator)
{
    int size = array.Length;
    string result = String.Empty;
    for (int i = 0; i < size - 1; i++)
    {
        result = result + Math.Round(array[i], round)
            + separator;
    }
    result = result + Math.Round(array[size - 1], round);
    return result;
}
#endregion Методы

Console.Clear();
int row = GetIntValue(1, 8);
int col = GetIntValue(1, 10);
int[,] matr = CreateMatrix(row, col);
Fill(matr, -9, 9);
Console.WriteLine("Задан двумерный массив из целых чисел: ");
Print(matr, ", ");
if (row > 0)
{
    Console.WriteLine("Среднее арифметическое элементов "
                    + "каждого столбца: ");
    // double[] averArithmCol = FindAverageArithm(matr);
    // Console.WriteLine(PrintDouble(averArithmCol, 1, "; "));
    Console.WriteLine(PrintDouble(FindAverageArithmColumns(matr), 1, "; "));
}
else Console.WriteLine("Нельзя найти среднее арифметическое "
                    + "элементов в столбцах");
