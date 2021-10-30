//**Задание**

// Имеется числовой массив A заполненный числами из отрезка [minValue; maxValue].
// Создать на его основе масив B, отбрасывая  
// элементы, больше 8


int [] A = new int [10];
int index = 0;
while (index < 10)
{
    A[index] = new Random().Next(0, 10);
    Console.WriteLine(A[index]);
    index++;
}
int [] B = new int [10];

// index = 0;
// while (index <10)
// {
//     int val = A[index];
//     Console.WriteLine(A[index]);
//     index++;
// }
Console.WriteLine("*");
// index = 0;
// B [index]=A [index];
// Console.WriteLine(B[index]);
index = 0;
 while (index < 10)
{
    if (A[index] < 8)
    {
        B[index]=A[index];
        Console.WriteLine(B[index]);
        index=index++;

    }
       index++;
 }