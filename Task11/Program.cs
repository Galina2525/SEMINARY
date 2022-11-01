// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа
// 456 -> 46
//782 ->72
// 918 -> 98
int number = new Random().Next(100,1000);
Console.WriteLine($"Random number = {number}");
int number1 = number/100*10;
int number2 = number % 10;
int number3 = number1+number2;
Console.WriteLine($"New number = {number3}");

