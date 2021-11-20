// // Почувствуй себя лидом

// 41. Выяснить являются ли три числа сторонами треугольника 
// Сумма длин двух любых сторон треугольника больше длины оставшейся стороны:
// a + b > c
// b + c > a
// c + a > b
bool triangle(int a, int b, int c) // создание метода проверки
{
    return ((a + b > c) && (b + c > a) && c + a > b);
}
int[] stringToNumbers(string s) //метод перевода строки в массив чисел
{
    string[] text = s.Split(' '); // Создали массив подстрок (каждое число - набор символов)  
    int[] arr = new int[text.Length]; //создали массив arr размером по количеству строчных кусочков
    for (int i = 0; i < text.Length; i++)
    {
        arr[i] = Int32.Parse(text[i]); // переводим каждый элемент массива строк в числа

    }
    return arr;
}
string PrintArray(int[] array) //Создаем метод выведения массива на экран в строку
{
    string res = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        res += $"{array[i]} ";
    }
    Console.WriteLine(res);
    return res;
}

// Console.WriteLine("Введите числа через пробел и нажмитие ентер");
// string condition = Console.ReadLine(); //ввели числа
// //PrintArray(stringToNumbers(condition));
// int[] arr = stringToNumbers(condition);
// Console.WriteLine($"The numbers are the sides of a triangle, these are:{triangle(arr[0], arr[1], arr[2])}"); // вызвали и напечатали ответ


//**алгоритм:

// 1. Вводим стороку с консоли
// 2. Ищем в сроке пробелы, куски до пробелов засовывем в отдельные строки
// 3. Строки переводим в числа и засовываем числа в массив
// 4. Берем для решения первые 3 числа массива


// Вариант Ник..
// int myReadNum(){
//     const int zerro = (int) '0'; // переводим символ в int
//     const int nine  = (int) '9';
//     int symb = Console.Read(); // Создали буфер
//     while (!(zerro <= symb && symb <= nine)) {symb = Console.Read();} // пока считываем не цифры, продолжаем считывать
//     int ans = 0;
//     while (zerro <= symb && symb <= nine) // проверяем, число ли это
//     {
//         ans = ans * 10 + (symb-zerro); // Записываем в переменную число. Вычитем ноль из-за кодировки 
//         //Console.WriteLine($"symb = {symb}");
//         symb = Console.Read();
//     }
//     return ans;
// }
// //Console.WriteLine(myReadNum() + 1); // Выводим число+1 (для проверки, что это число)
// // int d = myReadNum();
// // int e = myReadNum();
// // int f = myReadNum();
// // Console.WriteLine($"Ответ:{triangle(d, e, f)}");
// // А можно обойтись и вообще без переменных 
// Console.WriteLine($"Ответ:{triangle(myReadNum(), myReadNum(), myReadNum())}");

// 42. Определить сколько чисел больше 0 введено с клавиатуры
// Console.WriteLine("Введите числа через пробел и нажмитие ентер");
// string condition = Console.ReadLine(); //ввели числа
// //PrintArray(stringToNumbers(condition));
//int[] arr = stringToNumbers(condition);
// int countArray(int[] array) //Создаем метод подсчета положительных элементов
// {
//     int res = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) res++;
//     }
//     return res;
// }

//Console.WriteLine($"Положительных элементов {countArray(arr)}");


// 43. Написать программу преобразования десятичного числа в двоичное
int[] transfArray(int n, int k) //метод создания массива из десятичного числа в любую систему с основанием k
{
    int s = n;
    int x = 0;
    int num = (int)Math.Log(n, k) + 1;//узнаем количество элементов в массиве с учетом количества знаков итогового числа в системе с основанием к
    int[] arr = new int[num];//создаем массив
    while (s > 0)
    {
        x = s % k;
        s = s / k;
        arr[num - 1] = x; // положили остаток в последний элемент массива
        Console.WriteLine($"x = {x};\ts = {s}");
        if (num > 0) num = num - 1;
    }
    return arr;
}
PrintArray(transfArray(5, 2));
// 44. Найти точку пересечения двух прямых заданных уравнением y1=k1x1+b1, y2=k2x2+b2 и b2 и k2 заданы

// найти точку (x, y), x=x1=x1, y=y1=y2
// x=(y-b1)/k1
// y=k2*(y-b1)/k1+b2 
// y=k2y/k1-k2b1/k1+b2
// y(1-k2/k1)=b2-k2b1/k1
// y=(k1b2-k2b1)/(k1-k2)


// double FindY(int b1, int k1, int b2, int k2) // метод ищет y
// {
//     if ((k1 - k2) == 0) return 0;
//     return (k1 * b2 - k2 * b1) / (k1 - k2);
// }
// double FindX(int b1, int k1, int b2, int k2) // метод ищет x
// {
//     return (FindY(b1, k1, b2, k2) - b1) / k1;
// }
// Console.WriteLine("Введите b1,  k1,  b2,  k2 через пробел и нажмитие ентер");
// string condition = Console.ReadLine(); //ввели числа
// int[] arr = stringToNumbers(condition);
// int b1 = arr[0];
// int b2 = arr[2];
// int k1 = arr[1];
// int k2 = arr[3];
// if ((k1 - k2) == 0)
//     Console.WriteLine("Прямые параллельны");
// else
//     Console.WriteLine($"x={FindX(b1, k1, b2, k2)}, y= {FindY(b1, k1, b2, k2)}");
// 45. Показать числа Фибоначчи
// 46. Написать программу масштабирования фигуры
// 47. Написать программу копирования массива