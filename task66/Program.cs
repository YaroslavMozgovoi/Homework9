// Задача 66: 
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите натуральное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int SummaNaturalNumbers( int numM, int numN)
{
    if(numN == numM)return numM;
    return numN + SummaNaturalNumbers(numM, numN-1);

}
if(numberM > numberN)
{
    int m = numberM;
    numberM = numberN;
    numberN = m;
}


int summaNaturalNumbers = SummaNaturalNumbers(numberM, numberN );
Console.WriteLine(summaNaturalNumbers);