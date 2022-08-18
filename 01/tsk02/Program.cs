// Функция, на вход получает параметр, на выходе введженнео с консоли значение
int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  // Считавает с консоли строку
    int result = int.Parse(readValue);      // Преобрадует строку в целое число
    return result;                          // Возвращает результат
}

// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7

int numA = Prompt("Введите первое число > ");
int numB = Prompt("Введите второе число > ");
int numC = Prompt("Введите третье число > ");
int max = numA;
if (numB > numA) max = numB;
if (numC > numB) max = numC;
System.Console.WriteLine($"Максимальное число = {max}");