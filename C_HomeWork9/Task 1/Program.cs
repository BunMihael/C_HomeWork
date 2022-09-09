//  Задайте значения M и N. Напишите программу, которая выведет все 
// чётные натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""2, 4""
// M = 4; N = 8. -> ""4, 6, 8""

string EvenNaturalNumbers(int M, int N)
{
    if (M > N) return String.Empty;
    else if (M % 2 != 1) return $"{M} " + EvenNaturalNumbers(M + 2, N);
    else return EvenNaturalNumbers(M + 1, N);
}
Console.WriteLine(EvenNaturalNumbers(2, 5));
Console.WriteLine(EvenNaturalNumbers(4, 8));

// void AllEvenNumers(int M, int N)
// {
// if (M > N) return;
// if (M % 2 == 1) M += 1;

// Console.Write($"{M}, ");
// AllEvenNumers(M + 2, N);    
// }

// AllEvenNumers(1, 5);
// Console.WriteLine();
// AllEvenNumers(4, 8);