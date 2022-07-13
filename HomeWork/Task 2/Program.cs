// Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Enter 2 numbers and we'll tell you which one is bigger.");
Console.Write("Write namber A: ");
int numberA = int.Parse(Console.ReadLine());

Console.Write("Write namber B: ");
int numberB = int.Parse(Console.ReadLine());
int max = 0;
int min = 0;

if (numberA > numberB) 
{
    max = numberA; min = numberB;
    Console.WriteLine($"The number {max} is bigger than the {min}");
}
else if (numberA < numberB) 
{
    max = numberB; min = numberA;
    Console.WriteLine($"The number {max} is bigger than the {min}");
}
else
{
    Console.WriteLine($"Both numbers {max} and {min} are equal");
}


