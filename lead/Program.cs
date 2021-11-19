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

Console.WriteLine("Введите числа через пробел и нажмитие ентер");
string condition = Console.ReadLine(); //ввели числа
string[] text = condition.Split(' '); // Создали массив подстрок (каждое число - набор символов)

int count = text.Length; // узнали количество элементов массив
int[] Array1(int count) //Создаем массив нужного размера
{
    return new int[count];
}

void FillArray1(int[] array) // Создаем метод заполения массива числами
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Int32.Parse(text[i]); // переводим каждый элемент массива строк в числа
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
//int[] arr = Array1(count); //создали массив arr 
//FillArray1(arr); // наполнили его 
//Console.Write(PrintArray(arr)); // напечатали массив нужного размера
//Console.WriteLine($"The numbers are the sides of a triangle, these are:{triangle(arr[0], arr[1], arr[2])}"); // вызвали и напечатали ответ


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
int[] arr = Array1(count); //создали массив arr 
FillArray1(arr); // наполнили его числами
int countArray(int[] array) //Создаем метод подсчета положительных элементов
{
    int res = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) res++;
    }
    return res;
}
Console.WriteLine($"Полодительных элементов {countArray(arr)}");


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