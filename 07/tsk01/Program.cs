// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


int Prompt(string massage)
{
    System.Console.Write(massage);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

double[,] GenMatrix(int line, int columns)
{
    double[,] matrix = new double[line, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-100, 100) * 0.1;
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{Math.Round(matrix[i, j], 1)}\t");
        }
        System.Console.WriteLine();
    }
}

int line = Prompt("Введите количество строк> ");
int columns = Prompt("Введите количество столбцов> ");
if (line <= 0 || columns <= 0) System.Console.WriteLine("Введите число больше 0");
else
{
    PrintMatrix(GenMatrix(line, columns));
}