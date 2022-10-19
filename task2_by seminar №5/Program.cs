// //Написать программу масштабирования фигуры
// Для того чтобы фигура не смещалась при масшабировании, одна из её вершин должна иметь координаты (0,0)

double[] array_mach(string[] num, double k)
{
    double[] mas = new double[num.Length];
    for (int i = 0; i < num.Length; i++)
        {
        mas[i] = (double.Parse(num[i])) * k;
        }
    return mas;
}

void PrintMatrix(double[] massiv)
{
    for (int i = 0; i < massiv.Length; i=i+2)
    {
        Console.Write($"({massiv[i]}, {massiv[i+1]})  ");
    }
}

Console.Write("Введите координаты вершин фигуры через запятую x1,y1,x2,y2 и так далее: ");
string[] num = (Console.ReadLine() ?? "0").Split(',');
Console.Write("Введите коэфициент масштабирования: ");
double k = double.Parse(Console.ReadLine() ?? "0");
Console.Write("Каординаты после масштабирования: ");
double[] Skaled_koor = array_mach(num, k);
PrintMatrix(Skaled_koor);