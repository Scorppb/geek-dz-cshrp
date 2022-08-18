// Функция, на вход получает параметр, на выходе введженнео с консоли значение
int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  // Считавает с консоли строку
    int result = int.Parse(readValue);      // Преобрадует строку в целое число
    return result;                          // Возвращает результат
}

//Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

int date = Prompt("Введите число соответствующее дню недели > ");
if (date >= 8 || date <= 0)
{
    System.Console.WriteLine($"Число {date} не соответствует дню недели");
}
else if (date >= 1 && date <= 5)
{
    System.Console.WriteLine($"Числу {date} соответствует будний день");
}
else if (date >= 6 && date <= 7)
{
    System.Console.WriteLine($"Числу {date} соответствует выходной день");
}
