// Задача 66: Задайте значения M и N.
// Напишите программу, которая
// найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите целое число M:");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число N:");
int numberN = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int numM, int numN)
{
    if (numM == numN) return numM;
    else if (numM < numN) return numM + SumNumbers(numM + 1, numN);
    else return numN + SumNumbers(numM, numN + 1);
}
int res = SumNumbers(numberM, numberN);
Console.WriteLine(res);