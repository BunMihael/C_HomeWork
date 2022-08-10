/* Задача 27: Напишите программу, которая принимает на вход число
 и выдаёт сумму цифр в числе.
 452 -> 11
 82 -> 10
 9012 -> 12
*/

void Sum(int a)
{
    int result = 0;
    Console.Write($"{a} -> ");

    while (a > 0)
    {
        result += a % 10;
        a = a / 10;
    }
    Console.Write(result);
    Console.WriteLine();
}
Sum (452);
Sum(82);
Sum(9012);