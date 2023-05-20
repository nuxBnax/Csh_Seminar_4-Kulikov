// Задача 27: 

// Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("Enter ANY number");
int num = Convert.ToInt32(Console.ReadLine());

int result = 0;
int sum = num;
int n = 1;

while ((num / n) > 0)
{
    sum = ((num % (n * 10)) - (num % n)) / n;
    result += sum;
    n *= 10;
}

Console.WriteLine(result);