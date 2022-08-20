// Функция, на вход получает параметр, на выходе введженнео с консоли значение
int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  // Считавает с консоли строку
    int result = int.Parse(readValue);      // Преобрадует строку в целое число
    return result;                          // Возвращает результат
}

// Напишите программу, которая задаёт массив из 8 элементов, выводит их на экран. 
// И ищет второй максимум (элемент меньше максимального, но больше всех остальных)
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33], 19

int[] genArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(0, 101);
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

int findSecondMax(int[] array)
{
    int max1 = 0;
    int max2 = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max1)
        {
            max2 = max1;
            max1 = array[i];
        }
        else
        {
            if (array[i] != max1 && array[i] > max2)
            {
                max2 = array[i];
            }
        }
    }
    return max2;
}

int lenghtArray = Prompt("Введите длинну массива> ");
int[] array = genArray(lenghtArray);
printArray(array);
System.Console.WriteLine($"\nВторой максимум равен {findSecondMax(array)}");