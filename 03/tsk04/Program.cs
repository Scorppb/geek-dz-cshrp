// Функция, на вход получает параметр, на выходе введженнео с консоли значение
int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  // Считавает с консоли строку
    int result = int.Parse(readValue);      // Преобрадует строку в целое число
    return result;                          // Возвращает результат
}

// сортировка массива вставками

int[] InsertionSort(int[] array)
{
    int[] result = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        int j = i;
        while (j > 0 && result[j - 1] > array[i])
        {
            result[j] = result[j - 1];
            j--;
        }
        result[j] = array[i];
    }
    return result;
}


int[] arrayFill(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 101);
    }
    return array;
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + "\t");
    }
}

int num = Prompt("Введите число - длинну массива> ");
int[] result = arrayFill(num);
printArray(result);
System.Console.WriteLine(" ");
printArray(InsertionSort(result));