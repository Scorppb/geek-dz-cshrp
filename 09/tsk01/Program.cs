// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.


int Prompt(string massage)
{
    System.Console.Write(massage);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}


void FindPositiveDigits(int m, int n)
{
    if (m > n) return;
    if (m % 2 == 0) System.Console.Write($"{m} ");
    FindPositiveDigits(m + 1, n);
}

int m = Prompt("Введите первое число> "); 
int n = Prompt("Введите второе число> ");
System.Console.WriteLine($"{FindPositiveDigits(m,n)}");