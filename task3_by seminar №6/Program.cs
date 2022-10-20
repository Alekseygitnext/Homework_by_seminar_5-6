// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадрат

void FillArray(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            array[m, n] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            Console.Write($"{array[m, n]} ");
        }
        Console.WriteLine();
    }
}
void Replace(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            if ((m % 2 == 0) && (n % 2 == 0))
            {
                array[m, n] = array[m, n] * array[m, n];
            }
        }
    }
}
    
Console.Write("Введите число m :  ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();
Console.Write("Введите число n :  ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();
int[,] array = new int[m, n];
FillArray(array);
Console.WriteLine("Оригинал массива :  ");
PrintArray(array);
Console.WriteLine();
Replace(array);
Console.WriteLine("Массив с заменёнными элементами :  ");
PrintArray(array);