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
// Решение Сергея
// int Max2(int first, int second) => first > second ? first : second; 
// int Min2(int fir, int sec) => fir < sec ? fir : sec; 

// (int min, int max) MinMax(int f, int s) => f > s ? (f, s) : (s, f);

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
void func7(int n)
{
    func7support(-n,n);
}
void func7support(int m, int n)
{
    if (m<=n) 
    {
        Console.WriteLine (m);
        func7support(m+1, n);
    } 
}

func7(3);
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

// void func8(int N)
// {
//     if (N%2!=0) N=N-1;
//       if (N>=1)
//       {
//          Console.WriteLine(N);
//          func8(N-2);
//       } 
// }
// func8(5);

//**************************************Var2

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

// int func10 (int N)
// {
// int a = N/100;
// int c = N%10;
// int res = (N-a*100 - c)/10;
// return res;
// }
// Console.WriteLine(func10(325));

// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
// int func11(int N)
// {
//     int a = N/10;
//     int b = N%10;
//     int res= a;
//     if (a<b) res = b;
//     //Console.WriteLine(res);
//     return res;
//  }
// Console.Write(func11(28));


// 12. Удалить вторую цифру трёхзначного числа
// int func12 (int N)
// {
//     int a = N%10;
//     int b = N/100;
//     int c = b*100;
//     int res= c+a;
//     return res;
// }
// Console.Write(func12(456));


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
// double func22 (int x1, int y1, int x2, int y2)
// {
//   return Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
// }
// Console.WriteLine(func22(-3,-4,-7,-8));
// Почувствуй себя мидлом
// 23. Показать таблицу квадратов чисел от 1 до N 
// double[] FuncPow(int n) 
// { 
//     double [] array = new double [n]; 
//     for(int i = 1; i <= n; i++) 
//     { 
//         array[i - 1] = Math.Pow(i, 2); 
//     } 
//     return array; 
// } 

// double [] Cube = FuncPow(14); 

// for(int index = 0; index < Cube.Length; index++) Console.WriteLine(Cube[index]);
// 24. Найти кубы чисел от 1 до N
// string func24 (int n)
// {   
//     string text = "All is OK";
//     int i = 1;
//     while (i<=n)
//     {

//         Console.WriteLine (Math.Pow(i, 3));
//          i++;
//     }
//       return text;
// }
// Console.WriteLine(func24(5));

// 25. Найти сумму чисел от 1 до А

//             Variant 2. Recursion.

// int func25recursion(int N)
// {
//     if (N <= 1) return 0;
//     else
//     {
//         return  func25recursion(N - 1)+N;
//     }
// }
// Console.WriteLine(func25recursion(5));


// int func25 (int n)
// {

//      n = n * (n+1)/ 2;
//     return n;
// }
// Console.Write(func25(5));
// 26. Возведите число А в натуральную степень B используя цикл
// int func26 (int A, int B)
// {
//     int result = 1;
//     for (int i = 1; i < B; i++) 
//     {
//         result = result * A;
//     } 
//     return result;
// }
// Console.WriteLine(func26(3, 4));


// 27. Определить количество цифр в числе
// int func27 (string a)
// {
//     int x = a.Length;
//     return x;
// }
// Console.WriteLine(func27("34567"));

//28. Подсчитать сумму цифр в числе

// Variant with Recursion

// int func28recursion(int N)
// {
//     if (N == 0) return 0;
//     else
//     {
//         return N%10 + func28recursion(N/10);
//     }
// }
// Console.WriteLine(func28recursion(-1287));


//        int func28(int N)
// {
//     // string a = Convert.ToString(N);
//     // int x = a.Length;
//     int summ = 0;
//     // for (int i = 0; i < x; i++)
//     while (N!=0)
//     {
//         summ = summ + N % 10;
//         N = N / 10;
//     }
//     return summ;
// }
// Console.WriteLine (func28(3478));

// N 12345  o  summ
//   1234   5  5
//   123    4  9
//   12     3  12
//   1      2  14
//   0      1  15

//Char
// string str = "Нужно ли сейчас использовать тип данных char?";
// char c = str[2];
// Console.WriteLine(c);


// 29. Написать программу вычисления произведения чисел от 1 до N

//         int func29(int N)
// {
//         int multiplication = 1;
//         for (int i = 1; i <= N; i++) multiplication=i*multiplication;
//        return multiplication;
// }
// Console.WriteLine (func29(12));

//     Variant 2. Recursion.

// int func29recursion(int N)
// {
//     if (N < 1) return 1;
//     else
//     {
//         return N * func29recursion(N - 1);
//     }
// }
// Console.WriteLine(func29recursion(12));

// 30. Показать кубы чисел от 0 до N, заканчивающихся на четную цифру
//  int func30(int N)
// {
//         int cube = 2;
//         int i = 2;
//         while (i <= N)
//         {
//         cube=i*i*i;
//         i= i+2;
//         Console.WriteLine(cube);
//         }
//        return cube;
// }
// func30(12);
//*********************************************//
//************* Var 2/ Recursion **************//
//*********************************************//
// void func30recursion(int N)
// {
//     if (N % 2 != 0) N = N - 1;
//     if (N > 0)
//     {
//         Console.WriteLine(N * N * N);
//         func30recursion(N - 2);
//     }
// }
// func30recursion(5);
//*********************************************//
//************* Var 3/ Recursion **************//
//*********************************************//

// void func30recursion2 (int i, int n)
// {
//     if (i<n) 
//     {Console.WriteLine(i*i*i);
//      func30recursion2 (i+2, n);
//    }

// }
// func30recursion2 (1, 34);
//****************************************************//
            // *// Сортировка слиянием
//****************************************************//

// int[] array = {1,2,3,2,4,5,8};


// void merge(int start, int middle, int end)
// {
//     int[] arrOut = new int[end - start];
//     int i = start;
//     int j = middle;
//     int o = 0;
//     while ((i < middle) && (j < end)) // проверяем границы кусочков массива
//     {
//         //Console.WriteLine($"i = {i}\tj = {j}");
//         if (array[i] < array[j])
//         {
//             //Console.WriteLine($"array[{i}] = {array[i]} < array[{j}] = {array[j]}");
//             arrOut[o] = array[i];//В итоговом массиве i+j элементов
//             i++; o++;
//         }
//         else
//         {
//             arrOut[o] = array[j];//В итоговом массиве i+j элементов
//             j++; o++;
//         }
//     }
//     if (i >= middle) //Дописываем хвосты в out
//     {
//         for (; j < end; j++)
//         {
//             arrOut[o] = array[j];
//             o++;
//         }
//     }
//     else
//     {
//         for (; i < end; i++)
//         {
//             arrOut[o] = array[i];
//             o++;
//         }
//     }
//     for (int k = 0; k < o; k++)
//     {
//         Console.Write(arrOut[k]);
//         Console.Write(' ');
//         array[start + k] = arrOut[k];
//     }
//     Console.Write("\n");
// }
// void sort (int start, int end)
// {
//     if (end-start > 1)
//     {
//         int middle = start + (end-start)/2;
//         //Console.WriteLine($"length = {end-start}");
//         //Console.WriteLine($"start  = {start}");
//         //Console.WriteLine($"middle = {middle}");
//         //Console.WriteLine($"end    = {end}");
//         sort (start, middle);
//         sort (middle, end);
//         merge (start, middle, end);
//     }
// }
// //merge(0,3,7);
// sort(0,7);

// // Почувствуй себя сеньором
// 31. Задать массив из 8 элементов и вывести их на экран 
// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 
// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
// 34. Написать программу замену элементов массива на противоположные
// 35. Определить, присутствует ли в заданном массиве, некоторое число 
// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

// Почувствуй себя лидом
// 41. Выяснить являются ли три числа сторонами треугольника 
// 42. Определить сколько чисел больше 0 введено с клавиатуры
// 43. Написать программу преобразования десятичного числа в двоичное
// 44. Найти точку пересечения двух прямых заданных уравнением y=kx+b, а1 k1 и а2 и k2 заданы
// 45. Показать числа Фибоначчи
// 46. Написать программу масштабирования фигуры
// 47. Написать программу копирования массива