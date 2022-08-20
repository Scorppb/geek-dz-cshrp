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
        array[i] = new Random().NextDouble()*100;
    }
    return array;
}

void printArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(Math.Round(array[i],1) + " ");
    }
}
int lenghtArray = Prompt("Введите длинну массива> ");
double[] array = genArray(lenghtArray);
printArray(array);

