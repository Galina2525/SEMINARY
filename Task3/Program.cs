// Напишите программу, которая на вход принимает принимает одно число (N), а на выходе показывает все
// целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"

Console.WriteLine("Enter number");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number); // модуль числа. Т.е. если пишем -4, то берется 4
int i = -number;
while(number >=i){
    Console.WriteLine(i++);
}


