// Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Please write a three digit number and we will show a middle number.");
Console.Write("Write three digit number here: ");
int number = int.Parse(Console.ReadLine());
int MidNum = 0;

if (number > 999)
{
    Console.WriteLine($"The number {number} is not a three digit number. ");
}
else if (number < 100)
{
    Console.WriteLine($"The number {number} is not a three digit number. ");
}
else
{
    MidNum = number % 100;
    MidNum = MidNum / 10;
    Console.WriteLine($"The number {MidNum} is the second number of {number}. ");
}

// int NumSec(int num)
// {
//    return num / 10 %  10  
// }
// Console.WriteLine(NumSec(918))