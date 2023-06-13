int[] array = {1, 12, 13, 23, 35, 12, 1};
int n = array.Length;
int find = 12;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}