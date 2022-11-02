// Напишите программу, которая принимает на вход цифру, обозначающую день недели и проверяет,
//является ли этот день выходным.
//6 -> Yes
//7 -> Yes
//1 -> No
Console.WriteLine("Enter number of weekday ");
int number = Convert.ToInt32(Console.ReadLine());
if(number>=1 & number<=7)
{
    if(number >=1 & number <= 5)
    {
        Console.WriteLine("NO");
    }
    else
    {
        Console.WriteLine("YES");
    }
}
else
{
    Console.WriteLine("Your number is not weekday. ");
}
