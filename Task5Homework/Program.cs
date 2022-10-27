// Напишите программу, которая на вход принимает два числа и выдает какое число больше, а какое меньше.

Console.WriteLine("Enter numberA");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter numberB");
int numberB = Convert.ToInt32(Console.ReadLine());
if(numberA > numberB){
    Console.Write("MAX = ");
    Console.Write(numberA);

}
else{
    Console.Write("MAX = ");
    Console.WriteLine(numberB);
    
}


