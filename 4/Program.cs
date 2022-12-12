//Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// double FindQuad(double number, int step)
// {
//     double result = 1;
//     if(step == 0)
//     {       
//         return result;
//     } 
//     if(step > 0)
//     {
//         for(int i = 0; i < step; i++)
//         {
//             result = result * number;        
//         }
//         return result;
//     }
//     else
//     {
//         for(int i = 0; i > step; i--)
//         {
//             result = result * number;        
//         }
//         result = 1 / result;
//         return result;
//     }

// }

// Console.Write("Input number: ");
// double usernum = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input step: ");
// int userstep = Convert.ToInt32(Console.ReadLine());

// double answer = FindQuad(usernum, userstep);

// Console.WriteLine($"Step {userstep} of {usernum} is {answer}");



//Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// int Findsum(int num)
// {
//     int result = 0; 
//     int temp = Math.Abs(num);     
//     while(temp != 0)
//     {
//         result += temp % 10;
//         temp = temp / 10;
//     }
//     return result;
// }

// Console.Write("Input number: ");
// int usernum = Convert.ToInt32(Console.ReadLine());

// int answer = Findsum(usernum);

// Console.WriteLine($"Sum numbers of {usernum} is {answer}");


// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// int[] CreateArray(int size)
// {
//     int[] array = new int[size];

//     for(int i = 0; i < size; i++)
//     {
//         Console.Write($"Input {i + 1} mass element ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.WriteLine($"Array [{i +1}] is {array[i]} ");
//     }
    
// }

// Console.Write("Input number of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] userarray = CreateArray(size);
// ShowArray(userarray);