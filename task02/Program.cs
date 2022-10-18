// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите M");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N");
int numberN = Convert.ToInt32(Console.ReadLine());
if (numberM > numberN)
{
    int temp = numberM;
    numberM = numberN;
    numberN = temp;
}

int sum = Sum (numberM, numberN);
Console.WriteLine(sum);

int Sum (int numM, int numN)
{
    if (numM + 1 >= numN)
    {
        return numM + numN;
    }
    return numM + Sum (numM + 1, numN);
}