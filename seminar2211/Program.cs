// масштабирование относительно нуля
void Scale(int x1, int y1, int x2, int y2, int n)
{
    Console.WriteLine($"Координаты исходного отрезка({x1}, {y1}), ({x2}, {y2})");
    int x11 = n * x1;
    int x21 = n * x2;
    int y11 = n * x1;
    int y21 = n * x2;
    Console.WriteLine($"при масштабировании относительно 0 в {n} раз Координаты нового отрезка({x11}, {y11}), ({x21}, {y21})");
}
Scale(2, 3, 4, 3, 5);
