//  Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

Console.WriteLine("We will find the intersection point of two stright lines");
Console.WriteLine("Please, enter number for pont b1; ");
int b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Please, enter number for pont k1; ");
int k1 = int.Parse(Console.ReadLine());
Console.WriteLine("Please, enter number for pont b2; ");
int b2 = int.Parse(Console.ReadLine());
Console.WriteLine("Please, enter number for pont k2; ");
int k2 = int.Parse(Console.ReadLine());

int x = (b2 - b1) / (k1 - k2);

Console.WriteLine($"{x};{k1 * x + b1}");


