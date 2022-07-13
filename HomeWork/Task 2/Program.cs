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

if (numberA > numberB) 
{
    Console.WriteLine($"The number {numberA} is bigger than the {numberB}");
}
else if (numberA < numberB) 
{
    Console.WriteLine($"The number {numberB} is bigger than the {numberA}");
}
else
{
    Console.WriteLine($"Both numbers {numberA} and {numberB} are equal");
}


