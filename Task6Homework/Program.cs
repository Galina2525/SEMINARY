﻿// Напишите программу, которая на вход принимает три числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7
//44, 5 78 ->78

Console.WriteLine("Enter namberA ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter namberB ");
int numberB= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter namberC ");
int numberC = Convert.ToInt32(Console.ReadLine());

numberA = Max;
if(numberB > Max){
    Max = numberB;
}
if(numberC > Max){
    Max = numberC;
}

Console.WriteLine(Max);