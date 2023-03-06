/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
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
var CreateArray = (int col, int row) => new double[col, row];

//Заполняем рандомными числами
void FillRandomArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 100) / 10.0;
        }
    }
}

//Вывод
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}


int colSize = EnterMesseng("Введите количество строк : ");
int rowSize = EnterMesseng("Введите количество столбцов : ");

double[,] array = CreateArray(colSize, rowSize);
FillRandomArray(array);

PrintArray(array);