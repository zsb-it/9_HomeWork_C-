// Задача 68: Напишите программу
// вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.WriteLine("Введите целое число m:");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число n:");
int numberN = Convert.ToInt32(Console.ReadLine());

int FunctionAkerman(int m, int n)
{
    if(m==0) return n+1;
    else if (m>0 && n==0) return FunctionAkerman(m-1, 1);
    return FunctionAkerman(m-1, FunctionAkerman(m, n-1));
}

int functionAkerman = FunctionAkerman(numberM, numberN);
Console.WriteLine($"A({numberM},{numberN}) = {functionAkerman}");