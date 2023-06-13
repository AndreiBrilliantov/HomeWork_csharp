int Max(int arg1, int arg2, int arg3) {
    int result = arg1;
    if(arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
    }
int a1 = 12, a2 = 32, a3 = 65;
int max = Max(a1, a2, a3);
Console.WriteLine(max);