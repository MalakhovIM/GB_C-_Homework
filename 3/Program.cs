//Задача 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// bool CheckPoli(int num)
// { 
//     int result = 0;
//     int length = num;
//     int count = 0;
    
//     while(length > 0)
//     {
//         length = length / 10;
//         result++;        
//     }
    
//     if(result < 2)
//     {
//         return false;
//     }
//     else
//     {
//         int newnum = num;
//         int quad = result;
//         while(count < result / 2)
//         {            
//             int max = (int)(newnum / Math.Pow(10 , (quad - (count + 1))));
//             int min = newnum % 10;
            
//             if(max == min) 
//             {           
//                 newnum = Convert.ToInt32(newnum % Math.Pow(10 , (quad - (count + 1))) / 10);
//                 quad--;
//                 count ++;
//             }
//             else 
//                 return false;       
//         }
//         return true;
//     }


// }

// Console.Write("Input your number: ");
// int usernum = Convert.ToInt32(Console.ReadLine());

// bool answer = CheckPoli(usernum);

// Console.WriteLine(answer);

// Задача 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// double Length(double xa, double ya, double za, double xb, double yb, double zb)
// {
//     double x = xb - xa;
//     double y = yb - ya;
//     double z = zb - za;
//     double result = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));
//     return result;

// }

// Console.Write("input xA ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("input yA ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("input zA ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("input xB ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("input uA ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("input zB ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double lengthResult = Length(x1, y1, z1, x2, y2, z2);

// Console.WriteLine("Расстояние между точками " + lengthResult);

// Задача 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// void Quad(int num)
// {
//     int step = 1;
//     while(step <= num)
//     {
//         double result =Math.Pow(step, 3);
//         Console.Write(result + " ");
//         step++;
//     }
// }

// Console.Write("Введите число ");
// int usernum = Convert.ToInt32(Console.ReadLine());
// Quad(usernum);
