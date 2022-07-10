int Max(int arg1, int arg2, int arg3 )
{
    int result = arg1;
    if ( arg2 > result ) result = arg2;
    if ( arg3 > result ) result = arg3;
    return result;
}

int[] array = {16,309,30,29,132,54,50,23,90};

int max = Max(
    Max(array[0],array[1],array[2]),
    Max(array[3],array[4],array[5]),
    Max(array[6],array[7],array[8]));
Console.WriteLine(max);