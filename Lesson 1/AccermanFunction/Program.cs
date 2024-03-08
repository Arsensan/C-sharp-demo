// // Задача 2: Напишите программу вычисления функции Аккермана с 
// // помощью рекурсии. Даны два неотрицательных числа m и n.

// // A(m,n) = n+1, если m=0
// // A(m,n) = A(m-1,1), если m>0 и n=0
// // A(m,n) = A(m-1,A(m,n-1)), если m>0 и n>0



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
