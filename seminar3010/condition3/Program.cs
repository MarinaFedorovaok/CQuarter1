//**Задание**

// Имеется числовой массив A заполненный числами из отрезка [minValue; maxValue].
// Создать на его основе масив B, те, которые нарушают порядок
// знакочередования


int [] A = new int [10];
int index = 0;
while (index < 10)
{
    A[index] = new Random().Next(-5, 5);
    Console.WriteLine(A[index]);
    index++;
}
int [] B = new int [10];

Console.WriteLine("*");

index = 0;
 while (index < 10)
{
    if (A[index] < 0)
    {
        B[index]=A[index];
        Console.WriteLine(B[index]);
        index=index++;

    }
       index++;
 }