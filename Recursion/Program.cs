// Рекурсия
// 66. Показать натуральные числа от 1 до N, N задано
string PrintN(int n)
{
    if (n < 2) return "1";
    else
    {
        return $"{PrintN(n - 1)} {n}";
    }
}
//Console.WriteLine (PrintN (5));

// 67. Показать натуральные числа от N до 1, N задано
string PrintN2(int n)
{
    return n < 2 ? "1" : $"{n} {PrintN2(n - 1)}";
}
//Console.WriteLine(PrintN2(5));
// 68. Показать натуральные числа от M до N, N и M заданы
string PrintNM(int m, int n)
{
    if (m > n) return $"{PrintNM(n, m)}";
    if (m == n) return $"{m}";
    else
    {
        return $"{PrintNM(m, n - 1)} {n}";
    }
}
//Console.WriteLine(PrintNM(33, 25));

//69. Найти сумму элементов от M до N, N и M заданы
int Summ (int m, int n)
{
    if (n==m) return n;
    else
    {
        return n+Summ (m, n-1);
    }
}
Console.WriteLine(Summ(2,6));
