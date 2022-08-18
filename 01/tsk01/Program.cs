// Функция, на вход получает параметр, на выходе введженнео с консоли значение
int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  // Считавает с консоли строку
    int result = int.Parse(readValue);      // Преобрадует строку в целое число
    return result;                          // Возвращает результат
}

//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7, min = 5

int numA = Prompt("Введите первое число > ");
int numB = Prompt("Введите второе число > ");
if (numA > numB)
{
    System.Console.WriteLine($"max = {numA}, min = {numB}");
}
else
{
    System.Console.WriteLine($"max = {numB}, min = {numA}");
}