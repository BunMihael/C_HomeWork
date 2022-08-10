/* Задача 29: Напишите программу, которая задаёт массив из
8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/




void PrintArray(int[] arr)
{
    int count = arr.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] EightMass()
{
    int count = 8;
    int[] arr = new int[count];
    for (int i = 0; i < count; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
    return arr;
}
int[] arr_1 = EightMass();
PrintArray(arr_1);
int[] arr_2 = EightMass();
PrintArray(arr_2);