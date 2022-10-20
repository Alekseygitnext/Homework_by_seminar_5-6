// Показать двухмерный массив размером m*n заполненный вещественными числами

Console.WriteLine("введите количество строк");
int rows = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("введите количество столбцов");
int columns = int.Parse(Console.ReadLine() ?? "0");
double[,] numbers = new double[rows, columns];

void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-1000, 1000)) /100;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "  ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
FillArrayRandomNumbers(numbers);
PrintArray(numbers);