// Напишите программу, которая на вход принимает два числа и проверяет, является ли 
//первое число квадратом  второго.
//а = 25 b  =5 -> yes
//a = 2 b = 10 -> no
// a = 9 b = -3 -> yes
// a = -3 b = 9 -> no


Console.Write("Enter NumberA ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter NumberB ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA == numberB * numberB){
   Console.WriteLine("Yes");
}
else{
   Console.WriteLine("No");
}




