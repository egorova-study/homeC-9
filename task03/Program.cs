// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите m");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM < 0 || numberN < 0) Console.WriteLine("m и n не могут быть меньше нуля, введите другие числа");
else
{
    int result = AckermannFunction(numberM, numberN);
    Console.WriteLine($"A({numberM}, {numberN}) = {result}");
}

int AckermannFunction(int numM, int numN)
{
    if (numM == 0) return numN + 1;
    if (numM > 0 && numN == 0) return AckermannFunction(numM - 1, 1);
    return AckermannFunction(numM - 1, AckermannFunction(numM, numN - 1));
}