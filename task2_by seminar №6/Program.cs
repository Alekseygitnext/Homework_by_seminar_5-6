//  Задать двумерный массив следующим правилом: Aₘₙ = m+n

void FillMatrix(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            array[m, n] = m + n;
        }
    }
}
void PrintMatrix(int[,] array)
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
Console.Write("Введите число m :  ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число n :  ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();
int[,] array = new int[m, n];

FillMatrix(array);
PrintMatrix(array);

