/* Напишите программу, которая на вход принимает число, 
возвращает индексы этого элемента в двумерном массиве или же указание, что такого числа нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */
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
string Index(int[,] array2d)
{
    System.Console.WriteLine("Введите целое число которое вы хотите найти.");
    int Num = Convert.ToInt32(Console.ReadLine());
    string result = string.Empty;
    int count = 0;
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            if (Num == array2d[i, j])
            {
                result += $"[{Convert.ToString(i)};{Convert.ToString(j)}]";
                count++;
            }
        }
    }
    if (count == 0)
    {
        result = "ТАКОГО ЧИСЛА В МАССИВЕ НЕТ, ПОПРОБУЙТЕ СНОВА!";
    }
    return result;
}
int[,] array = Arr2d();
PrintMatrix(array);
string str = Index(array);
System.Console.WriteLine($"Индекс искомого числа: {str}");