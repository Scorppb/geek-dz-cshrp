// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int Prompt(string massage)
{
    System.Console.Write(massage);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int[] genArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
    return array;
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}

int sumUnfairPositionArray(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i +=2)
    {
        sum += array[i];
    }
    return sum;
}

int lenghtArray = Prompt("Введите длинну массива> ");
int[] array = genArray(lenghtArray);
printArray(array);
System.Console.WriteLine($"\nCумма элементов, стоящих на нечётных позициях равна {sumUnfairPositionArray(array)}");