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

int [] A = new int [10];
int index = 0;
while (index < 10)
{
    A[index] = new Random().Next(10, 100);
    Console.WriteLine(A[index]);
    index++;
}
 Console.WriteLine("******"); // первый массив


// int [] B = new int [10];
// index = 0;
// B [index]=A [index];
// Console.WriteLine(B[index]);
int [] B = new int [10];
B[0]=A[0]; 
Console.WriteLine(B[0]);// выводим первый элемент

index = 1;
 while (index < 10)
{
    if (A[0] < A[index])
    {
        B[index]=A[index];
        Console.WriteLine(B[index]);
        index++;
        if (A[index]<A[index+1])
        {
             B[index]=A[index];
             index++;

        }

       index ++;

    }
       
        index=index+1;
    }


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

// void FillArray(int[] collection)       // заполняем массив случайными целыми двузначными числами
// {
//     int length = collection.Length;
//     int index = 0;
//      while (index < length)
//      {
//          collection[index] = new Random().Next(10, 100);  // задаем рандомные целые числа от 10 до 99
//          index++; 
//      }
// }

// void PrintArray(int[] col)             // печатаем заданный в качестве аргумента массив       
// {
//     int count = col.Length;
//     int index = 0;
//     while (index < count)
//     {
//         if (col[index] != 0) Console.WriteLine(col[index] +" ");  // выводим на экран только те элементы массива, которые не маркированы 0 по умолчанию
//         index++;
//     }
//     Console.WriteLine();  // просто разрыв строки для удобства восприятия
// }
// int[] A = new int[10];            // создаем исходный массив А
// int[] B = new int[10];           // создаем массив для чисел, отбрасывая те, которые нарушают порядок возрастания
// FillArray(A);                       // вызываем функцию для заполнения массива А случайными двузначными числами от 10 до 99
// PrintArray(A);                      // выводим массив А на экран для понимания, с чем мы работаем

// Console.WriteLine("****");  // отделим первый массив от второго




// int [] A = new int [10];
// int index = 0;
// while (index < 10)
// {
//     A[index] = new Random().Next(10, 100);
//     Console.WriteLine(A[index]);
//     index++;
// }

// Console.WriteLine("*****"); // Здесь все нормально, создали массив А

//int[] B = new int[10];       // создаем массив для чисел, отбрасывая те, которые нарушают порядок возрастания
// int max = A[0];        // по умолчанию считаем нулевой элемент максимальным

// int index = 0;

// while (index < 10)
// {
//     if (A[index] > max)             // проверяем, если текущий элемент больше предыдущего (не нарушает порядок возрастания)
//     {
//         B[index] = A[index];  // то забираем его в массив В
//         max = A[index];             // запоминаем текущий элемент для сравнения со следующим элементом
//        // Console.WriteLine(B[index]); // Выводим массив В
//     }
//     else 
//     {                                    // если текущий элемент оказался меньше предыдущего (нарушил возрастание), то дальше ничего не делаем
//         break;                           // прерываем цикл
//     }                                     
//     index++;
// }

// FillArray(B);                       // вызываем функцию для заполнения массива А случайными двузначными числами от 10 до 99
// PrintArray(B);                      // выводим массив А на экран для понимания, с чем мы работаем



//Моя попытка с так и не нйденной ошибкой

// int indexA = 0; //Объявили счетчик для первого и второго числа
// int indexA2 = 0;   // Объявили счетчикдля остальных чисел

//  while (indexA < 10)
//      if (A[0] > A[indexA]) // выясняем, является ли первый элемент массива A самым большим
//      {
//          B[0]=A[0];
//           indexA++;

//        }
//        indexA++;
//     }
