Console.Clear();



// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }




// int[] array = { 11, 21, 31, 41, 15, 61, 17, 18, 19 };


// int max = Max(
//     Max(array[0], array[1], array[2]), 
//     Max(array[3], array[4], array[5]), 
//     Max(array[6], array[7], array[8]));

// Console.WriteLine(max);


//вариант 2
// int[] array = { 11, 42, 13, 42, 52, 62, 4, 42 };

// int n = array.Length;

// int find = 42;

// int index = 0;
// while (index < n)
// {
//     if (array[index] == find)
//     {
//         Console.WriteLine(index);
//         break;
//     }
//     // index = index + 1;
//     index++;
// }



// Вариант 3


void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);

        index++;
    }
}

void PrintArrey(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position] + ", ");
        position++;
    }

}


int[] array = new int[10];

FillArray(array);
PrintArrey(array);
