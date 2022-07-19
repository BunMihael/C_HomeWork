// Напишите программу, которая выводит случайное трёхзначное число
// и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int a = new Random().Next(100, 1000);
int prt1 = 0;
int prt2 = 0;

prt1 = a / 100;
prt2 = a % 10;

Console.WriteLine($"Number {a} without middle number is looking like this: {prt1}{prt2} ");

// void.NumRendom()
//{
//    int num = new.Random().Next(100,1000);
//    Console.WriteLine($"{num} -> {num/ 100}{num% 10}");
//}
// NumRendom();


//// void.NumRendom()
//{
//    int num = new.Random().Next(100,1000);
//    Console.Write($"{num} -> {num/ 100 *10 + num % 10}");
//}
// NumRendom();