// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.
//5 25 -> Yes
//-4 16 -> Yes
//25 5 -> Yes
//8,9 -> no
Console.WriteLine("Enter number1 ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number2 ");
int number2 = Convert.ToInt32(Console.ReadLine());
if(number1 == number2*number2 |number2 == number1*number1)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
