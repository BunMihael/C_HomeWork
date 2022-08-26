/* Задача 50. Напишите программу, которая на вход принимает позиции элемента
в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> такого числа в массиве нет
*/


void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);
    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            Console.Write($" {arr[i, j]} \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = new Random().Next(from, to);
        }
    }
    return arr;

}

string FirstExposition(int[,] arr, int pos1, int pos2)
{
    int element = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (arr.GetLength(0) < pos1)
        {
            return "Invalid row number.";
        }
        else
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr.GetLength(1) < pos2)
                    return "Invalid column number.";
                else
                    return $" Positions: {pos1} , {pos2} have element: {arr[pos1-1,pos2-1]}.";
            }
        }
    }
    return "No";
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column, 1, 19);
Print(arr_1);
Console.WriteLine(FirstExposition(arr_1, 1, 7));
