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
    // void func6 (int a)
    // {
    //     if (a % 2 ==0)
    //     {
    //         Console.Write ($"{a}  является четным");
    //     }
    //     else {
    //     Console.Write ($"{a}  не является четным");

    //     }
    //  }
    // func6 (6);
                //  7. Показать числа от -N до N
    // int N = Convert.ToInt32(Console.ReadLine());
    //   for (int x = -N; x<=N; x++) 
    // {
    //     Console.WriteLine(x);
    // }
   
        //  8. Показать четные числа от 1 до N
//    int N = Convert.ToInt32(Console.ReadLine());
//      for (int x = 0; x<=N; x++) 
//     {
//          if (x % 2 ==0)
//            {
//                Console.WriteLine (x);
//        }
    
//      } 
        //  9. Показать последнюю цифру трёхзначного числа
// int N = Convert.ToInt32(Console.ReadLine());
// int a= N%10;
// Console.WriteLine(a);


        // 10. Показать вторую цифру трёхзначного числа
// int N = Convert.ToInt32(Console.ReadLine());
// int a = N/100;
// int c = N%10;
// int b = (N-a*100 - c)/10;
// Console.WriteLine(b);
    
    // 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
    
// int N = 98;
// int a = N/10;
// int b = N%10;
// if (a>b)
// {
//     Console.WriteLine(a);
// }
// else
//     Console.WriteLine(b);
   

    // 12. Удалить вторую цифру трёхзначного числа
//  int N = Convert.ToInt32(Console.ReadLine());
//  int a = N%10;
//  int b = N/100;
//  int c = b*100;
//  int d= c+a;
//  Console.WriteLine(d);

    // 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
//     int func13(int a, int b)
//  {
//    int res = 0;
//    if  ( a>b )
//       {
//         if (a %b ==0) 
//          {       
//            res = 1;
//          }
//          else res = a%b;
//       }
//  if  ( b>a )
//       {
//             if (b %a ==0) 
//             {       
//             res = 2;
//             }
//            else  res = b%a;
//       }
//  return res;
//  }
// int ans = func13(34,68);
// Console.WriteLine(ans);

// 14. Найти третью цифру числа или сообщить, что её нет

int func14(int N)
{
    int res = 0;
    if (N>99)
    {
        res = (N/100)%10;
    }
    else Console.WriteLine("третьей цифры нет");
 return res;
}
Console.WriteLine(func14(56));
//  int b = N/100;
//  int c = b*100;
//  int d= c+a;
//  Console.WriteLine(d);

// Почувствуй себя джуном
    // 15. Дано число. Проверить кратно ли оно 7 и 23
// int func15(int num)
// {
//     int res = 0;
//     if  (num %7 ==0)
//     {
//         if (num %23 ==0) 
//         {       
//          res = 1;
//         }
//     }
// return res; 
// }
// int ans = func15(160);
// Console.WriteLine(ans);

        // 16. Дано число обозначающее день недели. Выяснить является номер недели выходным днём

// 17. По двум заданным числам проверять является ли одно квадратом другого
// int function17 (int a, int b)
// {
//     int res=0;
//     if (a>b)
//     {
//        if (a==b*b) res=1;
//     }
//     else
//     {
//       if (b==a*a) res=2;  

//     }
//     return res;
// }
// int x = 30;
// int y = 6;
// int ans = function17(x,y);
// //Console.WriteLine(ans);
// if (ans == 0)
// {
// Console.WriteLine("ни одно число не является квадратом другого");
// }
// if (ans == 1)
// {
// Console.WriteLine($"{x} является квадратом {y}");
// }
// if (ans == 2)
// {
// Console.Write($"{y} является квадратом {x}");
// }

// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
// bool Func18(bool x, bool y) 
// { 
//     bool output = false; 
//     if(!(x & y) == !x ^ !y) 
//     { 
//         output = true; 
//     } 
//     return output; 
// } 
 
// bool ans = Func18(false, false); 
// Console.WriteLine(ans);

// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
// 20. Ввести номер четверти, показать диапазоны для возможных координат
// 21. Программа проверяет пятизначное число на палиндромом.
// 22. Найти расстояние между точками в пространстве 2D/3D