//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();
int[] array1 = new int[3];
Console.Write("Please insert the first number: ");
array1[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Please insert the second number: ");
array1[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("Please insert the third number: ");
array1[2] = Convert.ToInt32(Console.ReadLine());
int max = 0; 
int i = 0;  

while (i < array1.Length) {
    if (array1[i]>max)
    {
        max = array1[i];
    }
    i = i + 1;
}
Console.Write("Max number is " + max);