// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутк


int Prompt(string massage)
{
    System.Console.Write(massage);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}


int FindSum(int min, int max)
{
    return min > max ? 0 : FindSum(min + 1, max) + min;
}

int min = Prompt("Введите минимальное число> ");
int max = Prompt("Введите максимальное число> ");
if (min > max)
{
    System.Console.WriteLine("Введите корректные данные");
    return;
}
int sum = FindSum(min, max);
System.Console.WriteLine($"Cумма элементов в промежутке от M до N равна {sum}");


