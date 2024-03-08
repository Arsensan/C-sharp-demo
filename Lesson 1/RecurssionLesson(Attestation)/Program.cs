// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от M до N. Использовать рекурсию, не использовать циклы.


void printNaturalNumbers(int from, int to)
{
int toNum = to -1;
    if ( from <= toNum){
    if (from   == toNum  )
    {
        return;
    }
    printNaturalNumbers(from , toNum);
    Console.Write($"{toNum} ");
    } else
    Console.WriteLine ("From number must be lower than to number");
}
Console.WriteLine("Natural number from");
int inputFrom = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Natural number to");
int inputTo = Convert.ToInt32(Console.ReadLine());
printNaturalNumbers(inputFrom, inputTo);



// Задача 2: Напишите программу вычисления функции Аккермана с 
// помощью рекурсии. Даны два неотрицательных числа m и n.

// A(m,n) = n+1, если m=0
// A(m,n) = A(m-1,1), если m>0 и n=0
// A(m,n) = A(m-1,A(m,n-1)), если m>0 и n>0



int A(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return A(m - 1, 1);
    else 
        return A(m - 1, A(m, n - 1)); 
}

int a = A(2,3);
Console.WriteLine(a);

// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.


int[] makeArray()
{
    int[] array = new int[5];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Число " + (i + 1));
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void showArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

void reversePrintArray(int[] arr)
{

    if (arr.Length < 1)
    {
        return;
    }
    Console.Write($"{arr[arr.Length - 1]} ");
    Array.Resize(ref arr, arr.Length - 1);
    reversePrintArray(arr);
}
Console.WriteLine("Создайте массив из 5 чисел");
int[] resultArray = makeArray();
Console.WriteLine("Создали массив ");
showArray(resultArray);
Console.WriteLine("Развернули массив ");
reversePrintArray(resultArray);


