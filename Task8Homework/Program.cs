﻿// Напишите программу, которая на вход принимает число N, а на выходе показывает все четные числа
// от 1 до N
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.Write("Enter number ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;
while(number >= i & i>=1)
{
    if(i % 2 ==0){
    
    
    
    Console.WriteLine("even" + i );
    i=i+1;
}
    else
    {
        i=i+1;
    }
    
    
}
