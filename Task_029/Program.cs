// Задача 29:

// Напишите программу, которая задаёт массив 
// из нескольких элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void Main()
{
    int[] arr = FillArray(8, 1,10);
    PrintArray(arr);
}

int[] FillArray(int size, int leftRange, int rightRange)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        tempArray[i] = rand.Next(leftRange, rightRange + 1);
    }
    return tempArray;
}

void PrintArray(int[] Array)
{
    System.Console.WriteLine("[" + string.Join(", ", Array) + "]");
}

Main();


// void FillArray(int[] Array)
// {
//     Random rand = new Random();
//     for (int i = 0; i < Array.Length; i++)
//     {
//         Array[i] = rand.Next(0, 10);
//     }
// }

// void PrintArray(int[] Array)
// {
//     System.Console.WriteLine(string.Join(", ", Array));
// }

// int n = 8;
// int[] arr = new int[n];
// FillArray(arr);
// PrintArray(arr);

