// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутк


int Prompt(string massage)
{
    System.Console.Write(massage);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}


int FindSum(int m, int n)
{
    return m > n ? 0 : FindSum(m + 1, n) + m;
}

int sum = FindSum(Prompt("Введите число M > "), Prompt("Введите число N > "));
System.Console.WriteLine($"Cумма элементов в промежутке от M до N равна {sum}");