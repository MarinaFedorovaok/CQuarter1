﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// int i = 0;
// while (i < 10)

// {

//     i += 2;
//     Console.WriteLine (i);
//
// // }

// int [] arr = new int[] {1, 2, 3, 8, 12 }
// int k = GetNumber();


//**Задание**

// Имеется числовой массив A заполненный числами из отрезка [minValue; maxValue].
// Создать на его основе масив B, отбрасывая те, которые нарушают порядок
// возрастания
// элементы, больше 8
// знакочередования
                // Версия с 1 индексом

// int [] A = new int [10];
// int index = 0;
// while (index < 10)
// {
//     A[index] = new Random().Next(10, 100);
//     Console.WriteLine(A[index]);
//     index++;
// }

// index = 0;
// while (index <10)
// {
//     int val = A[index];
//     Console.WriteLine(A[index]);
//     index++;
// }

// Console.WriteLine("******");
// int [] B = new int [10];
// index = 0;
// B [index]=A [index];
// Console.WriteLine(B[index]);

// index = 0;
//  while (index < 10)
// {
//     if (A[index] < A[index+1])
//     {
//         B[index]=A[index];
//         B[index+1] = A[index+1];
//         Console.WriteLine(B[index]);
//         Console.WriteLine(B[index+1]);
//         index=index+1;

//     }
       
//         index=index+1;
//     }


// int find = 143;
// int index= 0;
// while (index < n)
// {
//     if (array[index] == find)
//         {
//             Console.WriteLine(index);
//             break;
//         }
//         index++;
// }
                // Версия с 2 индексами

int [] A = new int [10];
int index = 0;
while (index < 10)
{
    A[index] = new Random().Next(10, 100);
    Console.WriteLine(A[index]);
    index++;
}

Console.WriteLine("*****");

int [] B = new int [10];

int indexA = 1;
int indexB = 0;
while (indexA< 10)
{
    
     if (A[0] > A[indexA])
     {
         B[0]=A[0];
         Console.WriteLine(B[0]);
         indexA++;

       }
       if (A [indexA-1]<A [indexA])  
            {
                B [indexB] = A [indexA-1];
                Console.WriteLine(B[indexB]);
                indexA++;
                indexB++;

            }
            indexA++;


     }
    //  B[0]=A[0];
    //  Console.WriteLine(B[0]);
// indexB = 0;
// indexA = 0;
// B[indexB]=A[indexA];
// Console.WriteLine(B[indexB]);