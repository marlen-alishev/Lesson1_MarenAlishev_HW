//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();
Console.Write("Please insert the first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Please insert the second number: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a>b) 
{
    Console.Write ("Max number is " + a);
}
else if (a == b) 
{
    Console.Write ("The numbers are equal");
}
else 
{
    Console.Write("Max number is " + b);
}


