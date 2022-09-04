// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

int Prompt(string massage)
{
    System.Console.Write(massage);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}


int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0 && m > 0) return Akkerman(m - 1, 1);
    return Akkerman(m - 1, Akkerman(m, n - 1));
}

int m = Prompt("Введите неотрицательное число M > ");
int n = Prompt("Введите неотрицательное число N > ");
if (m < 0 || n < 0)
{
    System.Console.WriteLine("Введите неотрицательных числа");
    return;
}
System.Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {Akkerman(m, n)}");