// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает последнее
// 456->6
// 782->2

Console.WriteLine("Enter number  ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(number % 10);