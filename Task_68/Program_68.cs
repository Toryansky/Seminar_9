// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int FindAckermannFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return FindAckermannFunction(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return FindAckermannFunction(m - 1, FindAckermannFunction(m, n - 1));
    }
    return FindAckermannFunction(m, n);
}
Console.WriteLine($"\nФункция Аккермана : {FindAckermannFunction(m, n)}");