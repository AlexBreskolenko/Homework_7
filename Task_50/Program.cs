/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет

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

//Проверка координат
bool ValidCoordinatesArray(int[,] arr, int colEnter, int rowEnter)
{
    if ((colEnter <= arr.GetLength(0) - 1 && colEnter >= 0) && (rowEnter <= arr.GetLength(0) - 1 && rowEnter >= 0))
    {
        return true;
    }
    else
    {
        return false;
    }
}

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

//Вывод числа по заданным координатам
void PrintNumber(int[,] arr, int colEnter, int rowEnter) => Console.WriteLine($"Число = {arr[colEnter, rowEnter]}");

int sizeCol = EnterMesseng("Введите количество строк : ");
int sizeRow = EnterMesseng("Введите количество столбцов : ");

int[,] array = CreateArray(sizeCol, sizeRow);

FillRandomArray(array);

PrintArray(array);

int enterCol = EnterMesseng("Введите первые координаты : ");
int enterRow = EnterMesseng("Введите вторые координаты : ");

if (ValidCoordinatesArray(array, enterCol, enterRow))
{
    PrintNumber(array, enterCol, enterRow);
}
else
{
    Console.WriteLine("Такого числа в массиве нет.");
}
