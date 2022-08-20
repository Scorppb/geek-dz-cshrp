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
        int temp = number % 10;
        number = number / 10;
        result = result + temp;
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
    int numberMinus=number*(-1);
    System.Console.WriteLine($"Сумма цифр в числе {number} равна {SumDigitOfNumber(numberMinus)}");
}

