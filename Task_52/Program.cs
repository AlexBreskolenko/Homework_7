/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
Console.Clear();

//Ввод числа
int EnterMesseng(string messeng)
{
    Console.WriteLine(messeng);
    int number = int.Parse(Console.ReadLine());
    return number;
}

//Создаем массив
var CreateArray = (int col, int row) => new int[col, row];

//Заполняем рандомными числами
void FillRandomArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

//Вывод массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

//Вывод среднего арифметического
void PrintArithmeticMean(int[,] array)
{
    Console.Write("Среднее арифметическое каждого столбца : ");
    double result = 0;

    for(int i = 0; i < array.GetLength(1); i++)
    {
        for(int j = 0; j < array.GetLength(0); j++)
        {
            result += array[j, i];
        }
        result /= array.GetLength(0);
        
        Console.Write($"{Math.Round(result,1)}; ");
        result = 0;
    }
}

int sizeCol = EnterMesseng("Введите количество строк : ");
int sizeRow = EnterMesseng("Введите количество столбцов : ");

int[,] array = CreateArray(sizeCol, sizeRow);

FillRandomArray(array);

PrintArray(array);

PrintArithmeticMean(array);