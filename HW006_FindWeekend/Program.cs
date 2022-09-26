// Напишите программу, которая принимает 
// на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();

Console.WriteLine("Данная программа работает с цифрами, обозначающими день недели.");
Console.WriteLine("Введите цифру от 1 до 7, где 1 - понедельник, 7 - воскресенье, и нажмите Enter: ");
int day = int.Parse(Console.ReadLine());
int[] weekday = {1, 2, 3, 4, 5, 6, 7};
int week = weekday.Length;
int index = 0;
int dayInd = 0;
bool mistake = true;
while (index < week)
{
    if (weekday[index] == day)
    {
        mistake = false;
        dayInd = index;
    }
    index++;
}
if (mistake)
{
    Console.WriteLine("Вы ввели неверное значение");
}
else if (dayInd > 4)
{
    Console.WriteLine("Этот день является выходным");
}
else 
{
    Console.WriteLine("Этот день не является выходным");
}