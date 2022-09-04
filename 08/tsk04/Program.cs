// Со звездочкой (*) Напишите программу, которая заполнит спирально квадратный массив.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int Prompt(string massage)
{
    System.Console.Write(massage);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int[,] CreateSquareArray(int number)
{
    int[,] matrix = new int[number, number];
    int matrixMount = number * number;
    int row = 1;
    int column = 1;
    int count = 1;

    for (int i = 0; i < number; i++)
    {
        matrix[0, i] = count;
        count++;
    }
    for (int i = 1; i < number; i++)
    {
        matrix[i, number - 1] = count;
        count++;
    }
    for (int i = number - 2; i >= 0; i--)
    {
        matrix[number - 1, i] = count;
        count++;
    }
    for (int i = number - 2; i > 0; i--)
    {
        matrix[i, 0] = count;
        count++;
        if (count == matrixMount)
        {
            matrix[row, column] = count;
        }
    }

    while (count < matrixMount)
    {
        while (matrix[row, column + 1] == 0)
        {
            matrix[row, column] = count;
            count++;
            column++;
        }

        while (matrix[row + 1, column] == 0)
        {
            matrix[row, column] = count;
            count++;
            row++;
        }

        while (matrix[row, column - 1] == 0)
        {
            matrix[row, column] = count;
            count++;
            column--;
        }

        while (matrix[row - 1, column] == 0)
        {
            matrix[row, column] = count;
            count++;
            row--;
        }
        if (count == matrixMount)
        {
            matrix[row, column] = count;
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


int nummer = Prompt("Введите количество строк и столбцов> ");
int[,] matrix = CreateSquareArray(nummer);
PrintMatrix(matrix);

