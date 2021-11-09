// Почувствуй себя интерном
        //  0. Вывести квадрат числа
// int func (int x)
// {
// return x*x;
// 
// int res = func (5);
// Console.WriteLine(res);
            //  1. По двум заданным числам проверять является ли первое квадратом второго
// bool func28 (int a, int b)
//  {
//    return a == b*b;
//  }
// Console.WriteLine(func28 (25, 5));



// int func1 (int a, int b)
//  {
//      int result = 0;
//      if (a == b*b)  result = 1;
//      return result;
//  }
//  //Console.WriteLine(func1 (25, 5));
//  int ans  = func1(25, 5);
//  if(ans  == 0) Console.WriteLine("Не является");
//  else
//  {
//      Console.WriteLine("Является");
//  }

// int a = 25;
// int b = 5;

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
    //int N = Convert.ToInt32(Console.ReadLine());
    // int func7 (int N)
    // {
    //     int x= -N;
    //     while (x <=N ) 
    //    {
    //        Console.WriteLine (x);
    //         x++;
    //    }
    //     return x;
    // }
    // func7(4);
    // func7 (3);
   

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

// int func14(int N)
// {
//     int res = 0;
//     while (N>999)
//     {
//         N = N/10;
//     }
//   //  Console.WriteLine(N);
//     if (N>99)
//     {
//         res = N%10;
//     }
//     else Console.WriteLine("третьей цифры нет");
//  return res;
// }
// Console.WriteLine(func14(560576938));


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

        // 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным днём

// bool Day (int num)
// {
//     return num > 5;
// }
// Console.WriteLine(Day(4));


// int day (int num)
// {
//  int [] array  = {1, 2, 3, 4, 5, 6, 7};
//  int index = 0;
//  for (index=0; index<=array.Length; index++)   
//     {
//         if ((num - 1)>=array[5]) 
//     }
// }
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
//     return (!(x && y) == !x || !y);  
// } 
// Console.WriteLine(Func18(false, false)); 
// Console.WriteLine(Func18(false, true ));
// Console.WriteLine(Func18(true,  false)); 
// Console.WriteLine(Func18(true,  true )); 

// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
// int func19 (int x, int  y)
// { int ans = 4;
//     if (x>0&&y>0) ans = 1;
//     if (x<0&&y>0) ans = 2;
//     if (x<0&&y<0) ans = 3;
// return ans;
// }
// Console.WriteLine(func19(-34,-76));



// 20. Ввести номер четверти, показать диапазоны для возможных координат
// string func20 (int quarter)
// {
//     if (quarter == 1) return "Диапозон Х от 0 до бесконечности, диапозон у от 0 до бесконечности";
//     if (quarter == 2) return "Диапозон Х от - бесконечности до 0, диапозон у от 0 до бесконечности";
//     if (quarter == 3) return "Диапозон Х от - бесконечности до 0, диапозон у от - бесконечности до 0";
//     if (quarter == 4) return "Диапозон Х от 0 до бесконечности, диапозон у - бесконечности до 0";
//     return "Пользователь - банан";
// }
// Console.WriteLine(func20(Convert.ToInt32(Console.ReadLine())));



// 21. Программа проверяет пятизначное число на палиндромом.


// bool func21 (int a)
// {
//     return (a%10==a/10000 && a/10%10==a/1000%10);

// }
// Console.WriteLine(func21 (23435));
// Разбиваем число на цифры
// {
// for (int i = 0; i<5; i++)
// {

//     Console.WriteLine (a%10);
//     a= a/10;
// }
// }

// 22. Найти расстояние между точками в пространстве 2D/3D
double func22 (int x1, int y1, int x2, int y2)
{
  return Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
}
Console.WriteLine(func22(-3,-4,-7,-8));