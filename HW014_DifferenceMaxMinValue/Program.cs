// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным 
// элементами массива.
// [3 7 22 2 78] -> 76

// Алгоритм
// 1. Создать массив
// 2. Заполнить массив случайными вещественными числами
// 3. Распечатать массив
// 4. Посчитать разницу между максимальным и минимальным 
// элементами массива 

// Методы
// 1. Метод создания массива
// 2. Метод заполнения массива случайными вещественными числами
// 3. Метод вывода массива на печать
// 4. Метод, считающий разницу между максимальным и 
// минимальным элементами массива  

#region Методы    
// 1. Метод создания массива
double[] CreateArrayDouble(int size)
{
    return new double[size];
}

// 2. Метод заполнения массива случайными вещественными числами
void Fill(double[] array)
{
    int[] multiplier = {-1000, -100, -10, 10, 100, 1000};
    int element = 0;
    int count = multiplier.Length;
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        element = new Random().Next(0, count);
        array[i] = Math.Round(new Random().NextDouble() *
                   multiplier[element], 2);
    }
}

// 3. Метод вывода массива на печать
string Print(double[] array)
{
    return "{" + String.Join("; ", array) + "}";
}

// 4. Метод, считающий разницу между максимальным и 
// минимальным элементами массива  
double DifferenceMaxMin(double[] array)
{
    return array.Max() - array.Min();
}
#endregion

Console.Clear();
double[] numbers = CreateArrayDouble(10);
Fill(numbers);
Console.WriteLine("Задан массив вещественных чисел: ");
Console.WriteLine(Print(numbers));
Console.WriteLine($"Максимальный элемент: {numbers.Max()}");
Console.WriteLine($"Минимальный элемент: {numbers.Min()}");
double diffMaxMin = Math.Round(DifferenceMaxMin(numbers), 2);
Console.WriteLine($"Разница между максимальным и минимальным "
                + $"элементами = {diffMaxMin}");
