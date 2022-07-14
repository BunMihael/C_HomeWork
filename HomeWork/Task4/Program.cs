// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Enter 3 numbers and we'll tell you which one is bigger.");
Console.Write("Write namber A: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Write namber B: ");
int numberB = int.Parse(Console.ReadLine());
Console.Write("Write namber C: ");
int numberC = int.Parse(Console.ReadLine());
int max = 0;
int equal = 0;

if (numberA >= numberB) max = numberA;
if (numberA <= numberB) max = numberB;
else if (numberC > max) max = numberC;
{
    Console.WriteLine($"The bigger number is {max}");
}

if (max == numberC) equal = max;
 {
        Console.WriteLine($"All numbers are equal to {equal}");
 }