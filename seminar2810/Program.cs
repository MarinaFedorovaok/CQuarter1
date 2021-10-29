// int[] arr = new int [10];
// int index = 0;
// while(index<10)
// {
//     Console.Write(arr[index]);
//     index++;

// // }
void DrawRetangle(int posX, int posY, int wight, int hight)
{
   int row = 0;
   while (row< hight)
   {
    //    Console.SetCursorPosition(posX, posY + row);
       int count = 0;
       while (count<wight)
       {
           Console.Out.Write("+");
            count++;
       }
        row++;
        Console.Out.Write("\n");
   }

    //Console.SetCursorPosition(posX, posY);
    

}
//Console.Clear();
DrawRetangle(5, 3,9,4);
// Console.ReadLine();

// x^2+bx+c=0
// //A*x^2+b*x+c=0
// void Solve(double a, double b, double c)

// {
//     // double a = -1;
    // double b = -1;
    // double c = 6;
//     double d = b * b - 4 * a * c;
//     Console.WriteLine(d);
//     if (d < 0)
//     {
//         Console.WriteLine("действительных корней нет");
//     }
//     else
//     {
//         double x1 = (-b + Math.Sqrt(d)) / (2 * a);
//         double x2 = (-b - Math.Sqrt(d)) / (2 * a);
//         // return (x1, x2);
//         Console.WriteLine(x1);
//         Console.WriteLine(x2);
//     }
// }
// Solve(1, -7, 6);


//Try to make file


// void DrawRectangle(int wight, int hight)
// {
//    int row = 0;
//    while (row < hight)
//    {
//        int count = 0;
//        while (count < wight)
//        {
//            System.Console.Out.Write ("*");
//             count++;
//        }
//        row++;
// 	System.Console.Out.WriteLine(""); 
//    }
// }


// int wight = 30;
// int hight = 10;

// DrawRectangle(wight, hight);
