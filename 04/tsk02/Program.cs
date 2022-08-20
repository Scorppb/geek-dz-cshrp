// Функция, на вход получает параметр, на выходе введженнео с консоли значение
int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  // Считавает с консоли строку
    int result = int.Parse(readValue);      // Преобрадует строку в целое число
    return result;                          // Возвращает результат
}

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumDigitOfNumber(int number)
{
    int result = 0;
    for (int i = 0; number > 0; i++)
    {
        result = result + number % 10;
        number = number / 10;
    }
    return result;
}

int number = Prompt("Введите число> ");
if (number >= 0)
{
    System.Console.WriteLine($"Сумма цифр в числе {number} равна {SumDigitOfNumber(number)}");
}
else
{
    int numberOpposite = number * (-1);
    System.Console.WriteLine($"Сумма цифр в числе {number} равна {SumDigitOfNumber(numberOpposite)}");
}

