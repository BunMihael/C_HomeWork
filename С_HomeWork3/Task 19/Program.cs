// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

//Console.WriteLine("Введите пятизначное число и мы скажем полиндром ли оно: ");
//string num = Console.ReadLine();
//if (num!.Length == 5)
//{
//    string rev = string.Concat(num.Reverse());
//    Console.WriteLine(num == rev ? "Число палиндром" : "Число не палиндром");
//}
//else Console.WriteLine($"Вы ввели не пятизначное число");

void Polindrom(int n)
{
    int i = 0;
    string num = n.ToString();
    int size = num.Length - 1;
    string flag = "yes";

    while(i<size/2)
    {
        if(num[i] != num[size - i])
        {
            flag = "no";
            break;
        }
        i += 1;
    }
    Console.WriteLine($"{n} -> {flag}");
}

Polindrom(12488421);
Polindrom(23432);
Polindrom(14212);
