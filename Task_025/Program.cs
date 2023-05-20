// Задача 25: 
// Напишите цикл, который принимает на вход два 
// числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


void Main()
{
    int numA = ReadInt("Insert number A: ");
    int numB = ReadInt("Insert number B: ");
    Console.WriteLine(numA + " ^ " + numB + " = " + PoweredNumber(numA, numB));
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int PoweredNumber(int A, int B)
{
  int mult = 1;
  int counter = 1;
  while (counter <= B)
  {
    mult = mult * A;
    counter++;
  }
  return mult;
}

Main();

// System.Console.WriteLine("Enter number A:");
// int numA = Convert.ToInt32(System.Console.ReadLine());

// System.Console.WriteLine("Enter number B:");
// int numB = Convert.ToInt32(System.Console.ReadLine());

// int counter = 1;
// int mult = 1;

// while (counter <= numB)
// {
//   mult = mult * numA;
//   counter++;
// }

// Console.WriteLine(numA + " ^ " + numB + " = " + mult);
