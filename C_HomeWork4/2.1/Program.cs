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

/*
double DigitSum(int num)
{
    string n = num.ToString();
    int length = n.Length;
    double sum = 0;

    for(int i = 0; i < length; i++)
    {
        double m = char.GetNumericValue(n[i]);
        sum += m;
    }

    return sum;
}

int n = 123;

Console.WriteLine(DigitSum(n));


int SumNum(int num)
{
    int n_sum = 0;

    for(int i = num; num != 0; num /= 10)
    n_sum += num% 10;
    return n_sum;
}
Console.WriteLine(SumNum(456));
*/