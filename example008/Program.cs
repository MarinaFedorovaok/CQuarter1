int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2>result) result = arg2;
    if (arg3>result) result = arg3;
    return result;
}

int a1 = 3124;
int b1= 4114;
int c1 = 3124;
int a2= 14;
int b2= 414;
int c2 = 324;
int a3= 411;
int b3= 414;
int c3 = 324;

int max= Max(
    Max(a1, b1, c1),
    Max(a2, b2, c2),
    Max(a3, b3, c3)
);

Console.WriteLine(max);