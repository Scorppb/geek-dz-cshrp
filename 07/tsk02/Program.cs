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
    System.Console.WriteLine();
}


int line = Prompt("Введите количество строк> ");
int columns = Prompt("Введите количество столбцов> ");
int min = Prompt("Ведите минимальное допустимое значение> ");
int max = Prompt("Ведите максимальное допустимое значение> ");
int[,] matrix = GenMatrix(line, columns, min, max);
PrintMatrix(matrix);
int posLine = Prompt("Ведите строку для нахожденя элемента> ");
int posСolumn = Prompt("Ведите столбец для нахожденя элемента> ");
if (posLine < 0 | posLine - 1 > line | posСolumn < 0 | posСolumn - 1 > columns)
{
    Console.WriteLine("Элемент не существует");
}
else
{
    Console.WriteLine($"Значение элемента [{posLine},{posСolumn}] массива = {matrix[posLine - 1, posСolumn - 1]}");
}
