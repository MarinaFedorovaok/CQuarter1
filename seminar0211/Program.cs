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

                    // Циклы. Таблицы умножения.

for (int i = 0; i<=10; i++)
    {
        for (int j = 2; j <=10; j++)
            {
                Console.WriteLine($"{i}*{j}={i*j}");

            }
            Console.WriteLine();
    }

        // Замена элементов текста
      
    string Replace (string text, char oldValue, char newValue) //(Сhar) — тип данных, предназначенный для хранения одного символа (управляющего или печатного) в определённой кодировке. Может являться как однобайтовым (для стандартной таблицы символов), так и многобайтовым (к примеру, для Юникода). Основным применением является обращение к отдельным знакам строки.
    {
      
        string result = String.Empty;
        int length = text.Length;
        for (int i = 0; 1<length; i++)
        {
            if(text[i]==oldValue) result = result + $"{newValue}";
            else result = result + $"{text[i]}";

        }

    }
  string text = "Я к вам пишу — чего же боле? Что я могу ещё сказать?";
    string newText = Replace(text, ' ', '|');
    Console.WriteLine(newText);