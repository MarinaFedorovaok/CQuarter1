// Почувствуй себя интерном
        //  0. Вывести квадрат числа
// int func (int x)
// {
// return x*x;
// 
// int res = func (5);
// Console.WriteLine(res);
            //  1. По двум заданным числам проверять является ли первое квадратом второго

// void func1 (int a, int b)
// {
//     if (a == b*b)
//     {
//   Console.WriteLine("Является");  
//     }
//     else 
//     {Console.WriteLine ("Не является");
//     }
// }
// func1 (25, 6);

// int a = 25;
// int b = 5;



    //  2. Даны два числа. Показать большее и меньшее число

// int a = 3;
// int b = 4;
// void func2 (int a, int b)
// {
//     if (a>b)
//     {
//         Console.WriteLine ($"Большее число {a}");
//         Console.WriteLine ($"Меньшее число {b}");
//     }
//     else
//     {
//     Console.WriteLine ($"Большее число {b}");
//         Console.WriteLine ($"Меньшее число {a}");
//     }
// }
// func2 (56, 38);

        //  3. По заданному номеру дня недели вывести его название
// void week (int a)
// {
// string []array1 = {"mon", "tue", "Wen", "Thur", "Try", "Sut", "Syn"};
// Console.WriteLine (array1[a-1]);
// }
// week (2);
    //  4. Найти максимальное из трех чисел

// int Max (int a, int b, int c)
// {
//     int max = b;
//     if (a>max)
//     {
//         max=a;
       
//     }
//     if (c>max)
//         {
//             max=c;
            
//         }
//     return max;
// }
// int ans = Max (12,5,6);
// Console.Write(ans);

    //  5. Написать программу вычисления значения функции y=f(a)
    // double f(double a)
    // {
    //     double res = Math.Sin (a);
    //     return res;
    // }
    // double sin = f(2);
    // Console.Write(sin);

    //  6. Выяснить является ли число чётным
    void func6 (int a)
    {
        if (a % 2 ==0)
        {
            Console.Write ($"{a}  является четным");
        }
        else {
        Console.Write ($"{a}  не является четным");

        }
     }
    func6 (6);

//  7. =======Показать числа от -N до N========

// int [] arrayA = new int [10];

// void CreateArray(int [] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-10, 11);
//     }
// }

// void ShowArray(int [] array)
// {
//     for(int ind = 0; ind < array.Length; ind++)
//     {
//         Console.Write($"{arrayA[ind]} ");
//     }
// }

// CreateArray(arrayA);
// ShowArray(arrayA);

//  8. =========Показать четные числа от 1 до N=========

// int [] arrayA = new int [10];

// void CreateArray(int [] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1, 21);
//     }
// }

// void ShowArray(int [] array)
// {
//     for(int ind = 0; ind < array.Length; ind++)
//     {
//         Console.Write($"{arrayA[ind]} ");
//     }
// }

// void ShowEven(int [] array)
// {
//     for(int index = 0; index < array.Length; index++)
//     if(arrayA[index] % 2 == 0)
//     {
//         Console.Write($"{arrayA[index]} ");
//     }
// }

// CreateArray(arrayA);
// ShowArray(arrayA);
// Console.WriteLine();
// ShowEven(arrayA);

//  9. =====Показать последнюю цифру трёхзначного числа======

// int LastNumber(int arg)
// {
//     arg = arg % 10;
//     return arg;
// }
// int ans = LastNumber(251);
// Console.WriteLine(ans);

// 10. =========Показать вторую цифру трёхзначного числа========

// int SecNumber(int arg)
// {
//     arg = arg / 10 % 10;
//     return arg;
// }
// int ans = SecNumber(298);
// Console.WriteLine(ans);

// 11. =========Дано число из отрезка [10, 99]. Показать наибольшую цифру числа=======

// void MaxNum(int arg)
// {
//     int a = 0;
//     int b = 0;
//     a = arg / 10;
//     b = arg % 10;
//     if(a > b)
//     {
//         Console.WriteLine(a);
//     }
//     else
//     {
//         Console.WriteLine(b);
//     }
// }

// int CreateNum()
// {
//     int ranNum = new Random().Next(10, 100);
//     return ranNum;
// }

// int number = CreateNum();
// Console.WriteLine(number);
// MaxNum(number);

// 12. ======Удалить вторую цифру трёхзначного числа=========

// void DeleteSecNumber(int arg)
// {
//     int a = arg / 100;
//     int b = arg % 10;
//     int c = a * 10 + b;
//     Console.WriteLine(c);
// }

// DeleteSecNumber(371);

// 13. ========Выяснить, кратно ли число заданному, если нет, вывести остаток.=======

// int CreateNum()
// {
//     int ranNum = new Random().Next(10, 100);
//     return ranNum;
// }

// int CreateDev()
// {
//     int devNum = new Random().Next(2, 10);
//     return devNum;
// }

// int firstNum = CreateNum();
// int secondNum = CreateDev();

// if(firstNum % secondNum == 0)
// {
//     Console.WriteLine($"Число {firstNum} кратно {secondNum}");
// }
// else
// {
//     int residual = firstNum % secondNum;
//     Console.WriteLine($"Остаток деления {firstNum} на {secondNum} равен {residual}");
// }

// 14. Найти третью цифру числа или сообщить, что её нет

// int RandomNum()
// {
//     int x = new Random().Next(1, 1000);
//     return x;
// }

// int number = RandomNum();

// void FindThirdNum(int arg)
// {
//     if((number / 100) >= 1)
//     {
//         int y = number % 10;
//         Console.WriteLine($"Третьей цифрой числа {number} является {y}");
//     }
//     else
//     {
//         Console.WriteLine("Третьей цифры в числе нет!");
//     }
// }
// FindThirdNum(number);

// Почувствуй себя джуном
// 15. Дано число. Проверить кратно ли оно 7 и 23
// 16. Дано число обозначающее день недели. Выяснить является номер недели выходным днём
// 17. По двум заданным числам проверять является ли одно квадратом другого
// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
// 20. Ввести номер четверти, показать диапазоны для возможных координат
// 21. Программа проверяет пятизначное число на палиндромом.
// 22. Найти расстояние между точками в пространстве 2D/3D
