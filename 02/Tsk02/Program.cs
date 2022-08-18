// Функция, на вход получает параметр, на выходе введженнео с консоли значение
int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  // Считавает с консоли строку
    int result = int.Parse(readValue);      // Преобрадует строку в целое число
    return result;                          // Возвращает результат
}

//Напишите программу, которая выводит случайное трёхзначное число и удаляет 
//вторую цифру этого числа.
int remove2Digit(int value)
{
    int result = 10 * (value / 100) + (value % 10);
    return result;
}
int num = new Random().Next(100, 999);
System.Console.WriteLine($"Сгенерировано число {num}");
System.Console.WriteLine($"Результат удаления второй цифры числа {num} это {remove2Digit(num)}");