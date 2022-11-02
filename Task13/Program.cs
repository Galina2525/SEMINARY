// Напишите программу, которая выводит третью цифру заданного числа или сообщает,что третьей цифры нет
//645 ->5
//78 -> третьей цифры нет
//32679 -> 6
Console.WriteLine("Enter number ");
int number = Convert.ToInt32(Console.ReadLine());
int digitIndex = 2;
int digit = number.ToString()[digitIndex ];
Console.WriteLine(digit);