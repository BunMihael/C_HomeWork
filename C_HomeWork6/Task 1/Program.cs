// Пользователь вводит с клавиатуры M чисел. Посчитайте,
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

/*
Console.Write("Введите элементы(через пробел): ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
 
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Кол-во элементов > 0: {count}");
*/

int CountNum()
{
    int count = 0;
    string word;
    
    while(true)
    {
        Console.Write( "Output any number:  ");
        word = Console.ReadLine();

        if (word == "") return count;
        else if (int.Parse(word) > 0) count +=1;
    }
}
Console.Write(CountNum());


/*
int Check(int num)
{
    int count = 0;
    for (int i = 1; i <= num; i++)
    {
        Console.Write($"Число {i}: ");
        int a = int.Parse(Console.ReadLine());
        if (a > 0) count++;
    }
    return count;
}
Console.Write("Сколько чисел хотели бы Вы ввести?")
int a = int.Parse(Console.ReadLine());
Console.WriteLine($"Колличество чисел больше 0: {Check(a)}");
*/