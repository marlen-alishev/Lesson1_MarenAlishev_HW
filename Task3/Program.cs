
//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Clear();
Console.Write("Please insert your number: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0){
    Console.Write("Yes, it is an even number");
}
else 
{
    Console.Write("No, it is not an even number"); 
}