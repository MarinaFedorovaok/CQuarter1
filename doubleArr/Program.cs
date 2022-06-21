// String.Empty
//table[0,0] table[0,1] table[0,2]..
//table[1,0] table[1,1] table[1,2]..
// string[,] table = new string[2, 5];
// table[1, 2] = "слово";
// for (int rows = 0; rows <2; rows++)
// {
//    for (int columns = 0; columns <5; columns++)
//    {
//        Console.WriteLine($"-{table[rows, columns]}-");
//    }  
// }


// void PrintArray(int[,] matr)
// {
   
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLongLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// int[,] matrix = new int[3, 4];
// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);

int [,] pic = new int[,]
{
    {0, 1, 1, 1, 0},
    {0, 1, 0, 1, 0},
    {1, 0, 0, 1, 0},
    {0, 1, 0, 1, 0},
    {0, 0, 1, 1, 0},
    {0, 0, 0, 0, 0},
};
void PrintImage(int[,] pic)
{
   
    for (int i = 0; i < pic.GetLength(0); i++)
    {
        for (int j = 0; j < pic.GetLongLength(1); j++)
        {
            //Console.Write($"{matr[i, j]} ");
            if(pic[i,j] ==0) Console.Write(" ");
            else Console.Write("*");

        }
        Console.WriteLine();
    }
}
void FillImage(int row, int col)
{
    if (pic[row, col] ==0)
    {
        pic[row, col] = 8;
        FillImage(row-1,col);
        FillImage(row,col-1);
        FillImage(row+1,col);
        FillImage(row,col+1);
    }
}

PrintImage(pic);
FillImage(1,2);
PrintImage(pic);




