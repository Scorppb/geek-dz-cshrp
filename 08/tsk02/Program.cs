// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int Prompt(string massage)
{
    System.Console.Write(massage);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int[,] FillMatrix(int line, int columns)
{
    int[,] matrix = new int[line, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 9);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int FindRowBySum(int[,] matrix)
{
    int indexRow = 0;
    int minRowSum = int.MaxValue;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int rowSum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            rowSum += matrix[i, j];
        }
        if (rowSum < minRowSum)
        {
            minRowSum = rowSum;
            indexRow = i + 1;
        }
    }
    return indexRow;
}


int rows = Prompt("Введите количество строк> ");
int columns = Prompt("Введите количество столбцов> ");
if (rows <= 0 || columns <= 0) System.Console.WriteLine("Введите число больше 0");
else
{
    int[,] matrix = FillMatrix(rows, columns);
    PrintMatrix(matrix);
    System.Console.WriteLine($" ");
    int indexRow = FindRowBySum(matrix);
    System.Console.WriteLine($"Cтрока с наименьшей суммой элементов под номером: {indexRow}");
}