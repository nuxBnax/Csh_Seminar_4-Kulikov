// Задача 29:

// Напишите программу, которая задаёт массив 
// из нескольких элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// void Main()
// {
//     int size = ReadInt("Insert a size of array you need: ");
//     int LeftRange = ReadInt("Insert LEFT range filling number of array: ");
//     int RightRange = ReadInt("Insert RIGHT range filling number of array: ");
//     FillArray(arr);
// }

// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[] FillArray(int[] size, int LeftRange, int RightRange)
// {
//     int[] arr = new int[size];
//     Random rand = new Random();
//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = rand.Next(LeftRange, RightRange);
//     }
//     return arr;
// }

// void PrintArray(int[] Array)
// {
//     System.Console.WriteLine(string.Join(" ", Array));
// }

// int n = 8;
// int[] arr = new int[n];
// arr = FillArray(arr);
// PrintArray(arr);


void FillArray(int[] Array)
{
    Random rand = new Random();
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = rand.Next(0, 10);
    }
}

void PrintArray(int[] Array)
{
    System.Console.WriteLine(string.Join(", ", Array));
}

int n = 8;
int[] arr = new int[n];
FillArray(arr);
PrintArray(arr);

