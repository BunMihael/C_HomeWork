// Напишите программу, которая принимает на вход трёхзначное число и
// на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Please write a three digit number and we will show a last number.");
Console.Write("Write three digit number here: ");
int number = int.Parse(Console.ReadLine());
int LastNumb = 0;

LastNumb = number % 10;
Console.WriteLine($"The number {LastNumb} is the last number of {number}. ");