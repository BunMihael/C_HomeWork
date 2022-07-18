// Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Please write a three digit number and we will show a middle number.");
Console.Write("Write three digit number here: ");
int number = int.Parse(Console.ReadLine());
int MidNum = 0;

MidNum = number % 100;
MidNum = LastNumb / 10;
Console.WriteLine($"The number {MidNum} is the last number of {number}. ");