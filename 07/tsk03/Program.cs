// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в 
// каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int Prompt(string massage)
{
    System.Console.Write(massage);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int[,] GenMatrix(int line, int columns, int min, int max)
{
    int[,] matrix = new int[line, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max);
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

void FindAverage(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        double average = sum / matrix.GetLength(0);
        Console.Write($"{Math.Round(average, 2)}\t");
    }
}

int line = Prompt("Введите количество строк> ");
int columns = Prompt("Введите количество столбцов> ");
if (line <= 0 || columns <= 0) System.Console.WriteLine("Введите число больше 0");
else
{
    int min = Prompt("Ведите минимальное допустимое значение> ");
    int max = Prompt("Ведите максимальное допустимое значение> ");
    int[,] matrix = GenMatrix(line, columns, min, max);
    PrintMatrix(matrix);
    Console.WriteLine($"Количество столбцов: {matrix.GetLength(0)}, среднее арифметическое элементов: ");
    FindAverage(matrix);
}