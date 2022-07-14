// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4, 
// 8 -> 2, 4, 6, 8

Console.Write("Please enter a single digit number: ");
int num = int.Parse(Console.ReadLine());
int i = 2;

while (i <= num)
{
    Console.WriteLine($"{i}");
    i += 2;
}