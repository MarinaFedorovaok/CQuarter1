// масштабирование относительно нуля
void Scale (int x1, int y1, int x2, int y2, int n) 
{ Console.WriteLine ($"Координаты исходного отрезка({x1}, {y1}), ({x2}, {y2})");
  int x11 = n*x1;
  int x21 = n*x2;
  int y11 = n*x1;
  int y21 = n*x2;
  Console.WriteLine ($"при масштабировании относительно 0 в {n} раз Координаты нового отрезка({x11}, {y11}), ({x21}, {y21})");
}
Scale (2, 3, 4, 3, 5);
// double Length1 (int x1, int y1, int x2, int y2, int n)
// {
//   double L1 = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
//   double L2 = L1*n;
//   double k = (y2-y1)/(x2-x1); // ищем уравнение прямой
//   double b = (x2-x1)/Math.Sqrt(1/(1+k*k));
//   double x3 = x2-Math.Sqrt((L2*L2-(y2-y3)*(y2-y3))); //система уравнений
//   double y3 = k*x3+b;
//  return x3;

// }
// Console.WriteLine(Length1(-3,-4,-7,-8, 2));

//y3 = kx3+b ищем координаты третьей точки из уравнения прямой
//(x2-x3)^2+(y2-y3)^2=Length1^2
//x3 = x2-корень(Length1^2-(y2-y3)^2)
