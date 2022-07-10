int[] array = { 16, 20, 31, 23, 18, 50, 4, 23, 18 };

int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{
    if(array[index] == find )
    {
        Console.WriteLine(index);
        break;
    }
    index = index + 1;
}