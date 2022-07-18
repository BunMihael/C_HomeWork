// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Первый вариант решения
//Console.WriteLine("Введите номер дня недели и мы скажем выходной ли он: ");
//int a = int.Parse(Console.ReadLine());

//if (a == 1)
//    Console.WriteLine("Понедельник не выходной");
//else if (a == 2)
//    Console.WriteLine("Вторник не выходной ");
//else if (a == 3)
//    Console.WriteLine("Среда не выходной ");
//else if (a == 4)
//    Console.WriteLine("Четверг не выходной ");
//else if (a == 5)
//    Console.WriteLine("Пятница не выходной ");
//else if (a == 6)
//    Console.WriteLine("Суббота выходной день");
//else if (a == 7)
//    Console.WriteLine("Воскресенье выходной день");

//else
//    Console.WriteLine("Такого дня не найдено!");


// Второй вариант решения

void Checking (int N)
{
    if (N > 5)
    Console.WriteLine("Выходной день");
    else
    Console.WriteLine("Будний день");
}
Console.Write("Введите номер дня недели и мы скажем выходной ли он: ");
int n = int.Parse(Console.ReadLine());

Checking(n);
