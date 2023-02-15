
int[,] Arr2d()
{
    System.Console.WriteLine("Введите кол=во строк: M и кол-во строк: N, а так же диапазон значений [Lrange; Rrange]");
    int row = Convert.ToInt32(Console.ReadLine());
    int col = Convert.ToInt32(Console.ReadLine());
    int Lrange = Convert.ToInt32(Console.ReadLine());
    int Rrange = Convert.ToInt32(Console.ReadLine());
    Random rand = new Random();
    int[,] matrix = new int[row, col];
    System.Console.WriteLine();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = rand.Next(Lrange, Rrange + 1);
        }
    }
    System.Console.WriteLine();
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}
void Xcol(int[,] matrix)
{
        for (int j = 0; j < matrix.GetLength(1); j++)
    {double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        System.Console.Write($"{sum / matrix.GetLength(0)} ");
    }
}int[,] array = Arr2d();
PrintMatrix(array);
Xcol(array);

