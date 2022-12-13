// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

string PrintNumbers(int start, int end)
{
    if (start == end)
    {
        return start.ToString();
    }
    return (start + " " + PrintNumbers(++start, end));
}

int[] array = Array.ConvertAll(PrintNumbers(1,15).Split(), int.Parse);

int SumNum(int[] arr)
{
    int sum = 0; 
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }
    return sum;
}
System.Console.WriteLine(SumNum(array));