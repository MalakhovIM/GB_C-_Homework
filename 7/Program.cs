int[,] CreateRandom2DArray()
{
    Console.Write("Input number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min elemrnts: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max elements: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)    
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue +1);        
    
    return array;

}   



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

int[,] userArray = CreateRandom2DArray();
Show2DArray(userArray);



//Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// double[,] CreateRandomArray2dDouble()
// {
//     Console.Write("Input number of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input number of columns: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input min elemrnts: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input max elements: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     double[,] array = new double[rows, columns];

//     for(int i = 0; i < rows; i++)
//         for(int j = 0; j < columns; j++)
//         {
//             array[i,j] = new Random().Next(minValue, maxValue +1);
//             array[i,j] += new Random().NextDouble();
//         }
//     return array;
// }

// void Show2DArrayDouble(double[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)  
//         {
//             Console.Write(string.Format("{0:F3}",array[i,j]) + "\t");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// double[,] userArray = CreateRandomArray2dDouble();
// Show2DArrayDouble(userArray);


//Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// void ShowElemetOfArray(int[,] array)
// {   
//     Console.Write("Input rows index: ");
//     int rowIndex = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input columns index: ");
//     int columnIndex = Convert.ToInt32(Console.ReadLine());

//     if(array.GetLength(0) <= rowIndex || array.GetLength(1) <= columnIndex)
//         Console.WriteLine("The element does not exist");
//     else
//         Console.WriteLine($"Element on {rowIndex} index row and on a {columnIndex} index column = {array[rowIndex,columnIndex]}");
// }

// ShowElemetOfArray(userArray);


//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

double[] ColumnsMiddle(int[,] array)
{
    double[] middleArray = new double[array.GetLength(1)];

    for(int j = 0; j < array.GetLength(1); j++)
    {
        for(int i = 0; i < array.GetLength(0); i++)
            middleArray[j] += array[i,j];
        middleArray[j] /= array.GetLength(0);
    }
    return middleArray;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(string.Format("{0:F3}",array[i]) + "\t");
    }
    Console.WriteLine();
}

double[] resultAray = ColumnsMiddle(userArray);
ShowArray(resultAray);
