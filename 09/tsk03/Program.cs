// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Prompt(string massage)
{
    System.Console.Write(massage);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}


int Akkerman (int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return Akkerman(m - 1, 1);
    return Akkerman(m - 1, Akkerman(m, n - 1));
}

int number = Akkerman(Prompt("Введите неотрицательное число M > "), Prompt("Введите неотрицательное число N > "));
System.Console.WriteLine(number);