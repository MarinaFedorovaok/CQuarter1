double[,] FillArray(double[,] array)                                           // метод заполнения массива
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble()*10;
        }
    }
    return array;
}


void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }

}



double MaxElement(double[,] array)
{
    double max = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] > max)
            {
                max = array[i, j];
            }
        }
    }
    return max;
}


double MinElement(double[,] array)
{
    double min = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
            }
        }
    }
    return min;
}

double Dif(double a, double b)
{
    if (a > b) return a - b;
    else return b - a;
}






double[,] array = new double [3,4]; 
 FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine(MaxElement(array));
Console.WriteLine(MinElement(array));


Console.WriteLine();
Console.WriteLine(Dif(MaxElement(array), (MinElement(array))));
