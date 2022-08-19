/* Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 26
[-4, -6, 89, 6] -> 0
*/

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] GenerateNumbers(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(10, 100);
    }
    return arr;
}

int SumOfElements(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 1)
        {
            count += arr[i];
        }

    }
    return count;
}

int[] arr_1 = GenerateNumbers(4);
Print(arr_1);
Console.WriteLine(SumOfElements(arr_1));