int Max(int arg1, int arg2, int arg3, int arg4, int arg5, int arg6)
{
    int result = arg1;
    if (arg2>result) result=arg2;
    if (arg3>result) result=arg3;
    if (arg4>result) result=arg4;
    if (arg5>result) result=arg5;
    if (arg6>result) result=arg6;
    return result;
}
 //              0    1    2    3      4     5
 int [] array = {11, 222, 3453, 4212, 42112,2432};

 int result= Max(array[0], array[1],
                     array[2], array[3], array[4], array[5]);

       Console.WriteLine(result);