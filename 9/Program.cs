//Задача 1: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// void ShowNum(int num)
// {
//     Console.Write(num + " ");
//     if(num > 1)
//         ShowNum(num -1);
// }

// Console.Write("Input num N ");
// int userNum = Convert.ToInt32(Console.ReadLine());
// ShowNum(userNum);

// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// int SumOfNumbers(int firstNum, int secNum)
// {
    
//     if(firstNum > secNum)    
//         return SumOfNumbers(firstNum, secNum + 1) + secNum;       
//     else if(firstNum < secNum)
//         return SumOfNumbers(firstNum +1, secNum) + firstNum;
//     else return firstNum;

    
// }

// Console.Write("Input num N ");
// int userFirstNum = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input num M ");
// int userSecNum = Convert.ToInt32(Console.ReadLine());


// Console.WriteLine(SumOfNumbers(userFirstNum, userSecNum));


//Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Akkerman(int m, int n)
{
    if(m == 0)
        return n + 1;
    else if(n == 0)
        return Akkerman(m - 1 , 1);
    else return Akkerman(m - 1, Akkerman(m, n - 1));

}

Console.Write("Input num M ");
int userMNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Input num N ");
int userNNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Akkerman(userMNum, userNNum));