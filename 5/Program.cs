int[] CreateRandomArray(int size, int minValie, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValie, maxValue +1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

//Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// int CountEvenNum(int[] array)
// {
//     int count = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] % 2 == 0)
//             count++;
//     }
//     return count;
// }

// Console.Write("Input number of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input min elemrnts: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input max elements: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] userarray = CreateRandomArray(size, min, max);
// ShowArray(userarray);

// int result = CountEvenNum(userarray);

// Console.WriteLine("Amount of even numbers is " + result);



//Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// int SumUnevenElements(int[] array)
// {
//     int sum = 0;
//     for(int i = 0; i < array.Length; i += 2)
//           sum += array[i];
//     return sum;
// }

// Console.Write("Input number of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input min elemrnts: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input max elements: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] userarray = CreateRandomArray(size, min, max);
// ShowArray(userarray);

// int result = SumUnevenElements(userarray);

// Console.WriteLine("Sum elements on the uneven positions is " + result);




//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateRandomArrayDub(int size, int minValie, int maxValue)
{
    double[] array = new double[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValie, maxValue +1);
        array[i] += new Random().NextDouble();
    }
    return array;
}

void ShowArrayDub(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
    Console.WriteLine();
}

double DifferenceMinMax(double[] array)
{
    double min = array[0];
    double max = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] > max)
            max = array[i];
        if(array[i] < min)
            min = array[i];
    }
    double result = max - min;
    return result;
}

Console.Write("Input number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min elemrnts: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max elements: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] userarray = CreateRandomArrayDub(size, min, max);
ShowArrayDub(userarray);

double diff = DifferenceMinMax(userarray);
Console.WriteLine("Difference between min number and max number is " + diff);