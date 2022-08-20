// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным 
// элементов массива.
// [3 7.3 22.2 2 78] -> 76


int Prompt(string massage)
{
    System.Console.Write(massage);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

double[] genArray(int length)
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().NextDouble() * 100;
    }
    return array;
}

void printArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(Math.Round(array[i], 1) + " ");
    }
}

double findMax(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
    }
    return max;
}

double findMin(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i]) min = array[i];
    }
    return min;
}


int lenghtArray = Prompt("Введите длинну массива> ");
double[] array = genArray(lenghtArray);
printArray(array);
findMax(array);
findMin(array);
System.Console.WriteLine($"\nРазницу между максимальным и минимальным элементов массива {Math.Round((findMax(array))-(findMin(array)),1)}");

