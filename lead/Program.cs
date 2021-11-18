// Почувствуй себя лидом

// 41. Выяснить являются ли три числа сторонами треугольника 
// Сумма длин двух любых сторон треугольника больше длины оставшейся стороны:
// a + b > c
// b + c > a
// c + a > b
bool triangle(int a, int b, int c) // создание метода проверки
{
    return ((a + b > c) && (b + c > a) && c + a > b);
}
// Console.WriteLine("Bведите число1"); // ввод чисел с клавиатуры по очереди
// int d = int.Parse(Console.ReadLine());
// Console.WriteLine("Bведите число2");
// int e = int.Parse(Console.ReadLine());
// Console.WriteLine("Bведите число3");
// int f = int.Parse(Console.ReadLine());
// Console.WriteLine($"Ответ:{triangle(d, e, f)}");

              //*** Может помочь
             // Замена элементов текста
    // string text = "We go together";

    // string Replace (string text, char oldValue, char newValue) //(Сhar) — тип данных, предназначенный для хранения одного символа (управляющего или печатного) в определённой кодировке. Может являться как однобайтовым (для стандартной таблицы символов), так и многобайтовым (к примеру, для Юникода). Основным применением является обращение к отдельным знакам строки.
    // {
      
    //     string result = String.Empty;
    //     int length = text.Length;
    //     for (int i = 0; i < length; i=i+1)
    //     {
    //         if(text[i] == oldValue) result = result + $"{newValue}";
    //         else result = result + $"{text[i]}";

    //     }
    // return result;
    // }
  
    // string newText = Replace(text, ' ', '|');
    // Console.WriteLine(newText);
////
int[] Array1(int count) //Создаем массив размером, равным длине строки
{   
    return new int[count];
}

Console.WriteLine("Введите числа через пробел");
string condition = Console.ReadLine(); //ввели числа в строку
int count = condition.Length; // узнали количество символов

void FillArray1(int[] array) // Создаем метод заполения массива знаками 
{
       for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(condition[i]);
    }
}

string PrintArray(int[] array) //Создаем метод выведения массива на экран в строку
{
    string res = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        res += $"{array[i]} ";
    }
    return res;
}
int[] arr = Array1(count);
FillArray1(arr);
Console.Write(PrintArray(arr)); // создали и напечатали массив нужного размера


// 1. Вводим стороку с консоли
// 2. Определяем длину строки. Создаем массив размером, равным длине этой строки
// 3. В массив помещаем все символы по одному
// 4. создаем итоговый массив
// 5. В итоговый массив помещаем числа таким образом: 
//  - первое число - все знаки до пробела (преобразуем в число)
//  - второе число  -опять все знаки до пробела
//  6. На выходе - массив чисел


// 42. Определить сколько чисел больше 0 введено с клавиатуры
// int countAlements(int n)
// {
// string a;
//         int[] b = new int[n];
//         for (int i=0; i<n; i++)
//         {a = Console.ReadLine();
//         b[i] = Convert.ToInt32(a);
//         }

//         // while ((a = Console.ReadLine()) != "end") //Получаем строку и проверяем ее содержание
//         //     b[i++] = Convert.ToInt32(a); //в стркое нет "конца" - значит конвертим и пишем в массив
//         int count = 0;
//         for (int k = 0; k < n; k++) //вывод заполненных ячеек массива
//         {
//         if (b[k]>0) count++;
//             Console.WriteLine(b[k]);
//         }
//     return count;
//  }
// Console.WriteLine($"Количество положительных элементов:{countAlements(5)}");
//  Console.ReadKey(true);

// 43. Написать программу преобразования десятичного числа в двоичное
// 44. Найти точку пересечения двух прямых заданных уравнением y1=k1x1+b1, y2=k2x2+b2 и b2 и k2 заданы

// найти точку (x, y), x=x1=x1, y=y1=y2
//x=(y-b1)/k1
//y=k2*(y-b1)/k1+b2 
//y=k2y/k1-k2b1/k1+b2
//y(1-k2/k1)=b2-k2b1/k1
//y=(b2-k2b1/k1)/(1-k2/k1)

// double Find ((int b1, int k1) x, (int b2, int k2) y) 
//double[] FuncPow(int n) 
// { 
//     double [] array = new double [n]; 
//     for(int i = 1; i <= n; i++) 
//     { 
//         array[i - 1] = Math.Pow(i, 2); 
//     } 
//     return array; 
// } 

// 45. Показать числа Фибоначчи
// 46. Написать программу масштабирования фигуры
// 47. Написать программу копирования массива