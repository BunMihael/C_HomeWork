// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49


void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j],3} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;
}

void ArithmeticMean(int[,] array1, int[,] array2)
{
    int row = array1.GetLength(0);
    int column = array2.GetLength(1);

    for (int i = 0; i < column; i++)
    {
        for (int j = 0; j < row; j++)
        {
            Console.Write($"{array1[i,j] = array1[i, j] * array2[i, j], 5}");
        }
        Console.WriteLine();
        

    }

}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column, 1, 6);
Print(arr_1);
int[,] arr_2 = MassNums(row, column, 1, 6);
Print(arr_2);
ArithmeticMean(arr_1,arr_2);


// int[,] MatrixProduct(int[,] arr_first, int[,] arr_second)
// {
//     int row_size = arr_first.GetLength(0);
//     int column_size = arr_first.GetLength(1);
//     int[,] pr_matrix = new int[row_size, column_size];

//     if(column_size != arr_second.GetLength(0)) return pr_matrix;
//     else if(column_size == arr_second.GetLength(0))
//         pr_matrix = new int[row_size, column_size];
    
//     for(int i = 0; i < row_size; i++)
//     {
//         for(int j = 0; j < row_size; j++)
//         {
//             for(int p = 0; p < column_size; p++)
//                 pr_matrix[i,j] += arr_first[i,p] *arr_second[p,j];
//         }
//     }
//     return pr_matrix;
// }
