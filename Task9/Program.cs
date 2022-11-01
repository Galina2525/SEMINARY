// Напишите программу, которая выводит случайное число из отрезка [10, 99]
//  и показывает наибольшую цифру числа.
// 78->8
// 12->2
// 85 ->5
int number = new Random().Next(10,100);
Console.WriteLine($"Random number = {number}");

int digit2 = number % 10;
int digit1 = number /10;
if( digit1 > digit2)
{
    Console.WriteLine($"The first digit is the largest = {digit1}");
}
else
Console.WriteLine($"The second digit is the largest = {digit2}");