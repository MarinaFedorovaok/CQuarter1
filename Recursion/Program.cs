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
int Summ(int m, int n)
{
    if (n == m) return n;
    else
    {
        return n + Summ(m, n - 1);
    }
}
//Console.WriteLine(Summ(2,6));

//70. Найти сумму цифр числа
int SummFigures(int n)
{
    if (n == 0) return 0;
    else
    {
        return n % 10 + SummFigures(n / 10);
    }
}
//Console.WriteLine(SummFigures(1287));

//71. Написать программу вычисления функции Аккермана
int A(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0)
    {
        if (m == 0) return 1;
        else return A(m - 1, 1);
    }
    else return A(m-1, A(m, n-1));
}
// Console.WriteLine (A(0, 5));

// 72. Написать программу возведения числа А в целую стень B
int Degree (int a, int b)
{
    if (b == 0) return 1;
    else
    {
        return a*Degree (a, b-1);
    }
}
Console.WriteLine (Degree(3,2));