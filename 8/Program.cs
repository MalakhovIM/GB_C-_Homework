// int[,] CreateRandom2DArray()
// {
//     Console.Write("Input number of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input number of columns: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input min elemrnts: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input max elements: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,] array = new int[rows, columns];

//     for(int i = 0; i < rows; i++)    
//         for(int j = 0; j < columns; j++)
//             array[i,j] = new Random().Next(minValue, maxValue +1);        
    
//     return array;

// }   



void Show2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)  
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// int[,] userArray = CreateRandom2DArray();
// Show2DArray(userArray);




//Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// void Sort2DArray(int[,] array)
// {
    
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)  
//         {
//             int temp = array[i,j];
//             int indexMax = j;
//             int tempMax = array[i,j];
//             for(int m = j; m < array.GetLength(1); m++)
//             {
                
//                 if(array[i,m] > tempMax) 
//                 {
//                     tempMax = array[i,m];
//                     indexMax = m;
//                 }
//             }
//             array[i,j] = array[i,indexMax];
//             array[i,indexMax] = temp;
            

//         }
//     }
// }

// Sort2DArray(userArray);
// Show2DArray(userArray);



//Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// int[] SumOfRow(int[,] array)
// {
//     int[] sumArray = new int[array.GetLength(0)];
    
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         int sumOfRow = 0;
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             sumOfRow += array[i,j];
//         }
//         sumArray[i] = sumOfRow;
//     }
//     return sumArray;
// }

// void FindMaxRow(int[] array)
// {
//     int temp = 0;
//     int index = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] > temp) 
//         {
//             temp = array[i];
//             index = i;
//         }
//     }
//     Console.WriteLine($"Max sum is {temp}, of row {index}");

// }

// int[] userSumArray = SumOfRow(userArray);
// FindMaxRow(userSumArray);



//Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц. 
// cij = ai1 · b1j + ai2 · b2j + ... + ain · bnj

// int[,] ArrayMultiplication(int[,] firstArray, int[,] secondArray)
// {
//     if(firstArray.GetLength(1) == secondArray.GetLength(0))
//     {
//         int[,] array = new int[firstArray.GetLength(0), secondArray.GetLength(1)];
//         for(int i = 0; i < array.GetLength(0); i++)
//         {            
//             for(int j = 0; j < array.GetLength(1); j++)
//             {
//                 array[i,j] = firstArray[i,0] * secondArray[0,0 + j] + firstArray[i,1] * secondArray[1,0 + j];                                
//             }        
//         }
//         return array;

//     }
//     else
//     { 
//         Console.WriteLine("Multiplication imposible");
//         return firstArray;
//     }    
// }

// int[,] userSecArray = CreateRandom2DArray();
// Show2DArray(userSecArray);

// int[,] resultArray = ArrayMultiplication(userArray, userSecArray);

// Show2DArray(resultArray);



//Задача 4. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

void Mix3DArray(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)              
            {
                int randomI = new Random().Next(0, array.GetLength(0) -1);
                int randomJ = new Random().Next(0, array.GetLength(1) -1);
                int randomK = new Random().Next(0, array.GetLength(2) -1);
                int temp = array[i,j,k];
                array[i,j,k] = array[randomI,randomJ,randomK];
                array[randomI,randomJ,randomK] = temp;

            }
        }
    }
}

int[,,] Create3DArray()
{
    Console.Write("Input number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of page: ");
    int page = Convert.ToInt32(Console.ReadLine());
    
    while(rows * columns * page > 100)
    {
        Console.WriteLine("There will be repetitions in the numbers, enter new values");
        Console.Write("Input number of rows: ");
        rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input number of columns: ");
        columns = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input number of page: ");
        page = Convert.ToInt32(Console.ReadLine());
    }
    int[,,] array = new int[rows, columns, page];
    int counter = 0;

    for(int i = 0; i < rows; i++)    
        for(int j = 0; j < columns; j++)
            for(int k = 0; k < page; k++)
            {
                array[i,j,k] = 10 + counter;
                if(counter < 89)
                    counter++;
                else
                    counter = 0;
            }   
    return array;

}

void Show3DArray(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)              
            {
                Console.Write($"{array[i,j,k]} ({i},{j},{k})" + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,,] userArray = Create3DArray();

Mix3DArray(userArray);

Show3DArray(userArray);



//Задача 5. Напишите программу, которая заполнит спирально массив 4 на 4.

// int[,] SpiralArray()
// {
//     Console.Write("Input number of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input number of columns: ");
//     int columns = Convert.ToInt32(Console.ReadLine());

//     int[,] array = new int[rows, columns];
//     int i = 0;
//     int j = 0;
//     int startI = 0;
//     int startJ = 0;
//     int finI = 0;
//     int finJ = 0;
    
//     for(int k = 1; k <= rows * columns; k++)
//     {
//         array[i,j] = k;
//         if(j < columns - 1 - finJ && i == startI)
//             j++;
//         else
//         {
//             if(j == columns - 1 - finJ && i < rows - 1 - finI)
//                 i++;
//             else
//             {
//                 if(i == rows - 1 - finI && j > startJ)
//                     j--;
//                 else                             
//                     i--;
//             }
//         }
//         if(i == startI + 1 && j == startJ && startJ != columns - 1 - finJ)
//         {
//             startI++;
//             startJ++;
//             finI++;
//             finJ++;
//         }
//     }
//     return array;  
// }

// int[,] myArray = SpiralArray();
// Show2DArray(myArray);