// Функция, на вход получает параметр, на выходе введженнео с консоли значение
int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  // Считавает с консоли строку
    int result = int.Parse(readValue);      // Преобрадует строку в целое число
    return result;                          // Возвращает результат
}

// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> Четное

int numA = Prompt("Введите число > ");
if (numA % 2  == 0)
{
    System.Console.WriteLine($"Число {numA} - чётное");
}
else
{
    System.Console.WriteLine($"Число {numA} - нечётное");
}