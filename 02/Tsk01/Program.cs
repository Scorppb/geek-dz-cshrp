// Функция, на вход получает параметр, на выходе введженнео с консоли значение
int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  // Считавает с консоли строку
    int result = int.Parse(readValue);      // Преобрадует строку в целое число
    return result;                          // Возвращает результат
}

//Напишите программу, которая принимает на вход трёхзначное число и на выходе 
//показывает вторую цифру этого числа.

void RemoveAndPrintMiddleDigit(int value)
{

    if (value >= 100 && value <= 999)
    {
        int result = value / 10 % 10;
        System.Console.WriteLine($"Вторая цифра числа {value} это {result}");
    }
    else
    {
        System.Console.WriteLine($"Число {value} не является трёхзначным");
    }
}

int num = Prompt("Введите трёхзначное число > ");
RemoveAndPrintMiddleDigit(num);