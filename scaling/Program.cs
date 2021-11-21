// 46. Написать программу масштабирования фигуры
// Исходные данные:  фигура нарисована значками и надо нарисовать в н раз большую

int[,] pic = new int[,]
{
    {0, 0, 0, 0, 0},
    {0, 1, 0, 1, 0},
    {0, 0, 0, 0, 0},
    {1, 0, 0, 0, 1},
    {0, 1, 1, 1, 0},
    {0, 0, 0, 0, 0},
};

void PrintImage1(int[,] pic) //Cоздаем метод выведения фигуры в первом массиве
{
    for (int i = 0; i < pic.GetLength(1); i++)
    {
        for (int j = 0; j < pic.GetLongLength(1); j++)
        {
            //Console.Write($"{matr[i, j]} ");
            if (pic[i, j] == 0) Console.Write(" ");
            else Console.Write("@");

        }
        Console.WriteLine();
    }
}
PrintImage1(pic); // выводим первую фигуру
Console.WriteLine("-----------------");

void PrintScalingRow(int[,] pic, int NumROW, int n) //Cоздаем метод выведения отмасштабированной строки
{
    for (int i = 0; i < pic.GetLength(1); i++) //проверяем выход за строку
    {
        for (int m = 0; m<n; m++) //задаем счетчик масштабирования
        {
            if (pic[NumROW, i] == 0) Console.Write(" ");
            else Console.Write("@");
           
        }
    }  Console.WriteLine();//Переводим строку
}
void PrintScalingColumn(int[,] pic, int n)
{
for (int j = 0; j<pic.GetLength(0); j++) //задаем счетчик строк
{   
    for (int k=0; k<n; k++) //Задаем счетчик повтора строк
    PrintScalingRow(pic, j, n);

 }
}
PrintScalingColumn(pic, 5);
//PrintScalingRow(pic, 0, 2); // масштабируем первую строку
