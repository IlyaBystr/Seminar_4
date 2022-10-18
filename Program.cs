/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/
/*
Console.WriteLine("Введите число");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите натуарльное число для степени");
int stepen = int.Parse(Console.ReadLine()!);
if (stepen >= 1)
{
    Console.WriteLine($"Число {A} в степени {stepen} = {GetPow(A,stepen)}");

    int GetPow(int a, int b)
    {
        int number = 1;
        for (int i = 1; i <= b; i++)
        {
            number = number * a;
        }
        return number;
    }
}
else
{
    Console.WriteLine("Вы ввели не прравильную степень");
}
*/


/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/
/*
Console.WriteLine("Введите число");
int A = int.Parse(Console.ReadLine()!);
int len = NumberLen(A);
Console.WriteLine($"Сумма чисел чисал {A} равна = {SumNumber(A, len)}");

int NumberLen(int L)
{
    int ind = 0;
    while (L > 0)
    {
        L /= 10;
        ind++;
    }
    return ind;
}

int SumNumber(int a, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += a % 10;
    }
    return sum;
}
*/

/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/


int[] arr = new int[8];
FillArray(arr.Length);
Console.Write("[");
Console.Write(String.Join("|",arr));
Console.WriteLine("]");
void FillArray(int size)
{

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 9);
    }

}