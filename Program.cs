// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int PrintNumbers(int M, int N)
{
    if (N == M) return N;
    else return PrintNumbers(N + 1, M) + N;
}


Console.Write("введите число M:  ");
int numbM = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число N:  ");
int numbN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(PrintNumbers(numbM, numbN));
