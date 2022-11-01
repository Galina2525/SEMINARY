// напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23
// 14 -> no
// 46 > no
//161 -> yes
Console.WriteLine("Enter number ");
int number1 = Convert.ToInt32(Console.ReadLine());
if(number1 % 7 ==0 & number1 % 23 ==0)
{
    Console.WriteLine("Yes");
}
else
{
     Console.WriteLine("No");
}