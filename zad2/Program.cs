/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.Write("Введите первое число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write(SumNumbersRec(M, N));

// int SumNumbers(int M, int N)
// {
//     int res = 0;
//     while (true)
//     {
//         res+=N;
//         N--;
//         if (N == M-1)
//             break;
//     }
//     return res;
// }

int SumNumbersRec(int M, int N)
{
    if(N==M-1) return 0;
    return N+SumNumbersRec(M, N-1);
}