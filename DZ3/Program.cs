// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int A(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return A(m-1,1);
    }
    else
    {
        return A(m-1, A(m, n-1));
    }
}

Console.WriteLine("Введите число m");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число n");
int n = Convert.ToInt32(Console.ReadLine());

if (m < 0 || n < 0)
{
    Console.WriteLine("Введеные числла должны быть неотрицательными");
}
else
{
    Console.WriteLine($"Результат функции Аккермана для чисел {m} и {n} равен {A(m,n)}");
}