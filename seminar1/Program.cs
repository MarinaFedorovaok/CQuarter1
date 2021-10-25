// 1. Задача сложения двух чисел
// 2. Я хочу получить то и то... 
// 3. Я делаю так и так...
// 4. Я ожидаю получить такой-то результ.. или получают ошибку
// 5. Я получаю 23...
// 6. Почему?
/// 1. **Типы данных**
// int double string bool - вшиты в .net
/// 2. Переменные
/// 3. Задача 1. 
/// **Обмен значений двух переменных**
// int a = 3;
// int b = 4;
//Console.Write("a= ");
//Console.WriteLine(a);
///Console.Write("b= ");
//Console.WriteLine(b);

// Console.WriteLine("a = " + a + "\nb = " + b);
// //Console.WriteLine($"a = " + a + "\nb = " + b);
// a = a +b;
// b = a-b;
// a = a-b;
// Console.WriteLine($"Стало a = {a} b={b}");
// if (a>b)
// {
//     Console.WriteLine(a);
// }
// else
// {
// Console.WriteLine(b);
// }
// int current = 1;

// while (current<=10)
// {
//     Console.WriteLine(current*current);
//     current++;

// // }
// int current = 1;
// int a = 3;
// int b = 5;
// int result = 15;
// while (result <=128)
// {
//     Console.WriteLine(result);
//     result=15+a*b*current;
//     current++;
// }
int current = 2;
int n1 = 3;
int n2 = 5;

while (current <=128)
{
    if (current % n1 == 0 &&  current % n2 ==0)
    {
        Console.WriteLine (current);
    }
    current++;
}
//     Console.WriteLine(result);
//     result=15+a*b*current;
//     current++;