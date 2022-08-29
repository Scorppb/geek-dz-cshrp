// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


int Prompt(string massage)
{
    System.Console.Write(massage);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

double CalculationX(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}
double CalculationY(double k1, double b1, double x)
{
    double y = k1 * x + b1;
    return y;
}

int k1 = Prompt("Введите коофициент k1> ");
int b1 = Prompt("Введите коофициент b1> ");
int k2 = Prompt("Введите коофициент k2> ");
int b2 = Prompt("Введите коофициент b2> ");
if (b1 == b2 && k1 == k2)
{
    System.Console.WriteLine("Прямые совпадают");
}
else if (k1 == k2)
{
    System.Console.WriteLine("Прямые параллельны");
}
else
{
    double x = CalculationX(k1, b1, k2, b2);
    double y = CalculationY(k1,b1, x);
    System.Console.WriteLine($"Координаты точки пересечения ({x:f2}:{y:f2})");
}