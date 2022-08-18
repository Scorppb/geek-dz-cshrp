// Функция, на вход получает параметр, на выходе введженнео с консоли значение
int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  // Считавает с консоли строку
    int result = int.Parse(readValue);      // Преобрадует строку в целое число
    return result;                          // Возвращает результат
}

//Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.

int get3Digit(int volue)
{
    int result = volue / 100 % 10;
    return result;
}
int num = Prompt("Введите число > ");
if (num >= 100)
{
    int resolt = get3Digit(num);
    System.Console.WriteLine($"Третья цифра числа {num} это {resolt}");
}
else
{
    System.Console.WriteLine($"У числа {num} нет третьей цифры");
}
