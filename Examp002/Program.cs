//int Max(int [] arr)
/*
{
    int result = arr[0];
    for (int i = 0; i < arr.length; i++)
    {
        if (arr[i] > result)
        {
            result = arr[i];
        }
    }
    return result;
}

/*
int a1 = 33;
int b1 = 12;
int c1 = 55;

int a2 = 6;
int b2 = 124;
int c2 = 15;

int a3 = 22;
int b3 = 17;
int c3 = 43;
*/

//int [] arr = { 33, 12, 55, 6, 124, 15, 22, 17, 43};

/*
int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);

int maxEnd = Max(max1, max2, max3);
*/

//Console.WriteLine(Max(arr));

void FillArray(int[] Collection)
{
    int length = Collection.Length;

    int index = 0;

    while (index < length)
    {
        Collection[index] = new Random().Next(1,10);
        index++;
    }

}

void PrintArray(int[] Col)
{
    int count = Col.Length;
    int position = 0;

    while (position < count)
    {
        Console.WriteLine(Col[position]);
        position++;
    }
}

int[] newArray = new int[10];
FillArray(newArray);
PrintArray(newArray);