// Задача 25: Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.

void NaturDegree(int a, int b)
{
    int nums = 1;
    for (int i = 1; i <= b; i++)
    { 
        nums = nums * a;
    }
    Console.WriteLine($"{a} в натуральной степени {b} = {nums}");
}
NaturDegree(3, 5);
NaturDegree(2, 4);