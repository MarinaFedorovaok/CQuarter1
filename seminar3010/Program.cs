// See https://aka.ms/new-console-template for more information
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

Console.WriteLine("*****"); // Здесь все нормально, создали массив А

int [] B = new int [10]; // Создали массив В 

int indexA = 1;
int indexB = 0;   // Объявили счетчики для массивов A и B

while (indexA< 10)
{
    
     if (A[0] > A[indexA]) // выясняем, является ли первый элемент массива A самым большим
     {
         B[0]=A[0];
         Console.WriteLine(B[0]); // если он самый большой выводим его в массиве B
         indexA++;

       }
       if (A [indexA-1]<A [indexA])  // если он не самый большой - сравниваем его со следующим
            {
                B [indexB] = A [indexA-1]; // если первый элемент меньше - выводим его в массиве B
                Console.WriteLine(B[indexB]);
                indexA++;
                indexB++;

            }
            indexA++; // если не меньше - проверяем следующий элемент массива


     }
   