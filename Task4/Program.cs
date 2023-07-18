// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
Console.Write("Please insert your number: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 2; 

Console.Write("All even numbers until N: ");
while (i<=N) 
{
    Console.Write(i + " "); 
    i = i + 2;
}

