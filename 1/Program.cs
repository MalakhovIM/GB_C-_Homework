// Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.Write("Input first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if(num1 > num2)
// {
//     Console.WriteLine("Max number is " + num1);
//     Console.WriteLine("Min number is " + num2);
// }
// else
// {
//     Console.WriteLine("Max number is " + num2);
//     Console.WriteLine("Min number is " + num1);
// }

// Задача 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Input 3 numbers: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if(num2 > max)
{
    max = num2;
}
if(num3 > max)
{
    max = num3;
}

Console.WriteLine("Max number is " + max);