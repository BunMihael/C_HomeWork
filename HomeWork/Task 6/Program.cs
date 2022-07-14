// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Please write a number and we will answer if it is even.");
Console.Write("Write whole number: ");
int number = int.Parse(Console.ReadLine());

if (number % 2 != 1)
{
    Console.WriteLine($"The number {number} is an even number. ");
}
else 
{
    
    Console.WriteLine($"The number {number} an odd number. ");
}