// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 
// 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Prompt(string massage)
{
    System.Console.Write(massage);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int[] InputArray(int number)
{
    int[] array = new int[number];
    for (int i = 0; i < number; i++)
    {
        System.Console.Write("Введите число> ");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

int CountPositiveDigits(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

int volue = Prompt("Ведите количество чисел, которое хотите ввести> ");
if (volue > 0)
{
    int[] array = InputArray(volue);
    PrintArray(array);

    System.Console.WriteLine($"Количество чисел больше 0 равняется {CountPositiveDigits(array)}");
}
else
{
    System.Console.WriteLine("Количество чисел не должно быть отрицательным или равным 0");
}
