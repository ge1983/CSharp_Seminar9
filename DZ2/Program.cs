// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumMtoN(int M, int N)
{
    if (M == N)
    {
        return N;
    }
    else
    {
        return M + SumMtoN(M + 1, N);
    }
}

Console.WriteLine("Введите число M");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма от {M} до {N} равна {SumMtoN(M, N)}");
