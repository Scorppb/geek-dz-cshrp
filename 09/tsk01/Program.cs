// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.


int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void FindPositiveDigits(int min, int max)
{
    if (min > max) return;
    if (min % 2 == 0) System.Console.Write($"{min} ");
    FindPositiveDigits(min + 1, max);
}

int min = Prompt("Введите минимальное число> ");
int max = Prompt("Введите максимальное число> ");
if (min > max)
{
    System.Console.WriteLine("Введите корректные данные");
    return;
}
FindPositiveDigits(min, max);