﻿// Нахождение факториала числа

// Итеративно

int FactorialFor(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= i;
    return result;
}

Console.WriteLine(FactorialFor(10)); // 3628800

// Рекурсивно

int FactorialRec(int n)
{
    if (n == 1 || n == 0) return 1;
    else return n * FactorialRec(n - 1);
}
Console.WriteLine(FactorialRec(10)); // 3628800