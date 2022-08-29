// Найдите максимальное значение в матрице по каждой строке, ссумируйте их. Затем найдети 
// минимальное значение по каждой колонке, тоже ссумируйте их. 
// Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)

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

int FindMaxAndSumInLine(int[,] matrix)
{
    int sumMax = 0;
    int maxIndex = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == 0 || maxIndex < matrix[i, j]) maxIndex = matrix[i, j];
        }
        sumMax = sumMax + maxIndex;
    }
    Console.WriteLine($"Сумма максимумов строк = {sumMax}");
    return sumMax;
}

int FindMinAndSumInColumns(int[,] matrix)
{
    int sumMin = 0;
    int minIndex = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (i == 0 || minIndex > matrix[i, j]) minIndex = matrix[i, j];
        }
        sumMin = sumMin + minIndex;
    }
    Console.WriteLine($"Сумма минимумов столбцов = {sumMin}");
    return sumMin;
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
    System.Console.WriteLine();
    int difference = FindMaxAndSumInLine(matrix) - FindMinAndSumInColumns(matrix);
    System.Console.WriteLine($"Разница сумм = {difference}");
}