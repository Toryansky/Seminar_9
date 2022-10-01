// Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

int SummarizeNumbers(int start, int end)
{
    int m = start;
    int n = end;
    if (m > n)
    {
        n = start;
        m = end;
    }
    return ((end + start) / 2) * (end - start + 1);
}
Console.WriteLine($"\nСумма натуральных элементов в промежутке от M до N : {SummarizeNumbers(m, n)}");