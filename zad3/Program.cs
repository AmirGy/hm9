/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

int m = 2;
int n = 3;
Console.WriteLine(Ackerman(m, n));

// if(m==0) 
//     n+1;
// else if(m == 1)
//     n +2;
// else if (m == 2)
//     2*n+3;
// else if (m == 3)
//     Math.Pow(2, n+3) - 3;


int Ackerman(int m, int n)
{
    while (true)
    {
        if (m == 0)
            return m = 1;
        m = Ackerman(m - 1, n);
        n -= 1;
    }
    return m;
}


