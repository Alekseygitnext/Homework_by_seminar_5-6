// Написать программу копирования массива

//Программа копирования  одномероного массива

// int[] array = new int[10];
// int arrayCopy;

// Console.Write("Оригинал ");
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0, 50);
//     Console.Write(array[i] + " ");
// }
// Console.WriteLine();
// array[2] = 15; // для проверки
// Console.Write("   Копия ");
// for (int i = 0; i < array.Length; i++)
// {
//     arrayCopy = array[i];
//     Console.Write(arrayCopy + " ");
// }



//Программа копирования  двумерного масива

Console.WriteLine("Введите колличество строк массива m : ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите колличество столбцов массива n : ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[,]  matrix = new int[m,n];
Console.WriteLine("Оригинал " + " ");
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(1,10);
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
// matrix[0,0]=7; //для проверки копирования запустить эту строку
Console.WriteLine("Копия ");
int[,] matrixCopy = (int[,]) matrix.Clone();
for (int i = 0; i < matrixCopy.GetLength(0); i++)
{ 
    for (int j = 0; j < matrixCopy.GetLength(1); j++)
    {
        Console.Write("{0} ", matrixCopy[i, j]);
    }
    Console.WriteLine();
}    