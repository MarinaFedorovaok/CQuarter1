            // Метод1 - ничего не возваращает и не принимает
// void Method1 ()
// {
// Console.WriteLine("Hey!");

// }
// Method1();

//         Метод2 - ничего не возваращает. но принимает

// void Method2 (string msg)
// {
// Console.WriteLine(msg);

// }
// Method2(msg: "Here is a text");

      //  Метод3 -возваращает. но не принимает

// int Method3 ()
// {
//     return DateTime.Now.Year;
// }
// int Year = Method3 ();
// Console.WriteLine(Year);

        // Метод4 -возвращает и принимает

// string Method4 (int count, string c)
//   {
//       int i = 0;
//       string result = String.Empty;
//       while(i < count)
//       {
//           result = result+c;
//            i++;
//         }
//      return result;
//  }

// string res = Method4 (count: 10, c: "z");
// Console.WriteLine (res);

//                     // Циклы. Таблицы умножения.

// for (int i = 0; i<=10; i++)
//     {
//         for (int j = 2; j <=10; j++)
//             {
//                 Console.WriteLine($"{i}*{j}={i*j}");

//             }
//             Console.WriteLine();
   // }

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

                // Возвращает квардрат числа
        //  int m(int a)   
        //  {
        //      int result = a*a;
        //      return result;
        //  }
        //  int res = m(5);
        //  Console.Write(res);
            
            
            // Sorting arrang

    int[] Arr = {1, 3, 4, 56, 32, 25, 34, 5, 3};

void PrintArray (int[] array)

{
 int count = array.Length;
 int length = Arr.Length;

 for (int i =0; i < length; i++)

    {
        Console.WriteLine($"{array[i]}");
    }
    Console.WriteLine();

}

void SelectoinSort(int[] array)
{

    for (int i=0; i<array.Length - 1 ; i++)
    {
        int minPosition = i;

         for (int j=i+1; j<array.Length; j++)

         {
            if(array[j]< array[minPosition]) minPosition = j;

         }

        //
        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;



    }



}

PrintArray(Arr);
SelectoinSort(Arr);
PrintArray(Arr);


