// Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток
// от деления.
//34 , 5 -> не кратно, остаток 4
// 16, 4 -> кратно
Console.WriteLine("Enter numbrer1 ");
int numbrer1 = Convert.ToInt32(Console.ReadLine());
 
Console.WriteLine("Enter numbrer2 ");
int numbrer2 = Convert.ToInt32(Console.ReadLine());

int mod = numbrer1 % numbrer2;

if (mod == 0)
{
    Console.WriteLine("Multiple");
}
else
{
    Console.WriteLine("Not a multiple. Remainds is  " + mod);
}