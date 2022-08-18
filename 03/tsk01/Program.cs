// Функция, на вход получает параметр, на выходе введженнео с консоли значение
int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  // Считавает с консоли строку
    int result = int.Parse(readValue);      // Преобрадует строку в целое число
    return result;                          // Возвращает результат
}

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void CheckingNumber(int number)
{
    int number1 = number / 10000;
    number = number % 10000;
    int number2 = number / 1000;
    number = number % 1000;
    number = number % 100;
    int number4 = number / 10;
    number = number % 10;
    
    if (number1 == number && number2 == number4)
    {
        Console.WriteLine($"Ваше число - палиндром.");
    }
    else Console.WriteLine($"Ваше число - не палиндром.");
}

int number = Prompt("Введите пятизначное число> ");

if (number > 9999 && number < 100000)
{
    CheckingNumber(number);
}
else Console.WriteLine($"Число не пятизначное");


