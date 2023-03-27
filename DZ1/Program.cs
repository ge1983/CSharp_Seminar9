// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void PrintNumber(int N)
{
    if (N == 0)
    {
        return;
    }
    else
    {
        Console.Write($"{N} ");
        PrintNumber(N-1);
    }
}

Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Полученный ряд");
PrintNumber(N);
