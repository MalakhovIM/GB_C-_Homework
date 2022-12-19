//Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// int NumbersOfPositive(int num)
// {
//     int count = 0;
//     int result = 0;
//     while(count < num)
//     {
//         int temp = Convert.ToInt32(Console.ReadLine());
//         if(temp > 0) result++;
//         count++;

//     }
//     return result;
// }

// Console.Write("Input numbers of elements: ");
// int userNum = Convert.ToInt32(Console.ReadLine());

// int positiveNum = NumbersOfPositive(userNum);
// Console.WriteLine("Numbers of positive elements = " + positiveNum);

//Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// void FindIntersectionOfStraightLines(double crossY1, double coeff1, double crossY2, double coeff2)
// {
//     if(coeff1 == coeff2 && crossY1 == crossY2)
//         Console.WriteLine("Straight lines match");
//     else
//         if(coeff1 == coeff2 && crossY1 != crossY2)
//             Console.WriteLine("Straight lines are parallel");
//             else
//                 if(coeff1 != coeff2 && crossY1 == crossY2)
//                 Console.WriteLine("Intersection of straight lines on axis Y, point =" + crossY1);
//                 else
//                     {
//                         double pointX = (crossY2 - crossY1) / (coeff1 - coeff2);
//                         double pointY = coeff1 * pointX + crossY1;
//                         Console.WriteLine($"Intersection of straight lines point X={pointX}, point Y={pointY}");
//                     }

// }

// Console.Write("Input axis intersection point first line ");
// double userY1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input angular coefficient first line ");
// double userCoeff1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input axis intersection point second line ");
// double userY2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input angular coefficient second line ");
// double userCoeff2 = Convert.ToDouble(Console.ReadLine());

// FindIntersectionOfStraightLines(userY1, userCoeff1, userY2, userCoeff2);