// Напишите программу, которая на вход принимает число и выдает его квадрат (число, умноженное на само себя).
// Например:
// 4 ->16
// -3 ->9
// -7 ->49

Console.Write("Enter number"); //1. Приглашение к вводу
//int number = Convert.ToInt32(Console.ReadLine()); // 2.Считывание данных с консоли и преобразование в тип int
string? str = Console.ReadLine();// Если подробнее то 2.1 Считываем данные с консоли
int number = Convert.ToInt32(str);// 2.2 Конвертация в число
Console.Write(number*number); // Вывод на экран number  в квадрате