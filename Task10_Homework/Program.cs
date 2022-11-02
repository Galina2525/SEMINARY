// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую
//цифру этого числа.
//456 -> 5
//918 -> 1
//782 -> 8
Console.WriteLine("Enter three-digit number  ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 & number < 999 | number> -999 & number < -99)
{
     int result = number % 100 /10;

     Console.WriteLine($"The second digit is {result}");
}
else
{
    Console.WriteLine("Number is not three-digital! Enter three-digit number ");
}