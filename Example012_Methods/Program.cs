Console.Clear();


// 1 вид метода ничего не принемаем ничего не возвращаем

// void Method1()
// {
//     Console.WriteLine("Автор...");
// }
// Method1(); //вызываем вот так
// Method1();

// 2 Вид метода принемает ничего не взвращает


// void Method2(string mmax)
// {
//     Console.WriteLine(mmax);
// }
// Method2("Текст сообщения");

// 2.1 Вид метода принемает ничего не взвращает

// void Method21(string mmax, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(mmax);
//         i++;
//     }
// }
// Method21(mmax: "Текст сообщения", count: 5); // можно менять местами если прописали привязку к аргументам
// Method21(count: 5, mmax: "новый текст");



// 3 Вид метода ничего не принемаем, но возвращаем

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);

// 4 вид метода, принемаем и возвращаем

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count) 
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(count: 10, text: "Z");
// Console.WriteLine(res);


// 4.1 вид метода, принемаем и возвращаем
// string Method4(int count, string text)
// {

//     string result = String.Empty;

//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(count: 10, text: "Zz");
// Console.WriteLine(res);





// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.Write($"{i} x {j} = {i * j}, ");
//     }
//     Console.WriteLine();
// }


//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?




string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldV, char newV)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldV) result = result + $"{newV}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);
Console.WriteLine();




// сортировка

// int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();

// }

// void selectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] < array[minPosition]) 
//             {
//                 minPosition = j;
//             }
            
//         }



//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;

//     }

// }

// PrintArray(arr);
// selectionSort(arr);

// PrintArray(arr);

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();

}

void selectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[minPosition]) 
            {
                minPosition = j;
            }
            
        }



        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;

    }

}

PrintArray(arr);
selectionSort(arr);

PrintArray(arr);