// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// int SecNum(int num)
// {
//     int result;
//     if(num > 99 && num < 1000)
//     {
//         int semiresult = num % 100;
//         result = semiresult / 10;
//         return result;
//     }
//     else
//     {
//         result = -1;
//         return result;
//     }
// }

// Console.Write("Input three-digit number: ");
// int UserNumber = Convert.ToInt32(Console.ReadLine());

// int NewNum = SecNum(UserNumber);

// if(NewNum != -1)
//     Console.WriteLine("Sec number is " + NewNum);
// else
//     Console.WriteLine("Uncorrected number");

//Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// int FindNum3(int num)
// {
//     int finalresult;
//     if(num > 99)
//     {
//         int result = num;
//         while(result > 999)
//         {
//             result = result / 10;
//         }
//         result = result % 100;
//         finalresult = result % 10;
//         return finalresult;
//     }
//     else
//     {
//         finalresult = -1;
//         return finalresult;
//     }
// }

// Console.Write("Input number: ");
// int UserNumber = Convert.ToInt32(Console.ReadLine());

// int NewNum = FindNum3(UserNumber);

// if(NewNum != -1)
//     Console.WriteLine("Third number is " + NewNum);
// else
//     Console.WriteLine("Third number not found");

//Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// bool FindWeekend(int num)
// {
//     if(num == 6 || num == 7)
//         return true;
//     else
//         return false;
// }

// Console.Write("Input the weekday number: ");
// int Day = Convert.ToInt32(Console.ReadLine());
// bool result = FindWeekend(Day);
// Console.WriteLine("This day weekend? " + result);