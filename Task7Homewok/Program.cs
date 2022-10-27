// Напишите программу, которая на вход принимает число и выдает, является ли число четным 
//(делится ли без остатка на два)
// 4 -> да
// -3 -> нет

Console.WriteLine("Enter number ");
int number = Convert.ToInt32(Console.ReadLine());
if(number % 2 ==0){
    Console.WriteLine("Yes");
}
else{
    Console.WriteLine("No");
}


