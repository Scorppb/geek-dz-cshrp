// Функция, на вход получает параметр, на выходе введженнео с консоли значение
int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  // Считавает с консоли строку
    int result = int.Parse(readValue);      // Преобрадует строку в целое число
    return result;                          // Возвращает результат
}

// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
// в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Exponentiation(int number, int degree)
{
    int result = 1;
    for (int i = 0; i < degree; i++)
    {
        result = result * number;
    }
    return result;
}



int number = Prompt("Введите число A, которое неоходимо возводить в степень> ");
int degree = Prompt("Введите число B, которое соответствует натуральной степени> ");
if (degree > 0)
{
    System.Console.WriteLine($"Если число {number} возвести в натуральную степень {degree} получим результат {Exponentiation(number, degree)}");
}
else
{
    System.Console.WriteLine("Число B не соответствует натуральному");
}