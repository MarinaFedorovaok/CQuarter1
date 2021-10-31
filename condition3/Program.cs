//**Задание**

// Имеется числовой массив A заполненный числами из отрезка [minValue; maxValue].
// Создать на его основе масив B, убрав те элементы, которые нарушают порядок
// знакочередования


int [] A = new int [10];
int index = 0;
while (index < 10)
{
    A[index] = new Random().Next(-5, 5);
    Console.WriteLine(A[index]);
    index++;
}

Console.WriteLine("*");
//Trying to count the amount
// int count = 0;
// int amountB = 0;
// int a = 0;
// int b = 0;
// int c = 0;
// int d = 0;
// int e = 0;
// int f = 0;
// int g = 0;
// int h = 0;
// int i = 0;
// int j = 0;
// int [] B = new int [amountB] {a, b, c, d, e, f, g, h, i, j};

int [] B = new int [10];
int indexA = 0;
int indexB = 0;
 while (indexA < 10)
{
    if (A[indexA] < 0)
    {
        B[indexB]=A[indexA];
        Console.WriteLine(B[indexB]);
        indexB++;

    }
       indexA++;
 }