// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


int Prompt(string massage)
{
    System.Console.Write(massage);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int[,] GenMatrix(int rows, int columns, int min = -10, int max = 10)
{
    int[,] matrix = new int[rows, columns];
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
    System.Console.WriteLine();
}

void Main(int rows, int columns, int positionRows, int positionСolumns, int[,] matrix)
{
    if (positionRows <= 0 |
           positionRows - 1 > rows |
           positionСolumns <= 0 |
           positionСolumns - 1 > columns)
    {
        Console.WriteLine("Элемент не существует");
    }
    else
    {
        Console.WriteLine($"Значение элемента [{positionRows},{positionСolumns}] массива = {matrix[positionRows - 1, positionСolumns - 1]}");
    }
}

int rows = Prompt("Введите количество строк> ");
int columns = Prompt("Введите количество столбцов> ");
if (rows <= 0 || columns <= 0) System.Console.WriteLine("Введите число больше 0");
else
{
    int min = Prompt("Ведите минимальное допустимое значение> ");
    int max = Prompt("Ведите максимальное допустимое значение> ");
    int[,] matrix = GenMatrix(rows, columns, min, max);
    PrintMatrix(matrix);
    int positionRows = Prompt("Ведите строку для нахожденя элемента> ");
    int positionСolumns = Prompt("Ведите столбец для нахожденя элемента> ");
    Main(rows, columns, positionRows, positionСolumns, matrix);
}

