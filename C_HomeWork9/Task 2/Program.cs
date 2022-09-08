// Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int NumbersRec(int a, int b)
{
    if (a >= b) return a;
    else return a + NumbersRec(a + 1, b);
}

Console.WriteLine(NumbersRec(1, 15));
Console.WriteLine(NumbersRec(4, 8));

