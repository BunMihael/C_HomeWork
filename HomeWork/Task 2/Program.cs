// Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Write namber A: ");
int numberA = int.Parse(Console.ReadLine());

Console.Write("Write namber B: ");
int numberB = int.Parse(Console.ReadLine());
int max = 0;

if (numberA > numberB) max = numberA;
else if (numberA < numberB) max = numberB;
else if (numberB == numberA) max = numberB = numberA;
Console.WriteLine(max);
