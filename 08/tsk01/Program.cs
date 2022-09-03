// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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

int[,] BubbleSortRows(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int k = 0; k < matrix.GetLength(1) - 1; k++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1 - k; j++)
            {
                if (matrix[i, j] < matrix[i, j + 1])
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, j + 1];
                    matrix[i, j + 1] = temp;
                }
            }
        }
    }
    return matrix;
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
    System.Console.WriteLine("В итоге получается вот такой массив: ");
    int[,] newMatrix = BubbleSortRows(matrix);
    PrintMatrix(newMatrix);
}