// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, 
//  что такого элемента нет: "Позиция по рядам выходит за пределы массива"
// или "Позиция по колонкам выходит за пределы массива"
// Позиции в массиве считать от единицы.
// В коде, начальные условия:

// int[,] numbers = new int[,] {
//     {1, 2, 3, 4},
//     {5, 6, 7, 8},
//     {9, 10, 11, 12}
// };

// int x = 2;
// int y = 2;

using System;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()

// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Поиск элемента по позициям
// int FindElementByPosition(int[,] array, int x, int y)
// {
//     int target = 0;
//     if (ValidatePosition(array, x, y))
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 if (array[i, j] == array[x-1, y-1])
//                     target = array[i, j];
//             }
//         }

//     }
//     return target;
//     }


// // Проверка позиций на вхождение в массив
// bool ValidatePosition(int[,] array, int x, int y)
// {
//     if (array.GetLength(0) < x)
//     {
//         Console.Write(" Позиция по рядам выходит за пределы массива");
//         return false;
//     }
//      if (array.GetLength(1) < y)
//     {
//         Console.Write("Позиция по колонкам выходит за пределы массива");
//         return false;
//     }
//     return true;
// }

// void PrintResult(int[,] numbers, int x, int y)
// {
//     if (ValidatePosition(numbers, x, y)) {

//     for (int i = 0; i < numbers.GetLength(0); i++)
//     {
//         for (int j = 0; j < numbers.GetLength(1); j++)
//         {
//             if (numbers[i, j] == numbers[x-1, y-1])
//             {
//                 Console.Write(numbers[i, j]);
//             }
//         }
//     }
//     }
// }
// int[,] arr1 ={
//                 {1, 2, 3, 4},
//                 {5, 6, 7, 8},
//                 {9, 10, 11, 12}
//                 };
// int num = FindElementByPosition(arr1,2, 1);
// Console.Write(num);
// Console.WriteLine();
// PrintResult(arr1,2,1);

// Печать массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

// Обмен первой с последней строкой
int[,] SwapFirstLastRows(int[,] array)
{
    int[,] changeArr = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == 0 | i == array.GetLength(0) - 1)
            {
                changeArr[i, j] = array[array.GetLength(0) - 1 - i, j];
            }
            else
            {
                changeArr[i, j] = array[i, j];
            }
        }
    }
    return changeArr;
}

// Обмен элементами массива
void SwapItems(int[,] array, int i)
{
    //Напишите свое решение здесь
}

void PrintResult(int[,] numbers)
{
    int[,] changeArr = new int[numbers.GetLength(0), numbers.GetLength(1)];
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            if (i == 0 | i == numbers.GetLength(0) - 1)
            {
                changeArr[i, j] = numbers[numbers.GetLength(0) - 1 - i, j];
                Console.Write(changeArr [i, j] + " ");
            }
            else
            {
                changeArr[i, j] = numbers[i, j];
                Console.Write(changeArr [i, j] + " ");
            }
        }
        Console.WriteLine();
    }
}


int[,] numbers = new int[,]
            {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12},
                {13, 14, 15, 16},
            };

PrintArray(numbers);
Console.WriteLine("***************");
PrintResult(numbers );
