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

string Method4 (int count, string c)
  {
      int i = 0;
      string result = String.Empty;
      while(i < count)
      {
          result = result+c;
           i++;
        }
     return result;
 }

string res = Method4 (count: 10, c: "z");
Console.WriteLine (res);
