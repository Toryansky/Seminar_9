// Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Write("Введите N: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PrintNumberRow(number, 1));

string PrintNumberRow(int end, int start)
{
    if (end == start)
    {
        return end.ToString();
    }
    return (end + " " + PrintNumberRow(end - 1, start));
}